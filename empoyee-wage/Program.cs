namespace empoyee_wage
{
    internal class Program
    {
        public const int part_time = 1;
        public const int full_time = 2;

        public static void ComputeEmpwage(string company, int emp_rate_per_hrs, int max_hrs_in_month, int no_of_working_days)
        {
            int total_emp_hrs = 0;
            int total_working_days = 0;

            Console.WriteLine("Welcome to Employee Wage Application");
            Console.WriteLine("Click 0 if Absent, Click 1 if Part-time, Click 2 for Full-time");
            int empCheck = Convert.ToInt32(Console.ReadLine());

            while ((total_emp_hrs < max_hrs_in_month) && (total_working_days < no_of_working_days))
            {
                total_working_days++;

                int emp_hrs = getworkhours(empCheck);

                total_emp_hrs += emp_hrs;

            }


            int totalwage = total_emp_hrs * emp_rate_per_hrs;
            Console.WriteLine($"Total emp wage for company {company} is {totalwage}rs ");

        }

        public static int getworkhours(int empcheck)
        {
            int emp_hrs = 0;
            switch (empcheck)
            {
                case part_time:
                    emp_hrs = 4;
                    break;
                case full_time:
                    emp_hrs = 8;
                    break;
                default:
                    emp_hrs = 0;
                    break;
            }

            return emp_hrs;
        }



        static void Main(string[] args)
        {
            ComputeEmpwage("dmart", 50, 100, 20);
            ComputeEmpwage("swiggy", 20, 80, 28);
        }
    }

}
