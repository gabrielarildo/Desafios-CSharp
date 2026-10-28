namespace DesafiosCSharp.Desafios;

public static class DesafioSoma
{
    public static void Executar()
    {
        int soma = 0;

        // Soma os números inteiros de 1 a 10 com a estrutura for
        for (int numero = 1; numero <= 10; numero++)
        {
            soma += numero;
        }

        Console.WriteLine($"A soma de 1 a 10 é: {soma}");
    }
}
