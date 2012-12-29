using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFetch
{
    class Program
    {
        static void Main(string[] args)
        {
            int infoLeft = 29;
            DrawOs();
            Console.SetCursorPosition(infoLeft, 2);
            WriteUser();
        }

        private static void WriteUser()
        {
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            userName = userName.Replace('\\', '@');
            Console.Write(userName);
            Console.ReadKey(true);
        }

        private static void DrawOs()
        {
            //top left
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(0, 0);
            Console.Write(@"       #####
     #########
     #########
    ##########
    ##########
    #########
    #########
   ##########
   #### ####
           #");
            //top right
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(14, 2);
            Console.Write(" #");
            Console.SetCursorPosition(14, 3);
            Console.Write(" ###     ##");
            Console.SetCursorPosition(14, 4);
            Console.Write(" ##########");
            Console.SetCursorPosition(13, 5);
            Console.Write(" ##########");
            Console.SetCursorPosition(13, 6);
            Console.Write(" ##########");
            Console.SetCursorPosition(13, 7);
            Console.Write(" ##########");
            Console.SetCursorPosition(12, 8);
            Console.Write(" ##########");
            Console.SetCursorPosition(12, 9);
            Console.Write(" ##########");
            Console.SetCursorPosition(11, 10);
            Console.Write("  ##########");
            Console.SetCursorPosition(12, 11);
            Console.Write("  ########");
            //bottom left
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(0, 10);
            Console.Write(@"   ########
  ##########
  #########
  #########
 ##########
 #########
 #########
##########
##     ##");
            //bottom right
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(11, 12);
            Console.Write(" ##");
            Console.SetCursorPosition(11, 13);
            Console.Write(" ##########");
            Console.SetCursorPosition(11, 14);
            Console.Write(" ##########");
            Console.SetCursorPosition(10, 15);
            Console.Write(" ##########");
            Console.SetCursorPosition(10, 16);
            Console.Write(" ##########");
            Console.SetCursorPosition(10, 17);
            Console.Write(" ##########");
            Console.SetCursorPosition(9, 18);
            Console.Write(" ###########");
            Console.SetCursorPosition(9, 19);
            Console.Write(" ##########");
            Console.SetCursorPosition(10, 20);
            Console.Write(" #########");
            Console.SetCursorPosition(12, 21);
            Console.Write(" #####");
            Console.ResetColor();
        }
    }
}
