using Models;
using Services;

namespace Controllers
{
    public class PedidoController
    {

        private PedidoService pedidoService;

        public PedidoController()
        {
            pedidoService = new PedidoService();    
        }

        public bool Inserir(Pedido pedido)
        {
            return pedidoService.Inserir(pedido);
        }

        public List<Pedido> GetAll() 
        { 
            return pedidoService.GetAll();
        }

    }
}
