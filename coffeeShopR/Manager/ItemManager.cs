using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using coffeeShopR.Repository;
using System.Data;
using coffeeShopR.Model;

namespace coffeeShopR.Manager
{
    public class ItemManager
    {
        private ItemRepository _itemRepository = new ItemRepository();

        public bool Add(Item item)
        {
            return _itemRepository.Add(item);
        }

        public bool IsNameExist(Item item)
        {
            return _itemRepository.IsNameExist(item);
        }

        public bool Delete(Item item)
        {
            return _itemRepository.Delete(item);

        }

        public bool Update(Item item)

        {
            return _itemRepository.Update(item);
        }

        public DataTable Display()
        {
            return _itemRepository.Display();
        }

        public DataTable Search(Item item)
        {

            return _itemRepository.Search(item);
        }

        
    }
}
