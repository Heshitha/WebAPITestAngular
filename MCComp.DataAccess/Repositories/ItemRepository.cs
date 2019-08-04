using MCComp.Core.Domain;
using MCComp.Core.Repositories;
using System.Data.Entity;
using System.Linq;

namespace MCComp.DataAccess.Repositories
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        public ItemRepository(MCContext context) : base(context)
        {

        }

        public MCContext MCContext
        {
            get { return Context as MCContext; }
        }
    }
}
