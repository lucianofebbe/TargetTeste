using Newtonsoft.Json;

class Program
{
    public class Faturamento
    {
        public string Dia { get; set; }
        public decimal Valor { get; set; }
    }

    static void Main()
    {
        // Alterar Caminho para Execução
        string json = ReadJson("C:/Users/lucia/source/repos/TargetDesafio/DesafioTres/dados.json");

        // Deserializa o JSON
        List<Faturamento> faturamentoList = JsonConvert.DeserializeObject<List<Faturamento>>(json);

        // Filtra os dias com faturamento
        var diasComFaturamento = faturamentoList.Where(f => f.Valor > 0).ToList();

        // Calcular o menor e maior valor de faturamento
        decimal menorFaturamento = diasComFaturamento.Min(f => f.Valor);
        decimal maiorFaturamento = diasComFaturamento.Max(f => f.Valor);

        // Calcular a média do faturamento
        decimal mediaFaturamento = diasComFaturamento.Average(f => f.Valor);

        // Calcular o número de dias com faturamento acima da média
        int diasAcimaDaMedia = diasComFaturamento.Count(f => f.Valor > mediaFaturamento);

        // Exibir os resultados
        Console.WriteLine($"Menor faturamento: {menorFaturamento:C}");
        Console.WriteLine($"Maior faturamento: {maiorFaturamento:C}");
        Console.WriteLine($"Número de dias acima da média: {diasAcimaDaMedia}");
        Console.ReadLine();

    }

    private static string ReadJson(string caminhoArquivo)
    {
        try
        {
            // Lendo o conteúdo do arquivo JSON para uma string
            string jsonString = File.ReadAllText(caminhoArquivo);

            return jsonString;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.ToString());
        }
    }
}