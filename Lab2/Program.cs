using Lab2;
using System;
using System.Linq;
using System.Xml.Linq;
using System.IO;

//EXERCICE 1
/*class Program
{
    static void Main()
    {
        int[] numbers = { 1, 5, 3, 6, 11, 2, 15, 21, 13, 12, 10 };

        var outputNumbers = from num in numbers
                            where num > 5
                            orderby num
                            select num;

        foreach (int num in outputNumbers)
        {
            Console.WriteLine(num.ToString());
        }

        Console.ReadLine();
    }
}*/

//EXERCICE 2
/*class Program
{
    static void Main()
    {
        int[] numbers = { 1, 5, 3, 6, 11, 2, 15, 21, 13, 12, 10 };

        var outputNumbers = numbers.Where(n => n > 5).OrderByDescending(n => n);

        foreach (int num in outputNumbers)
        {
            Console.WriteLine(num);
        }

        Console.ReadLine();
    }
}*/

//EXERCICE 3
/*class Program
{
    static void Main()
    {
        FileInfo[] files = new DirectoryInfo(@"c:\windows").GetFiles();

        var query = from item in files
                    where item.Length > 10000
                    orderby item.Length descending, item.Name
                    select new MyFileInfo
                    {
                        Name = item.Name,
                        Length = item.Length,
                        CreationTime = item.CreationTime,
                    };
        Console.WriteLine("{0,-40}{1,6} MB {2}", "FileName", "Size", "Creation Date");

        foreach (MyFileInfo item in query)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }
}*/

//EXERCICE 4
/*class Program
{
    static void Main()
    {
        var files = new DirectoryInfo(@"c:\windows").GetFiles();

        var query = from item in files
                    where item.Length > 10000
                    orderby item.Length descending, item.Name
                    select new
                    {
                        Name = item.Name,
                        Length = item.Length,
                        CreationTime = item.CreationTime,
                    };
        Console.WriteLine("FileName\t\tSize\t\tCreation Date");

        foreach (var item in query)
        {
            Console.WriteLine("{0} \t\t{1} bytes,\t{2}", item.Name, item.Length, item.CreationTime);
        }

        Console.ReadLine();
    }
}*/

//EXERCICE 5
class Program
{
    static void Main()
    {
        var files = new DirectoryInfo(@"c:\windows").GetFiles();

        var query = files.Where(f => f.Length > 10000)
            .OrderBy(files => files.Length).ThenBy(f => f.Name)
            .Select(f =>new {Name = f.Name, Length = f.Length,CreationTime = f.CreationTime });
        
        Console.WriteLine("FileName\t\tSize\t\tCreation Date");

        foreach (var item in query)
        {
            Console.WriteLine("{0} \t\t{1} bytes,\t{2}", item.Name, item.Length, item.CreationTime);
        }

        Console.ReadLine();
    }
}