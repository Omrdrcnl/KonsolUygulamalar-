// Out Keywordü

// Output parametre barındıran bir metodu kullanırken , out parmetrelerden gelecek olan degerleri karsılayacak değişkenler tanımlamalıdır.

using System.Data;

class program
{



    int _b = 0;
    string _c = "";// veya atamadan direkt de çagırabiliyoruz yeni versiyonlarla

    int a = X(5, out int _b, out string _c);

    static int X(int a, out int b, out string c)
    {
        b = 28;
        c = "ali";
        return 0;
    }
}