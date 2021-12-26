using Project.Entities.Abstract;
using Project.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities.Concrete
{
    public class Subject: BaseEntity, IEntity
    {
        public string SubjectTitle { get; set; }

        public ICollection<Comment> Comment { get; set; }
            
    }

}
