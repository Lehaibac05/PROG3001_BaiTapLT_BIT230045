namespace BaitapLT6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double number;

            Console.WriteLine("Nhap vao mot so duong.");

                while (true) {
                Console.Write("Nhap vao so: ");
                number = double.Parse(Console.ReadLine());

                if (number < 0)
                {
                    Console.WriteLine("So khong hop le, xin moi nhap lai.");
                    break;
                }
                else if (number == 0)
                {
                    continue;
                }
                else
                {
                    sum += number;
                }
                Console.WriteLine("Tong cua chuoi so la: " + sum);
            }
        }
    }
}
