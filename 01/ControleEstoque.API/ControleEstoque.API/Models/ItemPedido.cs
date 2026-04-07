using System.ComponentModel.DataAnnotations;
using 
{
    
}
namespace ControleEstoque.API.Models
{
    public class ItemPedido
    {

        public class ItemPedido
        {
            public int Id { get; set; }
           
            public int Quantidade { get; set; }


            [Required, Column(TypeName = "decimal(10,2)")]
            public class PrecoUnitario { }
            
                
            
        }
    }
}