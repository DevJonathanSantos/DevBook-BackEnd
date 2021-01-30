IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Account] (
    [Id] uniqueidentifier NOT NULL,
    [EmailOrCPF] nvarchar(max) NOT NULL,
    [Password] VARCHAR(12) NOT NULL,
    CONSTRAINT [PK_Account] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Address] (
    [Id] uniqueidentifier NOT NULL,
    [Street] VARCHAR(40) NOT NULL,
    [Number] VARCHAR(40) NOT NULL,
    [Neighborhood] VARCHAR(40) NOT NULL,
    [City] VARCHAR(40) NOT NULL,
    [State] VARCHAR(40) NOT NULL,
    [Country] VARCHAR(40) NOT NULL,
    [ZipCode] VARCHAR(40) NOT NULL,
    CONSTRAINT [PK_Address] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Formation] (
    [Id] uniqueidentifier NOT NULL,
    [Name] VARCHAR(40) NULL,
    [Type] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Formation] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Role] (
    [Id] uniqueidentifier NOT NULL,
    [Name] VARCHAR(40) NULL,
    [StartDate] datetime2 NOT NULL,
    [EndDate] datetime2 NOT NULL,
    [Salary] DECIMAL(10,2) NOT NULL,
    CONSTRAINT [PK_Role] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Profession] (
    [Id] uniqueidentifier NOT NULL,
    [Name] VARCHAR(40) NULL,
    [StartDate] datetime2 NOT NULL,
    [EndDate] datetime2 NOT NULL,
    [RoleId] uniqueidentifier NULL,
    CONSTRAINT [PK_Profession] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Profession_Role_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [Role] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Company] (
    [Id] uniqueidentifier NOT NULL,
    [Name] VARCHAR(40) NULL,
    [StartDate] datetime2 NOT NULL,
    [EndDate] datetime2 NOT NULL,
    [ProfessionId] uniqueidentifier NULL,
    CONSTRAINT [PK_Company] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Company_Profession_ProfessionId] FOREIGN KEY ([ProfessionId]) REFERENCES [Profession] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Users] (
    [Id] uniqueidentifier NOT NULL,
    [FirstName] VARCHAR(40) NOT NULL,
    [LastName] VARCHAR(40) NOT NULL,
    [DateOfBirth] CHAR(8) NOT NULL,
    [EmailAddress] VARCHAR(40) NOT NULL,
    [PhoneNumber] VARCHAR(14) NOT NULL,
    [CompanyId] uniqueidentifier NULL,
    [FormationId] uniqueidentifier NULL,
    [AddressId] uniqueidentifier NULL,
    [AccountId] uniqueidentifier NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Users_Account_AccountId] FOREIGN KEY ([AccountId]) REFERENCES [Account] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Users_Address_AddressId] FOREIGN KEY ([AddressId]) REFERENCES [Address] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Users_Company_CompanyId] FOREIGN KEY ([CompanyId]) REFERENCES [Company] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Users_Formation_FormationId] FOREIGN KEY ([FormationId]) REFERENCES [Formation] ([Id]) ON DELETE NO ACTION
);
GO

CREATE INDEX [IX_Company_ProfessionId] ON [Company] ([ProfessionId]);
GO

CREATE INDEX [IX_Profession_RoleId] ON [Profession] ([RoleId]);
GO

CREATE INDEX [IX_Users_AccountId] ON [Users] ([AccountId]);
GO

CREATE INDEX [IX_Users_AddressId] ON [Users] ([AddressId]);
GO

CREATE INDEX [IX_Users_CompanyId] ON [Users] ([CompanyId]);
GO

CREATE INDEX [IX_Users_FormationId] ON [Users] ([FormationId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210116205631_PrimeiraMigração', N'5.0.2');
GO

COMMIT;
GO

