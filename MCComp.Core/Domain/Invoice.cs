using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MCComp.Core.Domain
{
    public class Invoice
    {
        [Key]
        public int ID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public double Discount { get; set; }
        public virtual ICollection<Item> Items { get; set; }

        public Invoice()
        {
            Items = new HashSet<Item>();
        }
    }
}
