using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_EXAM02
{
    internal abstract class Exam : ICloneable
    {
        public TimeSpan Duration { get; set; }
        public int NumberOfQuestions { get; set; }

        public List<Question> Questions { get; set; } = new List<Question>();

        public Exam(TimeSpan duration, int numberOfQuestions)
        {
            Duration = duration;
            NumberOfQuestions = numberOfQuestions;
        }

        public abstract void ShowExam();

        public abstract object Clone();

    }
}
