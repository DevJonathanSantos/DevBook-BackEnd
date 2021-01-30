using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevBook.Domain.Entities
{
    public abstract class Entity //: Notifiable
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}
