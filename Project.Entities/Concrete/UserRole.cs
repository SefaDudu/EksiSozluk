using Project.Entities.Abstract;
using Project.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Entities.Concrete
{
   public class UserRole:BaseEntity,IEntity
    {
        public User User { get; set; }
        public Guid UserId { get; set; }
        public Role Role { get; set; }
        public Guid RoleId { get; set; }
    }
}
