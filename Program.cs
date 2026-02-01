namespace GuessNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Today We build small GuessnumberGame in C# Consoleapp anyway lets do it 
            // First step we use while and or for I choose for 
            // Step 2 enter Random method and create NewRandom
            // Users have 3 hearts,step 3 enter user input do you think ? int string or double 
            int UserInput;  //of course int
            // We enter UserInput and hearts = i
            Random RandomNumber=new Random(); //Random must be int type
            int RandomNumberIntType =RandomNumber.Next(0, 10); // we choose from 0 to 10 but you will  choose other version 
            Console.WriteLine("Please enter Random Number");
            for (int i = 1; i <= 3; i++)
            {
                UserInput =int.Parse(Console.ReadLine());// Enter input
                if (UserInput != RandomNumberIntType && i == 3) //if you finish 3 hearts you lost game
                {
                    Console.WriteLine("You Lost Game");
                    break;
                }
                if (UserInput == RandomNumberIntType )
                {
                    Console.WriteLine("Congratulations You Found");
                    Console.ReadLine();//Enter and finish 
                    break;
                }
                else if (UserInput < RandomNumberIntType)
                {
                    Console.WriteLine("Please say Bigger Number");
                }
                else if(UserInput > RandomNumberIntType) // I shouldn't have written this, but I did to make it clear. (if)
                {
                    Console.WriteLine("Please say Smaller Number");
                }
            }
            //Done 01.31.2026 Update 02.01.2026
        }
    }
}
