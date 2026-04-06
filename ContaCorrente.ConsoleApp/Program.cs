
using System.Security.Cryptography;
//conta corrente

int numeroIdentificacao = RandomNumberGenerator.GetInt32(1, 101);
string titular = "Marco";
decimal saldo = 1000;
decimal limiteDebito = 1200;

while (true)
{
    Console.Clear();
    Console.WriteLine($"Conta Corrente de {titular}");
    Console.WriteLine("----------------------------------");
    Console.WriteLine("1 - Saque");
    Console.WriteLine("2 - Depósito");
    Console.WriteLine("3 - Consulta de saldo");
    Console.WriteLine("4 - Sair");

    string? opcaoMenu = Console.ReadLine()?.ToUpper();

    if (opcaoMenu == "S")
        break;

    if (opcaoMenu == "1")
    {
        Console.WriteLine("Digite o valor que deseja sacar (R$ ): ");
        decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

        if (saldo <= -limiteDebito)
        {
            Console.WriteLine("Valor do limite de débito ja foi ultrapassado!");
            Console.ReadLine();
           break;
        }
        else
        {
            saldo -= valorSaque;

            Console.WriteLine("Valor foi sacado com sucesso!");
            Console.ReadLine();
        }



    }
    else if (opcaoMenu == "2")

    {
        Console.WriteLine("Digite o valor que deseja depositar (R$ ): ");
        decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

        saldo += valorDeposito;
    }
    else if (opcaoMenu == "3")
    {
        Console.WriteLine($"O valor do saldo da conta é de (RS) {saldo}");
        Console.ReadLine();
    }

}
