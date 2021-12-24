using Project.Entities.Abstract;
using Project.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Entities.Concrete
{
    public class Role:BaseEntity,IEntity
    {
        public string Name { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
