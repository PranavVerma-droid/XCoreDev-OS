using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Sys = Cosmos.System;

namespace XCoreDev
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {

            Console.WriteLine("");
            Console.WriteLine("");
            
            
            Console.WriteLine("XCoreDev booted successfully. Made by PranavVerma-droid.");
            Console.WriteLine("https://github.com/PranavVerma-droid");
            
            Console.WriteLine("");

            Console.WriteLine("Run 'Help' for help.");
            Console.WriteLine("There are some hidden easter eggs! See if you can find them");
        }

        protected override void Run()
        {
            string input = "";

            input = Console.ReadLine();
            HandleCommand(input);
            
            
            
            /*Console.Write("Input: ");
            var input = Console.ReadLine();
            Console.Write("Text typed: ");
            Console.WriteLine(input);*/
        }

        public static object HandleCommand(string input)
        {
            if (input == "help")
            {
                Console.WriteLine("help -- shows this menu");
                Console.WriteLine("info -- shows the build info");
                Console.WriteLine("build -- shows the build number");
                Console.WriteLine("shutdown -- shuts the system down");
                Console.WriteLine("reboot -- reboots the system");
                Console.WriteLine("info -- shows the build info");
                //Console.WriteLine();
            }

            else if (input == "info")
            {
                //Console.WriteLine($"{Sys.Global.}")
                Console.WriteLine("Made by Pranav Verma");
            }
            else if (input == "build") {
                Console.WriteLine("XCoreDev V1.0.0");

            }
            else if (input == "shutdown")
            {
                Console.WriteLine("Shutting Down!");

                //System.Threading.Thread.Sleep(5000);
                Sys.Power.Shutdown();
            }
            else if (input == "reboot")
            {
                Sys.Power.Reboot();
            }


            else {
                Console.WriteLine("Not a valid command.");
            }
        }
    }
}
