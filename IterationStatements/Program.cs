using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        //Write a method that will print to the console all numbers 1000 through - 1000
        static void ListNum(int x, int y)
        {
            for (int i = x; i <= y; i++)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        static void By3(int x, int y)
        {
            for (int i = x; i <= y; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        static void Equal(int x, int y)
        {
            if (x == y) Console.WriteLine($"{x} and {y} are equal");
            if (x != y) Console.WriteLine($"{x} and {y} are not equal");
        }

        //Write a method to check whether a given number is even or odd
        static void OddorEven(int x)
        {
            if (x % 2 == 0) Console.WriteLine("Even");
            if (x % 2 == 1) Console.WriteLine("Odd");
        }

        //Write a method to check whether a given number is positive or negative
        static void PosorNeg(int x)
        {
            if (x > 0) Console.WriteLine("postive");
            if (x < 0) Console.WriteLine("negative");
            if (x == 0) Console.WriteLine("Zero is not positive or negative");
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        static void Vote(int x)
        {
            if (x >= 18) Console.WriteLine("You can vote");
            if (x < 18) Console.WriteLine("You can not vote yet");
        }

        //Write a method to check if an integer(from the user) is in the range -10 to 10
        static void RangeCheck(int x, int y, int z)
        {
            if (x <= z && y >= z) Console.WriteLine($"{z} is between {x} and {y}");
            else Console.WriteLine($"{z} is not between {x} and {y}");
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        static void MultTable(int x, int y, int z)
        {
            for (int i = x; i <= y; i++)
            {
                int newz = z * i;
                Console.WriteLine($"{z} * {i} = {newz} ");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //ListNum();
            Console.WriteLine("Enter what range of numbers you would like typed out");
            int start = Convert.ToInt32(Console.ReadLine());
            int end = Convert.ToInt32(Console.ReadLine());
            ListNum(start, end);
            //By3(3, 999);
            Console.WriteLine("Enter what range of numbers you would like typed out incremented by 3");
            start = Convert.ToInt32(Console.ReadLine());
            end = Convert.ToInt32(Console.ReadLine());
            By3(start, end);
            //Equal(1, 1);
            Console.WriteLine("Enter two numbers to see if they are equal");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Equal(num1, num2);
            //OddorEven (111);
            Console.WriteLine("Enter a number to find out if its odd or even");
            num1 = Convert.ToInt32(Console.ReadLine());
            OddorEven(num1);
            //PosorNeg(0);
            Console.WriteLine("Enter a number to find out if its negative or positive");
            num1 = Convert.ToInt32(Console.ReadLine());
            PosorNeg(num1);
            //Vote(17);
            Console.WriteLine("Enter your age to find out if you can vote");
            int age = Convert.ToInt32(Console.ReadLine());
            Vote(age);
            //RangeCheck(-1000, 1000, 300);
            Console.WriteLine("Enter two numbers then enter a third number to find out if its inbetween the first two numbers");
            start = Convert.ToInt32(Console.ReadLine());
            end = Convert.ToInt32(Console.ReadLine());
            num1 = Convert.ToInt32(Console.ReadLine());
            RangeCheck(start, end, num1);
            //MultTable(1, 10, 5);
            Console.WriteLine("Enter a number then a range of numbers to be multiplied by the first number.");
            num1 = Convert.ToInt32(Console.ReadLine());
            start = Convert.ToInt32(Console.ReadLine());
            end = Convert.ToInt32(Console.ReadLine());
            MultTable(start, end, num1);
        }
    }
}
