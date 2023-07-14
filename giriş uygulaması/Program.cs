using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace giriş_uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool anahtar = true;
            while (anahtar)
            {
            Baslangıc:
                Console.WriteLine("Kayıt(1)\nGiriş(2)\nÇıkış(3)");
                ConsoleKeyInfo secim = Console.ReadKey();
                if (secim.KeyChar == '1')
                {
                    Console.WriteLine("Kullanıcı adı oluştur: ");
                    string kayıtlı = Console.ReadLine();
                    Console.WriteLine("Yeni Şifre: ");
                    string yenisifre = Console.ReadLine();

                    Console.WriteLine("Kayıt oluşturuluyor......");
                    Thread.Sleep(2000);
                    Console.Clear();
                    goto Baslangıc;
                }
                else if (secim.KeyChar == '2')
                {
                Başlangıç1:
                    Console.WriteLine("Kullanıcı adı: ");
                    string kullanici_adi = Console.ReadLine();
                    Console.WriteLine("Şifre: ");
                    string sifre = Console.ReadLine();
                    int hak_sayisi = 3;
                    string[] kayıtlı = new string[1];
                    string[] yenisifre = new string[1];
                    for (int i = 0; i <1 ; i=1)
                    {
                       ;
                    }
                    if (kullanici_adi == kayıtlı && sifre == yenisifre) 
                    {
                        Console.WriteLine("Kullanıcı adı ve şifre doğru.");
                    }
                    else
                    {
                        Console.WriteLine("Kullanıcı adI veya şifre yanlış tekrar deneyiniz.");
                        if (hak_sayisi > 0)
                        {
                            hak_sayisi -= 1;
                        }
                        if (hak_sayisi == 0)
                        {
                            Console.WriteLine("Hakkınız dolmuştur.");
                            Thread.Sleep(2000);
                            break;
                            goto Başlangıç1;
                        }
                    }
                }
                else if (secim.KeyChar == '3')
                {
                    Console.Clear();
                    Console.WriteLine("Çıkış yapılıyor.....");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("hatalı işlem");
                }

                Console.ReadLine();
            }
        }
    }
}
    
