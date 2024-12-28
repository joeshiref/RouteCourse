namespace Course_Assignment
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            #region "Q1"
            Console.WriteLine("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
            #endregion

            #region "Q2"
            string str = "213";
            int result = int.Parse(str);
            Console.WriteLine($"Converted value: {result}");
            // Program will throw an exception as the string is not in the correct format
            #endregion

            #region "Q3"
            double a = 10.3;
            double b = 3.5;
            Console.WriteLine($"Addition: {a + b}");
            #endregion

            #region "Q4"
            string original = "Hello World";
            string substr = original.Substring(3,5);
            Console.WriteLine(substr);
            #endregion

            #region "Q5"
            int originalValue = 10;
            int newValue = originalValue;
            newValue = 20;
            Console.WriteLine(originalValue);
            Console.WriteLine(newValue);
            #endregion

            #region "Q6"
            Person person1 = new Person();
            person1.Name = "Youssef";
            Person person2 = person1;
            person2.Name = "Sherif";
            Console.WriteLine($"person1's Name: {person1.Name}");
            Console.WriteLine($"person2's Name: {person2.Name}");
            #endregion

            #region "Q7"
            string s1 = "Hello";
            string s2 = "World";
            Console.WriteLine(s1+s2);
            #endregion

            #region "Q8"
            // A value 1 will be assigned to d.
            #endregion

            #region "Q9"
            // 6 1
            #endregion

            #region "Q10"
            // 7 7
            #endregion

        }
    }
}
