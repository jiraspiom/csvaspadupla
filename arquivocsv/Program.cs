
using arquivocsv;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;


var arquivoB = LerArquivoA();

object LerArquivoA()
{
    string filePath = @"D:/DEV/AFotoGit/teste/BIO_1067_422312_ROP_OI_FIXO_RELATORIO_ANALITICO_INSAPOIO_20220501_20220530_062823.txt";

    try
    {
        List<Arquivo> listaArquivo = new List<Arquivo>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            reader.ReadLine(); // sai da primeira linha

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                listaArquivo.Add(line.Replace("\"",""));            
            }

            foreach (var item in listaArquivo)
            {
              Console.WriteLine($"nome: {item.DescricaoInsapoio}");
            }

            Console.WriteLine(listaArquivo.Count);
        }

        return listaArquivo;

    }
    catch (Exception ex)
    {        
        return ex.Message;
    }    
}


object LerArquivoB()
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
                Console.WriteLine($"primeiro: {arquivo.CodStatus}, segundo: {arquivo.CPFCliente} uai: {arquivo.DescricaoInsapoio}");
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
