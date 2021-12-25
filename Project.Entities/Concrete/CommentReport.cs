using Project.Entities.Abstract;
using Project.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities.Concrete
{
    public class CommentReport: BaseEntity, IEntity
    {
        public Guid CommentId { get; set; }
        public string CommentText { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Comment Comment { get; set; }

    }
}
