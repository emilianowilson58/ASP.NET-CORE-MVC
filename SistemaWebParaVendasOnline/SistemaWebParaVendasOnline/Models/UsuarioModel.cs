using System.Data;

namespace SistemaWebParaVendasOnline.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public byte[]? SenhaHash { get; set; }
        public byte[]? SenhaSalt { get; set; }
        public string? Telefone { get; set; }
        public DateTime DataCadastro { get; set; } 
        public string? Foto { get; set; }
        public bool Vendedor { get; set; } = false;
        //Criando relação com as Permissões
        public ICollection<UsuarioPermissaoModel>? UsuarioPermissaos { get; set; }
    }
}
