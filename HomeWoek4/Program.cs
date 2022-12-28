namespace HomeWoek4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded daxil et: ");
            int number = int.Parse(Console.ReadLine());

            int r1, r2;
            int tmp;
            bool isDifferenceDigit = true;
            while (number != 0)
            {
                r1 = number % 10;
                number /= 10;
                tmp = number;

                while (tmp != 0)
                {
                    r2 = tmp % 10;
                    tmp /= 10;

                    if (r1 == r2)
                    {
                        Console.WriteLine("muxtelif reqemli deyil");
                        isDifferenceDigit = false;
                        break;
                    }

                }
                if (!isDifferenceDigit)
                    break;
            }
            if (isDifferenceDigit)
                Console.WriteLine("Muxtelif Reqemlidir");
        }
    }
}