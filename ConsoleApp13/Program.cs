using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kaç sayı üretmek istiyorsunuz?");
            int adet =int .Parse(Console.ReadLine());
            
            
            Random rastgele = new Random();
            int[] dizi = new int[adet];

            for (int i = 0; i < 100; i++)
            {
                int yeniSayi = rastgele.Next(0, 1000);
                Console.WriteLine(yeniSayi . ToString());

                if (dizi.Contains(yeniSayi))
                {
                    i++;
                } 
                else
                {
                  dizi [i] = yeniSayi;
                }


            }Array.Sort(dizi);
            for (int i = 0; i <dizi.Length; i++) ;
            {

                Console.Write("\n\nRasgele dizi\n\n" + dizi[0]);
            }
            Console.ReadKey();

        }
            
       
        }
    }
