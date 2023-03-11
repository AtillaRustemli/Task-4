namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int qaliq, newNum = 0;
        l1:

            Console.Write("Ededi qeyd edin: ");
            if (!int.TryParse(Console.ReadLine(), out x) || !(1 <= x && x <= 365))
            {
                goto l1;
            }
            if (1 <= x && x <= 31)
            {
                Console.WriteLine("Ay: Yanvar");
            }
            else if (32<=x&&x<=59)
            {
                Console.WriteLine("Ay: Fevral");

               
            }
            else if (60<=x&&x<=90)
            {
                Console.WriteLine("Ay: Mart");
                
            }
            else if (91<=x&&x<=120)
            {
                Console.WriteLine("Ay: Aprel");
                
            }
            else if (121<=x&&x<=151)
            {
                Console.WriteLine("Ay: May");
                
            }
            else if (152<=x&&x<=181)
            {
                Console.WriteLine("Ay: Iyun");
               
            }
            else if (182<=x&x<=212)
            {
                Console.WriteLine("Ay: Iyul");
            }
            else if (213<=x&&x<=243)
            {
                Console.WriteLine("Ay: Avqust");
            }
            else if (244<=x&&x<=273)
            {
                Console.WriteLine("Ay: Sentyabr");
            }
            else if (274<=x&&x<=304)
            {
                Console.WriteLine("Ay: Oktyabr");
            }
            else if (305<=x&x<=334)
            {
                Console.WriteLine("Ay: Noyabr");
            }
            else 
            {
                Console.WriteLine("Ay: Dekabr");
            }
            //--------------------------------------------------------------------------------
           
            if (1 <= x && x <= 19|| 355 <= x && x <= 365)
            {
                Console.WriteLine("Burc: Oglaq");
            }
            if (20 <= x && x <= 49)
            {
                Console.WriteLine("Burc: Dolca");
            }
            if (50 <= x && x <= 79)
            {
                Console.WriteLine("Burc: Baliq");
            }
            if (80 <= x && x <= 109)
            {
                Console.WriteLine("Burc: Qoc");
            }
            if (110 <= x && x <= 140)
            {
                Console.WriteLine("Burc: Buga");
            }

            if (141 <= x && x <= 171)
            {
                Console.WriteLine("Burc: Ekizler");
            }
            if (172 <= x && x <= 203)
            {
                Console.WriteLine("Burc: Xerceng");
            }
            if (204 <= x && x <= 234)
            {
                Console.WriteLine("Burc: Sir");
            }
            if (236 <= x && x <= 265)
            {
                Console.WriteLine("Burc: Qiz");
            }
            if (266 <= x && x <= 296)
            {
                Console.WriteLine("Burc: Terezi");
            }
            if (297 <= x && x <= 325)
            {
                Console.WriteLine("Burc: Eqreb");
            }
            if (326 <= x && x <= 355)
            {
                Console.WriteLine("Burc: Dolca");
            }

        }
    }
}