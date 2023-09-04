// Girelen sayının kaç basamaklı olduğunu döndür
namespace BasicCApps8
{
	class program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("---------Basamak Uygulaması---------");
            Console.WriteLine("Lütfen sayıyı giriniz");
			string bas = Console.ReadLine();

			Console.WriteLine("Basmak sayısı: "+ bas.Length);
        }
	}
}
