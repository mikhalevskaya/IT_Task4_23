using System.Text;

namespace ConsoleApp1;

public class StudentStudEng : Student
{
    public StudentStudEng(string surname, double averageScore, int course, bool studyingEnglish) : base(surname, averageScore, course)
    {
        StudyingEnglish = studyingEnglish;
    }
    public bool StudyingEnglish { private set; get; }

    public override double CalculateQuality()
    {
        double baseQuality = base.CalculateQuality();
        if (StudyingEnglish)
        {
            return 2 * baseQuality;
        }
        return 0.9 * baseQuality;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();
        stringBuilder.AppendLine(base.ToString());
        stringBuilder.AppendLine($"Studying English: {StudyingEnglish}");
        return stringBuilder.ToString();
    }
}