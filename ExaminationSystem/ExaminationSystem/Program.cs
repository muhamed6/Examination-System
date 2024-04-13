using ExamAfterVideo;
using System.Diagnostics;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new Subject("C#", 1);

            sub.CreateExam();

            Console.WriteLine("Do You Want To Start Exam Y/N");

            char choice = Char.Parse(Console.ReadLine());

            if (choice == 'Y' || choice == 'y')
            {
                Stopwatch sw = new();
                sw.Start();
                sub.SubjectExam.ShowExam();
                Console.WriteLine($" The Time is {sw.Elapsed}");
            }

            else
            {
                Console.WriteLine("Thank You");
            }
        }
    }
}
