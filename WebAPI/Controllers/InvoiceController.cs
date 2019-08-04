using MCComp.Business;
using MCComp.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class InvoiceController : ApiController
    {
        private InvoiceManager _invoiceManger;

        public InvoiceController()
        {
            _invoiceManger = new InvoiceManager();
        }

        [Route("api/invoice/{pageIndex}/{pageSize}")]
        // GET: api/Invoice
        public IEnumerable<Invoice> Get(int pageIndex, int pageSize = 10)
        {
            return _invoiceManger.GetAllInvoices(pageIndex, pageSize);
        }

        
        // GET: api/Invoice/5
        public Invoice Get(int id)
        {
            return _invoiceManger.GetInvoiceWithItems(id);
        }

        // POST: api/Invoice
        public Invoice Post([FromBody]Invoice invoice)
        {
            return _invoiceManger.Save(invoice);
        }

        // PUT: api/Invoice/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Invoice/5
        public void Delete(int id)
        {
        }
    }
}
