namespace empoyee_wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 is for present and 0 for absent ");
            int attendance = int.Parse(Console.ReadLine());

            if (attendance == 1)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
