using System.Text;

namespace ConsoleApp1;

public class Student
{
    public Student(string surname, double averageScore, int course)
    {
        Surname = surname;
        AverageScore = averageScore;
        Course = course;
    }

    public string Surname { private set; get; }
    public double AverageScore { private set; get; }
    public int Course { private set; get; }

    public virtual double CalculateQuality()
    {
        return 0.2 * AverageScore * Course;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();
        stringBuilder.AppendLine(base.ToString());
        stringBuilder.AppendLine($"Surname: {Surname}");
        stringBuilder.AppendLine($"Average score: {AverageScore}");
        stringBuilder.AppendLine($"Course: {Course}");
        stringBuilder.AppendLine($"Quality: {CalculateQuality()}");
        return stringBuilder.ToString();
    }
}