using System;
class Program
{
    static void Main(string[] args)
    {
        FruitPriceList list = new FruitPriceList(5);

        list.Add("사과", 1500);
        list.Add("바나나", 3000);
        list.Add("딸기", 8000);

        Console.WriteLine($"등록된 과일 수: {list.Count}개\n");

        Console.WriteLine($"사과 가격: {list["사과"]}원");
        Console.WriteLine($"바나나 가격: {list["바나나"]}원");
        Console.WriteLine($"포도 가격: {list["포도"]}원\n");

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine($"{i}번: {list[i]}");
        }
    }
}