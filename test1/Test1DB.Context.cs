﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace test1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Test11Entities1 : DbContext
    {
        public Test11Entities1()
            : base("name=Test11Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admin> admin { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Pachienti> Pachienti { get; set; }
        public virtual DbSet<PriemPacientov> PriemPacientov { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
