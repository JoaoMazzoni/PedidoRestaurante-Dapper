using Models;
using Repositories;

namespace Services
{
    public class PedidoService
    {
        private IPedidoRepository pedidoRepository;
        private IItemRepository itemRepository;

        public PedidoService()
        {
            pedidoRepository = new PedidoRepository();  
            itemRepository = new ItemRepository();
        }

        public bool Inserir(Pedido pedido)
        {
            int idItem = itemRepository.Inserir(pedido.Item);
            pedido.Item.ItemId = idItem;
            return pedidoRepository.Inserir(pedido);

        }

        public List<Pedido> GetAll() 
        { 
            return pedidoRepository.GetAll();
        }

    }
}
