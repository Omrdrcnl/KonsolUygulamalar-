
// REF Keywordü (Referans, OOP Kavramıdır. Stack'da int, bool vb. Heap'de object, string vb.
// Stacka dogrudan erişebiliriz ancak Heap'e ulasmak için referans kullanmamız gerekir.
// 
// )

namespace CappsEducation2
{
    class program
    {
        /*
		 * Referans türlerini eşitlersek referansın işaret ettiği objeyi değiştirdiğimizde eşitlenen iki değer birden değişecektir.
		 * Ve aynı objeyi referans etmeye devam edeceklerdir.
		 * Ref heap'daki nesneye erişebilmek için kullandığımız yapıdır. = operatörü ile birbirleryle iletişime geçerler.
		 *	Yani, referanslar da eşittir operatörü ile herhangi bir verisel veya nesnesel türeme söz konusu olmamakta 
			işaretlenmiş nesne diğer referans tarafından işaretlenmektedir.
		 *
         */

        // Değer türlü değişkenleri birbirlerine atarsak buna  Deep Copy denir. Stack'da işlem görürler.
        // = asign olarak kullanılır veri sadece klonlarnır. Referans olarak eşitlenmezler
        // ref keywordü kullanırsak referans olarak eşitlemiş oluruz böylelikle değer türlü değişkenin referansını kullanırız
        // Ref keywordü, değer türlü değişkenlerin referans türlü değişkenler gibi çalışmasını sağlayan bir komuttur.( Shallow Copy )

        static void Main(string[] args)
        {
            int a = 4;

            ref int b = ref a;  // buradaki "=" operatörü asiggn değildir. Artık referanslarını eşitledik. a değiştiğinde b'de değişir.
            Console.WriteLine(a);
            Console.WriteLine(b);

            a *= 5;
            Console.WriteLine(b);

            b = 15;
            Console.WriteLine(a);

        }
        /*
		 * Ref Returns özelliği sadece metotlarda geçerlidir.
		 * 
		 */
        static int a = 5;
        static int b = X(ref a);

        static ref int X(ref int y)
        {
            y = 25;
            return ref y;
        }
    }
}