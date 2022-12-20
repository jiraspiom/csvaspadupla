using CsvHelper.Configuration.Attributes;

namespace arquivocsv.Classes
{
    public class ArquivoA
    {
        [Name("DATA_REFERENCIA")]
        public string DataReferencia { get; set; }

        [Name("STATUS")]
        public string Status { get; set; }

        [Name("COD_STATUS")]
        public string CodStatus { get; set; }

        [Name("GEOGRAFIA")]
        public string Geografia { get; set; }

        [Name("SIGLA_UF")]
        public string SiglaUF { get; set; }

        [Name("SIGLA_GAA")]
        public string SiglaGAA { get; set; }

        [Name("SIGLA_GRAM")]
        public string SiglaGRAM { get; set; }

        [Name("SIGLA_GRA")]
        public string SiglaGRA { get; set; }

        [Name("ESTACAO")]
        public string Estacao { get; set; }

        [Name("DDD")]
        public string DDD { get; set; }

        [Name("NUMERO_TERMINAL")]
        public string NumeroTerminal { get; set; }

        [Name("REGISTRO")]
        public string Registro { get; set; }

        [Name("DATA_ABERTURA")]
        public string DataAbertura { get; set; }

        [Name("HORA_ABERTURA")]
        public string HoraAbertura { get; set; }

        [Name("PRAZO")]
        public string Prazo { get; set; }

        [Name("DATA_FECHAMENTO")]
        public string DataFechamento { get; set; }

        [Name("HORA_FECHAMENTO")]
        public string HoraFechamento { get; set; }

        [Name("DATA_PROMESSA")]
        public string DataPromessa { get; set; }

        [Name("HORA_PROMESSA")]
        public string HoraPromessa { get; set; }

        [Name("MATRICULA_ATENDENTE")]
        public string MatriculaAtendente { get; set; }

        [Name("CODIGO_INSAPOIO")]
        public string CodigoInsapoio { get; set; }

        [Name("DESCRICAO_INSAPOIO")]
        public string DescricaoInsapoio { get; set; }

        [Name("LOCALIDADES")]
        public string Localidades { get; set; }

        [Name("UNIDADE_NEGOCIO")]
        public string UnidadeNegocio { get; set; }

        [Name("DESCRICAO_RELACIONAMENTO")]
        public string DescricaoRelacionamento { get; set; }

        [Name("NRC_CLIENTE")]
        public string NRCCliente { get; set; }

        [Name("CPF_CLIENTE")]
        public string CPFCliente { get; set; }

        [Name("CAMPO_OBSERVACAO")]
        public string CampoObservacao { get; set; }

        [Name("COD_LOCALIDADE")]
        public string CodLocalidade { get; set; }
    }
}
