using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SayitoYazi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            string[] birBas = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] onBas = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
            string yuzBas = "yüz";
            string binBas = "bin";

            int birler = sayi % 10;
            int onlar = ((sayi % 100) - birler) / 10;
            int yuzler = (((sayi % 1000)) - sayi % 100)/100;
            int binler = ((sayi % 10000) - ((sayi % 1000) - sayi % 100)) / 1000;
            string metin = birBas[yuzler] + yuzBas;
            string metin2 = birBas[binler] + binBas;
            Console.WriteLine(metin2);
            Console.WriteLine(metin);
            Console.WriteLine(onBas[onlar] + birBas[birler]);



        }
    }
}





