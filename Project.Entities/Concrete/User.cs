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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Photo { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }

        public ICollection<UserRole> UserRole { get; set; }
        public ICollection<Comment> Comment   { get; set; }
        public ICollection<UserReport> UserReport   { get; set; }
        public ICollection<CommentVote> CommentVote   { get; set; }
        public ICollection<CommentReport> CommentReport   { get; set; }
        public ICollection<Blacklist> Blacklist   { get; set; }
 


         
    }
}
