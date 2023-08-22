namespace EstoqueInteligente.Service.DTO
{
    public record Nomenclaturas( string Ano_Ato, string Codigo, string Data_Fim, string Data_Inicio, string Descricao, string Numero_Ato, string Tipo_Ato);

    public record NCMArquivo(string Ato, string Data_Ultima_Atualizacao_NCM, List<Nomenclaturas> Nomenclaturas);
}
