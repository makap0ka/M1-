
using System;

namespace _04_ArrayTasks
{
    internal class Program
    {
        static void PrintArray(string text, int[] arr)
        {
            Console.Write(text + ": ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }

        static void PrintMatrix(string text, double[,] matrix)
        {
            Console.WriteLine(text);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],8:F2} ");
                }

                Console.WriteLine();
            }
        }

        static void Task1()
        {
            Console.WriteLine();
            Console.WriteLine("TASK 1");

            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine()!);

            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine()!);
            }

            PrintArray("Original array", arr);

            int evenCount = 0;
            int oddCount = 0;
            int uniqueCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }

                int count = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    uniqueCount++;
                }
            }

            Console.WriteLine($"Even elements: {evenCount}");
            Console.WriteLine($"Odd elements: {oddCount}");
            Console.WriteLine($"Unique elements: {uniqueCount}");
        }

        static void Task2()
        {
            Console.WriteLine();
            Console.WriteLine("TASK 2");

            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine()!);

            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine()!);
            }

            PrintArray("Original array", arr);

            Console.Write("Enter the comparison value: ");
            int number = int.Parse(Console.ReadLine()!);

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < number)
                {
                    count++;
                }
            }

            Console.WriteLine($"Elements less than {number}: {count}");
        }

        static void Task3()
        {
            Console.WriteLine();
            Console.WriteLine("TASK 3");

            int[] A = new int[5];
            double[,] B = new double[3, 4];

            Random random = new Random();

            Console.WriteLine("Enter 5 elements for array A:");

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"A[{i}] = ");
                A[i] = int.Parse(Console.ReadLine()!);
            }

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = Math.Round(
                        random.Next(100) + random.NextDouble(), 2);
                }
            }

            PrintArray("Array A", A);
            PrintMatrix("Matrix B", B);

            double max = A[0];
            double min = A[0];
            double sum = 0;
            double product = 1;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }

                if (A[i] < min)
                {
                    min = A[i];
                }

                sum += A[i];
                product *= A[i];
            }

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j] > max)
                    {
                        max = B[i, j];
                    }

                    if (B[i, j] < min)
                    {
                        min = B[i, j];
                    }

                    sum += B[i, j];
                    product *= B[i, j];
                }
            }

            int evenSum = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    evenSum += A[i];
                }
            }

            double oddColumnsSum = 0;

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (j % 2 == 0)
                    {
                        oddColumnsSum += B[i, j];
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Maximum element: {max:F2}");
            Console.WriteLine($"Minimum element: {min:F2}");
            Console.WriteLine($"Total sum: {sum:F2}");
            Console.WriteLine($"Total product: {product:F2}");
            Console.WriteLine($"Sum of even elements in A: {evenSum}");
            Console.WriteLine($"Sum of odd-numbered columns in B: {oddColumnsSum:F2}");
        }

        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine();
                Console.WriteLine("==============================");
                Console.WriteLine("          ARRAY MENU");
                Console.WriteLine("1. Even, odd and unique elements");
                Console.WriteLine("2. Elements less than a number");
                Console.WriteLine("3. Array A and matrix B");
                Console.WriteLine("0. Exit");
                Console.WriteLine("==============================");
                Console.Write("Your choice: ");

                choice = int.Parse(Console.ReadLine()!);

                switch (choice)
                {
                    case 1:
                        Task1();
                        break;

                    case 2:
                        Task2();
                        break;

                    case 3:
                        Task3();
                        break;

                    case 0:
                        Console.WriteLine("Program finished");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 0);
        }
    }
}
