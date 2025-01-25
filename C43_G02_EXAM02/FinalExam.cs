using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_EXAM02
{
    internal class FinalExam : Exam
    {
        public FinalExam(TimeSpan time, int numQuestions) : base(time, numQuestions) { }

        public override void ShowExam()
        {
            Console.WriteLine($"Final Exam ({Duration.TotalMinutes} minutes)");
            foreach (var q in Questions)
            {
                Console.WriteLine(q);
                Console.WriteLine("Answers:");
                foreach (var a in q.AnswerList)
                    Console.WriteLine($"- {a}");
            }
            Console.WriteLine($"\nTotal Grade: {Questions.Sum(q => q.Mark)}");
        }

        public override object Clone() => new FinalExam(Duration, NumberOfQuestions)
        {
            Questions = Questions.Select(q => (Question)q.Clone()).ToList()
        };
    }
}
