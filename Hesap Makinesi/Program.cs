// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Basit hesap makiesine hos geldiniz.");

Console.Write("Birinci sayiyi giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ikinci sayiyi giriniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Yapmak istediginiz islemi seciniz (= , - , * , /)");
char isaretci = Convert.ToChar(Console.ReadLine());

    if (isaretci == '+')
    {
        Console.WriteLine("Iki sayinin toplami :" + (sayi1 + sayi2));
    }

    else if (isaretci == '-')
    {
        Console.WriteLine("Iki sayinin farki :" + (sayi1 - sayi2));
    }
    else if (isaretci == '*')
    {
        Console.WriteLine("Iki sayinin carpimi :" + (sayi1 * sayi2));
    }
    else if (isaretci == '/')
    {
                if (sayi2 == 0)
            {
                Console.WriteLine("Gecersiz islem. Bir sayi 0'a bolunemez!");
            }
        Console.WriteLine("Bolumun sonucu: " + (sayi1 / sayi2));
    }


