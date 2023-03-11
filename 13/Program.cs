namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long x;
            long qaliq, qaliq1;
            int a = 0;
            long newNum = 0, secNum = 0;
        l1:
            Console.Write("7 reqemli ededi qeyd edin: ");
            if (!long.TryParse(Console.ReadLine(), out x) || !(999999 < x && x < 10000000))
            {
                goto l1;
            }
            long endx= x % 1000;
            while(endx>0) {
                qaliq1 = endx % 10;
                endx /= 10;
                secNum = secNum * 10 + qaliq1;
}
            if (x / 10000 == secNum)
            {
                while (x>0)
                {
                    qaliq = x % 10;
                    x /= 10;
                    if (qaliq == 0)
                    {
                        a++;
                    }
                }

                Console.WriteLine($"Ededin terkibindeki 0-larin sayi: {a}");
            }
            else
            {
                Console.WriteLine("Eded polindrom deyil");
            }


        }
    }
}