namespace Examination_system_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject math = new Subject("Mathematics", "MATH101");

            var q1 = new TrueFalseQuestion("Q1", "Is 2+2=4?", 1, true);
            var q2 = new ChooseOneQuestion("Q2", "Which number is prime?", 2, new List<string> { "4", "7", "8" }, 1);
            var q3 = new ChooseAllQuestion("Q3", "Select even numbers", 3, new List<string> { "2", "3", "4", "5" }, new List<int> { 0, 2 });

            Exam practiceExam = new PracticeExam(math, 30);
            practiceExam.Questions.Add(q1);
            practiceExam.Questions.Add(q2);

            Exam finalExam = new FinalExam(math, 60);
            finalExam.Questions.Add(q1);
            finalExam.Questions.Add(q3);

            Console.WriteLine("===== PRACTICE EXAM =====");
            practiceExam.Display();

            Console.WriteLine("\n===== FINAL EXAM =====");
            finalExam.Display();
        }
    }
}
