using Entities;

namespace BusinessLayer.Abstract
{
    public interface IGradeService
    {
        double CalculateAverage(Student student);
        string DetermineGrade(double average);
        bool IsPass(double average);
    }
}
