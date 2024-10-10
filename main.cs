using System;

class Program
{
    static void Main()
    {
        // Definindo o vetor de faturamento (365 dias do ano)
        double[] faturamento = new double[365];

        // 0 representa dias sem faturamento
        Random rand = new Random();
        for (int i = 0; i < faturamento.Length; i++)
        {
            // Simulando faturamento com 10% de chance de ser zero
            faturamento[i] = rand.NextDouble() < 0.1 ? 0 : rand.Next(1000, 5000);
        }

        // Variáveis para o cálculo
        double menorFaturamento = double.MaxValue;
        double maiorFaturamento = double.MinValue;
        double somaFaturamento = 0;
        int diasComFaturamento = 0;

        // Cálculo do menor, maior e soma do faturamento
        for (int i = 0; i < faturamento.Length; i++)
        {
            if (faturamento[i] > 0)
            {
                // Atualiza menor e maior faturamento
                if (faturamento[i] < menorFaturamento)
                {
                    menorFaturamento = faturamento[i];
                }
                if (faturamento[i] > maiorFaturamento)
                {
                    maiorFaturamento = faturamento[i];
                }
                // Soma do faturamento e contagem de dias com faturamento
                somaFaturamento += faturamento[i];
                diasComFaturamento++;
            }
        }

        // Cálculo da média
        double mediaFaturamento = diasComFaturamento > 0 ? somaFaturamento / diasComFaturamento : 0;

        // Cálculo dos dias com faturamento acima da média
        int diasAcimaDaMedia = 0;
        for (int i = 0; i < faturamento.Length; i++)
        {
            if (faturamento[i] > mediaFaturamento)
            {
                diasAcimaDaMedia++;
            }
        }

        // Exibindo os resultados
        Console.WriteLine($"Menor Faturamento: {menorFaturamento}");
        Console.WriteLine($"Maior Faturamento: {maiorFaturamento}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
}

