using DevBook.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevBook.Domain.Entities
{
    public class Formation:Entity
    {
        public Formation(string name, EFormationType type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get;  set; }
        public EFormationType Type { get; set; }
    }
}
