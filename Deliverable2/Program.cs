using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter an integer number between 5 and 15:");
            int length = int.Parse(Console.ReadLine());

            if (length >= 5 && length <= 15)
            {
                int[] array = Method1(length);

                Console.WriteLine("Array elements:");
                foreach (int element in array)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();

                int sum = Method2(array);
                Console.WriteLine("Sum of array elements: " + sum);
            }
            else
            {
                Console.WriteLine("Invalid input. The number must be between 5 and 15.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer number.");
        }

        Console.ReadLine();
    }

    static int[] Method1(int length)
    {
        Random random = new Random();
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(10, 51);
        }

        return array;
    }

    static int Method2(int[] array)
    {
        int sum = 0;

        foreach (int element in array)
        {
            sum += element;
        }

        return sum;
    }
}
