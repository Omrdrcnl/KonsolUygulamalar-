// Girilen Sayının Faktöriyelini alma

namespace BasicCapps5
{
	class program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Faktöriyel hesaplama");
			Console.WriteLine("Lütfen sayı giriniz");
			int sayi = int.Parse(Console.ReadLine());


            int sonuc = 1;
			string _sonuc = "";

            if (sayi == 0)
			{
                Console.WriteLine("Sonuç: " + 1);
			}
			else
			{
                for (int i = 1; i <= sayi; i++)
                {

                    sonuc *= i;
					_sonuc += $"{i} x ";

					if(i == sayi)
					{
						_sonuc += $"{i} ={sonuc}" ;
					}
                }

                Console.WriteLine("Faktöriyel sonuç: " + _sonuc);
            }
            Console.WriteLine("---Fonksiyon Sonucu---");
            Console.WriteLine("Sonuç: "+ Faktoriyel(sayi));
            Console.ReadLine();
		}

		static int Faktoriyel(int i)
		{
			if (i > 1)
			{
				return i * Faktoriyel(--i);// Rekürsif(Kendi içinde fonksiyonu çağırmak) aynı işlemi tekrarlamak için kullandık
			}
			else if (i == 0)
			{
				return 1;
			}
			else return i;
		}

	}
}