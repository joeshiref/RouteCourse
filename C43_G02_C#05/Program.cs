namespace C43_G02_C_05
{
    internal class Program
    {

        static int SumDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += (n % 10);
                n /= 10;
            }
            return sum;
        }
        static bool IsPrime(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        static string ChangeChar(string str, int pos, char c)
        {
            char[] arr = str.ToCharArray();
            arr[pos] = c;
            return new string(arr);
        }

        static void Main(string[] args)
        {
            #region Q19
            // Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            //Console.Write("Enter the size of the identity matrix: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //        Console.Write(i == j ? "1 " : "0 ");
            //    Console.WriteLine();
            //}
            #endregion

            #region Q20
            // Write a program in C# Sharp to find the sum of all elements of the array.

            //Console.Write("Enter the size of the array: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}
            //Console.WriteLine("The sum of all elements of the array is: " + sum);
            #endregion

            #region Q21
            // Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //Console.WriteLine("Enter the size of the arrays: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[n];
            //int[] arr2 = new int[n];
            //int[] arr3 = new int[n * 2];
            //Console.WriteLine("Enter the elements of the first array: ");
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Enter the elements of the second array: ");
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    arr2[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(arr1);
            //Array.Sort(arr2);
            //int j = 0, k = 0;
            //for(int i =0; i< arr3.Length;i++)
            //{
            //    if (j < arr1.Length && k < arr2.Length)
            //    {
            //        if (arr1[j] < arr2[k])
            //        {
            //            arr3[i] = arr1[j];
            //            j++;
            //        }
            //        else
            //        {
            //            arr3[i] = arr2[k];
            //            k++;
            //        }
            //    }
            //    else if (j < arr1.Length)
            //    {
            //        arr3[i] = arr1[j];
            //        j++;
            //    }
            //    else
            //    {
            //        arr3[i] = arr2[k];
            //        k++;
            //    }
            //}
            //Console.WriteLine("The merged array is: ");
            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    Console.Write(arr3[i] + " ");
            //}
            #endregion

            #region Q22
            // Write a program in C# Sharp to count the frequency of each element of an array.

            //Console.WriteLine("Enter the size of the array: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //Console.WriteLine("Enter the elements of the array: ");
            //int mxSize = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //    mxSize = Math.Max(mxSize, arr[i]);
            //}
            //int[] freq = new int[mxSize + 1];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    freq[arr[i]]++;
            //}
            //for (int i = 0; i < freq.Length; i++)
            //{
            //    if (freq[i] != 0)
            //    {
            //        Console.WriteLine("The frequency of " + i + " is: " + freq[i]);
            //    }
            //}
            #endregion

            #region Q23
            // Write a program in C# Sharp to find maximum and minimum element in an array

            //Console.WriteLine("Enter the size of the array: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //Console.WriteLine("Enter the elements of the array: ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int max = arr[0], min = arr[0];
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    max = Math.Max(max, arr[i]);
            //    min = Math.Min(min, arr[i]);
            //}
            //Console.WriteLine("The maximum element in the array is: " + max);
            //Console.WriteLine("The minimum element in the array is: " + min);
            #endregion

            #region Q24
            // Write a program in C# Sharp to find the second largest element in an array.

            //Console.WriteLine("Enter the size of the array: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //Console.WriteLine("Enter the elements of the array: ");
            //int firstMax = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //    firstMax = Math.Max(firstMax, arr[i]);
            //}
            //int secondMax = int.MinValue;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] != firstMax)
            //    {
            //        secondMax = Math.Max(secondMax, arr[i]);
            //    }
            //}
            #endregion

            #region Q25

            //Console.WriteLine("Enter the size of the array: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //Console.WriteLine("Enter the elements of the array: ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int maxDistance = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            maxDistance = Math.Max(maxDistance, j - i - 1);
            //        }
            //    }
            //}
            //Console.WriteLine("The longest distance between two equal cells is: " + maxDistance);
            #endregion

            #region Q26
            // Given a list of space separated words, reverse the order of the words.

            //Console.WriteLine("Enter the list of space separated words: ");
            //string[] words = Console.ReadLine().Split(' ');
            //for (int i = words.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(words[i] + " ");
            //}
            #endregion

            #region Q27
            // Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            //Console.WriteLine("Enter the size of the arrays: ");
            //int n = int.Parse(Console.ReadLine());
            //int[,] arr1 = new int[n, n];
            //int[,] arr2 = new int[n, n];
            //Console.WriteLine("Enter the elements of the first array: ");
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        arr1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        arr2[i, j] = arr1[i, j];
            //    }
            //}
            //Console.WriteLine("The second array is: ");
            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        Console.Write(arr2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q28
            //  Write a Program to Print One Dimensional Array in Reverse Order

            //Console.WriteLine("Enter the size of the array: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //Console.WriteLine("Enter the elements of the array: ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            #endregion

            #region Functions Q1
            // Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            // Passing by value: When a value type parameter is passed by value, a copy of the variable's value is passed to the function. Whatever changes is made to this parameter inside the function, doesn't affect the original variable.
            // Passing by reference: When a value type parameter is passed by reference, the address of the variable is passed to the function. Whatever changes is made to this parameter inside the function, affects the original variable.

            #endregion

            #region Functions Q2
            // Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

            //Console.WriteLine("Enter a number: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("The sum of the digits of the number is: " + SumDigits(n));
            #endregion

            #region Functions Q3
            // Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not .

            //Console.WriteLine("Enter a number: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(IsPrime(n) ? "The number is prime" : "The number is not prime");
            #endregion

            #region Functions Q4
            // Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter .

            //Console.WriteLine("Enter a number: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("The factorial of the number is: " + Factorial(n));
            #endregion

            #region Functions Q5
            // Create a function named "ChangeChar" to modify a letter in a       certain position (0 based) of a string, replacing it with a different letter .

            //Console.WriteLine("Enter a string: ");
            //string str = Console.ReadLine();
            //Console.WriteLine("Enter the position of the character you want to change (zero based): ");
            //int pos = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the character you want to replace it with: ");
            //char c = char.Parse(Console.ReadLine());
            //Console.WriteLine("The new string is: " + ChangeChar(str, pos, c));
            #endregion
        }
    }
}
