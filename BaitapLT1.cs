namespace BaitapLT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap vao mot so: ");
            int num = int .Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Day la so duong");
            }
            else if (num < 0)
            {
                Console.WriteLine("day la so am");
            }
            else if (num == 0)
            {
                Console.WriteLine("Day la so 0");
            }
        }
    }
}
