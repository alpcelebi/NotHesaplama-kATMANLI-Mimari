using System;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Entities;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IGradeService gradeService = new GradeService();

            // Öğrenci bilgilerini al
            Student student = new Student();

            Console.WriteLine("Öğrenci Adı: ");
            student.FirstName = Console.ReadLine();

            Console.WriteLine("Öğrenci Soyadı: ");
            student.LastName = Console.ReadLine();

            Console.WriteLine("1. Notu: ");
            student.Grade1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2. Notu: ");
            student.Grade2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("3. Notu: ");
            student.Grade3 = Convert.ToDouble(Console.ReadLine());

            // Not ortalamasını hesapla
            double average = gradeService.CalculateAverage(student);

            // Harf notunu belirle
            string grade = gradeService.DetermineGrade(average);

            // Geçip kaldığı bilgisini kontrol et
            bool isPass = gradeService.IsPass(average);

            // Sonuçları yazdır
            Console.WriteLine($"Öğrenci: {student.FirstName} {student.LastName}");
            Console.WriteLine($"Not Ortalaması: {average}");
            Console.WriteLine($"Harf Notu: {grade}");
            Console.WriteLine($"Durumu: {(isPass ? "Geçti" : "Kaldı")}");

            Console.ReadLine();
        }
    }
}
