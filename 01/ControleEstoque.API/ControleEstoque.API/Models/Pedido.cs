using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;



namespace ControleEstoque.API.Models;

   

public class Pedido
{
    [Key]
    public int Id { get; set; }

    public DateTime DataPedido { get; set; } = DateTime.Now;


    [Required, StringLength(20)]
    public string Status { get; set; } //aberto, fechado, suspenso...

    public ICollection<ItemPedido> Itens { get; set; } = new List<ItemPedido>(); // Relacionamento com a entidade ItemPedido, indicando que um pedido pode conter vários itens



}

 
    


 


