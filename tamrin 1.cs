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

   
        int searchNumber1 = 15;
        int searchNumber2 = 27;
        bool found1 = false;
        bool found2 = false;
        int column1 = -1;
        int column2 = -1;
        for (int j = 0; j < 10; j++)
        {
            for (int i = 0; i < 10; i++)
            {
                if (array[i, j] == searchNumber1)
                {
                    found1 = true;
                    column1 = j;
                }
                if (array[i, j] == searchNumber2)
                {
                    found2 = true;
                    column2 = j;
                }
            }
        }

 
        if (found1 && found2)
        {
            Console.WriteLine("num" + searchNumber1 + " soton" + (column1 + 1) );
            Console.WriteLine("num" + searchNumber2 + " soton " + (column2 + 1)  );
        }
        else if (found1 && !found2)
        {
            Console.WriteLine("num" + searchNumber1 + " soton" + (column1 + 1) + " but " + searchNumber2 + " not found ! ");
        }
        else if (!found1 && found2)
        {
            Console.WriteLine("num" + searchNumber2 + " soton" + (column2 + 1) + " but" + searchNumber1  " 