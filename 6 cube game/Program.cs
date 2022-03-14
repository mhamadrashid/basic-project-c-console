using System;


namespace mhamad_rashid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short exit = 0;
            Console.WriteLine(" 6 cube game , you can try until 6 steps  ");
            Console.Write("Enter the name  of player  1  :");
            // name player one p1
            string p1 = Console.ReadLine();
            Console.Write("Enter the name  of player  2  :");
            // name player two p2
            string p2 = Console.ReadLine();
            Console.WriteLine("                T.B // Each player will be try his chansce 3 times ");
            Console.WriteLine("\n robot is starting ...");
            Console.WriteLine(" please Enter number of your chance ");
          // get random number from roboot , bettwen 1 and 6 
            Random r = new Random();
            int num = r.Next(1,6);
            do
            {

           
            for (int i = 3; i >=1; i--)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("*********************************************************");
                    Console.Write($"player 1 :{p1} =   ");
                        // ch1 it used for seve chooese player one 
                    int ch1 = Convert.ToInt32(Console.ReadLine());
                    if (ch1>6 || ch1<1)
                    {
                        Console.WriteLine(" ERROR  , please Enter number Under 6");
                        continue;
                    }
                    if (ch1 == num)
                    {
                        Console.WriteLine(".....................");
                        Console.WriteLine($"congratulations !! \n {p1}  is winer \n roboT : {num} \n  {p1} :  {ch1}");
                        Console.WriteLine(".....................");
                        Console.ReadLine();
                        return;
                    }
                    else
                    {
                        Console.WriteLine($" Failed           {p1}  has  {i-1} chances left " );
                        break;
                        
                    }
                }
                for (int a = 0; a < 2; a++)
                {
                    Console.WriteLine("*************************************");
                    Console.Write($"player 2 :{p2} =   ");
                        // ch2 it used for seve chooese player two 
                        int ch2 = Convert.ToInt32(Console.ReadLine());
                    if (ch2 > 6 || ch2 < 1)
                    {
                        Console.WriteLine(" ERROR  , please Enter number Under 6");
                        continue;
                    }
                    if (ch2 == num)
                    {
                        Console.WriteLine(".....................");
                        Console.WriteLine($"congratulations !! \n {p2}  is winer \n roboT : {num} \n {p2} :  {ch2}");
                        Console.WriteLine(".....................");
                        Console.ReadLine();
                        return;
                    }
                    else
                    {
                        Console.WriteLine($" Failed           {p1}  has  {i - 1} chances left  ");
                        break;
                    }
                }
               
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Game Over ");
            Console.WriteLine("--------------------------------");
                Console.Write( " Enter number 1 to continu  OR  number 0 to EXIT the game \n Enter number  : ");
               exit = Convert.ToInt16(Console.ReadLine());
            } while (exit==1);

            Console.WriteLine("               Never give up , try again you can win it ");
        }
    }
}
