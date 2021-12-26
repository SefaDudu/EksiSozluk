using Project.Entities.Abstract;
using Project.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities.Concrete
{
    public class UserReport: BaseEntity, IEntity
    {
        //Reportlanan User
        public Guid ReportedUserId { get; set; }

        //Reportlayan User
        public User User { get; set; }
        public Guid UserId { get; set; }

        public string Comment { get; set; }

    }
}
