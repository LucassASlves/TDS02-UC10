using System.ComponentModel.DataAnnotations;


namespace ControleEstoque.API.Models// Define o namespace para a organização do código, indicando que esta classe faz parte dos modelos do sistema de controle de estoque
{
    public enum PerfilUsuario { Cliente, Caixa, Gerente }// Define um enum para os perfis de usuário, permitindo categorizar os usuários do sistema em Cliente, Caixa e Gerente
    public enum  Turno { Manhã, Tarde, Noite}   
        
   
    public abstract class Usuario// Define a classe abstrata Usuario, que serve como base para diferentes tipos de usuários no sistema, como Cliente, Caixa e Gerente
    {
        [Key]
        public int Id { get; set; }// Identificador único para cada usuário, gerado automaticamente pelo banco de dados

        [Required, StringLength(100)]// O nome do usuário é obrigatório e tem um limite de 100 caracteres para garantir a consistência dos dados
        public string Nome { get; set; }// Armazena o nome do usuário, que é obrigatório e tem um limite de 100 caracteres

        [Required, EmailAddress, StringLength(100)]// O email deve ser único para cada usuário, garantindo que não haja duplicatas
        public string Email { get; set; }// Armazena o email do usuário, que deve ser único

        [Required]// A senha em si não é armazenada diretamente por questões de segurança
        public string SenhaHash { get; set; }// Armazena o hash da senha para segurança

        [Required]
        public PerfilUsuario Perfil { get; set; } // Define o perfil do usuário (Cliente, Caixa, Gerente)

    }
    
} 