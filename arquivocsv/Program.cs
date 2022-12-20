
using arquivocsv;

string filePathA = @"D:/DEV/AFotoGit/teste/BIO_1067_422312_ROP_OI_FIXO_RELATORIO_ANALITICO_INSAPOIO_20220501_20220530_062823.txt";
string filePathB = @"D:/DEV/AFotoGit/teste/wll-R1-2022-12-06-completo.csv";

List<Arquivo> arquivoB = LerArquivo.LerArquivoA(filePathA);
List<ArquivoWll> arquivoWll = LerArquivo.LerArquivoWll(filePathB);

List<Vetor> result = Vetor.CriarListaVetor(arquivoB, arquivoWll);

foreach (var item in result)
{
    Console.WriteLine($"status: {item.Status} chave: {item.Chave} protocolo: {item.Protocolo} nome: {item.Nome}");
}


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
