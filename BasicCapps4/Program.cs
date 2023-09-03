// Kullanıcının dogum tarihini isteyeceğiz yaşını hesaplayacağız

using System.Threading.Channels;

namespace BasicCapps4
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Dogum tarihinizi giriniz");

            DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
            int yas = Convert.ToInt32(DateTime.Now.Year - dateTime.Year);

            DateTime today = DateTime.Now;
            if (dateTime > today.AddYears(-yas))
            {
                yas--;
            }

            Console.WriteLine("Yaşınız: " + yas);
            Console.WriteLine("---------");
            Console.WriteLine("Diğer yöntem");
            TimeSpan date = DateTime.Now - dateTime;


            Console.WriteLine("Yaşınız: " + date.Days / 365);


        }
    }
}
