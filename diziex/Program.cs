using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] gunler = new string[7];
            //string[] yenigunler = new string[7];
            //gunler[0]= "pzt";
            //gunler[1]= "salı";
            //gunler[2] = "crs";
            //gunler[3] = "prs";
            //gunler[4] = "cuma";
            //gunler[5] = "cmrtsi";
            //gunler[6] = "pazar";

            ////Array.Clear(gunler, 0, 3);
            //yenigunler=(string[])gunler.Clone();
            //for (int i=0; i<gunler.Length; i++)
            //{
            //    Console.WriteLine("gunler");
            //    Console.WriteLine(gunler[i]);
            //}
            //for (int i = 0; i <= 6; i++)
            //{
            //    Console.WriteLine("yenı gunler");
            //    Console.WriteLine(yenigunler[i]);
            //}
            //int x = gunler.Length;
            //Console.WriteLine(x);

            while (true)
            {
                Console.WriteLine("kaç adet sayı toplayacaksınız?:");
                try
                {
                    int x = Convert.ToInt32(Console.ReadLine());
                    int[] sayi = new int[x];
                    int toplam = 0;
                    for (int i = 0; i < x; i++)
                    {
                        //Console.Write("{0} sayı giriniz  :  ",i+1);
                        //sayi[i] = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            Console.Write("{0} sayı giriniz  :  ", i + 1);
                            sayi[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {

                            Console.WriteLine("yanlıs giris yaptınız");
                            Console.Write("{0} sayı giriniz  :  ", i + 1);
                            sayi[i] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    for (int c = 0; c < x; c++)
                    {
                        Console.Write(sayi[c]);
                        if (c < x - 1)
                        {
                            Console.Write("+");
                        }
                        toplam = toplam + sayi[c];
                    }
                    Console.Write("=" + toplam);
                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("yanlıs giris yaptınız");
                    Console.ReadKey();
                }
            }
        }
    }

}