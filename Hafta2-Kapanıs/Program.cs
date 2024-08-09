// 1 - Aşağıdaki çıktıyı yazan bir program.
Console.WriteLine("Merhaba");
Console.WriteLine("Nasılsın ?");
Console.WriteLine("İyiyim");
Console.WriteLine("Sen nasılsın ?");
Console.WriteLine();
// 2 - Bir adet metinsel, bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp, ekrana yazdırınız.
string metinsel = "Örnek Metin";
int tamSayi = 42;
Console.WriteLine(metinsel);
Console.WriteLine(tamSayi);
Console.WriteLine();
// 3 - Rastgele bir sayı üretip, ekrana yazdırınız.
Random rnd = new Random();
int rastgeleSayi = rnd.Next();
Console.WriteLine(rastgeleSayi);
Console.WriteLine();
// 4 - Rastgele bir sayı üretip, bunun 3'e bölümünden kalanı ekrana yazdırınız.
int rastgeleSayi2 = rnd.Next();
Console.WriteLine(rastgeleSayi2 % 3);
Console.WriteLine();
// 5 - Kullanıcıya yaşını sorup, 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
int yas;
Console.Write("Yaşınızı giriniz: ");
string giris = Console.ReadLine();

// Girilen değerin geçerli bir sayı olup olmadığını kontrol ediyoruz
if (int.TryParse(giris, out yas))
{
    if (yas > 18)
    {
        Console.WriteLine("+");
    }
    else
    {
        Console.WriteLine("-");
    }
}
else
{
    Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
}
Console.WriteLine();
// 6 - Ekrana 10 defa "Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem.");
}
Console.WriteLine();
// 7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel", "Demet Evgar", bunların yerlerini değiştiriniz.
Console.Write("İlk metni giriniz: ");
string metin1 = Console.ReadLine();
Console.Write("İkinci metni giriniz: ");
string metin2 = Console.ReadLine();

// Metinleri değiştiriyoruz
MetinDegistir(ref metin1, ref metin2);

Console.WriteLine("Birinci metin: " + metin1);
Console.WriteLine("İkinci metin: " + metin2);
static void MetinDegistir(ref string metin1, ref string metin2)
{
    string temp = metin1;
    metin1 = metin2;
    metin2 = temp;
}
Console.WriteLine();
// 8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma" yazsın.
void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma");
}
BenDegerDondurmem();
Console.WriteLine();
// 9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
Console.WriteLine("Lütfen birinci sayıyı giriniz:");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen ikinci sayıyı giriniz:");
int sayi2 = Convert.ToInt32(Console.ReadLine());
int Topla(int sayi1, int sayi2)
{
    return sayi1 + sayi2;
}
Console.WriteLine("Toplam: " + Topla(sayi1, sayi2));
Console.WriteLine();
// 10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
bool kullaniciDegeri;
while (true)
{
    Console.Write("True ya da False giriniz: ");
    string giris = Console.ReadLine().ToLower();

    if (giris == "true" || giris == "false")
    {
        kullaniciDegeri = bool.Parse(giris);
        break; // Geçerli bir giriş yapıldı, döngüden çık
    }
    else
    {
        Console.WriteLine("Lütfen geçerli bir değer (true veya false) giriniz.");
    }
}

Console.WriteLine(BooleanToString(kullaniciDegeri));
    

    static string BooleanToString(bool deger)
{
    return deger.ToString();
}
Console.WriteLine();
// 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
// Yaşları kullanıcıdan alıyoruz
Console.Write("Birinci kişinin yaşını giriniz: ");
int yas1 = int.Parse(Console.ReadLine());

Console.Write("İkinci kişinin yaşını giriniz: ");
int yas2 = int.Parse(Console.ReadLine());

Console.Write("Üçüncü kişinin yaşını giriniz: ");
int yas3 = int.Parse(Console.ReadLine());

// En yaşlı olan kişinin yaşını buluyoruz
int enYasliYas = EnYasliYas(yas1, yas2, yas3);

Console.WriteLine("En yaşlı olan kişinin yaşı: " + enYasliYas);

static int EnYasliYas(int yas1, int yas2, int yas3)
{
    int enYasli = yas1;

    if (yas2 > enYasli)
    {
        enYasli = yas2;
    }

    if (yas3 > enYasli)
    {
        enYasli = yas3;
    }

    return enYasli;
}
Console.WriteLine();
// 12 - Kullanıcıdan sınırsız sayıda sayı alıp, bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
int EnBuyukSayi()
{
    List<int> sayilar = new List<int>();
    string giris;
    do
    {
        Console.Write("Bir sayı giriniz (bitirmek için 'q'): ");
        giris = Console.ReadLine();
        if (giris != "q")
        {
            sayilar.Add(int.Parse(giris));
        }
    } while (giris != "q");

    return sayilar.Max();
}
Console.WriteLine("En büyük sayı: " + EnBuyukSayi());
Console.WriteLine();
// 13 - Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.

void IsimleriDegistir(ref string isim1, ref string isim2)
{
    string temp = isim1;
    isim1 = isim2;
    isim2 = temp;
}
Console.WriteLine("Lütfen birinci ismi yazın:");
string isimA = Console.ReadLine();
Console.WriteLine("Lütfen ikinci ismi yazın:");
string isimB = Console.ReadLine();
IsimleriDegistir(ref isimA, ref isimB);
Console.WriteLine("İsim A: " + isimA);
Console.WriteLine("İsim B: " + isimB);
Console.WriteLine();
// 14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
bool TekMiCiftMi(int sayi)
{
    return sayi % 2 == 0;
}
Console.WriteLine("Lütfen bir sayı girin:");
int sayi =Convert.ToInt32(Console.ReadLine());
Console.WriteLine(TekMiCiftMi(sayi));
Console.WriteLine();
// 15 - Kullanıcıdan alınan hız ve zaman bilgileriyle, gidilen yolu hesaplayan bir metot yazınız.
// Kullanıcıdan hız bilgisini alıyoruz
Console.Write("Lütfen hızınızı giriniz (km/saat): ");
double hiz = double.Parse(Console.ReadLine());

// Kullanıcıdan zaman bilgisini alıyoruz
Console.Write("Lütfen geçen zamanı giriniz (saat): ");
double zaman = double.Parse(Console.ReadLine());

// Gidilen yolu hesaplayan metodu çağırıyoruz
double gidilenYol = GidilenYol(hiz, zaman);

// Sonucu ekrana yazdırıyoruz
Console.WriteLine("Gidilen yol: " + gidilenYol + " km");
    static double GidilenYol(double hiz, double zaman)
{
    // Yol = Hız * Zaman formülüne göre gidilen yolu hesaplıyoruz
    return hiz * zaman;
}
Console.WriteLine();
// 16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
// Kullanıcıdan yarıçap bilgisini alıyoruz
Console.Write("Lütfen dairenin yarıçapını giriniz: ");
double yaricap = double.Parse(Console.ReadLine());

// Daire alanını hesaplayan metodu çağırıyoruz
double alan = DaireAlani(yaricap);

// Sonucu ekrana yazdırıyoruz
Console.WriteLine("Dairenin alanı: " + alan);


    static double DaireAlani(double yaricap)
{
    // Dairenin alanı = π * r^2 formülüne göre hesaplanır
    return Math.PI * yaricap * yaricap;
}
Console.WriteLine();
// 17 - "Zaman bir GeRi SayIm" cümlesini alıp, hepsi büyük harf ve hepsi küçük harfle yazdırınız.
string cumle = "Zaman bir GeRi SayIm";
Console.WriteLine(cumle.ToUpper());
Console.WriteLine(cumle.ToLower());
Console.WriteLine();
// 18 - "Selamlar" metnini bir değişkene atayıp, başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
string metin = "    Selamlar   ";
metin = metin.Trim();
Console.WriteLine("'" + metin + "'");
