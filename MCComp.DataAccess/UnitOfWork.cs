using MCComp.Core;
using MCComp.Core.Repositories;
using MCComp.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCComp.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MCContext _context;

        public UnitOfWork(MCContext context)
        {
            _context = context;
            Invoices = new InvoiceRepository(_context);
            Items = new ItemRepository(_context);
        }

        public IItemRepository Items { get; private set; }

        public IInvoiceRepository Invoices { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
