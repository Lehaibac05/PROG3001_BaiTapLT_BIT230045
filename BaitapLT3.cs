namespace BaitapLT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Xin moi ban nhap mot so nguyen dương: ");
            int num = int.Parse(Console.ReadLine());
            if (num <= 0)
            {
                Console.WriteLine("So khong hop le, xin moi ban nhap lai.");
                return;
            }

            int factortial = 1;
            for (int i = 1; i <= num; i++)
            {
                factortial *= i;
            }
            Console.WriteLine("Giai thua cua " +num + " la: " +factortial);
        }
    }
}
