using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities.Concrete
{
    public class CommentVote
    {
        public Guid UserId { get; set; }
        public Guid CommentId { get; set; }
        public Byte Vote { get; set; }
    }
}
