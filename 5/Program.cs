namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
        l1:
            Console.Write("Ededi qeyd edin: ");
            if(!int.TryParse(Console.ReadLine(), out n)||!(10<=n&&n<=99)) {
                goto l1;
            }
            if ((n % 10 + n / 10) % 2 == 0)
            {
                Console.WriteLine((n % 10) * (n / 10));
            }
            else
            {
                Console.WriteLine("Ededin reqemleri beraber deyil.");
            }

        }
    }
}