﻿namespace empoyee_wage
{
    internal class Program
    {
        public const int part_time = 1;
        public const int full_time = 2;
        public const int emp_rate_per_hour = 100;
        public const int no_of_working_days = 20;
        public const int max_hrs_in_month = 100;

      


        public static void ComputeWage()
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
                //Console.WriteLine($"Day {total_working_days} Emp hrs: {emp_hrs}");
            }


            Console.WriteLine($"Total Days Worked: {total_working_days}");
            Console.WriteLine($"Total Hours Worked: {total_emp_hrs}");
            Console.WriteLine($"Total wage: {total_emp_hrs * emp_rate_per_hour}");
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
            ComputeWage();
        }

    }
}
