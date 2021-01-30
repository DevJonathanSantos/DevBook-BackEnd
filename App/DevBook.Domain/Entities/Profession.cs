using System;

namespace DevBook.Domain.Entities
{
    public class Profession: Entity
    {
        public string Name { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public Role Role { get; private set; }
    }
}
