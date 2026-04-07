using System.ComponentModel.DataAnnotations;


namespace ControleEstoque.API.Models// Define o namespace para a organização do código, indicando que esta classe faz parte dos modelos do sistema de controle de estoque
{
    public class Gerente : Usuario
        {
          [StringLength(50)]
          public string setor { get; set; } // Armazena o setor de atuação do gerente, com um limite de 50 caracteres para garantir a consistência dos dados
        }
    
} 