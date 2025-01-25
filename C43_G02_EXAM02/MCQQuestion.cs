using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_EXAM02
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, decimal mark, List<Answer> answers, Answer rightAnswer)
        : base(header, body, mark, answers, rightAnswer)
        {
            //if (answers.Count < 2)
            //    throw new ArgumentException("MCQ must have at least 2 answers");

            //if (!answers.Contains(rightAnswer))
            //    throw new ArgumentException("Right answer must be in answer list");
        }

        public override object Clone() => new MCQQuestion(
            Header,
            Body,
            Mark,
            AnswerList.Select(a => (Answer)a.Clone()).ToList(),
            (Answer)RightAnswer.Clone()
        );
    }
}
