namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
        l1:
            Console.Write("1-ci ededi qeyd edin: ");
            if (!int.TryParse(Console.ReadLine(), out a))
            {
                goto l1;
            }
            l2:
            Console.Write("2-ci ededi qeyd edin: ");
            if(!int.TryParse(Console.ReadLine(),out b))
            {
                goto l2;
            }
            if(a%b==0)
            {
                Console.WriteLine(a/b);
            }
            else
            {
                Console.WriteLine("Bolunmur");
            }

        }
    }
}