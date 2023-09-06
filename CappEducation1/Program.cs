// Overloading

using System.Security.Cryptography;

namespace CappsEducation1
{
    class program
    {
        static void Main(string[] args)
        {
            Matematik matematik = new Matematik();

            Console.WriteLine("1. topla fonk: " +matematik.topla());
            Console.WriteLine("2. topla fonk: " +matematik.topla(4,6));
            Console.WriteLine("3. topla fonk: " +matematik.topla(4,6,9));
        }
        /* Normal şartlarda bir sınıfın içinde birden fazla aynı isimde method bulunamaz
		 * Tanımlanmışsa eğer o methoda overloading yapılmış demektir.
		 * Ancak overload olması için Method imzaları farklı olmalıdır
		 * Methodlar arasında ki imza farkı olustrurken erişim belirleyici ve geri dönüş değeri aktif rol oynamaz
		 * parametre sayıları ve türleri farklı olmalıdır.
		 * 
		 */
        class Matematik
        {
            public int topla()
            {
                Random random = new Random();
                int x = (int)(random.Next(0, 9));
                int y = (int)(random.Next(0, 9));
                return x + y;
            }

            public int topla(int x, int y)
            {
                return x + y;
            }

            public int topla(int x, int y, int z)
            {
                return x + y + z;
            }

        }
    }
}