namespace C43_G02_EXAM02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject
            {
                SubjectId = 2,
                SubjectName = "C# Programming"
            };

            var practicalExam = new PracticalExam(TimeSpan.FromMinutes(60), 2)
            {
                Questions = new List<Question>
            {
                new MCQQuestion(
                    "MCQ-P1",
                    "Which keyword is used to define a class in C#?",
                    2,
                    new List<Answer>
                    {
                        new Answer(1, "class"),
                        new Answer(2, "struct"),
                        new Answer(3, "interface"),
                        new Answer(4, "enum")
                    },
                    new Answer(1, "class")
                ),
                new MCQQuestion(
                    "MCQ-P2",
                    "Which type of exception would you get for dividing by zero?",
                    3,
                    new List<Answer>
                    {
                        new Answer(1, "NullReferenceException"),
                        new Answer(2, "IndexOutOfRangeException"),
                        new Answer(3, "DivideByZeroException"),
                        new Answer(4, "InvalidCastException")
                    },
                    new Answer(3, "DivideByZeroException")
                )
            }
            };

            subject.CreateExam(practicalExam);

            Console.WriteLine("Subject: " + subject);
            Console.WriteLine("Practical Exam Details:");
            subject.Exam.ShowExam();

        }
    }
}
