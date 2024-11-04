using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Lütfen bir sayı girin: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            int square = number * number;
            Console.WriteLine("Girdiğiniz sayının karesi: " + square);
        }
        catch (FormatException)
        {
            Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Geçersiz giriş! Lütfen daha küçük veya daha büyük bir sayı giriniz.");
        }
    }
}
