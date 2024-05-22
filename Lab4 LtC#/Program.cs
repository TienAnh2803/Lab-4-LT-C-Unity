using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Tạo danh sách các số nguyên
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Sử dụng FindAll để lọc các số chẵn
        List<int> evenNumbers = numbers.FindAll(n => n % 2 == 0);

        // Sử dụng foreach để xuất ra từng item trong danh sách mới sau khi lọc
        foreach (int number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }
}