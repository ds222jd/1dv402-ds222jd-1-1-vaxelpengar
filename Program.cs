using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Växelpengar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarerar variabler
            double total;
            uint recieved;
            double roundingOffAmount;
            uint cash;

             {
                // Skaffar indata från användaren.

                Console.Write("Ange totalsumma     : ");
                total = double.Parse(Console.ReadLine());
                if (total < 1)
                {
                   // Felmeddelande ifall användaren matar in en för liten summa.
                    
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Totalsumman är för liten");
                    Console.ResetColor();
                    return;
                }
                else
                {

                    // Skapar en while loop för att ge användaren nya chanser om man matar in text istället för siffror
                    while (true)
                    {
                        //Fångar upp fel med try catch.
                        try
                        {
                            Console.Write("Ange erhållet belopp: ");
                            recieved = uint.Parse(Console.ReadLine());
                            cash = recieved;
                            if (recieved < total)
                            {
                                //Felmeddelande ifall mottaget belopp är för litet.

                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Erhållet belopp är för litet. Köpet kunde inte genomföras");
                                Console.ResetColor();


                                return;
                            }
                            else
                            {

                            }

                            break;

                        }
                        catch
                        {

                            //felmeddelande

                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Erhållet belopp felaktigt");
                            Console.ResetColor();

           }
            }
             {
               {
                 }

                        //Beräknar erhållen data.

                        recieved = (uint)Math.Round(total); 
                        roundingOffAmount = recieved - total; //Öresavrundningen
                        uint payback;
                        payback = cash - (uint)total;




                        //Presenterar kvitto
                        
                        Console.WriteLine("");
                        Console.WriteLine("KVITTO");

                        Console.WriteLine("----------------------------------");

                        Console.WriteLine("Totalt           :{0,12:c}", total);


                        Console.WriteLine("Öresavrundning   :{0,12:c}", roundingOffAmount);

                        Console.WriteLine("Att betala       :{0,12:c}", recieved - (uint)roundingOffAmount);


                        Console.WriteLine("Kontant          :{0,12:c}", cash);


                        Console.WriteLine("Tillbaka         :{0,12:c}", payback);

                        Console.WriteLine("----------------------------------");

                       {

                           {
                               //En tom rad i consolen för att separera kvitto och sedlar/mynt tillbaka
                               Console.WriteLine("");





                               // Variabler för division och modolusoperatorn, för presentation av kvitto.

                               uint fiveHundred = payback / 500;
                               uint left = payback % 500;
                              
                               uint hundred = left / 100;
                               left = left % 100;
                              
                               uint fifty = left / 50;
                               left = left % 50;
                              
                               uint twenty = left / 20;
                               left = left % 20;
                              
                               uint ten = left / 10;
                               left = left % 10;
                              
                               uint five = left / 5;
                               left = left % 5;
                              
                               uint one = left;





                               // Omsluter alla sedlar med en if sats för att enbart visa ett värde högre än 0.

                               if (fiveHundred > 0)
                               {
                                   Console.WriteLine(" 500-lappar      :{0,2}", fiveHundred);
                               }




                               if (hundred > 0)
                               {
                                   Console.WriteLine(" 100-lappar      :{0,2}", hundred);
                               }




                               if (fifty > 0)
                               {
                                   Console.WriteLine("  50-lappar      :{0,2}", fifty);
                               }





                               if (twenty > 0)
                               {
                                   Console.WriteLine("  20-lappar      :{0,2}", twenty);
                               }



                               if (ten > 0)
                               {
                                   Console.WriteLine("  10-kronor      :{0,2}", ten);
                               }




                               if (five > 0)
                               {
                                   Console.WriteLine("   5-kronor      :{0,2}", five);
                               }




                               if (one > 0)
                               {
                                   Console.WriteLine("   1-kronor      :{0,2}", one);
                               }

                               return;
                               {

                               }
                           }


                        }
                    }
                }
            }
        }
    }
}
        
    


    


    

