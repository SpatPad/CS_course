namespace FirstProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("It's Monday ;(");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("The last day of work week!");
                    break;
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("The weekend!");
                    break;                
                default:
                    Console.WriteLine("The Middle of the work week");
                    break;



            }
        }
    }
}