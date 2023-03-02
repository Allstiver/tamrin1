using System;

class Program
{
    static void Main(string[] args)
    {
       
        int[,] array = new int[10, 10];
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                array[i, j] = random.Next(1, 101);
            }
        }

      
        Console.WriteLine("arr:");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

       
        Console.Write("num1 ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("num2 ");
        int num2 = int.Parse(Console.ReadLine());

    
        Console.WriteLine("soton hayi ke add mojode : ");
        for (int j = 0; j < 10; j++)
        {
            bool foundNum1 = false;
            bool foundNum2 = false;
            for (int i = 0; i < 10; i++)
            {
                if (array[i, j] == num1)
                {
                    foundNum1 = true;
                }
                if (array[i, j] == num2)
                {
                    foundNum2 = true;
                }
            }
            if (foundNum1 && foundNum2)
            {
                Console.WriteLine(j);
            }
        }

       
        Console.ReadLine();
    }
}