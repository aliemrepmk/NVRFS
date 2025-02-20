using System;
using System.Linq;

// .Net & React Full Stack Ödevi
// Ali Emre Pamuk

// Q1
Console.WriteLine("1.Soru");
Console.Write("Bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());

if(sayi == 0)
{
    Console.WriteLine("Girilen sayı sıfır.");
}
else if(sayi > 0)
{
    Console.WriteLine("Girilen sayı pozitif.");
}
else
{
    Console.WriteLine("Girilen sayı negatif.");
}
Console.WriteLine();

// Q2
Console.WriteLine("2.Soru");
Console.Write("Haftanın kaçıncı günü? ");
int gun = Convert.ToInt32(Console.ReadLine());

switch(gun)
{
    case 1:
        Console.WriteLine("Pazartesi");
        break;
    case 2:
        Console.WriteLine("Salı");
        break;
    case 3:
        Console.WriteLine("Çarşamba");
        break;
    case 4:
        Console.WriteLine("Perşembe");
        break;
    case 5:
        Console.WriteLine("Cuma");
        break;
    case 6:
        Console.WriteLine("Cumartesi");
        break;
    case 7:
        Console.WriteLine("Pazar");
        break;
    default:
        Console.WriteLine("Geçersiz gün girdiniz.");
        break;
}
Console.WriteLine();

// Q3
Console.WriteLine("3.Soru");
Console.Write("Yapmak istediğiniz işlemi giriniz (+, -, *, /): ");
String islem = Convert.ToString(Console.ReadLine());

Console.Write("İlk sayıyı giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci sayıyı giriniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

switch(islem)
{
    case "+":
        Console.WriteLine(sayi1 + " + " + sayi2 + " = " + (sayi1 + sayi2));
        break;

    case "-":
        Console.WriteLine(sayi1 + " - " + sayi2 + " = " + (sayi1 - sayi2));
        break;

    case "*":
        Console.WriteLine(sayi1 + " * " + sayi2 + " = " + (sayi1 * sayi2));
        break;

    case "/":
        if(sayi2 != 0)
        {
            Console.WriteLine(sayi1 + " / " + sayi2 + " = " + (sayi1 / sayi2));
            break;
        }
        else
        {
            Console.WriteLine("Hatalı işlem!"); // 0 ile bölme işlemi durumu
            break;
        }
        
    default:
        Console.WriteLine("Geçersiz işlem girdiniz.");
        break;
}
Console.WriteLine();

// Q4
Console.WriteLine("4.Soru");
Console.Write("İlk sayıyı giriniz: ");
int s1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci sayıyı giriniz: ");
int s2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Üçüncü sayıyı giriniz: ");
int s3 = Convert.ToInt32(Console.ReadLine());

int buyuk;
if(s1 >= s2)
{
    buyuk = s1;
}
else
{
    buyuk = s2;
}

if(s3 >= buyuk)
{
    Console.WriteLine("Girilen üç sayı arasından en büyük olan: " + s3);
}
else
{
    Console.WriteLine("Girilen üç sayı arasından en büyük olan: " + buyuk);
}
Console.WriteLine();

// Q5
Console.WriteLine("5.Soru");
Console.Write("Şifrenizi giriniz: ");
String sifre = Convert.ToString(Console.ReadLine());
char[] kontrolEdilecekKarakterler = {'@', '#', '$', '%', '!', '&', '*'};

if ((sifre.Length >= 8) && (sifre.Any(kontrolEdilecekKarakterler.Contains) && (sifre.Any(char.IsUpper))))
{
    Console.WriteLine("Şifreniz güçlüdür.");
}
else
{
    Console.WriteLine("Şifreniz güçlü değildir.");
}
Console.WriteLine();