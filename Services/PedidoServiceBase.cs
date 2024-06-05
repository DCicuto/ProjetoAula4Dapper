using Models;

namespace Services
{
    public class PedidoServiceBase
    {

        public int Inserir(Pedido pedido)
        {
            return Inserir(pedido, itemRepository);
        }
    }
}