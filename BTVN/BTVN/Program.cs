using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 17, 19, 23, -3, -7, 50, 60, 100, 99, 101 };

        // 1. Tinh tong, trung binh, tong cac so nguyen to
        int sum = numbers.Sum();
        double average = numbers.Average();
        int primeSum = numbers.Where(IsPrime).Sum();
        Console.WriteLine($"Tong: {sum}, Trung binh: {average}, Tong cac so nguyen to: {primeSum}");

        // 2. Tim phan tu duong dau tien trong mang
        int? firstPositive = numbers.FirstOrDefault(x => x > 0);
        Console.WriteLine($"Phan tu duong dau tien: {firstPositive}");

        // 3. Tim phan tu duong nho nhat trong mang
        int? minPositive = numbers.Where(x => x > 0).Min();
        Console.WriteLine($"Phan tu duong nho nhat: {minPositive}");

        // 4. Dem so nguyen to trong mang
        int primeCount = numbers.Count(IsPrime);
        Console.WriteLine($"So luong so nguyen to: {primeCount}");

        // 5. Sap xep mang: chan tang dan, le giam dan
        var sorted = numbers
            .Where(x => x % 2 == 0).OrderBy(x => x)
            .Concat(numbers.Where(x => x % 2 != 0).OrderByDescending(x => x))
            .ToList();
        Console.WriteLine($"Mang sau sap xep: {string.Join(", ", sorted)}");

        // 6. Tim cac cap so co tong bang 100
        var pairs = numbers
            .SelectMany((x, i) => numbers.Skip(i + 1), (x, y) => new { x, y })
            .Where(pair => pair.x + pair.y == 100)
            .ToList();
        Console.WriteLine("Cac cap co tong bang 100:");
        foreach (var pair in pairs)
            Console.WriteLine($"({pair.x}, {pair.y})");

        // 7. Lay 3 so chan trong mang
        var evenNumbers = numbers.Where(x => x % 2 == 0).Take(3).ToList();
        Console.WriteLine($"3 so chan dau tien: {string.Join(", ", evenNumbers)}");

        // 8. Tim vi tri cua phan tu nho nhat trong mang
        int minElement = numbers.Min();
        int minIndex = numbers.IndexOf(minElement);
        Console.WriteLine($"Vi tri phan tu nho nhat: {minIndex}");

        // 9. Tim cac vi tri trong mang co gia tri nho nhat
        var minPositions = numbers.Select((value, index) => new { value, index })
                                  .Where(x => x.value == minElement)
                                  .Select(x => x.index)
                                  .ToList();
        Console.WriteLine($"Vi tri cac phan tu nho nhat: {string.Join(", ", minPositions)}");

        // 10. Tim GTLN cua bieu thuc P = 2 * i - 3 * j
        var maxP = numbers.SelectMany(i => numbers, (i, j) => 2 * i - 3 * j).Max();
        Console.WriteLine($"GTLN cua bieu thuc P = 2 * i - 3 * j: {maxP}");
    }

    // Ham kiem tra so nguyen to
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}
