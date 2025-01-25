namespace C43_G02_EXAM02
{
    public class Answer : ICloneable
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer(int id, string text)
        {
            AnswerId = id;
            AnswerText = text;
        }

        public override string ToString() => AnswerText;

        public object Clone() => new Answer(AnswerId, AnswerText);
    }
}