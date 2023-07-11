using System;
using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }
            return MyArray;
        }

        int sum(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                sum = sum + item;
            }
            return sum;
        }

        try
        {
            MaxLengthAttribute = Int32.Parse(Console.ReadLine());
        }
        catch(FormatException)
        {
            isValid = false;
            Console.WriteLine("Invalid Input!!");
        }
        if (isValid && (length < 5 || length > 15))
        {
            Console.WriteLine("Integer number must be between 5 and 15.");
        }
        isValid = true;

        while (!isValid || (length < 5 || length > 15)) ;

        int[] sampleArray = random_array(input);

        Console.WriteLine("The elements in the random array are: ");
        foreach (int sample in sampleArray)
        {
            string element = null;
            Console.WriteLine(element + "");
        }
        Console.WriteLine(" ");
        Console.WriteLine("The sum is: " + sum(sampleArray));
    }
}