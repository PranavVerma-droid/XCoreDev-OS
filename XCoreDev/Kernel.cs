using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Text;
using Sys = Cosmos.System;

namespace XCoreDev
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {


             
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            //Console.WriteLine("");
            
            
            
            Console.WriteLine("XCoreDevOS CLI booted successfully. Made by PranavVerma-droid.");
            Console.WriteLine("https://github.com/PranavVerma-droid");
            
            Console.WriteLine("");

            Console.WriteLine("Run 'help' for help.");
            Console.WriteLine("There are some hidden easter eggs! See if you can find them!");
            
            Console.WriteLine("");

        }
        
        protected override void Run()
        {
            
            
            string input = "";

            Console.Write("root$XCoreDev> ");
            input = Console.ReadLine();
            HandleThisCommand(input);
            


            /*Console.Write("Input: ");
            var input = Console.ReadLine();
            Console.Write("Text typed: ");
            Console.WriteLine(input);*/
            //Console.BackgroundColor = ConsoleColor.Yellow;
            //Sys.Network.IPv4.Address.
        }


        private void HandleThisCommand(string input)
        {
            //int counter1;
            if (input == "help")
            {
                Console.WriteLine("");
                Console.WriteLine("help -- shows this menu");
                Console.WriteLine("info -- shows the build info");
                Console.WriteLine("build -- shows the build number");
                Console.WriteLine("shutdown -- shuts the system down");
                Console.WriteLine("reboot -- reboots the system");
                Console.WriteLine("checksumdata -- see the checksum data");
                Console.WriteLine("boot -- boots into the OS");
                Console.WriteLine("consolecolor[parameter] -- changes the console color");
                Console.WriteLine("clear -- clears the console");
                Console.WriteLine("this is stupid -- idk what this does xD");
                Console.WriteLine("beep -- Beeps the console");
                Console.WriteLine("");
                //Console.WriteLine();
            }

            else if (input == "info")
            {
                //Console.WriteLine($"{Sys.Global.}")
                Console.WriteLine("");
                Console.WriteLine("Made by Pranav Verma");
                Console.WriteLine("https://github.com/PranavVerma-droid");
                Console.WriteLine("");
            }
            else if (input == "build")
            {
                Console.WriteLine("");
                Console.WriteLine("XCoreDev V1.0.0");
                Console.WriteLine("P.S - This Name is Stupid! I came up w/ this at 2am! give me some slack pls xD");
                Console.WriteLine("");

            }
            else if (input == "shutdown")
            {
                Console.WriteLine("Shutting Down!");
                Sys.Power.Shutdown();
            }
            else if (input == "reboot")
            {
                Sys.Power.Reboot();
            }
            else if (input == "fuck")
            {
                Console.WriteLine("");
                Console.WriteLine("Ayye! Stop Swearing!");
                Console.WriteLine("");
            }
            else if (input == "shit")
            {
                Console.WriteLine("");
                Console.WriteLine("Ayye! Stop Swearing!");
                Console.WriteLine("");
            }
            else if (input == "piss")
            {
                Console.WriteLine("");
                Console.WriteLine("Ayye! Stop Swearing! NOT PISS PLS");
                Console.WriteLine("");
            }
            else if (input == "ass")
            {
                Console.WriteLine("");
                Console.WriteLine("Ayye! Stop Swearing! NOT PISS PLS");
                Console.WriteLine("");
            }
            else if (input == "checksumdata")
            {
                Console.WriteLine("");
                Console.WriteLine("SHA512 32dceb94ca6b2445ec39802d7bb962e2d389801609ffb6706925539380fcb9c9ed75b932daae734ea8d5189d34c956494f50648d3dc3e292392607360bb47f35");
                Console.WriteLine("");
            }
            else if (input == "boot")
            {
                Console.WriteLine("");
                Console.WriteLine("Booting into XCoreDev.....");
                Console.Beep();
                Console.WriteLine("Nah! i dont feel Like booting yet xD");
                Console.WriteLine("");
            }


            else if (input == "consolecolorgreen")
            {
                Console.WriteLine("");
                Console.WriteLine("Console Color Changed to GREEN");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("");
            }
            else if (input == "consolecolorwhite")
            {
                Console.WriteLine("");
                Console.WriteLine("Console Color Changed to WHITE");
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("");
            }
            else if (input == "consolecoloryellow")
            {
                Console.WriteLine("");
                Console.WriteLine("Console Color Changed to YELLOW");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("");
            }
            else if (input == "consolecolorblack")
            {
                Console.WriteLine("");
                Console.WriteLine("Console Color Changed to BLACK");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("");
            }
            else if (input == "consolecolorcyan")
            {
                Console.WriteLine("");
                Console.WriteLine("Console Color Changed to CYAN");
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine("");
            }
            else if (input == "consolecolorblue")
            {
                Console.WriteLine("");
                Console.WriteLine("Console Color Changed to BLUE");
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("");
            }
            else if (input == "consolecolormagenta")
            {
                Console.WriteLine("");
                Console.WriteLine("Console Color Changed to MAGENTA");
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.WriteLine("");
            }
            else if (input == "consolecolorgray")
            {
                Console.WriteLine("");
                Console.WriteLine("Console Color Changed to GRAY");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine("");
            }
            else if (input == "consolecolorred")
            {
                Console.WriteLine("");
                Console.WriteLine("Console Color Changed to RED");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("");
            }

            else if (input == "clear")
            {
                Console.Clear();

            }
            else if (input == "") {
                Console.WriteLine("");
                Console.WriteLine("No Command Entered.");
                Console.Beep();
                Console.WriteLine("");
            }
            else if (input == "this is stupid")
            {
                Console.WriteLine("ME ANGRY >:(");
                Sys.Power.Shutdown();
            }
            else if (input == "beep")
            {
                Console.WriteLine("");
                Console.WriteLine("Beeping the Console");
                Console.WriteLine("");
                Console.Beep();
            }



            else
            {
                Console.WriteLine("");
                Console.WriteLine("Not a valid command.");
                Console.Beep();
                Console.WriteLine("");
            }
            

            /*if (counter1 != 10)
            {
                Console.WriteLine("Ayye! Stop Swearing!");
                counter1++;
            }
            else
            {
                Console.WriteLine("Ayye! Thats Enough!");
                counter1 = 0;
            }*/






        }

        
    }
}
