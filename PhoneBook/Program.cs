namespace PhoneBook
{
    class program
    {
        static Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Telefon Rehberi Uygulaması");
                Console.WriteLine("1. Kişi Ekle");
                Console.WriteLine("2. Kişi Düzenle");
                Console.WriteLine("3. Kişi Sil");
                Console.WriteLine("4. Rehberi Görüntüle");
                Console.WriteLine("5. Çıkış");

                string ch = Console.ReadLine();

                switch (ch)
                {
                    case "1":
                        AddContact();
                        break;
                    case "2":
                        EditContact();
                        break;
                    case "3":
                        DeleteContact();
                        break;
                    case "4":
                        DisplayPhoneBook();
                        break;
                    case "5":
                        Console.WriteLine("Çıkış yapılıyor...");
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçenek. Lütfen tekrar deneyin.");
                        break;
                }
            }
        }

        static void AddContact()
        {
            Console.WriteLine("Ad giriniz:");
            string name = Console.ReadLine();

            Console.WriteLine("Numara giriniz:");
            string number = Console.ReadLine();

            phoneBook.Add(name, number);
            Console.WriteLine("Kayıt başarıyla eklendi..");
        }

        static void EditContact()
        {
            Console.WriteLine("Güncellemek istediğiniz adı yazınız");

            string name = Console.ReadLine();
            if (phoneBook.ContainsKey(name))
            {
                Console.WriteLine("Numarayı yazınız");
                string number = Console.ReadLine();
                if (number != null)
                {
                    phoneBook[name] = number;
                    Console.WriteLine("Kayıt başarıyla güncellendi");
                }

            }
            else
            {
                Console.WriteLine("Kayıt bulunamadı");
            }
        }

        static void DeleteContact()
        {
            DisplayPhoneBook();
            Console.WriteLine("Lütfen silmek istediğiniz kayıt ismini yazınız");
            string sel = Console.ReadLine();
            if (phoneBook.ContainsKey(sel))
            {
                phoneBook.Remove(sel);
                Console.WriteLine("Kayıt başarıyla silindi");
            }
            else
            {
                Console.WriteLine("Kayıt bulunamadı");
            }
        }

        static void DisplayPhoneBook()
        {
            Console.WriteLine("Rehber:");

            foreach (var item in phoneBook.OrderBy(x => x.Key))
            {
                Console.WriteLine("İsim: " + item.Key + " Numara: " + item.Value);
            }
        }
    }
}