using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAfterVideo
{
    public class Subject
    {   

        public string Name { get; set; }

        public int Id { get; set; }

        public Exam? SubjectExam { get; set; }

        public Subject(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public void CreateExam()
        {


            int Time, ExamType, NumberOfQuestions;

            do
            {
                Console.WriteLine("Enter 1 For Practical ||  2 For Final ");
            } while (!int.TryParse(Console.ReadLine(),out ExamType) && ExamType <1 || ExamType > 2);

            
            do
            {
                Console.WriteLine("Enter The Time ");
            } while (!int.TryParse(Console.ReadLine(),out Time));



            do
            {
                Console.WriteLine("Enter Number Of Questions ");
            } while (!int.TryParse(Console.ReadLine(), out NumberOfQuestions) && NumberOfQuestions <= 0);


            if(ExamType==1) 
            {
                SubjectExam=new PracticalExam(Time, NumberOfQuestions);
            }
            else if (ExamType == 2)
            {
                SubjectExam = new FinalExam(Time, NumberOfQuestions);
            }

            Console.Clear();

            SubjectExam.CreateQuestions();

        }
    }
}
