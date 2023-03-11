namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long x;
            long qaliq;
            int a = 0;
            long newNum = 0;
        l1:
            Console.Write("6 reqemli ededi qeyd edin: ");
            if (!long.TryParse(Console.ReadLine(), out x) || !(99999 < x && x < 1000000))
            {
                goto l1;
            }
            x = 80000000 + x * 10 + 8;
           
            long y = (x % 10000) * 10000 + x / 10000;
            while(y> 0)
            {
                qaliq = y % 10;
                y /= 10;
               
                newNum = newNum * 10 + qaliq;
            }
            y = newNum;
            newNum= 0;
            long qaliq1;
            while(y>0)
            {
                qaliq1=y % 10;
                y /= 10;
                a++;
                if (a==1||a==3||a==5||a==7)
                {
                    qaliq1 = 0;
                    
                }
              
                newNum = newNum * 10 + qaliq1;
            }

            Console.WriteLine(newNum);
        }
    }
}