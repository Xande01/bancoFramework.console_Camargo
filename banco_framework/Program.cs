using Application;
using Domain.Model;
using CpfCnpjLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Seja bem vindo ao banco Framework");
        Console.WriteLine("Por favor, identifique-se");
        Console.WriteLine("");
        var pessoa = Identificacao();
    }

    static Pessoa Identificacao()
    {
        var cliente = new Cliente();
        var pessoa = new Pessoa();
        var opçao = 0;

        Console.WriteLine("Seu número de identificação:");
        pessoa.Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Seu nome:");
        pessoa.Nome = Console.ReadLine();

        Console.WriteLine("Seu CPF:");
        pessoa.Cpf = Console.ReadLine();


        if (!Cpf.Validar(pessoa.Cpf))
        {
            Console.WriteLine("CPF digitado não é válido");            
            return Identificacao();
            
        }

        Console.WriteLine("Seu saldo:");
        cliente.Saldo = float.Parse(Console.ReadLine());
                
        Console.Clear();

        do
        {

            Console.WriteLine($"Como posso ajudar {pessoa.Nome}?");
            Console.WriteLine("1 - Depósito");
            Console.WriteLine("2 - Saque");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("-------------");
            Console.WriteLine("Selecione uma opção");

            string input = Console.ReadLine();
            opçao = int.Parse(input);   

            switch (opçao)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Deposito selecionado ");
                    Console.WriteLine("Digite o valor: ");
                    float valorDeposito = float.Parse(Console.ReadLine());
                    
                    var soma = new Calculo();
                    cliente.Saldo = soma.Soma(cliente.Saldo, valorDeposito);
                    Console.WriteLine($"Depósito de R$ {valorDeposito} realizado com sucesso!");
                    Console.WriteLine($"Saldo atual é R$ {cliente.Saldo}");
                    break;

                case 2:
                    Console.WriteLine("Saque selecionado");
                    Console.WriteLine("Digite o valor: ");
                    float valorSaque = float.Parse(Console.ReadLine());
                    if (valorSaque > cliente.Saldo)
                        {
                        Console.WriteLine("Saldo insuficiente para realizar o saque.");
                        }
                    else
                    {
                        var subtracao = new Calculo();
                        cliente.Saldo = subtracao.Subtracao(cliente.Saldo, valorSaque);

                        Console.WriteLine($"Saque de R$ {valorSaque} realizado com sucesso!");
                        Console.WriteLine($"Saldo atual é R$ {cliente.Saldo}");
                    }

                    break;

                case 3:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.Clear();
                    break;

            }
        } while (opçao != 3);

        return pessoa;
    }


}