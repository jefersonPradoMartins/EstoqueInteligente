namespace EstoqueInteligente.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class Bairro
    {
        public int CodigoBairro { get; set; }
        public string NomeBairro { get; set; }
    }
    public class Cidade
    {
        public int CodigoCidade { get; set; }
        public string NomeCidade { get; set; }
    }
}