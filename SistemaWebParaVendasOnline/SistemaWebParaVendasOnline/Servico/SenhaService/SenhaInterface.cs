namespace SistemaWebParaVendasOnline.Servico.SenhaService
{
    public interface SenhaInterface
    {
        void CriarSenhaHash(string senha, out byte[] senhaHash, out byte[] senhaSalt);
    }
}
