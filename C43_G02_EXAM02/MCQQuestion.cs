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
        : base(header, body, mark, answers, rightAnswer) { }

        public override object Clone() => new MCQQuestion(
            Header,
            Body,
            Mark,
            AnswerList.Select(a => (Answer)a.Clone()).ToList(),
            (Answer)RightAnswer.Clone()
        );
    }
}
