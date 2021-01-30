using System;
using System.Collections.Generic;
using System.Text;

namespace DevBook.Domain.Repositories.Models
{
    public class Company
    {
        public string Name { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public Profession Profession { get; private set; }
    }
}
