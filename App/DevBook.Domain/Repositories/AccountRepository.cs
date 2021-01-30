using DevBook.Domain.Entities;
using DevBook.Domain.Extensions;
using DevBook.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DevBook.Domain.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DataContext _context;

        public AccountRepository(DataContext context)
        {
            _context = context;
        }

        //public async Task<Guid> AutenticatAccount(Account account)
        //{
        //}

        public async Task<bool> CreateAccount(User user)
        {
            

            try
            {
                user = _context.Users.Find(Guid.Parse("bb6b96a9-cb07-44fb-b6c9-c2b981df40bb"));
                _context.Remove(user);


                _context.Add(user);

                _context.SaveChanges();
            }
            catch (Exception e)
            {

                throw;
            }
            

            return false;
        }

        public bool CreateAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAccount(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Logon(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
