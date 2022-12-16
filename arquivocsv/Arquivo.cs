using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arquivocsv
{
    public class Arquivo
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

        public Arquivo(string dataReferencia, string status, string codStatus, string geografia, string siglaUF, string siglaGAA, string siglaGRAM, string siglaGRA, string estacao, string dDD, string numeroTerminal, string registro, string dataAbertura, string horaAbertura, string prazo, string dataFechamento, string horaFechamento, string dataPromessa, string horaPromessa, string matriculaAtendente, string codigoInsapoio, string descricaoInsapoio, string localidades, string unidadeNegocio, string descricaoRelacionamento, string nRCCliente, string cPFCliente, string campoObservacao, string codLocalidade)
        {
            DataReferencia = dataReferencia;
            Status = status;
            CodStatus = codStatus;
            Geografia = geografia;
            SiglaUF = siglaUF;
            SiglaGAA = siglaGAA;
            SiglaGRAM = siglaGRAM;
            SiglaGRA = siglaGRA;
            Estacao = estacao;
            DDD = dDD;
            NumeroTerminal = numeroTerminal;
            Registro = registro;
            DataAbertura = dataAbertura;
            HoraAbertura = horaAbertura;
            Prazo = prazo;
            DataFechamento = dataFechamento;
            HoraFechamento = horaFechamento;
            DataPromessa = dataPromessa;
            HoraPromessa = horaPromessa;
            MatriculaAtendente = matriculaAtendente;
            CodigoInsapoio = codigoInsapoio;
            DescricaoInsapoio = descricaoInsapoio;
            Localidades = localidades;
            UnidadeNegocio = unidadeNegocio;
            DescricaoRelacionamento = descricaoRelacionamento;
            NRCCliente = nRCCliente;
            CPFCliente = cPFCliente;
            CampoObservacao = campoObservacao;
            CodLocalidade = codLocalidade;
        }

        public static implicit operator Arquivo(string line)
        {
            var data = line.Split(";");
            return new Arquivo(
                data[0],
                data[1],
                data[2],
                data[3],
                data[4],
                data[5],
                data[6],
                data[7],
                data[8],
                data[9],
                data[10],
                data[11],
                data[12],
                data[13],
                data[14],
                data[15],
                data[16],
                data[17],
                data[18],
                data[19],
                data[20],
                data[21],
                data[22],
                data[23],
                data[24],
                data[25],
                data[26],
                data[27],
                data[28]
            );
        }
    }
}
