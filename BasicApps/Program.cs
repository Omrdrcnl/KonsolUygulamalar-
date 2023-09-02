namespace BasicApps
{
    class program
    {
        static double kara(double x, double y)
        {
            return x + y;
        }

        static void Main()
        {
            Console.WriteLine("Lütfen toplamak istediğiniz sayıları arasında birer boşluk olacak şekilde 2 sayı giriniz");

            string[] sayilar = Console.ReadLine().Split(" ");

            if (sayilar.Length != 2)
            {
                Console.WriteLine("Lütfen geçerli bir format giriniz");
            }
            else
            {

                double.TryParse(sayilar[0], out double sayi1);
                double.TryParse(sayilar[1], out double sayi2);

                double sonuc = kara(sayi1, sayi2);

                Console.WriteLine("sonuç: " + sonuc);
            }


        }
    }
}