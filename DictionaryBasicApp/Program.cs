namespace DictionaryBasicApp
{
    class program
    {
        static Dictionary<string, int> data = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Lütfen seçim yapınız.");
                Console.WriteLine("1. Not Ekle");
                Console.WriteLine("2. Notları Listele");
                Console.WriteLine("3. Çıkış");

                string choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        AddGradues(data); break;
                    case "2":
                        ListGradues(data); break;
                    case "3":
                        Console.WriteLine("Çıkış yapılıyor...");
                        return;
                    default:
                        Console.WriteLine("Lütfen doğru bir seçenek seçiniz..");
                        break;
                }
            }
        }

        static void AddGradues(Dictionary<string, int> data)
        {
            Console.WriteLine("Lütfen Öğrenci Adını Giriniz");

            string name = Console.ReadLine();

            if (!data.ContainsKey(name))
            {
                Console.WriteLine("Lütfen Öğrenci notunu giriniz");

                int grad = Convert.ToInt32(Console.ReadLine());


                data.Add(name, grad);
                Console.WriteLine("Not Eklendi");

            }
            else
            {
                Console.WriteLine("Öğrenci adı zaten mevcut Notu güncellemek istermisiniz ? E/H");

                string ch = Console.ReadLine();

                if (ch.ToLower() == "e")
                {
                    Console.WriteLine("Lütfen yeni notu giriniz");

                    int not = Convert.ToInt32(Console.ReadLine());

                    data[name] = not;
                    Console.WriteLine("Not güncellendi");
                }
            }

        }

        static void ListGradues(Dictionary<string, int> data)
        {
            foreach (var item in data)
            {
                Console.WriteLine("Öğrenci adı: " + item.Key + " Notu: " + item.Value);
            }
        }

    }
}