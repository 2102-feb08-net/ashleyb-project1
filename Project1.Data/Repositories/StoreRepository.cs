using System.Linq;
using Project1.BL;


namespace Project1.Data
{
    public class StoreRepository : IStoreRepository
    {
        private readonly Project1Context _context;

        public StoreRepository(Project1Context context)
        {
            _context = context;
        }
        public BL.Store GetStoreById(int id)
        {
            var store = _context.Stores.Where(s => s.StoreId == id).First();
            BL.Store searched = new BL.Store(store.StoreId, store.StoreName);
            return searched;
        }
    }
}