using System.Xml.Linq;

namespace Assignment05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 19- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            //Console.WriteLine("Enter the num of matrix:");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(i == j ? "1" : "0");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 20- Write a program in C# Sharp to find the sum of all elements of the array.

            //int[] arr = { 10, 20, 30, 40, 50 };

            //int sum = 0;
            //foreach (int i in arr)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);


            #endregion

            #region 21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //int[] arr1 = { 1, 3, 5, 7 };
            //int[] arr2 = { 2, 4, 6, 8 };

            //int[] continAllarr = new int[arr1.Length + arr2.Length];

            //arr1.CopyTo(continAllarr, 0);
            //arr2.CopyTo(continAllarr, arr1.Length);
            //Array.Sort(continAllarr);

            //foreach (int arr in continAllarr)
            //{
            //    Console.WriteLine(arr);
            //}

            #endregion

            #region 22- Write a program in C# Sharp to count the frequency of each element of an array.


            #endregion

            #region 23- Write a program in C# Sharp to find maximum and minimum element in an array

            //int[] array = { 44, 45, 50, 67, 3, 4, 1 };

            //int max = array.Max();
            //int min = array.Min();

            //Console.WriteLine(max);
            //Console.WriteLine(min);

            #endregion

            #region 25-. Consider an Array of Integer values with size N, having values as in this Example.


            #endregion

            #region 26- Given a list of space separated words, reverse the order of the words.

            //Console.Write("Enter space separated words:");
            //string input = Console.ReadLine();

            #endregion

            #region 27- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            //Console.Write("Enter the num of rows:");
            //int row = int.Parse(Console.ReadLine());

            //Console.Write("Enter the num of columns:");
            //int colm = int.Parse(Console.ReadLine());

            //int[,] arr1 = new int[row, colm];
            //int[,] arr2 = new int[row, colm];


            //Console.WriteLine("Enter the first array:");
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < colm; j++)
            //    {
            //        Console.Write($"Enter value for element [{i}, {j}]: ");
            //        arr1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}


            //Array.Copy(arr1, arr2, arr1.Length);

            //Console.WriteLine("\nThe elements of the second array are:");
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < colm; j++)
            //    {
            //        Console.Write(arr2[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 28- Write a Program to Print One Dimensional Array in Reverse Order

            //Console.Write("Enter the size of array:");
            //int size = int.Parse(Console.ReadLine());

            //int[] array = new int[size];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //for (   int i = size -1; i >= 0; i--)
            //{
            //    Console.WriteLine(array[i]);
            //}


            #endregion

            #region 1- Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.


            //static void PassByValue(int x)
            //{
            //    x = x * 2;
            //    Console.WriteLine("PassByValue: " + x);
            //}

            //static void PassByReference(ref int x)
            //{
            //    x = x * 2;
            //    Console.WriteLine("PassByReference: " + x);
            //}

            //int x1 = 5;
            //Console.WriteLine("قبل PassByValue: " + x1);
            //PassByValue(x1);
            //Console.WriteLine("بعد PassByValue: " + x1); 

            //int y = 5;
            //Console.WriteLine("\nPassByReference: " + y);
            //PassByReference(ref y);
            //Console.WriteLine("PassByReference: " + y);
            //by value not changed but by refernce changed
            #endregion

            #region 2-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

            //static int SumOfInput(int num)
            //{
            //    int sum = 0;

            //    while (num != 0)
            //    {
            //        sum += num % 10;
            //        num /= 10;
            //    }

            //    return sum;
            //}
            //int num = int.Parse(Console.ReadLine());
            //int result = SumOfInput((num));
            //Console.WriteLine($"The sum of input {result}");
            #endregion

            #region 3- Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not .

            //static bool IsPrime(int num)
            //{


            //    for (int i = 2; i <= Math.Sqrt(num); i++)
            //    {
            //        if (num % i == 0)
            //            return false;
            //    }

            //return true;
            //}

            //Console.Write("Enter a num; ");
            //int num = int.Parse(Console.ReadLine());

            //bool result = IsPrime(num);

            //if (result)
            //    Console.WriteLine($"{num} is a prime");
            //else
            //    Console.WriteLine($"{num} is not a prime");


            #endregion

            #region 4- Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter .

            //static int Factorial(int num)
            //{

            //    int result = 1;

            //    for (int i = 1; i <= num; i++)
            //    {
            //        result *= i;
            //    }

            //    return result;
            //}

            //Console.Write("Enter a num:");
            //int num = int.Parse(Console.ReadLine());

            //int factorial = Factorial(num);

            //if (factorial != -1)
            //    Console.WriteLine($"The factorial ={factorial}");


            #endregion

            #region   5- Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter.

            //static string ChangeChar(string input, int position, char newChar)
            //{
            //    char[] charArray = input.ToCharArray();
            //    charArray[position] = newChar;
            //    return new string(charArray);
            //}
            //Console.Write("Enter the string: ");
            //string input = Console.ReadLine();

            //Console.Write("Enter the position of the character");
            //int p = int.Parse(Console.ReadLine());

            //Console.Write("Enter the new char: ");
            //char newChar = Console.ReadLine()[0];
            //string changes = ChangeChar(input, p, newChar);
            //Console.WriteLine($"Modified string: {changes}");
            #endregion
        }
    }
}
