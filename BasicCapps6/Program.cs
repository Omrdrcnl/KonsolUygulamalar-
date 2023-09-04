// Pozitif sayılarda çarpma işleminin toplama kullanarak bulan uygulama

using System.Xml.Serialization;


namespace BasicApps6
{
	class program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Lütfen birinci sayıyı giriniz");
			int.TryParse(Console.ReadLine(), out int sayi1);

            Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            int.TryParse(Console.ReadLine(), out int sayi2);

            int sonuc = 0;
            string _sonuc = "";

            for (int i = 1; i <= sayi2; i++)
            {
                sonuc += sayi1;
                _sonuc += $"{sayi1} + ";
                if (i == sayi2)
                {
                    _sonuc += $" ={sonuc} ";

                }
            }

            Console.WriteLine("Sonuç: "+ _sonuc);
        }

    }

}