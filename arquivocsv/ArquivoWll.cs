using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arquivocsv
{
    public class ArquivoWll
    {
        public string Pedido { get; set; }
        public string Cliente { get; set; }
        public string CPF { get; set; }
        public string Transportadora { get; set; }
        public string UF { get; set; }
        public string TipoDeServico { get; set; }
        public string Produto { get; set; }
        public string Data { get; set; }
        public string Mes { get; set; }
        public string Objeto { get; set; }
        public string NumNota { get; set; }
        public string Status { get; set; }
        public string DataStatus { get; set; }
        public string QtdItens { get; set; }
        public string QtdAparelho { get; set; }
        public string QtdChip { get; set; }
        public string TMAInbound { get; set; }
        public string TMAOutbound { get; set; }
        public string TMALogistica { get; set; }
        public string TMACanal { get; set; }
        public string TMACadeia { get; set; }
        public string DataSolic { get; set; }
        public string DataDisponivelCorte { get; set; }
        public string DataFaturamento { get; set; }
        public string DataExpedicao { get; set; }
        public string DataEntrega { get; set; }
        public string DataDisponivel { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string PrazoTransportadora { get; set; }
        public string TentativasEntregaTransportadora { get; set; }
        public string SomenteSistema { get; set; }
        public string CEP { get; set; }
        public string AreaDeRisco { get; set; }
        public string MotivoDevolucao { get; set; }
        public string DataPrimeiraTentativaDeEntrega { get; set; }
        public string OSSAP { get; set; }
        public string OSSTC { get; set; }
        public string Terminal { get; set; }        

        public ArquivoWll(
            string pedido, string cliente, string cPF, string transportadora, string uF, string tipoDeServico, string produto, string data, string mes, string objeto,
            string numNota, string status, string dataStatus, string qtdItens, string qtdAparelho, string qtdChip, string tMAInbound, string tMAOutbound, string tMALogistica, string tMACanal,
            string tMACadeia, string dataSolic, string dataDisponivelCorte, string dataFaturamento, string dataExpedicao, string dataEntrega, string dataDisponivel, string cidade, string bairro, string prazoTransportadora,
            string tentativasEntregaTransportadora, string somenteSistema, string cEP, string areaDeRisco, string motivoDevolucao, string dataPrimeiraTentativaDeEntrega, string oSSAP, string oSSTC, string terminal)
        {
            Pedido = pedido;
            Cliente = cliente;
            CPF = cPF;
            Transportadora = transportadora;
            UF = uF;
            TipoDeServico = tipoDeServico;
            Produto = produto;
            Data = data;
            Mes = mes;
            Objeto = objeto;
            NumNota = numNota;
            Status = status;
            DataStatus = dataStatus;
            QtdItens = qtdItens;
            QtdAparelho = qtdAparelho;
            QtdChip = qtdChip;
            TMAInbound = tMAInbound;
            TMAOutbound = tMAOutbound;
            TMALogistica = tMALogistica;
            TMACanal = tMACanal;
            TMACadeia = tMACadeia;
            DataSolic = dataSolic;
            DataDisponivelCorte = dataDisponivelCorte;
            DataFaturamento = dataFaturamento;
            DataExpedicao = dataExpedicao;
            DataEntrega = dataEntrega;
            DataDisponivel = dataDisponivel;
            Cidade = cidade;
            Bairro = bairro;
            PrazoTransportadora = prazoTransportadora;
            TentativasEntregaTransportadora = tentativasEntregaTransportadora;
            SomenteSistema = somenteSistema;
            CEP = cEP;
            AreaDeRisco = areaDeRisco;
            MotivoDevolucao = motivoDevolucao;
            DataPrimeiraTentativaDeEntrega = dataPrimeiraTentativaDeEntrega;
            OSSAP = oSSAP;
            OSSTC = oSSTC;
            Terminal = terminal;            
        }

        public static implicit operator ArquivoWll(string line)
        {
            var data = line.Split(";");
            return new ArquivoWll(
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
                data[28],
                data[29],
                data[30],
                data[31],
                data[32],
                data[33],
                data[34],
                data[35],
                data[36],
                data[37],
                data[38]
            );
        }
    }
}
