using System;
using System.Collections.Generic;
using System.Text;

namespace DevBook.Domain.Entities
{
    public class Role:Entity
    {
        public string Name { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public double Salary { get; private set; }
    }
}

