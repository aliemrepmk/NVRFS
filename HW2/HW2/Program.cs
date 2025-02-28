// Q1
Console.Write("1.SORU\nBir sayı giriniz: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberString = number.ToString();
int sum = 0;

for(int i = 0; i < numberString.Length; i++)
{
    sum += int.Parse(numberString[i].ToString());
}
Console.WriteLine("Girilen sayının rakamları toplamı: " + sum);

// Q2
Console.Write("\n2.SORU\n10 ile 100 arasında bir sayı giriniz: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

while(secondNumber < 10 || secondNumber > 100)
{
    Console.Write("Geçersiz değer girdiniz. Tekrar giriniz: ");
    secondNumber = Convert.ToInt32(Console.ReadLine());
}

if(secondNumber >= 10 && secondNumber <= 100)
{
    Console.WriteLine("Girdiğiniz sayı geçerlidir: " + secondNumber);
}

// Q3
Console.Write("\n3.SORU\n");
List<int> ages = new List<int> { 0, 10, 17, 21, 36, 44, 50, 65, 72, 88, 93, 105 };
foreach(int age in ages)
{
    string ageCategory = "";
    if (age >= 0 && age <= 12)
    {
        ageCategory = "Çocuk";
    }
    else if (age >= 13 && age <= 19)
    {
        ageCategory = "Genç";
    }
    else if (age >= 20 && age <= 64)
    {
        ageCategory = "Yetişkin";
    }
    else if (age >= 65)
    {
        ageCategory = "Yaşlı";
    }

    Console.WriteLine(age + " -> " + ageCategory);
}

// Q4
Console.Write("\n4.SORU\n");
int[] repeatedNumbers = { 0, 1, 2, 3, 1, 4, 5, 6, 6, 8, 9, 5, 9 };
Console.Write("Dizi: ");
Console.Write(string.Join(", ", repeatedNumbers));

Console.Write("\nTekrar eden elemanlar: ");
for (int i = 0; i < repeatedNumbers.Length; i++)
{
    for (int j = i + 1; j < repeatedNumbers.Length; j++)
    {
        if (repeatedNumbers[i] == repeatedNumbers[j])
        {
            Console.Write(repeatedNumbers[i] + " ");
            break;
        }
    }
}

// Q5
Console.Write("\n\n5.SORU\n");
string[] words = {"Ali", "Emre", "Pamuk", "Acunmedya", "eğitim"};
string longWord = words[0];
string shortWord = words[0];
Console.Write("Kelimeler: ");

foreach(string word in words)
{
    Console.Write(word + " ");

    if(word.Length > longWord.Length)
    {
        longWord = word;
    }

    if(word.Length < shortWord.Length)
    {
        shortWord = word;
    }
}
Console.WriteLine("\nEn uzun kelime: " + longWord);
Console.WriteLine("En kısa kelime: " + shortWord);

// Q6
Console.Write("\n6.SORU\nBir cümle giriniz: ");
string sentence = Console.ReadLine();
string[] sentenceWords = sentence.Split(new char[] { ' ', '.', ',', ';', '!' });

for(int i = 0; i < sentenceWords.Length - 1; i++)
{
    for(int k = 0; k < sentenceWords.Length - 1 - i; k++)
    {
        if (string.Compare(sentenceWords[k], sentenceWords[k + 1]) > 0)
        {
            string temp = sentenceWords[k];
            sentenceWords[k] = sentenceWords[k + 1];
            sentenceWords[k + 1] = temp;
        }
    }
}

Console.WriteLine("Girilen cümle: " + sentence);
Console.Write("Alfabetik olarak sıralama: ");
foreach(string word in sentenceWords)
{
    Console.Write(word + " ");
}

// Q7
Console.Write("\n\n7.SORU\n");
string[] fruits = { "Elma", "Portakal", "Armut" };
Console.Write("Başlangıç dizisi: ");
foreach(string fruit in fruits)
{
    Console.Write(fruit + " ");
}
Console.Write(", Başlangıç dizi boyutu: " + fruits.Length);
Console.Write("\nDiziye eklenecek elemanı yazın: ");
string newFruit = Console.ReadLine();

int newArraySize = fruits.Length + 1; 
string[] newFruits = new string[newArraySize];
Array.Copy(fruits, newFruits, fruits.Length);
newFruits[newArraySize - 1] = newFruit;

Console.Write("Yeni dizi: ");
foreach (string fruit in newFruits)
{
    Console.Write(fruit + " ");
}
Console.Write(", yeni dizi boyutu: " + newFruits.Length);

// Q8
Console.Write("\n\n8.SORU\n");
List<string> userWords = new List<string>();
string input;
int counter = 1;

while (true)
{
    Console.Write(counter + ". kelimeyi giriniz (Çıkış yazarak çıkın): ");
    input = Console.ReadLine();

    if(input.ToLower() == "çıkış")
    {
        break;
    }

    userWords.Add(input);
    counter++;
}

Console.Write("\nGirilen kelimeler tersten: ");
for(int i = userWords.Count - 1; i >= 0; i--)
{
    Console.Write(userWords[i] + " ");
}

// Q9
Console.Write("\n\n9.SORU\n");
List<int> numbers = new List<int>();
string userInput;
counter = 1;

while (true)
{
    Console.Write(counter + ". sayıyı giriniz (Çıkış yazarak çıkın): ");
    userInput = Console.ReadLine();

    if(userInput.ToLower() == "çıkış")
    {
        break;
    } else
    {
        numbers.Add(int.Parse(userInput));
    }

    counter++;
}

if(numbers.Count > 0)
{
    double avg = numbers.Average();
    numbers.Sort();

    Console.Write("Girilen sayılar (Küçükten büyüğe sıralanmış): ");
    Console.Write(string.Join(",", numbers));

    Console.Write("\nGirilen sayıların ortalaması: " + avg);
} else
{
    Console.Write("Hiç sayı girilmedi");
}

// Q10
Console.Write("\n\n10.SORU\n");
List<int> numberList = new List<int> { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25 };
Console.Write("Başlangıç liste elemanları: ");
Console.Write(string.Join(",", numberList));

numberList.RemoveAll(sayi => sayi < 10);
Console.Write("\n10'dan küçük elemanlar silindikten sonra liste elemanları: ");
Console.Write(string.Join(",", numberList));

// Q11
Console.Write("\n\n11.SORU\n");
List<int> grades = new List<int> { 13, 22, 35, 46, 50, 57, 68, 72, 84, 96, 100 };
Console.Write("Başlangıç notları: ");
Console.Write(string.Join(",", grades));

for(int i = 0; i < grades.Count; i++)
{
    if (grades[i] < 50)
    {
        grades[i] = 50;
    }
}

Console.Write("\nGüncellenmiş notlar: ");
Console.Write(string.Join(",", grades));