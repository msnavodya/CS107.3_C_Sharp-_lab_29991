using System;

 
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(" Question 6 \n");

        Console.Write("Enter a Name : ");
        String name = Console.ReadLine();
        String Grade = "";

        Console.Write("Enter Marks : ");
        int marks = int.Parse(Console.ReadLine());

        if (marks > 100)
        {
            Console.WriteLine("Wrong MArks !");
        }
        else if (marks >= 75)
        {
            Grade = "A";
        }
        else if (marks >= 65)
        {
            Grade = "B";
        }
        else if (marks >= 55)
        {
            Grade = "C";
        }
        else if (marks >= 45)
        {
            Grade = "D";
        }
        else
        {
            Console.WriteLine("Faild");
        }
        Console.WriteLine(name + " Your Grade is " + Grade);

        Console.ReadLine();
    }
}