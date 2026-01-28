using Lab2;
using System;
using System.Linq;
using System.Xml.Linq;
using System.IO;

//EXERCISE 1
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

//EXERCISE 2
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

//EXERCISE 3
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

//EXERCISE 4
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

//EXERCISE 5
/*class Program
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
}*/

//EXERCISE 6
/*class Program
{
    public static int DoubleIt(int value)
    {
        Console.WriteLine("About to double Number " + value.ToString());
        return value * 2;
    }

    static void Main(string[] args)
    {
        int[] numbers = { 1, 5, 3, 6, 10, 12, 8 };

        //var query = from number in numbers
        //            select DoubleIt(number);

        var query = numbers.Select(n => DoubleIt(n));

        //var query2 = from n in numbers
        //             select(DoubleIt(n));

        Console.WriteLine("Before the foreach loop");

        foreach(var item in query)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }
}*/

//EXERCISE 7
/*class Program
{
    public static int DoubleIt(int value)
    {
        Console.WriteLine("About to double Number " + value.ToString());
        return value * 2;
    }

    static void Main(string[] args)
    {
        int[] numbers = { 1, 5, 3, 6, 10, 12, 8 };

        var query1 = from number in numbers
                     orderby number descending
                     select number;

        var query2 = from number in query1
                     where number < 8
                     select number;

        var query3 = from number in query2
                     select DoubleIt(number);

        foreach (var item in query3)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }
}*/

//EXERCISE 8 9 and 10
/*class Program
{
    static void Main(string[] args)
    {
        string[] n = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John"};

        //Alphabetical order
        var query1 = from name in n
                     orderby name descending
                     select name;

        //Name longer than four letters
        var query2 = from name in n
                     where name.Length > 4
                     select name;
        //Only begins with M
        var query3 = from name in n
                     where name[0] == 'M'
                     select name;

        Console.WriteLine("Exercise 8 :");
        foreach (var item in query2)
        {
            Console.WriteLine("\t" + item);
        }

        Console.WriteLine("\nExercise 9 :");
        foreach (var item in query1)
        {
            Console.WriteLine("\t" + item);
        }

        Console.WriteLine("\nExercise 10 :");
        foreach (var item in query3)
        {
            Console.WriteLine("\t" + item);
        }

        Console.ReadLine();
    }
}
*/

//Exercise 11 and 12
class Program
{
    public class Customer
    {
        public string Name;
        public string City;
    }

    private static List<Customer> GetCustomers()
    {
        Customer c1 = new Customer { Name = "Tom", City = "Dublin" };
        Customer c2 = new Customer { Name = "Sally", City = "Galway" };
        Customer c3 = new Customer { Name = "George", City = "Cork" };
        Customer c4 = new Customer { Name = "Molly", City = "Dublin" };
        Customer c5 = new Customer { Name = "Joe", City = "Galway" };
        List<Customer> customers = new List<Customer>();
        customers.Add(c1);
        customers.Add(c2);
        customers.Add(c3);
        customers.Add(c4);
        customers.Add(c5);
        return customers;
    }
    static void Main(string[] args)
    {
        //Customers from Dublin
        var query1 = from customer in GetCustomers()
                     where customer.City == "Dublin"
                     select customer;

        //Ordering Customers by City and by Name
        var query2 = from customer in GetCustomers()
                     orderby customer.City, customer.Name descending
                     select customer;

        Console.WriteLine("Exercise 10 :");
        foreach (var item in query1)
        {
            Console.WriteLine("\tName : " + item.Name + "\tCity: " + item.City);
        }

        Console.WriteLine("\nExercise 11 :");
        foreach (var item in query2)
        {
            Console.WriteLine("\tName : " + item.Name + "\tCity: " + item.City);
        }

        Console.ReadLine();
    }
}
