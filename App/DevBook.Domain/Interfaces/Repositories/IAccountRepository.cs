using DevBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevBook.Domain.Interfaces.Repositories
{
    public interface IAccountRepository
    {
        public Task<bool> CreateAccount(User user);

        public bool CreateAccount(Account account);

        public Task DeleteAccount(Guid id);

        //public Task<Guid> AutenticatAccount(Account account);
        public bool Logon(Account account);
    }
}
