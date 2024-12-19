namespace C43_G02_C_04
{
    internal class Program
    {
        static void solve(int n)
        {
            if (n == 0)
            {
                return;
            }
            solve(n / 2);
            Console.Write(n % 2);
        }
        static void Main(string[] args)
        {
            #region Q13
            //Console.WriteLine("Enter a String");
            //string input = Console.ReadLine();
            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(input[i]);
            //}
            #endregion

            #region Q14
            //Console.WriteLine("Enter an Integer");
            //int num = int.Parse(Console.ReadLine());
            //while(num!=0)
            //{
            //    Console.Write(num % 10);
            //    num = num / 10;
            //}
            #endregion

            #region Q15
            //Console.WriteLine("Input starting number of range: ");
            //string? startInput = Console.ReadLine();
            //if (int.TryParse(startInput, out int start))
            //{
            //    Console.WriteLine("Input ending number of range: ");
            //    string? endInput = Console.ReadLine();
            //    if (int.TryParse(endInput, out int end))
            //    {
            //        for (int i = start; i < end; i++)
            //        {
            //            int num = i;
            //            bool prime = true;
            //            for (int j = 2; j < num; j++)
            //            {
            //                if (num % j == 0)
            //                {
            //                    prime = false;
            //                    break;
            //                }
            //            }
            //            if (prime && i!=1)
            //            {
            //                Console.Write(num + " ");
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid ending number.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid starting number.");
            //}
            #endregion

            #region Q16
            // I am not sure if this question should be solved without strings too or not.
            // I'll try a recursive approach

            //Console.WriteLine("Enter a number");
            //int num = int.Parse(Console.ReadLine());
            //solve(num);
            #endregion

            #region Q17
            //double x1, y1, x2, y2, x3, y3;
            //Console.WriteLine("Enter the coordinates of the first point:");
            //x1 = double.Parse(Console.ReadLine());
            //y1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the coordinates of the second point:");
            //x2 = double.Parse(Console.ReadLine());
            //y2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the coordinates of the third point:");
            //x3 = double.Parse(Console.ReadLine());
            //y3 = double.Parse(Console.ReadLine());
            //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //{
            //    Console.WriteLine("The three points are on the same line");
            //}
            //else
            //{
            //    Console.WriteLine("The three points are not on the same line");
            //}
            #endregion

            #region Q18
            //Console.Write("Enter the time taken by the worker to complete the task (in hours): ");
            //double timeTaken = double.Parse(Console.ReadLine());
            //if (timeTaken >= 2 && timeTaken <= 3)
            //{
            //    Console.WriteLine("The worker is highly efficient.");
            //}
            //else if (timeTaken > 3 && timeTaken <= 4)
            //{
            //    Console.WriteLine("The worker is instructed to increase their speed.");
            //}
            //else if (timeTaken > 4 && timeTaken <= 5)
            //{
            //    Console.WriteLine("The worker is provided with training to enhance their speed.");
            //}
            //else if (timeTaken > 5)
            //{
            //    Console.WriteLine("The worker is required to leave the company.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. The time taken must be greater than or equal to 0.");
            //}
            #endregion
        }
    }
}