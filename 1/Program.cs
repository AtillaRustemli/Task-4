namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n;
        l1:
            Console.Write("Ededi qeyd edin: ");
            if(!long.TryParse(Console.ReadLine(),out n)) {
                goto l1;
            }
            if (n % 2 == 0)
            {
                Console.WriteLine("Eded cutdur");
            }
            else
            {
                Console.WriteLine("Eded tekdir");
            }
        }
    }
}