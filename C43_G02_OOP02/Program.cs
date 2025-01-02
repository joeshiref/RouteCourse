namespace C43_G02_OOP02
{
    public class HiringDate
    {
        private int _day;
        private int _month;
        private int _year;

        public int Day
        {
            get { return _day; }
            set
            {
                if (value >= 1 && value <= 31)
                    _day = value;
                else
                    throw new ArgumentOutOfRangeException("Day must be between 1 and 31.");
            }
        }

        public int Month
        {
            get { return _month; }
            set
            {
                if (value >= 1 && value <= 12)
                    _month = value;
                else
                    throw new ArgumentOutOfRangeException("Month must be between 1 and 12.");
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                if (value >= 1900 && value <= DateTime.Now.Year)
                    _year = value;
                else
                    throw new ArgumentOutOfRangeException($"Year must be between 1900 and {DateTime.Now.Year}.");
            }
        }

        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }

    }
    public enum SecurityPrivilege
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }
    public enum Gender
    {
        Male,
        Female
    }
    class Employee
    {
        public int Id { get; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public SecurityPrivilege SecurityLevel { get; set; }
        public HiringDate HireDate { get; }
        public Gender Gender { get; set; }
        public Employee(int id, string name, double salary, SecurityPrivilege securityLevel, HiringDate hireDate, Gender gender)
        {
            Id = id;
            Name = name;
            Salary = salary;
            SecurityLevel = securityLevel;
            HireDate = hireDate;
            Gender = gender;
        }
        public override string ToString()
        {
            return String.Format(
                "Employee Details:\n" +
                "ID: {0}\n" +
                "Name: {1}\n" +
                "Security Privilege: {2}\n" +
                "Salary: {3:C}\n" +
                "Hire Date: {4:dd/MM/yyyy}\n" + 
                "Gender: {5}",
                Id, Name, SecurityLevel, Salary, HireDate, Gender
            );
        }

    }
    internal class Program
    {
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        struct Person
        {
            public string Name;
            public int Age;
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public override string ToString() {
                return $"Name: {Name}, Age: {Age}";
            }
        }
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        static string GetMonthRange(Season season)
        {
            switch (season)
            {
                case Season.Spring:
                    return "March to May";
                case Season.Summer:
                    return "June to August";
                case Season.Autumn:
                    return "September to November";
                case Season.Winter:
                    return "December to February";
                default:
                    return "Unknown";
            }
        }

        enum Permission
        {
            None = 0,
            Read = 1,
            Write = 2,
            Delete = 4,
            Execute = 8
        }
        enum Colors
        {
            Red,
            Green,
            Blue
        }
        static bool IsPrimaryColor(Colors color)
        {
            return color == Colors.Red || color == Colors.Green || color == Colors.Blue;
        }
        struct Point
        {
            public double X;
            public double Y;
        }
        static void Main(string[] args)
        {
            #region Question 1
            // Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region Question 2
            // Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person[] people = new Person[3];
            //people[0] = new Person("Joe", 28);
            //people[1] = new Person("Ahmed", 30);
            //people[2] = new Person("Mona", 35);
            //foreach (Person person in people)
            //{
            //    Console.WriteLine(person);
            //}
            #endregion

            #region Question 3
            // Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.WriteLine("Enter a season:");
            //string input = Console.ReadLine();
            //if (Enum.TryParse(typeof(Season), input, true, out object result))
            //{
            //    Season season = (Season)result;
            //    string monthRange = GetMonthRange(season);
            //    Console.WriteLine($"The months for {season} are: {monthRange}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter one of the following: Spring, Summer, Autumn, Winter.");
            //}
            #endregion

            #region Question 4

            //Permission userPermissions = Permission.None;
            //// Add Write and Read permissions
            //userPermissions |= Permission.Read;
            //userPermissions |= Permission.Write;
            //Console.WriteLine($"Current Permissions: {userPermissions}"); // 0011

            //// Check if a specific permission exists
            //bool hasWritePermission = (userPermissions & Permission.Delete) == Permission.Delete;
            //Console.WriteLine($"Has Write Permission: {hasWritePermission}");

            //// Remove a permission
            //userPermissions &= ~Permission.Write;
            //Console.WriteLine($"Permissions after removing Write: {userPermissions}");

            #endregion

            #region Question 5
            // Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //Console.WriteLine("Enter a color:");
            //string input = Console.ReadLine();
            //if (Enum.TryParse(typeof(Colors), input, true, out object result))
            //{
            //    Colors color = (Colors)result;
            //    bool isPrimaryColor = IsPrimaryColor(color);
            //    Console.WriteLine($"{color} is a primary color: {isPrimaryColor}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter one of the following: Red, Green, Blue.");
            //}

            #endregion

            #region Question 6
            // Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            //Point point1 = new Point();
            //Point point2 = new Point();
            //Console.WriteLine("Enter the X coordinate of the first point:");
            //point1.X = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Y coordinate of the first point:");
            //point1.Y = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the X coordinate of the second point:");
            //point2.X = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Y coordinate of the second point:");
            //point2.Y = double.Parse(Console.ReadLine());
            //double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
            //Console.WriteLine($"The distance between the two points is: {distance}");

            #endregion

            #region Question 7
            // Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person[] persons = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:");

            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Age: ");
            //    int age;
            //    while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid age (non-negative integer):");
            //    }

            //    persons[i] = new Person { Name = name, Age = age };
            //}

            //Person oldestPerson = persons[0];
            //for (int i = 1; i < 3; i++)
            //{
            //    if (persons[i].Age > oldestPerson.Age)
            //    {
            //        oldestPerson = persons[i];
            //    }
            //}
            //Console.WriteLine($"The oldest person is: {oldestPerson}");
            #endregion

            #region Part #2

            //Employee[] EmpArr = new Employee[3];


            //EmpArr[0] = new Employee(
            //    id: 101,
            //    name: "Alice Smith",
            //    securityLevel: SecurityPrivilege.DBA,
            //    salary: 85000,
            //    hireDate: new HiringDate(4, 8, 2024),
            //    gender: Gender.Female
            //);

            //EmpArr[1] = new Employee(
            //    id: 102,
            //    name: "Bob Johnson",
            //    securityLevel: SecurityPrivilege.Developer,
            //    salary: 45000,
            //    hireDate: new HiringDate(1, 1, 2025),
            //    gender: Gender.Male
            //);

            //EmpArr[2] = new Employee(
            //    id: 103,
            //    name: "Charlie Brown",
            //    securityLevel: SecurityPrivilege.Secretary,
            //    salary: 95000,
            //    hireDate: new HiringDate(3, 5, 2021),
            //    gender: Gender.Male
            //);

            //foreach (var employee in EmpArr)
            //{
            //    Console.WriteLine(employee.ToString());
            //    Console.WriteLine(); 
            //}
            #endregion

        }
    }
}
