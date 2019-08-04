using MCComp.Core.Domain;
using MCComp.Core.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace MCComp.DataAccess.Repositories
{
    public class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(MCContext context) : base(context)
        {

        }

        public MCContext MCContext
        {
            get { return Context as MCContext; }
        }

        public IEnumerable<Invoice> GetAll(int pageIndex, int pageSize)
        {
            return MCContext.Invoices
                .OrderBy(x => x.ID)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public Invoice GetInvoiceWithItems(int id)
        {
            return MCContext.Invoices.Include(i => i.Items).SingleOrDefault(i => i.ID == id);
        }

        public override Invoice Add(Invoice invoice)
        {
            var items = invoice.Items;

            ICollection<Item> itemsFromCntx = new HashSet<Item>();

            foreach(var item in items)
            {
                var x = MCContext.Items.FirstOrDefault(y => y.ID == item.ID);
                itemsFromCntx.Add(x);
            }
            invoice.Items = itemsFromCntx;
            invoice = MCContext.Invoices.Add(invoice);
            return invoice;
        }
    }
}
