using System.Linq.Expressions;

namespace Alan_Hesaplama;

class Program
{
    static void Main(string[] args)
    {
        Program.Giris();
        Console.ReadKey();
    }
    static double pi=3.14;
    public static void Giris()
    {
        Console.WriteLine("Lütfen işlem yapmak istediğiniz geometrik şekli seçiniz:");
        Console.WriteLine("Daire hesaplamaları için (1):");
        Console.WriteLine("Üçgen hesaplamaları için (2):");
        Console.WriteLine("Kare hesaplamaları için (3):");
        Console.WriteLine("Dikdörtgen hesaplamaları için (4):");
        int secim=int.Parse(Console.ReadLine());
        if (secim>4 || secim<1)
        {
            Console.WriteLine("Hatalı seçim yaptınız Lütfen tekrar deneyin");
            Giris();
        }
        else
        {
            switch (secim)
            {
                case 1:
                Daire();
                break;
                case 2:
                Ucgen();
                break;
                case 3:
                Kare();
                break;
                case 4:
                Dikdörtgen();
                break;
            }
        }
    }
    public static void Daire()
    {
        Console.Clear();
        Console.WriteLine("Lütfen dairenin yarıçapını giriniz");
        double yaricap=double.Parse(Console.ReadLine());
        Console.WriteLine("Dairenin Alanı: "+pi*yaricap*yaricap);
        Console.WriteLine("Dairenin Çevresi: "+pi*2*yaricap);

    }
    public static void Ucgen()
    {
        Console.Clear();
        Console.WriteLine("Lütfen Üçgenin taban uzunluğunu giriniz");
        double taban=double.Parse(Console.ReadLine());
        Console.WriteLine("Lütfen Üçgenin Yüksekliğini giriniz");
        double yukseklik=double.Parse(Console.ReadLine());
        Console.WriteLine("Üçgenin Çevresi : "+taban*3);
        Console.WriteLine("Üçgenin Alanı : "+(taban*yukseklik)/2);
    }
    public static void Kare()
    {
        Console.Clear();
        Console.WriteLine("Lütfen karenin kenar uzunluğunu giriniz");
        double kenar=double.Parse(Console.ReadLine());
        Console.WriteLine("Karenin Çevresi : "+kenar*4);
        Console.WriteLine("Karenin Alanı : "+kenar*kenar);
    }
    public static void Dikdörtgen()
    {
        Console.Clear();
        Console.WriteLine("Lütfen dikdörtgenin uzun kenar uzunluğunu giriniz");
        double Ukenar=double.Parse(Console.ReadLine());
        Console.WriteLine("Lütfen dikdörtgenin kısa kenar uzunluğunu giriniz");
        double Kkenar=double.Parse(Console.ReadLine());
        Console.WriteLine("Karenin Çevresi : "+(Ukenar*2)+(2*Kkenar));
        Console.WriteLine("Karenin Alanı : "+Ukenar*Kkenar);
    }
}
