namespace TodoApp
{
    class program
    {
        static List<string> Notlar = new List<string>();


        static void Main(string[] args)
        {
            while (true)//programı sonsuz döngüye soktuk, yoksa herhangi bir işlemden sonra kapanıyor.
            {

                Console.WriteLine("Lütfen Yapma istediğiniz İşlemi aşağıdan seçiniz.");
                Console.WriteLine("Not girişi yap : 1");
                Console.WriteLine("Notları Listele : 2");
                Console.WriteLine("Not Sil : 3");
                Console.WriteLine("Çıkış: 4");

                string islem = Console.ReadLine();

                switch (islem)
                {
                    case "1":
                        NotGir(); break;
                    case "2":
                        NotListele(); break;
                    case "3":
                        NotSil(); break;
                    case "4":
                        Console.WriteLine("Çıkış yapılıyor..."); return;
                    default: Console.WriteLine("Lütfen geçerli bir işlem giriniz"); break;
                }
            }
        }

        static void NotGir()
        {
            Console.WriteLine("Lütfen entera basıp3 eklenecek notu giriniz...");
            if (Console.ReadLine() != null)
            {
                string sec = Console.ReadLine();

                Notlar.Add(sec);
                Console.WriteLine("Not başarıyla eklendi...");
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir not giriniz.");
            }
            Console.WriteLine("");

        }


        static void NotListele()
        {
            Console.WriteLine("Notlarınız:");

            for (int i = 0; i < Notlar.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + Notlar[i]);
            }
            Console.WriteLine("");
        }
        static void NotSil()
        {
            NotListele();
            Console.WriteLine("Lütfen Silmekİstediğiniz not numarasını seçiniz");

            if (int.TryParse(Console.ReadLine(), out int sayi1))
            {
                Notlar.RemoveAt(sayi1 - 1);
                Console.WriteLine("Not başarıyla silindi");
            }
            NotListele();
            Console.WriteLine("");

        }

    }
}