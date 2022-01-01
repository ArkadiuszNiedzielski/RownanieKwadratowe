using System;

namespace RownanieKwadratowe
{
    class RownanieKwadratowe
    {
        private
             double a, b, c, x1, x2, delta, wynik;

        public void podajWartosci()
        {
            try
            {
                Console.WriteLine("Podaj wartość a,b,c. Każdą zatwierdź Enterem");
                a = double.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("Wartość a nie może być zerem. Kończę program");
                    Environment.Exit(0);
                }
                b = double.Parse(Console.ReadLine());
                c = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Nieprawidłowe dane, kończę program");
            }
        }

        public double liczRownanie()
        {
             delta= (b * b) - 4 * a * c;



            return wynik;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RownanieKwadratowe dzialanie = new RownanieKwadratowe();
            dzialanie.podajWartosci();
        }
    }
}
