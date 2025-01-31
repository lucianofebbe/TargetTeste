using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int soma = Enumerable.Range(1, 13).Sum();
        Console.WriteLine($"O valor final de SOMA é: {soma}");
        Console.ReadLine();

    }
}
