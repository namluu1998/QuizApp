﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuizApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class quizappEntities : DbContext
    {
        public quizappEntities()
            : base("name=quizappEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admin_athu> admin_athu { get; set; }
        public virtual DbSet<exam> exams { get; set; }
        public virtual DbSet<question> questions { get; set; }
        public virtual DbSet<student_record> student_record { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}