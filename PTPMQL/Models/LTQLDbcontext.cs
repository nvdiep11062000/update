using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    public partial class LTQLDbcontext : DbContext
    {
        public LTQLDbcontext() : base("name=LTQLDbcontext")
        {

        }
        public virtual DbSet<Account> Acounts { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.UserName)
                .IsUnicode(false);
        }
    }
}