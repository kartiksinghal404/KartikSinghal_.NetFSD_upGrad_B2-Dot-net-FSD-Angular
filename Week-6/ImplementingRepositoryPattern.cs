using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryPatternDemo
{
    // Entity Class
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Course { get; set; }
    }

    // Repository Interface
    public interface IStudentRepository
    {
        void AddStudent(Student student);
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
        void DeleteStudent(int id);
    }

    // Repository Implementation
    public class StudentRepository : IStudentRepository
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

        public Student GetStudentById(int id)
        {
            return students.FirstOrDefault(s => s.StudentId == id);
        }

        public void DeleteStudent(int id)
        {
            var student = GetStudentById(id);
            if (student != null)
            {
                students.Remove(student);
            }
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            IStudentRepository repo = new StudentRepository();

            // Adding Students
            repo.AddStudent(new Student { StudentId = 1, StudentName = "Kartik", Course = ".NET" });
            repo.AddStudent(new Student { StudentId = 2, StudentName = "Rahul", Course = "Java" });

            // Viewing All Students
            Console.WriteLine("All Students:");
            foreach (var student in repo.GetAllStudents())
            {
                Console.WriteLine($"ID: {student.StudentId}, Name: {student.StudentName}, Course: {student.Course}");
            }

            // Get Student by ID
            Console.WriteLine("\nFind Student with ID 1:");
            var foundStudent = repo.GetStudentById(1);
            if (foundStudent != null)
            {
                Console.WriteLine($"ID: {foundStudent.StudentId}, Name: {foundStudent.StudentName}, Course: {foundStudent.Course}");
            }

            // Delete Student
            repo.DeleteStudent(2);

            // Viewing After Deletion
            Console.WriteLine("\nAfter Deleting Student with ID 2:");
            foreach (var student in repo.GetAllStudents())
            {
                Console.WriteLine($"ID: {student.StudentId}, Name: {student.StudentName}, Course: {student.Course}");
            }

            Console.ReadLine();
        }
    }
}