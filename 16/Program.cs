namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int qaliq;
            int a = 0;
            
            int[] reqemler = new int[0];
            int size;
        l1:

            Console.Write("6 reqemli ededi qeyd edin: ");
            if (!int.TryParse(Console.ReadLine(), out x) || !(99999 <= x && x <= 1000000))
            {
                goto l1;
            }
            
            while(x>0)
            {
                qaliq = x % 10;
                x /= 10;
                if (Array.IndexOf(reqemler, qaliq) == -1)
                {
                    a++;
                size = reqemler.Length;

                    Array.Resize(ref reqemler,size+1);
                    reqemler[size] = qaliq;

                }

                
                
            }
            Console.WriteLine($"Ededin terkibindeki Unikal reqemlerin sayi: {a}");


        }
    }
}