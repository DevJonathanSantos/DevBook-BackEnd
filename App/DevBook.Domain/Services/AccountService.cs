using DevBook.Domain.Entities;
using DevBook.Domain.Interfaces.Repositories;
using DevBook.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevBook.Domain.Services
{
    public class AccountService: IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public Task<Guid> AutenticatAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CreateAccount(User user)
        {
            bool accountCreated =  await _accountRepository.CreateAccount(user);

            return accountCreated;
        }

        public Task DeleteAccount(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Logon(Account account)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Validade()
        {
            throw new NotImplementedException();
        }
    }
}
