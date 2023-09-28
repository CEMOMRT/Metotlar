using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20; // Ref yapısına benzer birde out var onda metod dışında tanımlamamıza gerek yok.
            int number2 = 100;
            var result = Add(ref number1, number2); // Yolladığımız referans değişkeni her zaman başına ref yazacağız.
            Console.WriteLine(result);
            Console.WriteLine(number1);
            Console.ReadKey();
        }
        
        static int Add(ref int number1,int number2) //referans parametre bir sınıftaki aynı isimde bir değişkenin değerini metodun içinde tanımladığımız gibi atamamızı sağlar.
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Overload(int number1,int number2)
        {
            return number1 - number2;
        }
        static int Overload(int number1, int number2, int number3) //içindekiler metodun imzası oluyo böylece aynı isimde farkıl metotlar kullanabiliyorus, bunada metot overload deniyor.
        {
            return number1 * number2 * number3;
        }

    }
}
