
using arquivocsv;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Linq;

List<Arquivo> arquivoB = LerArquivoA();
List<ArquivoWll> arquivoWll = LerArquivoWll();

/*
foreach (var item in arquivoB)
{
    Console.WriteLine($" chave: {item.SiglaUF}-{item.DDD}{item.NumeroTerminal}  protocolo : {item.DDD}{item.NumeroTerminal}{item.Registro}{item.MatriculaAtendente}");
}

Console.WriteLine($"quantidade: {arquivoB.Count}");


foreach (var item in arquivoWll)
{
    Console.WriteLine($"chave: {item.UF}-{item.Terminal}  datastatus: {item.DataStatus} nome: {item.Cliente}");
}

Console.WriteLine($"quantidade: {arquivoWll.Count}");
*/


var result = arquivoB
            .Join(arquivoWll,
                arquivoB => (arquivoB.SiglaUF + "-" + arquivoB.DDD + arquivoB.NumeroTerminal), arquivoWll => arquivoWll.UF + "-" + arquivoWll.Terminal,
                (arquivoB, arquivoWll) => new { ArquivoB = arquivoB, ArquivoWll = arquivoWll })
            .Select(a => new
            {
                Status = a.ArquivoB.Status,
                Chave = a.ArquivoB.SiglaUF + "-" + a.ArquivoB.DDD + a.ArquivoB.NumeroTerminal,
                Protrocolo = a.ArquivoB.DDD + a.ArquivoB.NumeroTerminal + a.ArquivoB.Registro + a.ArquivoB.MatriculaAtendente,
                Nome = a.ArquivoWll.Cliente
            }).ToList();

foreach (var item in result)
{
    Console.WriteLine($"status: {item.Status} chave: {item.Chave} protocolo: {item.Protrocolo} nome: {item.Nome}");
}

List<Arquivo>? LerArquivoA()
{
    string filePath = @"D:/DEV/AFotoGit/teste/BIO_1067_422312_ROP_OI_FIXO_RELATORIO_ANALITICO_INSAPOIO_20220501_20220530_062823.txt";

    try
    {
        List<Arquivo> listaArquivo = new List<Arquivo>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            reader.ReadLine(); //sai da primeira linha

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                line = line + ";chave";
                line = line.Replace("\"", "");

                listaArquivo.Add(line);
            }
            
            //retorna objeto filtrado
            return listaArquivo.Where(x =>
                x.Status != "FECHADA" &&
                (
                    x.CodigoInsapoio == "106" ||
                    x.CodigoInsapoio == "107" ||
                    x.CodigoInsapoio == "108" ||
                    x.CodigoInsapoio == "109" ||
                    x.CodigoInsapoio == "110" ||
                    x.CodigoInsapoio == "111" ||
                    x.CodigoInsapoio == "121"
                )).ToList();
        }
    }
    catch (Exception)
    {
        return null;
    }
}


List<ArquivoWll>? LerArquivoWll()
{
    string filePath = @"D:/DEV/AFotoGit/teste/wll-R1-2022-12-06-completo.csv";

    try
    {
        List<ArquivoWll> listaArquivo = new List<ArquivoWll>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            reader.ReadLine(); //sai da primeira linha

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                //line = line + ";chave";
                line = line.Replace("\"", "");

                listaArquivo.Add(line);
            }            
        }

        return listaArquivo;

    }
    catch (Exception)
    {
        return null;
    }
}



object LerArquivoBugado()
{
    try
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = true,
            Delimiter = ";",
            ShouldQuote = args => true,
        };

        List<ArquivoA> arquivos;

        var local = "D:/DEV/AFotoGit/teste/BIO_1067_422312_ROP_OI_FIXO_RELATORIO_ANALITICO_INSAPOIO_20220501_20220530_062823.txt";
        var localSaida = "D:/DEV/AFotoGit/teste/arquivoA.txt";

        //File.WriteAllText(localSaida, Regex.Replace(File.ReadAllText(local), "[\"]", ""));

        //var file = Regex.Replace(File.ReadAllText(local), "[\"]", "");

        using (var reader = new StreamReader(localSaida))
        using (var csv = new CsvReader(reader, config))
        {
            csv.Context.RegisterClassMap<ArquivoAMap>();

            arquivos = csv.GetRecords<ArquivoA>().ToList();

            foreach (var arquivo in arquivos)
                Console.WriteLine($"chave {arquivo.DDD}");
        }

        //using (var writer = new StreamWriter("testeFile.csv"))
        //using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        //{
        //    csv.Context.RegisterClassMap<AtendimentoMap>();

        //    csv.WriteHeader<Atendimento>();
        //    csv.NextRecord();

        //    csv.WriteRecords(atendimentos);
        //}
    }
    catch (Exception ex)
    {
        Console.WriteLine($"erro foi: {ex.Message}"); ;
    }

    return "";
}
