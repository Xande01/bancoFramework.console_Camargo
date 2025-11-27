using Domain.Model;

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
        var pessoa = new Pessoa();
        var opçao = 0;

        Console.WriteLine("Seu número de identificação:");
        pessoa.Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Seu nome:");
        pessoa.Nome = Console.ReadLine();

        Console.WriteLine("Seu CPF:");
        pessoa.Cpf = Console.ReadLine();
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
                    Console.WriteLine("Depósito selecionado");
                    break;

                case 2:
                    Console.WriteLine("Saque selecionado");
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