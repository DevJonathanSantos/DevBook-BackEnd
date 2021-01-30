using System;
using System.Collections.Generic;
using System.Text;

namespace DevBook.Domain.Repositories.Models
{
    public class Account
    {
        public string EmailOrCPF { get; private set; }
        public string Password { get; private set; }
    }
}
