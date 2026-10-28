using System.Globalization;

namespace DesafiosCSharp.Desafios;

public static class CalculadoraSimples
{
    public static void Executar()
    {
        if (!LerNumero("Digite o primeiro número: ", out double numero1))
        {
            return;
        }

        if (!LerNumero("Digite o segundo número: ", out double numero2))
        {
            return;
        }

        int opcao = LerOperacao();

        double resultado = 0;

        switch (opcao)
        {
            case 1:
                resultado = numero1 + numero2;
                break;
            case 2:
                resultado = numero1 - numero2;
                break;
            case 3:
                resultado = numero1 * numero2;
                break;
            case 4:
                if (numero2 == 0)
                {
                    Console.WriteLine("Erro: não é possível dividir por zero!");
                    return;
                }
                resultado = numero1 / numero2;
                break;
            default:
                Console.WriteLine("Operação inválida!");
                return;
        }

        Console.WriteLine($"Resultado: {resultado}");
    }

    private static bool LerNumero(string mensagem, out double numero)
    {
        Console.Write(mensagem);
        string? entrada = Console.ReadLine();

        // Valida se o valor digitado pode ser convertido para número
        if (double.TryParse(entrada, NumberStyles.Float, CultureInfo.InvariantCulture, out numero))
        {
            return true;
        }

        Console.WriteLine("Valor inválido! Digite um número válido.");
        return false;
    }

    private static int LerOperacao()
    {
        Console.WriteLine();
        Console.WriteLine("Escolha a operação desejada:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.Write("Digite o número da operação: ");

        int.TryParse(Console.ReadLine(), out int opcao);

        return opcao;
    }
}
