﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Matrimonial_Website.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Matrimonial_WebsiteEntities : DbContext
    {
        public Matrimonial_WebsiteEntities()
            : base("name=Matrimonial_WebsiteEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<chat> chats { get; set; }
        public virtual DbSet<image_gallery> image_gallery { get; set; }
        public virtual DbSet<successful_stories> successful_stories { get; set; }
        public virtual DbSet<user_profile> user_profile { get; set; }
    }
}