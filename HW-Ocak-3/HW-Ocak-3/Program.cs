// Ali Emre Pamuk
// HW-Ocak-3

Console.Write("Bir sayı girin: ");
int sayi = Convert.ToInt32(Console.ReadLine());

if (sayi % 2 == 0)
{
    Console.WriteLine("Girilen sayı çifttir.");
}
else
{
    Console.WriteLine("Girilen sayı tektir.");
}

if (sayi > 0)
{
    Console.WriteLine("Girilen sayı pozitiftir.");
}
else if (sayi < 0)
{
    Console.WriteLine("Girilen sayı negatiftir.");
}
else
{
    Console.WriteLine("Girilen sayı sıfırdır.");
}