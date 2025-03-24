namespace EnumExcerise
{
    public enum MonthsOfYear
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        Auguts = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number between 1 to 12: ");
            int input = int.Parse( Console.ReadLine());  

            if(input >= 1 && input <= 12)
            {
                MonthsOfYear months = (MonthsOfYear)input;
                Console.WriteLine($"Your input number is equal to month: {months}");
            }
            else
            {
                Console.WriteLine("Invalid Number.Please enter number between 1 and 12");
            }
              
            Console.ReadLine();
        }
    }
}
