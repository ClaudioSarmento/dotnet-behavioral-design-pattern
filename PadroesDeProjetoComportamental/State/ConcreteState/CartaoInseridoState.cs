using State.State;

namespace State.ConcreteState;

public class CartaoInseridoState : ICaixaEletronicoState
{
    public void EjetarCartao()
    {
        Console.WriteLine("O cartão foi ejetado com sucesso.");
    }

    public void InformarSenha()
    {
        Console.WriteLine("A senha foi inserida com sucesso.");
    }

    public void InserirCartao()
    {
        Console.WriteLine("Operação inválida. O Cartão já foi inserido");
    }
    public void SacarDinheiro()
    {
        Console.WriteLine("O saque foi realizado com sucesso");
    }
}
