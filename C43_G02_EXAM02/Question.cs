namespace C43_G02_EXAM02
{
    public abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }

        public decimal Mark {  get; set; }

        public List<Answer> AnswerList { get; set; }
        public Answer RightAnswer { get; set; }

        protected Question(string header, string body, decimal mark, List<Answer> answers, Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answers;
            RightAnswer = rightAnswer;
        }
        public abstract object Clone();
        public int CompareTo(Question other) => Mark.CompareTo(other?.Mark);
        public override string ToString() => $"{Header}\n{Body}\nMarks: {Mark}";
    }
}