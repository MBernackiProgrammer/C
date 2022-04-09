namespace GreetingAplication
{
    class Program
    {
        static void Main(string[] args)
        {
            for(;;)
            {
                System.Console.WriteLine("Can I get your data ? Y / N");
                string Option = System.Console.ReadLine();

                if(Option == "Y")
                {
                    break;
                }
                else
                {
                    System.Console.WriteLine("Try again, you should say Yes (Y)");
                }
            }

            System.Console.WriteLine("Your name :");

            string Name = System.Console.ReadLine();

            System.Console.WriteLine("Hi, " + Name);
        }
    }
}