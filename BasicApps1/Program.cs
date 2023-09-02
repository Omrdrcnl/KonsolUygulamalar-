
//Base class yapısı ve virtiual methodun ezilmesine örnek
public class baseClass
{
    public virtual void adalar()
    {
        Console.WriteLine("Adalar güzeldir");
    }

    public void adafunction()
    {
        adalar();
        Console.WriteLine("*------------*");
    }
   
}

public class yeniClass: baseClass
{
    public override void adalar()
    {
        base.adalar();
        Console.WriteLine("Adalar ayrıca sıcaktırda");
    }

    public void adafunction()
    {
        adalar();
    }
}

class program
{
    static void Main(string[] Args)
    {
        baseClass baseClass = new baseClass();
        baseClass.adafunction();

        yeniClass yeniClass = new yeniClass();
        yeniClass.adafunction();
        Console.ReadLine();
    }
}