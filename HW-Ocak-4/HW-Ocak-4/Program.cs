// Ali Emre Pamuk
// HW-Ocak-4

Console.WriteLine("1'den 10'a kadar sayılar: ");
for(int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

Console.Write("\nBir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());
int toplam = 0;


for(int i = 1; i <= sayi; i++)
{
    toplam += i;
}
Console.WriteLine("1'den " + sayi + " kadar olan sayıların toplamı: " + toplam);