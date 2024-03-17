// See https://aka.ms/new-console-template for more information

using System.Security.AccessControl;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int zmienna = 0;
        String zmienionoNaMain = "Modyfikacja2";
        String zmienionoNaMain2 = "MODYFIKACJA3AHA";
        int[] aha = { 1,1,2,4,3,2};
        Console.WriteLine(Zadanie3(aha));
        Console.WriteLine(Zadanie4(aha));
    }

    public static double Zadanie3(int[] tablica)
    {
        double suma = 0;
        foreach (int num in tablica)
        {
            suma += num;
        }
        
        return suma / tablica.Length;
    }

    public static int Zadanie4(int[] tab)
    {
        int max = tab[1];
        foreach (int value in tab)
        {
            if (max < value)
            {
                max = value;
            }
        }

        return max;
    }
    
}