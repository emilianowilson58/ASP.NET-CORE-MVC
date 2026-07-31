namespace SistemaWebParaVendasOnline.Models
{
    public class MensagemModel
    {
        //Criando relação  da tabela Mensagem de [n:1] muito para um com a tabela usuario
        public int Id { get; set; }
        public string? Text { get; set; }
        public DateTime DataEnvio { get; set; }

        public int RemetenteId { get; set; }
        public UsuarioModel? Usuario { get; set; }

        public int DestinatarioId { get; set; }
        public UsuarioModel? Destinatario { get; set; }
    }
}
