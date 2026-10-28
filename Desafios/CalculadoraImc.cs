using System.Globalization;

namespace DesafiosCSharp.Desafios;

public static class CalculadoraImc
{
    public static void Executar()
    {
        double peso = LerValorPositivo("Digite o seu peso (em quilogramas): ");
        double altura = LerValorPositivo("Digite a sua altura (em metros): ");

        double imc = peso / (altura * altura);
        string classificacao = ClassificarImc(imc);
        string imcFormatado = imc.ToString("F2", CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.WriteLine($"O seu IMC é: {imcFormatado}");
        Console.WriteLine($"Classificação: {classificacao}");
    }

    private static double LerValorPositivo(string mensagem)
    {
        double valor;

        while (true)
        {
            Console.Write(mensagem);
            string? entrada = Console.ReadLine();

            // Valida se o valor é um número maior que zero
            if (double.TryParse(entrada, NumberStyles.Float, CultureInfo.InvariantCulture, out valor) && valor > 0)
            {
                return valor;
            }

            Console.WriteLine("Valor inválido! Por favor, digite um número maior que zero.");
        }
    }

    private static string ClassificarImc(double imc)
    {
        if (imc < 18.5)
        {
            return "Abaixo do peso";
        }

        if (imc < 25)
        {
            return "Peso normal";
        }

        if (imc < 30)
        {
            return "Sobrepeso";
        }

        return "Obesidade";
    }
}
