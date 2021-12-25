using Project.Entities.Abstract;
using Project.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Entities.Concrete
{
    public class User : BaseEntity,IEntity
    {
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<Comment> Comments   { get; set; }
        public ICollection<UserReport> UserReports   { get; set; }
        public ICollection<CommentVote> CommentVotes   { get; set; }
        public ICollection<CommentReport> CommentReports   { get; set; }
        public ICollection<Blacklist> Blacklists   { get; set; }
        public ICollection<Subject> Subjects   { get; set; }


         
    }
}
