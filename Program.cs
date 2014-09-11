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

            // Skaffar indata


            {


                Console.Write("Ange totalsumma     : ");
                total = double.Parse(Console.ReadLine());
                if (total < 0.51)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Totalsumman är för liten");
                    Console.ResetColor();
                     
                }
                else
                {


                    while (true)
                    {
                        try
                        {
                            Console.Write("Ange erhållet belopp: ");
                            recieved = uint.Parse(Console.ReadLine());
                            cash = recieved;

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
                        //Presenterar kvitto

                        Console.WriteLine("KVITTO");

                        Console.WriteLine("-------------------------------------------------");

                        Console.WriteLine("Totalt        : {0:c} ", total);
                        recieved = (uint)Math.Round(total);
                        roundingOffAmount = recieved - total;



                        Console.WriteLine("Öresavrundning: {0:c} ", roundingOffAmount);

                        Console.WriteLine("Att betala    : {0:c} ", recieved - (uint)roundingOffAmount);


                        Console.WriteLine("Kontant       : {0:c}", cash);


                        Console.WriteLine("Tillbaka      : {0:c}", cash - (uint)Math.Round(total));

                        Console.WriteLine("-------------------------------------------------");

                    }



                }
            }
        }
    }
}
        
    


    


    

