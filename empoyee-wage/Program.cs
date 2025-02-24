namespace empoyee_wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter no. of hours: ");
            int hours = int.Parse(Console.ReadLine());
            int empWage = 0;
            int emp_rate_per_hour = 200;
            switch (hours)
            {
                case 1:
                    empWage = hours * emp_rate_per_hour;
                    Console.WriteLine("Your part-time wage is: " + empWage);
                    break;
                case 2:
                    empWage = hours * emp_rate_per_hour;
                    Console.WriteLine("Your part-time wage is: " + empWage);
                    break;
                case 3:
                    empWage = hours * emp_rate_per_hour;
                    Console.WriteLine("Your part-time wage is: " + empWage);
                    break;

                case 4:
                    empWage = hours * emp_rate_per_hour;
                    Console.WriteLine("Your part-time wage is: "+empWage);
                    break;

                case 8:
                    empWage = hours * emp_rate_per_hour;
                    Console.WriteLine("Your full-time wage is:" + empWage);
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
            
        }
    }
}
