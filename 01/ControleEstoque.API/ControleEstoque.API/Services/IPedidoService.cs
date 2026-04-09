using ControleEstoque.API.Models;

namespace ControleEstoque.API.Services
{
    public interface IPedidoService
    {
        Task<Pedido?> ObterPedidoComDethalesAsync(int pedidoId);
        Task<IEnumerable<Pedido>> ObterPedidosPorUsuarioAsync(int clienteId);
        Task<Pedido> CriarPedidoAsync(int clienteId);
        Task CriarPedidoAsync(object clienteId, object value);
    }
}
