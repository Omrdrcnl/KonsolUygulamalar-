// Bölme işleminin çıkarma işlemi yaparak yapan uygulama

namespace BasicApps7
{
	class program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("-----BÖLME İŞLEMİ------");

            Console.WriteLine("BÖLÜNECEK sayıyı giriniz");
			int.TryParse(Console.ReadLine(), out int sayi1);

            Console.WriteLine("BÖLEN sayıyı giriniz");
            int.TryParse(Console.ReadLine(), out int sayi2);

			int count = sayi1;
			int sonuc = 0;
			int kalan = 0;

			for (int i = 1; i <= count; i++)
			{
				if(sayi1 > sayi2)
				{
                    sayi1 -= sayi2;
                }
				else if(sayi1 == sayi2)
				{
					sonuc = i;
					break;
				}
				else
				{
                    kalan = sayi1;
                    sonuc = i;
                    break;
                }
			}

            Console.WriteLine("Kalan: " + kalan + " sonuç: " + sonuc);
        }
    }

}