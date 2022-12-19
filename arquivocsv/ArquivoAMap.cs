using CsvHelper.Configuration;

namespace arquivocsv
{
    public class ArquivoAMap : ClassMap<ArquivoA>
    {
        public ArquivoAMap()
        {
            Map(m => m.DataReferencia).Name("DATA_REFERENCIA");
            Map(m => m.Status).Name("STATUS");
            Map(m => m.CodStatus).Name("COD_STATUS");
            Map(m => m.Geografia).Name("GEOGRAFIA");
            Map(m => m.SiglaUF).Name("SIGLA_UF");
            Map(m => m.SiglaGAA).Name("SIGLA_GAA");
            Map(m => m.SiglaGRAM).Name("SIGLA_GRAM");
            Map(m => m.SiglaGRA).Name("SIGLA_GRA");
            Map(m => m.Estacao).Name("ESTACAO");
            Map(m => m.DDD).Name("DDD");
            Map(m => m.NumeroTerminal).Name("NUMERO_TERMINAL");
            Map(m => m.Registro).Name("REGISTRO");
            Map(m => m.DataAbertura).Name("DATA_ABERTURA");
            Map(m => m.HoraAbertura).Name("HORA_ABERTURA");
            Map(m => m.Prazo).Name("PRAZO");
            Map(m => m.DataFechamento).Name("DATA_FECHAMENTO");
            Map(m => m.HoraFechamento).Name("HORA_FECHAMENTO");
            Map(m => m.DataPromessa).Name("DATA_PROMESSA");
            Map(m => m.HoraPromessa).Name("HORA_PROMESSA");
            Map(m => m.MatriculaAtendente).Name("MATRICULA_ATENDENTE");
            Map(m => m.CodigoInsapoio).Name("CODIGO_INSAPOIO");
            Map(m => m.DescricaoInsapoio).Name("DESCRICAO_INSAPOIO");
            Map(m => m.Localidades).Name("LOCALIDADES");
            Map(m => m.UnidadeNegocio).Name("UNIDADE_NEGOCIO");
            Map(m => m.DescricaoRelacionamento).Name("DESCRICAO_RELACIONAMENTO");
            Map(m => m.NRCCliente).Name("NRC_CLIENTE");
            Map(m => m.CPFCliente).Name("CPF_CLIENTE");
            Map(m => m.CampoObservacao).Name("CAMPO_OBSERVACAO");
            Map(m => m.CodLocalidade).Name("COD_LOCALIDADE");
        }
    }

}
