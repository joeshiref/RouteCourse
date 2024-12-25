using System;

namespace C43_G02_C_06
{
    internal class Program
    {
        static void ModifyObjectByValue(Person person)
        {
            person.Name = "Modified by Value";

            person = new Person { Name = "New Object by Value" };
        }
        static void ModifyObjectByReference(ref Person person)
        {
            person.Name = "Modified by Reference";

            person = new Person { Name = "New Object by Reference" };
        }

        static void Calculate(int num1, int num2, out int sum, out int difference)
        {
            sum = num1 + num2;
            difference = num1 - num2;
        }
        static void MinMaxArray(int[] array, ref int min, ref int max)
        {
            min = array[0];
            max = array[0];

            foreach (int number in array)
            {
                if (number < min)
                    min = number;

                if (number > max)
                    max = number;
            }
        }
        static void Main(string[] args)
        {
            #region Q1
            // When a reference type is passed by value, the method receives a copy of the reference to the object. Changes made to the object's properties or fields inside the method will affect the original object because both the original reference and the copied reference point to the same object in memory. However, if you reassign the reference itself (assign a new object to it), this change will not affect the original reference.
            // When a reference type is passed by reference (using the ref or out keyword), the method works directly with the original reference. Reassigning the reference inside the method will also change the original reference outside the method.


            //Person person = new Person { Name = "Original" };

            //Console.WriteLine($"Before ModifyObjectByValue: {person.Name}");
            //ModifyObjectByValue(person);
            //Console.WriteLine($"After ModifyObjectByValue: {person.Name}");

            //Console.WriteLine($"Before ModifyObjectByReference: {person.Name}");
            //ModifyObjectByReference(ref person);
            //Console.WriteLine($"After ModifyObjectByReference: {person.Name}");

            #endregion

            #region Q2
            // Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //Console.WriteLine("Enter the first number:");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second number:");
            //int num2 = int.Parse(Console.ReadLine());

            //Calculate(num1, num2, out int sum, out int difference);
            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Difference: {difference}");

            #endregion

            #region Q3
            // Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //Console.WriteLine("Enter the size of the array: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] numbers = new int[n];
            //for(int i = 0; i < n; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //int min = 0;
            //int max = 0;
            //MinMaxArray(numbers, ref min, ref max);
            //Console.WriteLine($"Minimum value: {min}");
            //Console.WriteLine($"Maximum value: {max}");
            #endregion
        }
    }
}
class Person
{
    public string Name { get; set; }
}