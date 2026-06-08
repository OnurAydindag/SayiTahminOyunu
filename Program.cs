string cevap = "E";

while (cevap == "E")
{
    Random random = new Random();
    int tutulanSayi = random.Next(1, 101);
    int tahminSayisi = 0;

    int sayi = 0;

    while (sayi != tutulanSayi)
    {
        Console.Write("1 ile 100 arasında bir sayı giriniz: ");

        string girilenDeger = Console.ReadLine();

        bool sonuc = int.TryParse(girilenDeger, out sayi);

        if (!sonuc)
        {
            Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
            continue;
        }

        if (sayi < 1 || sayi > 100)
        {
            Console.WriteLine("Lütfen 1 ile 100 arasında bir sayı giriniz!");
            continue;
        }

        tahminSayisi++;

        if (sayi < tutulanSayi)
        {
            Console.WriteLine("Daha Büyük Bir Sayı Giriniz");
        }
        else if (sayi > tutulanSayi)
        {
            Console.WriteLine("Daha Küçük Bir Sayı Giriniz");
        }
    }

    Console.WriteLine("Tebrikler Bildiniz!");
    Console.WriteLine($"{tahminSayisi} tahminde bildiniz.");

    do
    {
        Console.Write("Tekrar oynamak ister misiniz? (E/H): ");
        cevap = Console.ReadLine().ToUpper();

        if (cevap != "E" && cevap != "H")
        {
            Console.WriteLine("Lütfen E veya H giriniz!");
        }

    } while (cevap != "E" && cevap != "H");
}

Console.WriteLine("Oyun kapatıldı.");