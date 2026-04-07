using System.ComponentModel.DataAnnotations;


namespace ControleEstoque.API.Models// Define o namespace para a organização do código, indicando que esta classe faz parte dos modelos do sistema de controle de estoque
{
    public class  cliente : Usuario
    {
        [StringLength(14)]
        public string CPF { get; set; } // Armazena o CPF do cliente, que é um identificador único no Brasil e tem um limite de 14 caracteres (incluindo pontos e hífen)

        public ICollection<Pedido> PedidosFechados { get; set; } = new List<Pedido>();
    }

    
}
