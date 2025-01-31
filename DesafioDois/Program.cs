using System;

class Program
{
    private static String strSeqFibonacci = "";
    static void Main()
    {
        Console.Write("Digite um número: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (EhFibonacci(numero))
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
            else
                Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Digite um número inteiro.");
        }
        Console.WriteLine(strSeqFibonacci);
        Console.ReadLine();
    }

    static bool EhFibonacci(int n)
    {
        if (n < 0) return false;
        int a = 0, b = 1;
        while (a < n)
        {
            int temp = a + b;
            a = b;
            b = temp;
            strSeqFibonacci += $"Seguencia: {a}, ";
        }
        return a == n;
    }
}
