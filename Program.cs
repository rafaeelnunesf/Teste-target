using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha uma questão para executar (1 a 5):");
        Console.WriteLine("1. Soma com laço\n2. Fibonacci\n3. Análise de faturamento diário\n4. Percentual por estado\n5. Inversão de string");
        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            int escolha = int.Parse(input);

            switch (escolha)
            {
                case 1:
                    Questao1();
                    break;
                case 2:
                    Questao2();
                    break;
                case 3:
                    Questao3();
                    break;
                case 4:
                    Questao4();
                    break;
                case 5:
                    Questao5();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }

    // Questão 1
    static void Questao1()
    {
        Console.WriteLine("Questão 1: Soma com laço");
        int INDICE = 13, SOMA = 0, K = 0;

        while (K < INDICE)
        {
            K += 1;
            SOMA += K;
        }

        Console.WriteLine($"O valor de SOMA é: {SOMA}");
    }

    // Questão 2
    static void Questao2()
    {
        Console.WriteLine("Questão 2: Verificação Fibonacci");
        Console.Write("Digite um número: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int numero))
        {
            if (PertenceFibonacci(numero))
            {
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }

    static bool PertenceFibonacci(int numero)
    {
        int a = 0, b = 1;
        while (b < numero)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return b == numero || numero == 0;
    }

    // Questão 3
    static void Questao3()
    {
        Console.WriteLine("Questão 3: Análise de faturamento diário");

        string caminhoJson = "dados.json";
        string json = File.ReadAllText(caminhoJson);

        var dados = JsonConvert.DeserializeObject<List<Faturamento>>(json);

        var valoresMaioresQueZero = dados.Where(v => v.Valor > 0).Select(v => v.Valor).ToList();

        double menorValor = valoresMaioresQueZero.Min();
        double maiorValor = valoresMaioresQueZero.Max();
        double mediaMensal = valoresMaioresQueZero.Average();
        int diasAcimaMedia = valoresMaioresQueZero.Count(v => v > mediaMensal);

        Console.WriteLine($"Menor valor: {menorValor:F2}");
        Console.WriteLine($"Maior valor: {maiorValor:F2}");
        Console.WriteLine($"Dias acima da média: {diasAcimaMedia}");
    }

    public class Faturamento
    {
        public int Dia { get; set; }
        public double Valor { get; set; }
    }

    // Questão 4
    static void Questao4()
    {
        Console.WriteLine("Questão 4: Percentual por estado");

        var faturamento = new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

        double total = faturamento.Values.Sum();

        foreach (var estado in faturamento)
        {
            double percentual = (estado.Value / total) * 100;
            Console.WriteLine($"{estado.Key}: {percentual:F2}%");
        }
    }

    // Questão 5
    static void Questao5()
    {
        Console.WriteLine("Questão 5: Inversão de string");
        Console.Write("Digite uma string: ");
        string texto = Console.ReadLine();

        string invertida = InverterString(texto);
        Console.WriteLine($"String invertida: {invertida}");
    }

    static string InverterString(string texto)
    {
        if (texto == null) return string.Empty;
        string invertida = "";
        for (int i = texto.Length - 1; i >= 0; i--)
        {
            invertida += texto[i];
        }
        return invertida;
    }
}
