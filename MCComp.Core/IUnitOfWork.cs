using MCComp.Core.Repositories;
using System;

namespace MCComp.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IItemRepository Items { get; }
        IInvoiceRepository Invoices { get; }
        int Complete();
    }
}
