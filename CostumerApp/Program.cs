namespace CostumerApp
{
    class program
    {
        static List<Costumer> costumers = new List<Costumer>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Lütfen Yapacağınız işlemi seçiniz:");
                Console.WriteLine("1. Müşteri Ekle");
                Console.WriteLine("2. Müşteri Sil");
                Console.WriteLine("3. Müşteri Listele");
                Console.WriteLine("4. Çıkış");

                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        AddCostumer(); break;
                    case "2":
                        DeleteCostumer(); break;
                    case "3":
                        CostumerList(); break;
                    case "4":
                        Console.WriteLine("Çıkış yapılıyor.."); return;
                    default:
                        Console.WriteLine("Lütfen doğru bir seçim yapınız"); break;
                }
            }
        }

        static void AddCostumer()
        {
            Console.WriteLine("Lütfen Müsteri ismini giriniz.");
            string name = Console.ReadLine();
            Console.WriteLine("Lütfen Müsteri soyismini giriniz.");
            string surname = Console.ReadLine();
            Console.WriteLine("Lütfen Müsteri yaşını giriniz.");
            string age = Console.ReadLine();

            Costumer costumer = new Costumer(name, surname, age);
            costumers.Add(costumer);
            Console.WriteLine("Müsteri başarıyla eklendi.");
            Console.WriteLine("-----");

        }

        static void CostumerList()
        {
            Console.WriteLine("Müsteri Listesi:");
            for (int i = 0; i < costumers.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + costumers[i].Name + " " + costumers[i].Surname + "  Yas: " + costumers[i].Age);
                Console.WriteLine("-------");
            }
        }
        static void DeleteCostumer()
        {
            CostumerList();
            Console.WriteLine("Lütfen silinecek Müsteri numarasını giriniz.");

            if (int.TryParse(Console.ReadLine(), out int sayi))
            {
                if (sayi > costumers.Count)
                {
                    Console.WriteLine("Lütfen geçerli bir no giriniz");
                }
                else if (sayi == 0)
                {
                    Console.WriteLine("Sayı 0 olamaz");
                }
                else
                {
                    costumers.RemoveAt(sayi - 1);
                    Console.WriteLine("Müşteri başarıyla silindi");
                    CostumerList();
                }

            }
        }

    }

    class Costumer
    {
        public Costumer(string name, string surname, string age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }

    }
}