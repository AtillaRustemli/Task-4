namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
        l1:
            Console.Write("Ededi qeyd edin: ");
            if(!int.TryParse(Console.ReadLine(), out n)||!(100<=n&&n<1000))
            {
                goto l1;
            }
            int x = n % 10 + n / 100;
            if (x.Equals( (n % 100) / 10))
            {
                Console.WriteLine("Beli");
            }
            else
            {
                Console.WriteLine("Xeyr");
            }
        }
    }
}