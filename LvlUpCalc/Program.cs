internal class Program
{
    private static void Main(string[] args)
    {
        //Infinite loop until the user closes the terminal
        do
        {
            //Asks the user to enter the details of their run
            Console.WriteLine("Enter the Rune amount neeeded to level up:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the amount of levels you require:");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a * b;
            Console.WriteLine("You need :" + (c) + " Runes");
            Console.WriteLine("Creature rune drop Rate:");
            int Crune = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many kills made per run?");
            int Kper = Convert.ToInt32(Console.ReadLine());
            int aveK = c / Crune;
            int run = aveK / Kper;
            Console.WriteLine("You need to kill :" + aveK +" Times"+"\n"+ "And go on "+ run + " Run(s)");
            
        } while (true);
       

    }
}