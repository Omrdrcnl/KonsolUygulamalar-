namespace hesapMakinesi
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.");
            Console.WriteLine("Toplama İşlemi : 1");
            Console.WriteLine("Çıkarma İşlemi : 2");
            Console.WriteLine("Çarpma İşlemi : 3");
            Console.WriteLine("Bölme İşlemi : 4");
            Console.WriteLine("Vazgeç : 5");

            string islem = Console.ReadLine();

            switch (islem)
            {
                case "1":
                    ToplamaIslemi(); break;
                case "2":
                    CıkarmaIslemi(); break;
                case "3":
                    CarpmaIslemi(); break;
                case "4":
                    BolmeIslemi(); break;
                case "5":
                    Console.WriteLine("Programdan çıkılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    break;
            }
        }

        static void ToplamaIslemi()
        {
            Console.WriteLine("Lütfen toplma istediğiniz sayıları virgül(,) ile ayırarak giriniz.");

            string[] sayilar = Console.ReadLine().Split(",");

            double toplam = 0;

            foreach (string say in sayilar)
            {
                if (double.TryParse(say, out double sayi))
                {
                    toplam += sayi;
                }
            }

            Console.WriteLine("Sonuç: " + toplam);

        }
        static void BolmeIslemi()
        {
            Console.WriteLine("Lütfen Bölmek istediğiniz 2 sayıyı virgül(,) ile ayırarak giriniz.");

            string[] sayilar = Console.ReadLine().Split(",");

            if (sayilar.Length != 2)
            {
                Console.WriteLine("Lütfen geçerli bir işlem Giriniz");
                return;

            }
            else
            {
                double.TryParse(sayilar[0], out double sayi1);
                double.TryParse(sayilar[1], out double sayi2);

                double sonuc = sayi1 / sayi2;

                Console.WriteLine("Sonuç: " + sonuc);
            }

        }
        static void CıkarmaIslemi()
        {
            Console.WriteLine("Lütfen Çıkarmak istediğiniz 2 sayıyı virgül(,) ile ayırarak giriniz.");
            string[] sayilar = Console.ReadLine().Split(",");

            if (sayilar.Length != 2)
            {
                Console.WriteLine("Lütfen geçerli bir işlem Giriniz");
                return;
            }
            else
            {
                double.TryParse(sayilar[0], out double sayi1);
                double.TryParse(sayilar[1], out double sayi2);

                double sonuc = sayi1 - sayi2;

                Console.WriteLine("Sonuç: " + sonuc);
            }

        }
        static void CarpmaIslemi()
        {
            Console.WriteLine("Lütfen Çıkarmak istediğiniz 2 sayıyı virgül(,) ile ayırarak giriniz.");
            string[] sayilar = Console.ReadLine().Split(",");

            if (sayilar.Length != 2)
            {
                Console.WriteLine("Lütfen geçerli bir işlem Giriniz");
                return;
            }
            else
            {
                double.TryParse(sayilar[0], out double sayi1);
                double.TryParse(sayilar[1], out double sayi2);

                double sonuc = sayi1 * sayi2;

                Console.WriteLine("Sonuç: " + sonuc);
            }
        }
    }
}