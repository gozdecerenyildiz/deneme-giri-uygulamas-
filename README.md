# deneme-giri-uygulamas-
### Basit Kayıt ve Giriş Sistemi

Dizi ve döngüler kullanarak bir kayıt-giriş console uygulaması hazırladım.

İlk olarak kullanıcının ekranına Kayıt için(1),Giriş için(2),Çıkış için(3) arasında seçim yapılacak ekran gelir.

(1) seçtiği durumda kayıt için isim ve şifre alınır stringe çevrilir.Sonra  "Kayıt oluşturuluyor" yazar ve bu 2 saniye boyunca yazar.Bunu yapan kod ise "Thread.Sleep(2000); "
ekranı temizler ve başa döndürür.



            
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

  (2) seçildiği durumda kayıt altındaki kullanıcı adı ve şifre alınır. En fazla 3 kere deneme şansı verilir.
  
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

  Şifre ve kullanıcı adı doğru girildiği takdirde "Kullanıcı adı ve şifre doğru." ekranda yazar.Doğru değilse "Kullanıcı adI veya şifre yanlış tekrar deneyiniz." yazar.
  
                    if (kullanici_adi == kayıtlı && sifre == yenisifre) 
                    {
                        Console.WriteLine("Kullanıcı adı ve şifre doğru.");
                    }
                    else
                    {
                        Console.WriteLine("Kullanıcı adI veya şifre yanlış tekrar deneyiniz.");

  Eğer 3 hakkıda doldu ise "Hakkınız dolmuştur." yazar ve en baş ekrana yollar.Bunu goto ile yapar.
  
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
                

  (3) seçildiği durumda çıkış yapılır eğer 1,2,3 dışında bir sayıya basıldığında  "hatalı işlem" yazar.
    
      
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
