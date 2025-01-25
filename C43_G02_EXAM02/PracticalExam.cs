using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_EXAM02
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(TimeSpan time, int numQuestions) : base(time, numQuestions) { }

        public override void ShowExam()
        {
            Console.WriteLine($"Practical Exam ({Duration.TotalMinutes} minutes)");
            foreach (var q in Questions)
            {
                Console.WriteLine(q);
                Console.WriteLine("Answers:");
                foreach (var a in q.AnswerList)
                    Console.WriteLine($"- {a}");
            }

            Console.WriteLine("\nCorrect Answers:");
            foreach (var q in Questions)
                Console.WriteLine($"{q.Header}: {q.RightAnswer}");
        }

        public override object Clone() => new PracticalExam(Duration, NumberOfQuestions)
        {
            Questions = Questions.Select(q => (Question)q.Clone()).ToList()
        };
    }
}
