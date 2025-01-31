using System;

class Program
{
    static void Main()
    {
        // Entrada da string (pode ser alterada conforme necessário)
        Console.Write("Digite uma string para inverter: ");
        string entrada = Console.ReadLine();

        // Chama a função para inverter a string
        string invertida = InverterString(entrada);

        // Exibe o resultado
        Console.WriteLine($"String invertida: {invertida}");
        Console.ReadLine();

    }

    static string InverterString(string str)
    {
        char[] caracteres = str.ToCharArray(); // Converte a string em um array de caracteres
        int esquerda = 0;
        int direita = str.Length - 1;

        // Inverte os caracteres manualmente
        while (esquerda < direita)
        {
            // Troca os caracteres de posição
            char temp = caracteres[esquerda];
            caracteres[esquerda] = caracteres[direita];
            caracteres[direita] = temp;

            // Move os índices para o centro
            esquerda++;
            direita--;
        }

        // Retorna a string invertida
        return new string(caracteres);
    }
}
