using System;

namespace CumledekiKelimeSayisi
{
    internal class Program
    {
        private static object kelimeler;

        static void Main(string[] args)
        {
            string metin;
            Console.Write("Metni Girin  : ");
            metin = Console.ReadLine();
            string[] kelimeler = metin.Split(' ');
            Console.WriteLine("Kelime Sayısı :" + kelimeler.Length);
            foreach (string kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }
            Console.ReadKey();

        }
    }
}
