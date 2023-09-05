// Local fonksiyonlar-- C# 7 ile birlikte gelmiştir.

//
namespace CappEducation
{
    class CappEducation
    {
        static void Main(string[] args)
        {
            x();
        }
        //Local fonksiyonlar yalnızca tanımlandıgı method içerisinden erişilebilir.
        // Üst fonksiyonla aynı isimde tanımlanırsa içerisinde ki fonksiyon dısardakini ezecektir.
        public static void x()
        {
            void y()
            {
                Console.WriteLine("X fonksiyonu içerisinde ki Y fonksiyonu tetiklendi.");
            }

            y();
        }
        //İleri seviyede Anonim, Delegate, Func gibi yapılar local fuunction yerine kullanılıyor.

    }
}
