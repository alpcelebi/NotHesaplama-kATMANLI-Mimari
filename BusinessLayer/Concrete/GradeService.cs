using BusinessLayer.Abstract;
using Entities;


namespace BusinessLayer.Concrete
{
    public class GradeService : IGradeService
    {
        public double CalculateAverage(Student student)
        {
            return (student.Grade1 + student.Grade2 + student.Grade3) / 3;
        }

        public string DetermineGrade(double average)
        {
            if (average >= 90)
                return "A";
            else if (average >= 80)
                return "B";
            else if (average >= 70)
                return "C";
            else if (average >= 60)
                return "D";
            else
                return "F";
        }

        public bool IsPass(double average)
        {
            return average >= 60;
        }
    }
}
