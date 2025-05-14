namespace whıle;
class Program
{
    static void Main(string[] args)

    {
        // Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

        int i = 0;
        while (i < 10)
        {
            Console.WriteLine("Ben bu yazılım işini halledicem kendime inanıyorum.");
            i++;
        }



        //1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

        int j = 1;
        while (j < 20)
        {
            Console.WriteLine($"{j}");
            j++;
        }

        //1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

        int c = 0;
        while (c < 20)
        {
            if (c % 2 == 0)
                Console.WriteLine($"{c}");
            c++;
        }

        //50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

        int sayı = 50;
        int toplam = 0;
        while (sayı < 150)
        {
            toplam += sayı;
            sayı++;
        }
        Console.WriteLine($"toplam: {toplam}");



        // 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

        int sayac = 1;

        int toplamCıft = 0;

        int toplamTek = 0;


        while (sayac <= 120)
        {
            if (sayac % 2 == 0) // ikiye bölümünden kalan 0 ise çift sayıdır
            {
                toplamCıft += sayac;
            }
            else
            {
                toplamTek += sayac;
            }
            sayac++;
        }
        Console.WriteLine($"Çift sayıların toplamı: {toplamCıft}");
        Console.WriteLine($"Tek sayıların toplamı: {toplamTek}");
    }
}
    


        





