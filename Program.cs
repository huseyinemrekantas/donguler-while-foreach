// See https://aka.ms/new-console-template for more information
using System;
namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            // 1 den baslayarak console dan girilen sayiya kadar (say1 dahil) ortalama hesaplayip console a yazdiran program.
            Console.WriteLine("Lütfen bir sayi giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);
            
            // 'a' dan 'z' ye kadar tüm harfleri yazdıran kod.
            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(character);
                character++;
            }

            Console.Write("\n*** foreach ***\n");
            string[] arabalar = {"BMW","FORD","TOYOTA","NİSSAN"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

        }

    }
}
     
         
           

