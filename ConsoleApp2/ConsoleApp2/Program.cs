// See https://aka.ms/new-console-template for more information

using System.Security.AccessControl;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int zmienna = 0;
        String zmienna2 = "Modyfikacja2";
        String zmienna3 = "MODYFIKACJA3AHA";
        int[] aha = { 1,1,2 };
        Console.WriteLine(Zadanie3(aha));
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
}