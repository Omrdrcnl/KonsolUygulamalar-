using System.Threading.Channels;

namespace OrderApp
{
    class program
    {
        static List<Order> orders = new List<Order>();

        static void Main(string[] Args)
        {
            while (true)
            {
                Console.WriteLine("Lütfen Seçim Yapınız.");
                Console.WriteLine("1. Görev Ekle");
                Console.WriteLine("2. Görev Listele");
                Console.WriteLine("3. Görev Tamamla");
                Console.WriteLine("4. Görev Sil");
                Console.WriteLine("5. Çıkış yap");

                string islem = Console.ReadLine();
                switch (islem)
                {
                    case "1":
                        AddOrder(); break;
                    case "2":
                        OrderList(); break;
                    case "3":
                        OrderDone(); break;
                    case "4":
                        OrderDelete(); break;
                    case "5":
                        Console.WriteLine("Çıkış yapılıyor...");
                        return;
                    default:
                        Console.WriteLine("Lütfen geçerli bir değer giriniz");
                        break;

                }

            }
        }

        static void AddOrder()
        {
            Console.WriteLine("Görev ekleyiniz");

            string girdi = Console.ReadLine();

            if (!string.IsNullOrEmpty(girdi))
            {
                string ord = girdi;
                Order order = new Order(ord);
                orders.Add(order);
                Console.WriteLine("Görev başarıyla eklendi");
            }
            else
            {
                Console.WriteLine("Lütfen string bir değer giriniz.");
            }

        }
        static void OrderList()
        {
            Console.WriteLine("----------");
            for (int i = 0; i < orders.Count(); i++)
            {
                Console.WriteLine((i + 1) + ". " + orders[i].Name + " Yapıldı mı ?" + (orders[i].isDone == false ? "Hayır" : "Evet"));
            }
        }
        static void OrderDone()
        {
            OrderList();
            Console.WriteLine("Lütfen tamamladığınız görevi seçiniz:");

            string girdi = Console.ReadLine();

            if (girdi != null && Convert.ToInt32(girdi) <= orders.Count())
            {
                int o = Convert.ToInt32(girdi);

                orders[o - 1].isDone = true;
            }
            else
            {
                Console.WriteLine("Lütfen doğru bir değer giriniz.");
            }

        }

        static void OrderDelete()
        {
            OrderList();
            Console.WriteLine("Lütfen silmek istediğiniz görevi seçiniz:");

            string girdi = Console.ReadLine();


            if (girdi != null && Convert.ToInt32(girdi) < orders.Count())
            {
                int o = Convert.ToInt32(girdi);

                orders.RemoveAt(o-1);
            }
            else
            {
                Console.WriteLine("Lütfen doğru bir değer giriniz.");
            }
        }

    }

    class Order
    {
        public Order(string name)
        {
            Name = name;
            isDone = false;
        }

        public string Name { get; set; }
        public bool isDone { get; set; }
    }
}