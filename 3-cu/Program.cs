namespace _3_cu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
        l1:
            Console.Write("Ededi qeyd edin: ");
            if(!int.TryParse(Console.ReadLine(),out n))
            {
                goto l1;
            }
            if(n%10==7) {
                Console.WriteLine("Beli");
            }
            else
            {
                Console.WriteLine("Xeyr");
            }
        }
    }
}