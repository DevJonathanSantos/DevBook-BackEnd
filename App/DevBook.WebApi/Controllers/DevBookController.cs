using DevBook.Domain.Entities;
using DevBook.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBook.WebApi.Controllers
{
    [Route("devbook")]
    [ApiController]
    public class DevBookController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public DevBookController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("validateAccount")]
        public async Task<bool> Validade()
        {
            return false;
        }

        [HttpPost("account/create")]
        public async Task CreateAccount()
        {
            var user = new User()
            {
                FirstName = "Jonathan",
                LastName = "Oliveira",
                PhoneNumber = "11958607051",
                EmailAddress = "jonathan.olivera@gmail.com",
                DateOfBirth = "09092000",

                Company = new Company()
                {
                    Name = "eefege",
                    EndDate = DateTime.Now,
                    StartDate = DateTime.Now
                }
            };  

            //Inserir efeito cascata

            bool accountCreated = await _accountService.CreateAccount(user);

        }

        [HttpPost("deleteAccount")]
        public async Task DeleteAccount(Guid id)
        {
        }

        //[HttpPost("AutenticatAccount")]
        //public async Task<Guid> AutenticatAccount(Account account)
        //{
        //    Guid id = _accountService.CreateAccount(account);

        //    return id;
        //}

        [HttpPost("get/user")]
        public async Task<User> GetUser(Guid id)
        {
            return null;
        }
    }
}
