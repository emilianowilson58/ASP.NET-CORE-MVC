using SistemaWebParaVendasOnline.Data;
using SistemaWebParaVendasOnline.Models;
using SistemaWebParaVendasOnline.Servico.SenhaService;
using SistemaWebParaVendasOnline.ViewModel;
using System.Data;

namespace SistemaWebParaVendasOnline.Servico.LoginService
{
    public class AccountService : AccountInterface
    {
        private readonly ApplicationDbContext _contect;
        private readonly SenhaInterface _senhaInterface;

        public AccountService(ApplicationDbContext context, SenhaInterface senhaInterface)
        {
            _contect = context;
            _senhaInterface = senhaInterface;

        }

        public async Task<ResponseModel<UsuarioModel>> CadastroUsuario(RegistroViewModel registroViewModel)
        {
            ResponseModel<UsuarioModel> response = new ResponseModel<UsuarioModel>();
            try
            {
                if (VerificarSenha(registroViewModel))
                {
                    response.Mensagem = "Email já Existe";
                    response.Status = false;
                    return response;
                }
                //if (VerificarTelfone(registroViewModel))
                //{
                //    response.Mensagem = "Número de Telefone já Existe";
                //    response.Status = false;
                //    return response;
                //}

                _senhaInterface.CriarSenhaHash(registroViewModel.Senha, out byte[] senhaHash, out byte[] senhaSalt);

                var usuario = new UsuarioModel()
                {
                    Nome = registroViewModel.Nome,
                    Email = registroViewModel.Email,
                    Telefone = registroViewModel.Telefone,
                    SenhaHash = senhaHash,
                    SenhaSalt = senhaSalt,
                    DataCadastro = DateTime.Now,
                    Vendedor = true
                };

                _contect.Add(usuario);
                await _contect.SaveChangesAsync();

                return response;

            }
            catch (Exception erro)
            {
                response.Mensagem = erro.Message;
                response.Status = false;
                return response;
            }

           
        }

        private bool VerificarSenha(RegistroViewModel registroViewModel)
        {
           var usuario = _contect.Usuarios.FirstOrDefault(email => email.Email ==  registroViewModel.Email);

            if (usuario == null)
            {
                return false;
            }

            return true;
        }

        //private bool VerificarTelfone(RegistroViewModel registroViewModel)
        //{
        //    var usuarioT = _contect.Usuarios.FirstOrDefault(tel => tel.Telefone == registroViewModel.Telefone);

        //    if(usuarioT == null)
        //    {
        //        return false;
        //    }
           
        //    return true;
        //}

    }
}
