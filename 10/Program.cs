namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f;
        l1:
            Console.Write("1-ci ededi daxil edin: ");
            if(!int.TryParse(Console.ReadLine(), out a)) {
                goto l1;
            }
        l2:
            Console.Write("2-ci ededi daxil edin: ");
            if (!int.TryParse(Console.ReadLine(), out b))
            {
                goto l2;
            }
        l3:
            Console.Write("3-ci ededi daxil edin: ");
            if (!int.TryParse(Console.ReadLine(), out c))
            {
                goto l3;
            }
        l4:
            Console.Write("4-ci ededi daxil edin: ");
            if (!int.TryParse(Console.ReadLine(), out d))
            {
                goto l4;
            }
        l5:
            Console.Write("5-ci ededi daxil edin: ");
            if (!int.TryParse(Console.ReadLine(), out e))
            {
                goto l5;
            }
        l6:
            Console.Write("6-ci ededi daxil edin: ");
            if (!int.TryParse(Console.ReadLine(), out f))
            {
                goto l6;
            }

            int n = Math.Max(a, b);
            int k = Math.Max(c, d);
            int t = Math.Max(e, f);
            int s = Math.Max(n, k);
            if(t>=s) {
                Console.WriteLine(t);
            }
            else
            {
                Console.WriteLine(s);
            }



        }
    }
}