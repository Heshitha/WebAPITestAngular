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
    public class ItemsController : ApiController
    {
        private ItemManager _itemManger;

        public ItemsController()
        {
            _itemManger = new ItemManager();
        }
        // GET: api/Items
        public IEnumerable<Item> Get()
        {
            return _itemManger.GetAllItems();
        }
    }
}
