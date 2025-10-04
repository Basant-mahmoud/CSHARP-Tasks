using Examination_system_;

public abstract class Exam : IDisplayable
{
    public Subject Subject { get; set; }
    public int TimeInMinutes { get; set; }
    public List<Question> Questions { get; set; }

    public Exam(Subject subject, int time)
    {
        Subject = subject;
        TimeInMinutes = time;
        Questions = new List<Question>();
    }

    public abstract void Display();


   
}
