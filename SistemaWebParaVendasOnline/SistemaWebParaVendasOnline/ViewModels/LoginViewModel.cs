using System.ComponentModel.DataAnnotations;

namespace SistemaWebParaVendasOnline.ViewModel
{
    public class LoginViewModel
    {
        //Dados Necessários da tela de Login
        [Required(ErrorMessage = "Campo vázio")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Campo vázio")]
        public string? Senha { get; set; }
    }
}
