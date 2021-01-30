using System;
using System.Collections.Generic;
using System.Text;

namespace DevBook.Domain.Repositories.Models
{
    public class User
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string EmailAddress { get; private set; }
        public string PhoneNumber { get; private set; }
        public Company Company { get; private set; }
        public Formation Formation { get; private set; }
        public Address Address { get; private set; }
        public Account Account { get; private set; }
    }
}
