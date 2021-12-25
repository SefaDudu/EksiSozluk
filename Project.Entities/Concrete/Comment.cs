using Project.Entities.Abstract;
using Project.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities.Concrete
{
    public class Comment: BaseEntity, IEntity
    {
        public Guid UserId { get; set; }
        public Guid SubjectId { get; set; }
        public string CommentText { get; set; }
        public Subject Subject { get; set; }
        public User User { get; set; }

        public ICollection<CommentReport> CommentReports { get; set; }
        public ICollection<CommentVote> CommentVotes { get; set; }


    }
}
