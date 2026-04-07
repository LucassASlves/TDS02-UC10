using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ControleEstoque.API.Models.Pedido;

namespace ControleEstoque.API.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }


        [Required, StringLength(100)]
        public string Nome { get; set; }


       
        [Required, Column(TypeName = "decimal(10,2)")]
        public string Preco { get; set; }

        [Required]
        public int QuantidadeEstoque { get; set; }

        [ForeignKey("Fornecedor")]

        public int FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; } // Relacionamento com a entidade Fornecedor, indicando que um produto é fornecido por um fornecedor específico

        public ICollection<ItemPedido> ItensPedido { get; set; } = new List<ItemPedido>(); // Relacionamento com a entidade ItemPedido, indicando que um produto pode estar presente em vários itens de pedido


    }
}
