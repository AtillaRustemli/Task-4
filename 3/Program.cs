namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
        l1:
            Console.Write("Eded qeyd edin: ");
            if(!int.TryParse(Console.ReadLine(),out a)||!(10<=a&&a<100))
            {
                goto l1;
            }

            if (a % 10 == a / 10)
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