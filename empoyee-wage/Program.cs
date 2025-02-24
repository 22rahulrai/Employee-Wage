namespace empoyee_wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of hours you work");

            int emp_hours = int.Parse(Console.ReadLine());
            int emp_wage = 0;
            int emp_rate_hour = 200;

            if (emp_hours <= 4){
                emp_wage=emp_hours*emp_rate_hour;
                Console.WriteLine("Your Part time wage is :" +emp_wage);
            }
            else if(emp_hours == 8)
            {
                emp_wage = emp_hours * emp_rate_hour;
                Console.WriteLine(" Your full time wage is: "+emp_wage);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
    }
}
