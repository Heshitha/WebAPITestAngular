using MCComp.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MCComp.Core.Repositories
{
    public interface IInvoiceRepository : IRepository<Invoice>
    {
        Invoice GetInvoiceWithItems(int id);

        IEnumerable<Invoice> GetAll(int pageIndex, int pageSize);
    }
}
