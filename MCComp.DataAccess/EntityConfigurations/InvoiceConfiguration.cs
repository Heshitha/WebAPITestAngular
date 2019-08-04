using MCComp.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCComp.DataAccess.EntityConfigurations
{
    public class InvoiceConfiguration : EntityTypeConfiguration<Invoice>
    {
        public InvoiceConfiguration()
        {
            HasMany(i => i.Items)
                .WithMany(x => x.Invoices)
                .Map(m =>
                {
                    m.ToTable("InvoiceItems");
                    m.MapLeftKey("InvoiceID");
                    m.MapRightKey("ItemID");
                });
                
        }
    }
}
