
using arquivocsv;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System.Globalization;
using System.Text.Json.Nodes;
using System.Text.Json;
using CsvHelper.Configuration.Attributes;
using System.Reflection.PortableExecutable;

var arquivoB = LerArquivoB();


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

        var local = "D:/DEV/AFotoGit/teste/arquivoA.txt";

        using (var reader = new StreamReader(local))
        using (var csv = new CsvReader(reader, config))
        {
            csv.Context.RegisterClassMap<ArquivoAMap>();

            arquivos = csv.GetRecords<ArquivoA>().ToList();

            foreach (var arquivo in arquivos)
                Console.WriteLine($"primeiro: {arquivo.CodStatus}, segundo: {arquivo.CPFCliente} status: {arquivo.Status}");
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
