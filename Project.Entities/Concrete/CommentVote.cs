using Project.Entities.Abstract;
using Project.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities.Concrete
{
    public class CommentVote:BaseEntity,IEntity
    {
        public User User { get; set; }
        public Guid UserId { get; set; }

        public Comment Comment { get; set; }
        public Guid CommentId { get; set; }



        public Byte Vote { get; set; }
    }
}
