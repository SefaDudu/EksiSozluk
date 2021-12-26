using Project.Entities.Abstract;
using Project.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities.Concrete
{
    public class Blacklist: BaseEntity, IEntity
    {
        public User User { get; set; }
        // Engelleyen Kişi
        public Guid UserId { get; set; }

        //Engellenen  Kişi
        public Guid BlacklistUserId { get; set; }

    }
}
