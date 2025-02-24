namespace empoyee_wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int hourlyWage = 200;

            Console.Write("Enter hours worked per day: ");
            int hoursWorkedPerDay = int.Parse(Console.ReadLine());
            
            int monthlyWage = monthly_wage(hourlyWage, hoursWorkedPerDay);

            Console.WriteLine($"The monthly wage is: {monthlyWage}");
        }

        
        public static int daily_wage(int hourlyWage, int hoursWorked)
        {
            return hourlyWage * hoursWorked;
        }

        // Method to calculate the monthly wage based on 20 working days using integer variables
        public static int monthly_wage(int hourlyWage, int hoursWorkedPerDay)
        {
            int dailyWage = daily_wage(hourlyWage, hoursWorkedPerDay);
            return dailyWage * 20; // Assuming 20 working days in a month
        }
    }
}
