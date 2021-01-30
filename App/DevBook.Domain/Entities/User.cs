using System;

namespace DevBook.Domain.Entities
{
    public class User : Entity
    {
        //public User() { }

        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public string DateOfBirth { get;  set; }
        public string EmailAddress { get;  set; }
        public string PhoneNumber { get;  set; }
        public Company Company { get;  set; }
        public Formation Formation { get; private set; }
        public Address Address { get; private set; }
        public Account Account { get; private set; }
    }
}
