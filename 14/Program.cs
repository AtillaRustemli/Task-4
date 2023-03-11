namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int qaliq, newNum = 0;
        l1:

            Console.Write("Ededi qeyd edin: ");
            if (!int.TryParse(Console.ReadLine(), out x) || !(1 <= x && x < 100000000))
            {
                goto l1;
                    }

            while (x > 0)
            {
                qaliq = x % 10;
                x /= 10;
                newNum = newNum * 10 + qaliq;
            }
            newNum = newNum * 10 + 1;
            x = newNum;
            int qaliq1;
            newNum= 0;
            while (x > 0)
            {
                qaliq1 = x % 10;
                x /= 10;
                newNum= newNum * 10 + qaliq1;
            }
            Console.WriteLine($"Ededin onune 1 artirilmish formasi: {newNum}");
        }
    }
}