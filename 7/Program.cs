namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
        l1:
            Console.Write("Ededi daxil edin: ");
            if(!int.TryParse(Console.ReadLine(),out n) || !(99 < n && n < 1000))
            {
            
                goto l1;
            }

            int y = n % 10 + n / 100 + (n % 100) / 10;
            if (y == (n / 100)* (n / 100))
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