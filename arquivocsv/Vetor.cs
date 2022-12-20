namespace arquivocsv
{
    public class Vetor
    {
        public string? Status { get; set; }
        public string? Chave { get; set; }
        public string? Protocolo { get; set; }
        public string? Nome { get; set; }

        public static List<Vetor> CriarListaVetor(List<Arquivo> arquivo, List<ArquivoWll> arquivoWll)
        {
            List<Vetor> result = arquivo
                    .Join(arquivoWll,
                        arquivo => (arquivo.SiglaUF + "-" + arquivo.DDD + arquivo.NumeroTerminal), arquivoWll => arquivoWll.UF + "-" + arquivoWll.Terminal,
                        (arquivo, arquivoWll) => new { ArquivoB = arquivo, ArquivoWll = arquivoWll })
                    .Select(a => new Vetor
                    {
                        Status = a.ArquivoB.Status,
                        Chave = a.ArquivoB.SiglaUF + "-" + a.ArquivoB.DDD + a.ArquivoB.NumeroTerminal,
                        Protocolo = a.ArquivoB.DDD + a.ArquivoB.NumeroTerminal + a.ArquivoB.Registro + a.ArquivoB.MatriculaAtendente,
                        Nome = a.ArquivoWll.Cliente
                    }).ToList();

            return result;

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"status: {item.Status} chave: {item.Chave} protocolo: {item.Protocolo} nome: {item.Nome}");
            //}
        }
    }
}
