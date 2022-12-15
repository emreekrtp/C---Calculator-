Console.WriteLine("Hoşgeldiniz İsminizi Öğerenebilir miyim ?");
string name = Console.ReadLine();
Console.WriteLine("Tekrar hoşgeldin " + name);


Console.Write("İLK SAYIYI GİRİNİZ : ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("İKİNCİ SAYIYI GİRİNİZ : ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n1. Toplama\n2.Çıkarma\n3.Çarpma\n4.Bölme");
Console.Write("İşleminizi seciniz : ");
int secenek =Convert.ToInt32(Console.ReadLine());



switch (secenek)
{
    case 1:
        Console.WriteLine("Toplama işleminin sonucu : " + (number1 + number2));
        break;
    case 2:
        Console.WriteLine("Çıkarma isleminin sonucu : " +(number1 - number2));
        break;
    case 3:
        Console.WriteLine("Çarpma işleminin sonucu : "+(number1 * number2));
        break;
    case 4:
        Console.WriteLine("Bölme işleminin sonucu : " + (number1 / number2));
        break;
    default:
        Console.WriteLine("GEÇERSİZ TUŞLAMA YAPTINIZ");
        break;
}

