using DevBook.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevBook.Domain.Repositories.Models
{
    public class Formation
    {
        public string Name { get; private set; }
        public EFormationType Type { get; private set; }
    }
}
