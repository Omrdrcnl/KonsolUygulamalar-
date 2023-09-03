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

			int[] sayilar = new int[sayi];
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

			Console.ReadLine();
		}
	}
}