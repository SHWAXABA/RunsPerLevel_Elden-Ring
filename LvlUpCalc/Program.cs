internal class Program
{
    private static void Main(string[] args)
    {
        // Running a do while loop with in internal switch statement
        String ans;
        do{
        Console.WriteLine("Do you want to run this program?(Y/N): ");
         ans = Console.ReadLine();
        //After selecting an option the program will loop until the user selects to close the program 
        switch(ans){
            case "Y":
                Console.WriteLine("!!!!ONLY ENTER NUMBERS!!!!"+"\n");
                //Declared variables: These were moved to the top after being declared
                    int a;
                    int b;
                    int Crune;
                    int Kper;
                // A set of Do while loops that check if the user has entered anything besides and integer values    
                    do{
                        Console.WriteLine("Enter the Rune amount needed to level up:");
                    }while(!int.TryParse(Console.ReadLine(),out a));
                    do{
                        Console.WriteLine("Enter the amount of levels you require:");
                    }while (!int.TryParse(Console.ReadLine(), out b));
                    //Multiplies the amount of levels by the number of average runes required
                    int c = a * b;
                        Console.WriteLine("You need :" + (c) + " Runes");
                     do{
                        Console.WriteLine("Creature rune drop Rate:");
                    }while (!int.TryParse(Console.ReadLine(), out Crune)); 
                    do{
                        Console.WriteLine("How many kills made per run?");
                    }while (!int.TryParse(Console.ReadLine(), out Kper)); 
                // Divides the number of needed runes by the creatre drop rate
                // Then the average Kills are divided by the Kills per run
                    int aveK = c / Crune;
                    int run = aveK / Kper;
                    Console.WriteLine("You need to kill :" + aveK + " Times" + "\n" + "And go on " + run + " Run(s)");
             
            break;
            case "N":
                Console.WriteLine(" Thank you for using this program!");
                Environment.Exit(1);
            break;
            default:
                Console.WriteLine("Please select the proper options"+"\n");
            break;
        }        
                        
        }while(ans != "N");
       

    }
}