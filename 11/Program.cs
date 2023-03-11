namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            l1:
            Console.Write("6 reqemli ededi qeyd edin: ");
            if(!int.TryParse(Console.ReadLine(),out x)||!(99999<x&&x<1000000)) 
            {
                goto l1;
            }
            int k = x % 1000;
            if (x/100000+(x / 10000)%10+(x / 1000)%10 == k / 100 + (k%100)/10+k%10)
            {
                int y = (x / 10000) * 100 + (x % 100);
                y = y + ((x % 10000) / 100);
                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine("Verilmish eded sherte uygun deyil.");
            }
        }
    }
}