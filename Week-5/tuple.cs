using System;

class EmployeePerformance
{
    // Method returning Tuple
    static (double sales, int rating) GetEmployeeData(double salesAmount, int feedbackRating)
    {
        return (salesAmount, feedbackRating);
    }

    static void Main()
    {
        try
        {
            // Input
            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Monthly Sales Amount: ");
            double sales = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Customer Feedback Rating (1-5): ");
            int rating = Convert.ToInt32(Console.ReadLine());

            // Validate rating
            if (rating < 1 || rating > 5)
            {
                Console.WriteLine("Invalid rating! Must be between 1 and 5.");
                return;
            }

            // Get tuple
            var employeeData = GetEmployeeData(sales, rating);

            // Pattern Matching using switch expression
            string performance = employeeData switch
            {
                (>= 100000, >= 4) => "High Performer",
                (>= 50000, >= 3) => "Average Performer",
                _ => "Needs Improvement"
            };

            // Output
            Console.WriteLine("\n--- Employee Performance Report ---");
            Console.WriteLine($"Employee Name   : {name}");
            Console.WriteLine($"Sales Amount    : {employeeData.sales}");
            Console.WriteLine($"Rating          : {employeeData.rating}");
            Console.WriteLine($"Performance     : {performance}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: Invalid input! " + ex.Message);
        }
    }
}