namespace DesafiosCSharp;

public static class Program
{
    public static void Main()
    {
        while (true)
        {
            ExibirMenu();

            string? entrada = Console.ReadLine();
            int.TryParse(entrada, out int opcao);

            switch (opcao)
            {
                case 1:
                    Desafios.DesafioSoma.Executar();
                    break;
                case 2:
                    Desafios.CalculadoraImc.Executar();
                    break;
                case 3:
                    Desafios.CalculadoraSimples.Executar();
                    break;
                case 0:
                    Console.WriteLine("Obrigado por usar o Desafios C#! Ate a proxima!");
                    return;
                default:
                    Console.WriteLine("Opção inválida! Digite 1, 2, 3 ou 0.");
                    break;
            }
        }
    }

    private static void ExibirMenu()
    {
        Console.WriteLine("=================================");
        Console.WriteLine("         DESAFIOS C#");
        Console.WriteLine("=================================");
        Console.WriteLine("1 - Soma de 1 a 10");
        Console.WriteLine("2 - Calculadora de IMC");
        Console.WriteLine("3 - Calculadora Simples");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("=================================");
        Console.Write("Digite a opção desejada: ");
    }
}
