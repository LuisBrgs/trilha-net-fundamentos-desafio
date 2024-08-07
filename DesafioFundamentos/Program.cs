using DesafioFundamentos.Models;

Console.WriteLine("Seja bem-vindo(a) ao sistema de estacionamento!");
decimal precoInicial = 0;
decimal precoPorHora = 0;

while (true)
{
    try
    {
        Console.WriteLine("Digite o preço inicial: ");
        precoInicial = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Agora digite o preço por hora: ");
        precoPorHora = Convert.ToDecimal(Console.ReadLine());
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Valor inválido! Digite apenas números.");
    }
}

Estacionamento estacionamento = new Estacionamento();

while (true)
{
    estacionamento.DisplayMenu();
    string opcao = Console.ReadLine();
    if (opcao == "1")
    {
        estacionamento.AdicionarVeiculo();
    }
    else if (opcao == "2")
    {
        estacionamento.RemoverVeiculo(precoInicial, precoPorHora);
    }
    else if (opcao == "3")
    {
        estacionamento.ListarVeiculos();
    }
    else if (opcao == "4")
    {
        Console.WriteLine("Encerrando o programa...");
        break;
    }
    else
    {
        Console.WriteLine("Opção inválida!");
    }
}