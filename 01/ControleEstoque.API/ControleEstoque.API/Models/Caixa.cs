using System.ComponentModel.DataAnnotations;


namespace ControleEstoque.API.Models// Define o namespace para a organização do código, indicando que esta classe faz parte dos modelos do sistema de controle de estoque
{
    public class Caixa : Usuario
        {
         [StringLength(50)]
         public string Turno { get; set; } // Armazena o turno de trabalho do caixa, com um limite de 50 caracteres para garantir a consistência dos dados

           public ICollection<Pedido> PedidosFechados { get; set; } = new List<Pedido>(); // Lista de pedidos abertos associados ao caixa, permitindo o acompanhamento das transações em andamento
    }
    
} 