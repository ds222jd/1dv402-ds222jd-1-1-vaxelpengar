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
            // Deklarerar variableer
            double total;
            uint recieved;
            double roundingOffAmount;
            uint cash;

            


            {
                // Skaffar indata från användarens tangentbord

                Console.Write("Ange totalsumma     : ");
                total = double.Parse(Console.ReadLine());
                if (total < 1)
                {
                   //Felmeddelande 
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Totalsumman är för liten");
                    Console.ResetColor();

                }
                else
                {

                    // Skapar en while loop för att ge användaren nya chanser om man matar in text istället för siffror
                    while (true)
                    {
                      //Fångar upp fel med try catch
                        try
                        {
                            Console.Write("Ange erhållet belopp: ");
                            recieved = uint.Parse(Console.ReadLine());
                            cash = recieved;
                            if (recieved < total)
                            {
                               //Felmeddelande 
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

                        //Räknar om variablerna

                        recieved = (uint)Math.Round(total);
                        roundingOffAmount = recieved - total;
                        uint payback;
                        payback = cash - (uint)total;




                        //Presenterar kvitto
                        Console.WriteLine("");
                        Console.WriteLine("KVITTO");

                        Console.WriteLine("----------------------------------");

                        Console.WriteLine("Totalt           :       {0:c}", total);


                        Console.WriteLine("Öresavrundning   :        {0:c}", roundingOffAmount);

                        Console.WriteLine("Att betala       :       {0:c}", recieved - (uint)roundingOffAmount);


                        Console.WriteLine("Kontant          :     {0:c}", cash);


                        Console.WriteLine("Tillbaka         :       {0:c}", payback);

                        Console.WriteLine("----------------------------------");





                        






                        {

                           

                            {
                                
                                Console.WriteLine("");

                           // Presenterar sedlar/mynt som ska ges tillbaka i växel.

                               
                                // Variabler för division och modolusoperatorn.

                                uint value;
                                uint left;

                           // Beräknar sedlar/mynt tillbaka genom att dividera 500 och ge ett värde till left som kan användas på nästa sedel/mynt och upprepar detta ända ner till 1.      
                                    value = payback / 500;
                                    left = payback % 500;
                                
                                // Omsluter alla sedlar med en if sats för att enbart visa ett värde högre än 0.
                                    if (value > 0)
                                    {
                                        Console.WriteLine(" 500-lappar      :{0,2}", value); 
                                    }




                                    value = left / 100;
                                    left = payback % 100;

                                    if (value > 0)
                                    {
                                        Console.WriteLine(" 100-lappar      :{0,2}", value);  
                                    }







                                    value = left / 50;
                                    left = payback % 50;

                                    if (value > 0)
                                    {
                                        Console.WriteLine("  50-lappar      :{0,2}", value);  
                                    }
                               




                              
                                
                                    value = left / 20;
                                    left = payback % 20;

                                    if (value > 0)
                                    {
                                        Console.WriteLine("  20-lappar      :{0,2}", value);  
                                    }







                                    value = left / 10;
                                    left = payback % 10;

                                    if (value > 0)
                                    {
                                        Console.WriteLine("  10-kronor      :{0,2}", value); 
                                    }
                                




                               
                                
                                    value = left / 5;
                                    left = payback % 5;

                                    if (value > 0)
                                    {
                                        Console.WriteLine("   5-kronor      :{0,2}", value);  
                                    }
                                




                                
                               
                                    value = left / 1;
                                    left = payback % 1;

                                    if (value > 0)
                                    {
                                        Console.WriteLine("   1-kronor      :{0,2}", value);  
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
        
    


    


    

