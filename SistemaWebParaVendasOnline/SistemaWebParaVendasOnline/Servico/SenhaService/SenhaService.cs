using System.Security.Cryptography;

namespace SistemaWebParaVendasOnline.Servico.SenhaService
{
    public class SenhaService : SenhaInterface
    {
        public void CriarSenhaHash(string senha, out byte[] senhaHash, out byte[] senhaSalt)
        {
            using (var hmac = new HMACSHA3_512())
            {
                senhaSalt = hmac.Key;
                senhaHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(senha));
            }
            
        }
    }
}
