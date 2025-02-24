namespace empoyee_wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1 if the employee is present, otherwise enter 0: ");
            int emp_present = int.Parse(Console.ReadLine());
            Console.WriteLine(emp_present);

            int emp_rate_per_hour = 100;

            int emp_hour = 0;
            int emp_salary = 0;

            if (emp_present == 1)
            {
                emp_hour = 7;
            }
            else
            {
                emp_hour = 0;
            }

            emp_salary = emp_rate_per_hour * emp_hour;
            Console.WriteLine("Employee salary : " + emp_salary);
        }
    }
}
