using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MCComp.Core.Domain
{
    public class Item
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }

        public Item()
        {
            Invoices = new HashSet<Invoice>();
        }
    }
}
