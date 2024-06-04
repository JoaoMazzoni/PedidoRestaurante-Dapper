using Models;
using Repositories;


namespace Services
{
    public class ItemService
    {
        private IItemRepository itemRepository;

        public ItemService()
        {
            itemRepository = new ItemRepository();
        }

        public int Inserir(Item item)
        {
            return itemRepository.Inserir(item);
        }



    }
}
