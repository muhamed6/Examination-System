using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAfterVideo
{
    public abstract class Questions
    {
        public Questions() : this(new Answer()) { }

        public Questions(Answer rightAnswer)
        {
            AnswerList = new Answer[0];
            RightAnswer = rightAnswer;
            UserAnswer = new Answer();
        }

        public abstract string Header { get; }
        public  string? Body { get; set; }

        public int Mark {  get; set; }

        public Answer[] AnswerList { get; set; }

        public Answer RightAnswer { get; set; }
        public Answer UserAnswer { get; set; }

        public abstract void AddQuestions();

        public override string ToString()
        {
            return $"{Header} \t Mark {Mark} \t The Question {Body}";
        }
    }
}
