
namespace ControleEstoque.API.DTOs
{
    public class CriarPedidoDTO
    {   
        //remover quando tiver JWT
        public int ClienteId { get; set; }

        public List<CriarItemPedidoDto> Itens { get; set; }

    }

    public class CriarItemPedidoDto
    {
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public object ClienteId { get; internal set; }
        public IEnumerable<object> Itens { get; internal set; }
        //Não pediremos o preço. o backend busca no banco.
    }









}

    



