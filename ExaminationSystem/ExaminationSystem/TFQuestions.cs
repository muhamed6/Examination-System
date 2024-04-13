using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAfterVideo
{
    public class TFQuestions : Questions
    {
        public TFQuestions() : base()
        {
            // mcq contains 2 answers true or false
            AnswerList = new Answer[2];
            AnswerList[0] = new Answer(1,"True");
            AnswerList[1] = new Answer(2,"False");
        }

        public override string Header => $"True Or False Question ";

        public override void AddQuestions()
        {
            Console.WriteLine(Header);

            Console.WriteLine("Enter  The  Question");

            do
            {
                Body = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(Body));

            int mark;

            do
            {
                Console.WriteLine("Enter The Mark Of The Question");
            }
            while (!int.TryParse(Console.ReadLine(), out mark) && mark <= 0);

            Mark = mark;

            int Right;

            do
            {
                Console.WriteLine("Enter Id Of The Right Answer ---> 1 for true & 2 for false");
            } while (!int.TryParse(Console.ReadLine() , out Right) && 1>Right || Right>2);

            RightAnswer.Id = Right;
            RightAnswer.Text = AnswerList[Right - 1].Text;



            Console.Clear();

        }
    }
}
