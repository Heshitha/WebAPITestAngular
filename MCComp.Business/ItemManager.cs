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
    public class ItemManager
    {
        private static IUnitOfWork _UnitOfWork;

        public ItemManager()
        {
            if(_UnitOfWork == null)
            {
                _UnitOfWork = new UnitOfWork(new MCContext());
            }
        }

        public IEnumerable<Item> GetAllItems()
        {
            return _UnitOfWork.Items.GetAll();
        }
    }
}
