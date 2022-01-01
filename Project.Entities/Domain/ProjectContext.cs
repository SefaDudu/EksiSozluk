﻿using Microsoft.EntityFrameworkCore;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Entities.Domain
{
   public class ProjectContext: DbContext
    {
        public ProjectContext()
        {

        }
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {

        }

     
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Blacklist> Blacklists { get; set; }
        public DbSet<UserReport> UserReports { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentReport> CommentReports { get; set; }
        public DbSet<CommentVote> CommentVotes { get; set; }



         
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);     
        }
    }
}
