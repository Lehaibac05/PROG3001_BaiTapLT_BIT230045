namespace BaitapLT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Xin moi ban nhap vao mot so: ");
            int dayNumber = int.Parse(Console.ReadLine());

            string dayName;

            switch (dayNumber) {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid day number";
                    break;
            }
            Console.WriteLine("The day of the week is: " + dayName);
        }
    }
}
