using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAfterVideo
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int _time, int _numberofQuestions) : base(_time, _numberofQuestions)
        {
        }

        public override void CreateQuestions()
        {
               // only mcqQuestions
               ArrayOfQuestions=new MCQQuestions[NumberOfQuestions];

            for (int i=0; i<NumberOfQuestions; i++)
            {
                ArrayOfQuestions[i]=new MCQQuestions();

                ArrayOfQuestions[i].AddQuestions();

            }
        }

        public override void ShowExam()
        {
            if (ArrayOfQuestions is not null)
            {
                foreach (var Question in ArrayOfQuestions)
                {
                    Console.WriteLine(Question);
                    for (int i = 0; i < Question.AnswerList.Length; i++)
                    {
                        Console.WriteLine(Question.AnswerList[i]);
                    }


                    int user;

                    do
                    {
                        Console.WriteLine("Enter Your Answer");
                    }
                    while (!int.TryParse(Console.ReadLine(), out user) && user < 1 || user > 3);

                    Question.UserAnswer.Id = user;
                    Question.UserAnswer.Text = Question.AnswerList[user - 1].Text;

                    Console.Clear();

                }

                Console.WriteLine("Right Answer");

                for(int i=0; i<NumberOfQuestions;i++) 
                {
                 Console.WriteLine($"Question {i+1} : {ArrayOfQuestions[i].Body}");
                 Console.WriteLine($"Right Answer  {i+1} = {ArrayOfQuestions[i].RightAnswer}");
                }
            }

        }
    }
}
