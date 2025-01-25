using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_EXAM02
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public void CreateExam(Exam exam)
        {
            Exam = exam;
            Exam.NumberOfQuestions = exam.Questions.Count;
        }

        public object Clone() => new Subject
        {
            SubjectId = SubjectId,
            SubjectName = SubjectName,
            Exam = (Exam)Exam?.Clone()
        };

        public override string ToString() => $"{SubjectName} (ID: {SubjectId})";
    }
}
