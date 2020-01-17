using System;
public class SumOrProductTwoNumbers
{
    public static int totalSum(int num1, int num2)
    {
        int total;
        total = num1 + num2;
        return total;
    }
    
    public static int totalProduct(int num1, int num2)
    {
        int product;
        product = num1 * num2;
        return product;
    }

    public static void Main()
    {
        Console.WriteLine("This program will give the sum (addition) and product (multiplication) of two numbers.");

        Console.WriteLine("\nEnter a number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nEnter another number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nThe sum of the two numbers is: {0}", totalSum(n1, n2));
        Console.WriteLine("\nThe product of the two numbers is: {0}", totalProduct(n1, n2));
    }
}
