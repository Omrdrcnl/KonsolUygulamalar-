using System.IO;

namespace FileMs
{


    class program
    {
        public static List<Filep> files = new List<Filep>();


        static void Main(string[] Args)
        {
            while (true)
            {
                Console.WriteLine("Dosya Yönetimi Uygulaması");
                Console.WriteLine("1. Dosya Ekle");
                Console.WriteLine("2. Dosyaları Listele");
                Console.WriteLine("3. Dosya Sil");
                Console.WriteLine("4. Dosyayı Oku");
                Console.WriteLine("5. Çıkış");

                string islem = Console.ReadLine();
                switch (islem)
                {
                    case "1":
                        AddFile(); break;
                    case "2":
                        FileList(); break;
                    case "3":
                        DeleteFile(); break;
                    case "4":
                        ReadFile(); break;
                    case "5":
                        Console.WriteLine("Çıkış yapılıyor..."); return;
                    default:
                        Console.WriteLine("Lütfen geçerli bir değer giriniz");
                        break;
                }

            }
        }

        static void AddFile()
        {
            Console.WriteLine("Dosya Ekleme:");
            Console.WriteLine("Lütfen Dosya adı giriniz.");
            string name = Console.ReadLine();

            Console.WriteLine("Lütfen dosya yolunu giriniz");

            string filePath = Console.ReadLine();
            //Sytytem OI Kullanarak dosya yolu verip içeriğini okudujFile methodu ordan geliyor
            if (File.Exists(filePath))
            {
                Console.WriteLine("Dosya bulundu. İçeriği okunuyor...");
                string title = File.ReadAllText(filePath);
                Filep file = new Filep(name, title);

                files.Add(file);
            }
            else
            {
                Console.WriteLine("Belirtilen dosya bulunamadı.");
            }


        }
        static void FileList()
        {
            Console.WriteLine("Dosya Listesi:");
            for(int i =0; i< files.Count(); i++)
            {
                Console.WriteLine((i+1) +". " + files[i].Name);

            }
            Console.WriteLine("--------");
        }
        static void DeleteFile()
        {
            FileList();
            Console.WriteLine("Lütfen silme istediğiniz dosya no seçiniz");

            string selectedNo = Console.ReadLine();
            if(selectedNo!=null && Convert.ToInt32(selectedNo) <= files.Count())
            {
                files.RemoveAt(Convert.ToInt32(selectedNo)-1);
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir no giriniz...");
            }

        }
        static void ReadFile()
        {
            FileList();
            Console.WriteLine("Lütfen okumak istediğiginz dosyayı seçiniz");

            string selectedNo = Console.ReadLine();
            if (selectedNo != null && Convert.ToInt32(selectedNo) <= files.Count())
            {
                int j = Convert.ToInt32(selectedNo);
                Console.WriteLine((j) + ". Dosya Adı: " + files[j-1].Name + " İçerik:3" +
                    " " + files[j-1].Title);

            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir no giriniz...");
            }


        }

    }

    class Filep
    {
        public Filep(string name, string title)
        {
            Name = name;
            Title = title;
        }

        public string Name { get; set; }
        public string Title { get; set; }

    }
}