using Models;
using Repositories;

namespace Services
{
    public class PedidoService
    {
        private IPedidoRepository pedidoRepository;

        public PedidoService()
        {
            pedidoRepository = new PedidoRepository();  
        }

        public bool Inserir(Pedido pedido)
        {
            return pedidoRepository.Inserir(pedido);
        }


    }
}
