// 1'den 10'a kadar olan sayıların küplerininin toplamını bulan uygulamayı yazınız
namespace BasicCapps3
{
    class program
    {
        static void Main(string[] args)
        {
            int sayac = 1;
            int toplamSonuc = 0;

            while (sayac <= 10)
            {
                int sonuc = Convert.ToInt32(Math.Pow(sayac, 3));
                sayac++;
                toplamSonuc += sonuc;
                Console.WriteLine("Sayı: " + (sayac - 1) + " Sonuç: " + sonuc);
            }
            Console.WriteLine("Toplam Sonuç: " + toplamSonuc);


        }

    }

}