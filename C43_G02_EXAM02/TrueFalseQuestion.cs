using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_EXAM02
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, decimal mark, Answer rightAnswer)
        : base(header, body, mark, new List<Answer>
        {
            new Answer(1, "True"),
            new Answer(2, "False")
        }, rightAnswer)
        {
            if (rightAnswer.AnswerId > 2)
                throw new ArgumentException("Invalid answer for True/False question");
        }

        public override object Clone() => new TrueFalseQuestion(Header, Body, Mark, (Answer)RightAnswer.Clone());
    }
}
