using Strategy.ConcreteStrategy;
using Strategy.Context;

Console.WriteLine("## Padrão Strategy ##\n");

CompressaoContext ctx = new CompressaoContext(new CompressaoRar());

Console.WriteLine("Informe o nome do arquivo a comprimir");

var nomeArquivo = Console.ReadLine();
if (string.IsNullOrEmpty(nomeArquivo))
    nomeArquivo = "";
 
Console.WriteLine("\nInforme o tipo de compressão a ser usada");
Console.WriteLine("1-Rar(Padrão) 2-Zip 3-Gzip\n");
var opcao = Convert.ToInt32(Console.ReadLine());

switch (opcao)
{
    case 2:
        ctx.DefineStrategy(new CompressaoZip());
        break;
    case 3:
        ctx.DefineStrategy(new CompressaoGzip());
        break;
}

ctx.CriarArquivoCompactado(nomeArquivo);

Console.Read();
