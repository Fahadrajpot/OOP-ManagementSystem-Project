using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectConsoleBased
{
    internal class ConsoleUtility
    {
        public static void PrintMenu()
        {
            Console.WriteLine(" ###########################################################################################################################################################");
            Console.WriteLine(" #                                                                                                                                                         #");
            Console.Write(" #                                        ");

            Console.Write("____  __     __   ____  __  ____  ____     ___  _  _  __  ____  __  __ _  ____");

            Console.WriteLine("                                   #");
            Console.Write(" #                                       ");

            Console.Write("(  __)/   \\  /   \\(    \\(  )(  __)/ ___)   / __)/ )( \\(  )/ ___)(  )(  ( \\(  __)");

            Console.WriteLine("                                  #");
            Console.Write(" #                                        ");

            Console.Write(") _)(  O  )(  O  )) D ( )(  ) _) \\___ \\  ( (__ ) \\/ ( )( \\___ \\ )( /    / ) _)");

            Console.WriteLine("                                   #");
            Console.Write(" #                                       ");

            Console.Write("(__)  \\ __/  \\ __/(____/(__)(____)(____/   \\___)\\ __ /(__)(____/(__)\\_)__)(____)");

            Console.WriteLine("                                  #");
            Console.WriteLine(" #                                                                                                                                                         #");
            Console.WriteLine(" #                                                                                                                                                         #");
            Console.WriteLine(" ###########################################################################################################################################################");
            Console.WriteLine();
            Console.WriteLine();
        }
        public static int PrintMain()
        {
            Console.WriteLine("1. Sign Up");
            Console.WriteLine("2. Sign In");
            Console.WriteLine("3. Exit");
            Console.Write("Enter an option to continue...");
            int Option = int.Parse(Console.ReadLine());
            return Option;
        }
        public static void ContinueStatement()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
