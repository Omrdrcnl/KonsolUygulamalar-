using System.Collections.Immutable;

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

            //string[] sayilar = Console.ReadLine().Split(" ");

            //if (sayilar.Length != 2)
            //{
            //    Console.WriteLine("Lütfen geçerli bir format giriniz");
            //}
            //else
            //{

            //    double.TryParse(sayilar[0], out double sayi1);
            //    double.TryParse(sayilar[1], out double sayi2);

            //    double sonuc = kara(sayi1, sayi2);

            //    Console.WriteLine("sonuç: " + sonuc);
            //}
            Console.WriteLine("birinci sayıyız yaz");
            string x = Console.ReadLine();
            Console.WriteLine("ikinci sayıyı yaz");
            string y = Console.ReadLine();

            Console.WriteLine(Sum(x, y)); 
        }

        static string Sum(string x, string y)
        {
            
            if(x.Length > y.Length) 
            {

                int t = x.Length - y.Length;
                string ekle = "";
                for (int i = 0; i < t; i++)
                {
                    ekle += "0";
                }

                string yeni = ekle + y;

                string[] dizi = new string[x.Length + 1];
                int sonu = 0;
                int k = 0;

                for (int i = 0; i < x.Length; i++)
                {


                    sonu = x[x.Length - i - 1] + k + yeni[yeni.Length - i - 1] - 96;

                    if (k > 0 && (x.Length - i - 1) == 0 && ((x[0] + k) > 10))
                    {
                        dizi[i] = sonu.ToString();
                        break;
                    }

                    if (sonu >= 10)
                    {
                        k = sonu / 10;
                        sonu = sonu % 10;
                    }
                    else
                    {
                        k = 0;
                    }
                    dizi[i] = sonu.ToString();
                }
                Array.Reverse(dizi);

                string kar = string.Join("", dizi);
                return kar;
            }
            else
            {

                int t = y.Length - x.Length;
                string ekle = "";
                for (int i = 0; i < t; i++)
                {
                    ekle += "0";
                }

                string yeni = ekle + x;


                string[] dizi = new string[y.Length + 1];
                int sonu = 0;
                int k = 0;

                for (int i = 0; i < y.Length; i++)
                {
                    sonu = yeni[yeni.Length - i - 1] + k + y[y.Length - i - 1] - 96;

                    if (k > 0 && (yeni.Length - i - 1) == 0 && ((x[0] + k) > 10))
                    {
                        dizi[i] = sonu.ToString();
                        break;
                    }

                    if (sonu >= 10)
                    {
                        k = sonu / 10;
                        sonu = sonu % 10;
                    }
                    else
                    {
                        k = 0;
                    }
                    dizi[i] = sonu.ToString();
                }
                Array.Reverse(dizi);

                string kar = string.Join("", dizi);
                return kar;
            }
           
        }
    }
}