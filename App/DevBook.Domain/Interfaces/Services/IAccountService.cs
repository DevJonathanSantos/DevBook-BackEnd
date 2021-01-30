using DevBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevBook.Domain.Interfaces.Services
{
    public interface IAccountService
    {
        public Task<bool> Validade();

        public Task<bool> CreateAccount(User user);

        public Task DeleteAccount(Guid id);

        public Task<Guid> AutenticatAccount(Account account);

        public bool Logon(Account account);
    }
}
