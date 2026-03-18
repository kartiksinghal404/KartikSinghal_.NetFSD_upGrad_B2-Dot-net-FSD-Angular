using System;

struct Student
{
    public int RollNo;
    public string Name;
    public string Course;
    public int Marks;
}

class Program
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        Student[] students = new Student[n];

        // Input student records
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nEnter details for Student {i + 1}");

            Console.Write("Enter Roll Number: ");
            students[i].RollNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            students[i].Name = Console.ReadLine();

            Console.Write("Enter Course: ");
            students[i].Course = Console.ReadLine();

            int marks;
            while (true)
            {
                Console.Write("Enter Marks: ");
                marks = int.Parse(Console.ReadLine());

                if (marks >= 0 && marks <= 100)
                {
                    students[i].Marks = marks;
                    break;
                }
                else
                {
                    Console.WriteLine("Marks must be between 0 and 100.");
                }
            }
        }

        while (true)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Display All Students");
            Console.WriteLine("2. Search Student by Roll Number");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nStudent Records:");
                    foreach (Student s in students)
                    {
                        Console.WriteLine($"Roll No: {s.RollNo} | Name: {s.Name} | Course: {s.Course} | Marks: {s.Marks}");
                    }
                    break;

                case 2:
                    Console.Write("\nEnter Roll Number to search: ");
                    int searchRoll = int.Parse(Console.ReadLine());
                    bool found = false;

                    foreach (Student s in students)
                    {
                        if (s.RollNo == searchRoll)
                        {
                            Console.WriteLine("\nStudent Found:");
                            Console.WriteLine($"Roll No: {s.RollNo} | Name: {s.Name} | Course: {s.Course} | Marks: {s.Marks}");
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Record not found.");
                    }
                    break;

                case 3:
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}