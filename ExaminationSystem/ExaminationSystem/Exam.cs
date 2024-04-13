using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAfterVideo
{
    public abstract class Exam
    {


        public int Time {  get; set; }
        public int NumberOfQuestions {  get; set; }
        public Questions[]? ArrayOfQuestions { get; set; }
        public Exam(int _time, int _numberofQuestions)
        {
            Time= _time;
            NumberOfQuestions= _numberofQuestions;
        }

        public abstract void ShowExam();
        public abstract void CreateQuestions();

    }
}
