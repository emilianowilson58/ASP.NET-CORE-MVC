using System.ComponentModel.DataAnnotations;

namespace SistemaWebParaVendasOnline.ViewModel
{
    public class RegistroViewModel
    {
        //Dados Necessários da tela de Cadastro
        [Required(ErrorMessage = "Digite o nome!")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "Insere o email!")]
        public string? Email { get; set; }
        
        [Required(ErrorMessage = "Digite a senha!")]
        public string? Senha { get; set; }
        
        public string? Telefone { get; set; }
        [Required(ErrorMessage = "Confirme a senha!"), Compare("Senha", ErrorMessage = "Senha Incorreta!")]
        public string? ConfirmarSenha { get; set; }
    }
}
