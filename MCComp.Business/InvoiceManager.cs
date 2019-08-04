using MCComp.Core;
using MCComp.Core.Domain;
using MCComp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCComp.Business
{
    public class InvoiceManager
    {
        private static IUnitOfWork _UnitOfWork;

        public InvoiceManager()
        {
            if (_UnitOfWork == null)
            {
                _UnitOfWork = new UnitOfWork(new MCContext());
            }
        }
        public IEnumerable<Invoice> GetAllInvoices(int pageIndex, int pageSize)
        {
            return _UnitOfWork.Invoices.GetAll(pageIndex, pageSize);
        }

        public Invoice GetInvoiceWithItems(int id)
        {
            return _UnitOfWork.Invoices.GetInvoiceWithItems(id);
        }

        public Invoice Save(Invoice invoice)
        {
            Invoice retVal = null;
            try
            {
                retVal = _UnitOfWork.Invoices.Add(invoice);
                _UnitOfWork.Complete();
            }
            catch (Exception)
            {

            }
            return retVal;
        }
    }
}
