namespace EstoqueInteligente.Service.DTO
{
    public class Nomenclaturas {
        public string Ano_Ato { get; set; }
        public string Codigo { get; set; }
        public string Data_Fim { get; set; }
        public string Data_Inicio { get; set; }
        public string Descricao { get; set; }
        public string Numero_Ato { get; set; }
        public string Tipo_Ato { get; set; }

        public Nomenclaturas() {}

        public Nomenclaturas(string Ano_Ato, string Codigo, string Data_Fim, string Data_Inicio, string Descricao, string Numero_Ato, string Tipo_Ato)
        {
            this.Ano_Ato = Ano_Ato;
            this.Codigo = Codigo;
            this.Data_Fim = Data_Fim;
            this.Data_Inicio = Data_Inicio;
            this.Descricao = Descricao;
            this.Numero_Ato = Numero_Ato;
            this.Tipo_Ato = Tipo_Ato;
        }
    } ;

    public record NCMArquivo(string Ato, string Data_Ultima_Atualizacao_NCM, List<Nomenclaturas> Nomenclaturas);
}
