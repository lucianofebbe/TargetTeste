class Program
{
    static void Main()
    {
        // Dicionário com os faturamentos por estado
        Dictionary<string, decimal> faturamentoEstados = new Dictionary<string, decimal>
        {
            {"SP", 67836.43m},
            {"RJ", 36678.66m},
            {"MG", 29229.88m},
            {"ES", 27165.48m},
            {"Outros", 19849.53m}
        };

        // Calcula o faturamento total
        decimal faturamentoTotal = 0;
        foreach (var valor in faturamentoEstados.Values)
        {
            faturamentoTotal += valor;
        }

        // Exibe os percentuais de cada estado
        Console.WriteLine("Percentual de representação de cada estado no faturamento total:");
        foreach (var estado in faturamentoEstados)
        {
            decimal percentual = (estado.Value / faturamentoTotal) * 100;
            Console.WriteLine($"{estado.Key}: {percentual:F2}%");
        }
        Console.ReadLine();
    }
}
