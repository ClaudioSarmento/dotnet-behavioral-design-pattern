using State.Context;

class Program
{
    static void Main(string[] args)
    {
        CaixaEletronico caixaEletronico = new CaixaEletronico();
        Console.WriteLine("Estado atual do Caixa Eletrônico: "
            + caixaEletronico.caixaEletronicoState.GetType());

        Console.WriteLine("");
        caixaEletronico.InformarSenha();
        caixaEletronico.SacarDinheiro();
        caixaEletronico.EjetarCartao();
        caixaEletronico.InserirCartao();
        Console.WriteLine("");

        Console.WriteLine("Estado atual do Caixa Eletrônico: "
            + caixaEletronico.caixaEletronicoState.GetType());
        caixaEletronico.InformarSenha();
        caixaEletronico.SacarDinheiro();
        caixaEletronico.InserirCartao();
        caixaEletronico.EjetarCartao();
        Console.WriteLine("");

        Console.WriteLine("Estado atual do Caixa Eletrônico: "
         + caixaEletronico.caixaEletronicoState.GetType());

    }
}