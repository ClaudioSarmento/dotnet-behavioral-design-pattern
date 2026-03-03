using Strategy.Strategy;

namespace Strategy.ConcreteStrategy;

public class CompressaoRar : ICompressao
{
    public void ComprimirArquivo(string nomeArquivo)
    {
        Console.WriteLine($"\nO arquivo '{nomeArquivo}' foi compactado usando Rar. " +
           $"\nUm arquivo com extensão .rar foi criado");
    }
}
