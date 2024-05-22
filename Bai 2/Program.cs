using System;
using System.Collections.Generic;
using System.Linq;

class userData
{
    public string Name { get; set; }
    public int Level { get; set; }
}

class Program
{
    static void Main()
    {
        // Tạo danh sách các đối tượng user
        List<userData> users = new List<userData>
        {
            new userData { Name = "GTA 5", Level = 10 },
            new userData { Name = "Genshin impact", Level = 15 },
            new userData { Name = "Gunny", Level = 5 },
            new userData { Name = "Lien minh huyen thoai", Level = 100 },
            new userData { Name = "Eve", Level = 1 }
        };

        // a/ Xuất thông tin “Name” và “level” của danh sách “userData” (dùng phương thức Select)
        var userInfo = users.Select(user => new { user.Name, user.Level });
        Console.WriteLine("User Info:");
        foreach (var info in userInfo)
        {
            Console.WriteLine($"Name: {info.Name}, Level: {info.Level}");
        }

        // b/ Xắp xếp lại danh sách “userData” theo thứ tự giảm dần “level” (dùng phương thức OrderByDescending)
        var sortedUsers = users.OrderByDescending(user => user.Level);
        Console.WriteLine("\nSorted Users by Level (Descending):");
        foreach (var user in sortedUsers)
        {
            Console.WriteLine($"Name: {user.Name}, Level: {user.Level}");
        }
    }
}