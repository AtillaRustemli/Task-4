namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin: ");
            string day=Console.ReadLine();
            switch(day) {
                case "1":
                    Console.WriteLine("1-ci gun");
                    break;
                case "2":
                    Console.WriteLine("2-ci gun");
                    break;
                case "3":
                    Console.WriteLine("3-ci gun");
                    break;
                case "4":
                    Console.WriteLine("4-ci gun");
                    break;
                case "5":
                    Console.WriteLine("5-ci gun");
                    break;
                case "6":
                    Console.WriteLine("6-ci gun");
                    break;
                case "7":
                    Console.WriteLine("7-ci gun");
                    break;
                default:
                    Console.WriteLine(day+" adli bir gun yoxdur");
                    break;


            }
        }
    }
}