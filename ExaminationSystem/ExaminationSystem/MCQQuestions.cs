using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAfterVideo
{
    public class MCQQuestions : Questions
    {


        public override string Header => $"Multiple Choice Question";

        public MCQQuestions() : base()
        {
            // mcq contains 3 answers
            AnswerList=new Answer[3];
        }

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
            while (!int.TryParse(Console.ReadLine(), out mark) && mark <= 0 );
            
            Mark = mark;

            Console.WriteLine("Enter Choices");

            for(int i = 0; i < AnswerList.Length; i++) 
            {
                AnswerList[i] = new Answer { Id = i+1 };



               Console.WriteLine($"Enter Choice {i+1}");

                AnswerList[i].Text=Console.ReadLine();

            }

            int Right;

            do
            {
                Console.WriteLine("Enter Id Of The Right Answer");
            }

            while (!int.TryParse(Console.ReadLine(), out Right) && Right < 1 || Right > 3);



            RightAnswer.Id = Right;

            RightAnswer.Text = AnswerList[Right-1].Text;


            Console.Clear();


        }
    }
}
