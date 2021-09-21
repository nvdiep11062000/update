﻿using System;
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
        public virtual DbSet<Item> Items { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .Property(e => e.NameItem)
                .IsUnicode(false);
        }
    }
}