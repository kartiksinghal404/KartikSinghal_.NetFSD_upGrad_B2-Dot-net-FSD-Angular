using System;
using System.Collections.Generic;

// 1. Student Class (Only holds data)
public class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public double Marks { get; set; }
}

// 2. StudentRepository (Only manages student data)
public class StudentRepository
{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public List<Student> GetAllStudents()
    {
        return students;
    }
}

// 3. ReportGenerator (Only generates report)
public class ReportGenerator
{
    public void GenerateReport(List<Student> students)
    {
        Console.WriteLine("===== Student Report =====");

        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.StudentId}");
            Console.WriteLine($"Name: {student.StudentName}");
            Console.WriteLine($"Marks: {student.Marks}");
            Console.WriteLine($"Grade: {GetGrade(student.Marks)}");
            Console.WriteLine("--------------------------");
        }
    }

    private string GetGrade(double marks)
    {
        if (marks >= 75) return "A";
        else if (marks >= 60) return "B";
        else if (marks >= 50) return "C";
        else return "Fail";
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        StudentRepository repo = new StudentRepository();

        // Adding students
        repo.AddStudent(new Student { StudentId = 1, StudentName = "Kartik", Marks = 82 });
        repo.AddStudent(new Student { StudentId = 2, StudentName = "Rahul", Marks = 55 });
        repo.AddStudent(new Student { StudentId = 3, StudentName = "Amit", Marks = 40 });

        // Generate report
        ReportGenerator report = new ReportGenerator();
        report.GenerateReport(repo.GetAllStudents());
    }
}