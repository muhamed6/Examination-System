using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAfterVideo
{
    public class FinalExam : Exam
    {
        public FinalExam(int _time, int _numberofQuestions) : base(_time, _numberofQuestions)
        {
        }

        public override void CreateQuestions()
        {

            ArrayOfQuestions = new Questions[NumberOfQuestions];

            int choice;
            for(int i = 0; i < NumberOfQuestions; i++) 
            {
                do {
                    Console.WriteLine("Enter Type 1 | MCQ       2| TF "); 
                   }
                while(!int.TryParse(Console.ReadLine(), out choice) && choice<1 || choice>2);

                if(choice == 1) 
                {
                    ArrayOfQuestions[i] = new MCQQuestions();
                    ArrayOfQuestions[i].AddQuestions();
                }

                else
                {
                    ArrayOfQuestions[i] = new TFQuestions();
                    ArrayOfQuestions[i].AddQuestions();
                }
            }
        }

        public override void ShowExam()
        {
            if(ArrayOfQuestions is not null)
            {
                foreach(var Question in ArrayOfQuestions)
                {


                    Console.WriteLine(Question);

                    for(int i = 0;i<Question.AnswerList.Length;i++) 
                    {
                        Console.WriteLine(Question.AnswerList[i]);
                    }


                    int user;

                    do 
                    {
                        Console.WriteLine("Enter Your Answer");
                    }
                    while(!int.TryParse(Console.ReadLine(),out user) && user<1 || user>3);

                    Question.UserAnswer.Id=user;
                    Question.UserAnswer.Text = Question.AnswerList[user - 1].Text;

                    Console.Clear();

                }


                int TotalGrade = 0, Grade = 0;
                for(int i=0;i<ArrayOfQuestions.Length;i++)
                {
                    TotalGrade += ArrayOfQuestions[i].Mark;

                    
                    if (ArrayOfQuestions[i].UserAnswer.Id == ArrayOfQuestions[i].RightAnswer.Id)
                    {
                        Grade+= ArrayOfQuestions[i].Mark;
                    }

                    Console.WriteLine($"َQuestion {i + 1} :{ArrayOfQuestions[i].Body}");
                    Console.WriteLine($"َRight Answer = {ArrayOfQuestions[i].RightAnswer}");
                }

                Console.WriteLine($"Your Grade is {Grade} Out Of {TotalGrade} ");


            }


        }
    }
}
