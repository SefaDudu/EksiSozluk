using Project.Entities.Abstract;
using Project.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities.Concrete
{
    public class Blacklist: BaseEntity, IEntity
    {
        public Guid UserId { get; set; }
        public Guid BlacklistUserId { get; set; }
        public User User { get; set; }
    }
}
