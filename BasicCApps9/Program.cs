// Girilen 3 basamaklı bir sayının basamaklarının küpleri toplamı kendisine eşit mi?
namespace BasicCApps9
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------- Uygulaması-------");
            Console.WriteLine("3 basamaklı sayıyı giriniz");
            string say = Console.ReadLine();
            int.TryParse(say, out int result);

            int bir = result / 100;
            int iki = (result/10)%10;
            int uc = result%10;

            if (bir != 0 && say.Length == 3)
            {
             

                double value = Math.Pow(uc, 3) + Math.Pow(iki,3) + Math.Pow(bir, 3);
                if (value == result)
                {
                    Console.WriteLine("Doğru: Bu sayı gereklilikleri karşılamaktadır.");
                }
                else
                {
                    Console.WriteLine("Yanlış: Bu sayı gereklilikleri karşılamamaktadır!");
                }
            }
            else
            {
                Console.WriteLine("Lütfen 3 basamaklı bir sayı giriniz.");
            }


        }
    }
}