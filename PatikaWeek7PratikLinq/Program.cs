
//Sayıların tutulacağı lsite tanımlaması
var numbers = new List<int>();
//Rastgele üretilecek sayıların tanımlaması
Random random = new Random();
for (int i = 0; i < 10; i++)
{
    int randomNumber = random.Next(-10, 20);
    numbers.Add(randomNumber);// Üretilen sayıların listeye eklenmesi

}

Console.WriteLine("-------------RASTGELE ÜRETİLEN SAYILAR-------------------");


foreach (int number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("-------------ÇİFT SAYILAR-------------------");

var evenNumbers = numbers.Where(x => x % 2 == 0);// Çift sayıların seçilip ekrana yazdırılması

foreach (int number in evenNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("-------------TEK SAYILAR-------------------");

var oddNumbers = numbers.Where(x => x % 2 != 0);// Tek sayıların seçilip ekrana yazdırılması


foreach (int number in oddNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("-------------NEGATİF SAYILAR-------------------");


var negativeNumber = numbers.Where(x => x < 0);// Negatif sayıların seçilip ekrana yazdırılması


foreach (int number in negativeNumber)
{
    Console.WriteLine(number);
}

Console.WriteLine("-------------POZİTİF SAYILAR-------------------");

var positiveNumber = numbers.Where(x => x > 0);// Pozitif sayıların seçilip ekrana yazdırılması


foreach (int number in positiveNumber)
{
    Console.WriteLine(number);
}

Console.WriteLine("-------------15'TEN BÜYÜK 22'DEN KÜÇÜK SAYILAR-------------------");

var rangeNumbers = numbers.Where(x => x > 15 & x < 22);// 15'ten büyük 22'den küçük sayıların seçilip ekrana yazdırılması


foreach (int number in rangeNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("-------------SAYILARIN KARESİ-------------------");

List<int> squarednumbers = numbers.Select(x => x * x).ToList();//Rastgele üretilen sayıların karesinin ekleneceği liste tanımlaması ve sayılarının karesinin alınması

foreach (int number in squarednumbers)
{
    Console.WriteLine(number);
}
