using System;

namespace Magic_Cube
{
    class MagicCube
    {
        static void Main(string[] args)
        {
            bool flag = true;

            int[,] arr = new int[3, 3];

            Random random = new Random();


            for (int i = 0; i < 3; i++)
             {
                 for (int j = 0; j < 3; j++)
                 {
                    Console.Write($"Write the {j+1} number on the {i+1} row: ");
                     arr[i, j] = int.Parse(Console.ReadLine());
                 }
              }
            Console.WriteLine("This is your cube");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                  
                    Console.Write(arr[i, j] + "  ");
                }
                Console.WriteLine();
            }

            int checkWith = arr[0, 0] + arr[0, 1] + arr[0, 2];

            for (int i = 0; i < 3; i++)
            {
                int sum= 0;
                for (int j = 0; j < 3; j++)
                {
                    sum += arr[i, j];
                }
                if (sum != checkWith)
                {
                    flag = false;
                    break;
                }
            }
            for (int j = 0; j < 3; j++)
            {
                int secondSum = 0;
                for (int i = 0; i < 3; i++)
                {
                    secondSum= arr[i, j] + secondSum;
                }
                if (secondSum != checkWith)
                {
                    flag = false;
                    break;

                }
            }
            if (flag)
            {
                Console.WriteLine("The cube is magical. See you!");
            }
            else
            {
                Console.WriteLine("Sadly, the cube is not magical. See you!");
            }
        }
    }
}
