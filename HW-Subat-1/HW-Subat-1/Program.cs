// Ali Emre Pamuk
// HW-Şubat-1

int[] dizi = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write("Dizinin " + (i + 1) + ". elemanını girin: ");
    dizi[i] = Convert.ToInt32(Console.ReadLine());
}

int enBuyuk = dizi[0];

Console.WriteLine("\nGirilen dizinin elemanları:");
foreach (int eleman in dizi)
{
    if (eleman > enBuyuk)
    {
        enBuyuk = eleman;
    }
    Console.WriteLine(eleman);
}
Console.WriteLine("\nDizinin en büyük elemanı: " + enBuyuk);