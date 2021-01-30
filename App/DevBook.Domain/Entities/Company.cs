using System;
using System.Collections.Generic;
using System.Text;

namespace DevBook.Domain.Entities
{
    public class Company:Entity
    {
        public string Name { get;  set; }
        public DateTime StartDate { get;  set; }
        public DateTime EndDate { get;  set; }
        public Profession Profession { get;  set; }
    }
}
