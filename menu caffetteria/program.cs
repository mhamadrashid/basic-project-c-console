using System;


namespace mhamad_rashid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short cha = 0; short qawa = 0; short shir = 0; short chuklata = 0; short niskafa = 0; short nerla = 0; short nerglav = 0; short shirmoz = 0;
            string a = "";
            int koygshty = 0;
            short adad, choese;
            Console.WriteLine("                         baxer beit bo  caffettriakaman   ");
            Console.Write(" bezahmat zhnmaray mezakat daxl bka  : ");
            short mez = Convert.ToInt16(Console.ReadLine());
            do
            {
                Console.WriteLine("\n \n               menu caffetteria  :");
                Console.WriteLine("   liste dawakaryakan        |      price     ");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(" 1- Cha                      |      250 dinar ");
                Console.WriteLine(" 2- Qawa                     |      500 dinar ");
                Console.WriteLine(" 3- sher                     |     1000 dinar ");
                Console.WriteLine(" 4- chuklata                 |      500 dinar ");
                Console.WriteLine(" 5- niskafa                  |      500 dinar ");
                Console.WriteLine(" 6- nergla                   |   5,000 dinar  ");
                Console.WriteLine(" 7- nergla VIP               |   10,000 dinar ");
                Console.WriteLine(" 8- shiir moz                |    3,000 dinar ");
                Console.WriteLine("                0- hichm nawet \n");
                Console.WriteLine("T.B \\ tkaya dawakaryakant ba zhmara dabne  : ");

                string i = "";
                while (i != "n")
                {
                    Console.Write(" dawakaryakat britya la : ");
                    choese = Convert.ToInt16(Console.ReadLine());
                    if (choese < 0 || choese>8)
                    {
                        Console.WriteLine($"\n \n**  bbura  {choese}  la minuakay emada niia  \n");
                        continue;
                    }
                    if (choese == 0)
                    {
                        break;
                    }
                    Console.Write(" chand danat dawet  : ");
                    adad = Convert.ToInt16(Console.ReadLine());
                    Console.Write(" datawe bardawam bit la dawa krdn ?  bale (B) or any key   yan naxer (N)  :");
                    i = Console.ReadLine().ToLower();
                    switch (choese)
                    {
                        case 1:
                            koygshty += adad * 250;
                            cha += adad;
                            break;
                        case 2:
                            koygshty += adad * 500;
                            qawa += adad;
                            break;
                        case 3:
                            koygshty += adad * 1000;
                            shir += adad;
                            break;
                        case 4:
                            koygshty += adad * 500;
                            chuklata += adad;
                            break;
                        case 5:
                            koygshty += adad * 500;
                            niskafa += adad;
                            break;
                        case 6:
                            koygshty += adad * 5000;
                            nerla += adad;
                            break;
                        case 7:
                            koygshty += adad * 10000;
                            nerglav += adad;
                            break;
                        case 8:
                            koygshty += adad * 3000;
                            shirmoz += adad;
                            break;

                    
                    }
                    if (i == "n")
                    {
                        float dolar = koygshty / 1480f;
                        Console.WriteLine("  \n\n                      wasly paradan ");
                        Console.WriteLine("----------------------------------------------------------------- \n ");
                        Console.WriteLine(" ** mezy zhmara :   " + mez);
                        Console.WriteLine("\n-----------------------------------------------------------------");
                        Console.WriteLine("     list        |    nrx    |   adad   |     koy gshty \n---------------------------------------------------------------  ");
                        Console.WriteLine($"  1- cha         |    250    |   {cha,4}   |        {(cha * 250),5}   ");
                        Console.WriteLine($"  2- Qawa        |    500    |   {qawa,4}   |        {(qawa * 500),5}   ");
                        Console.WriteLine($"  3- niskafa     |    500    |   {niskafa,4}   |        {(niskafa * 500),5}   ");
                        Console.WriteLine($"  4- shir        |    1000   |   {shir,4}   |        {(shir * 1000),5}   ");
                        Console.WriteLine($"  5- chuklata    |    500    |   {chuklata,4}   |        {(chuklata * 500),5}   ");
                        Console.WriteLine($"  6- shir moz    |    500    |   {shirmoz,4}   |        {(shirmoz * 500),5}   ");
                        Console.WriteLine($"  7- nergla      |    5,000  |   {nerla,4}   |         {(nerla * 5000),5}   ");
                        Console.WriteLine($"  8- nergla VIP  |    10,000 |   {nerglav,4}   |        {(nerglav * 10000),5}\n   ");
                        Console.WriteLine("--------------------------------------------------------------------");
                        Console.WriteLine(" \n   koy gshty xarjyakn  britya la  : " + koygshty + " dinar" + "     ba dolar : " + (int)dolar + "$\n\n ");
                        break;
                    }

                }
                Console.Write(" aya hichy tert dawet  ? bale (B) OR no (N)  :");
                a = Console.ReadLine().ToLower();

            } while (a == "b");
            Console.WriteLine("\n                            ****************************** GOOD BAY ******************************  ");

        }
    }
}
