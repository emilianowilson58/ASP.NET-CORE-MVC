using SistemaWebParaVendasOnline.Models;
using SistemaWebParaVendasOnline.ViewModel;

namespace SistemaWebParaVendasOnline.Servico.LoginService
{
    public interface AccountInterface
    {
       Task<ResponseModel<UsuarioModel>> CadastroUsuario(RegistroViewModel registroViewModel);
    }
}
