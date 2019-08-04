using MCComp.Core.Domain;
using MCComp.DataAccess.EntityConfigurations;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Text;

namespace MCComp.DataAccess
{
    public class MCContext : DbContext
    {
        public MCContext() : base("name=MCComp")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new InvoiceConfiguration());
        }
    }
}
