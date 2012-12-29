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
            //la place ou les éléments sont display... distance depuis le bord gauche de la console
            int infoLeft = 29;

            //méthode pour dessiner l'ASCII ART de l'OS (en couleur!)
            DrawOs();

            //je déplace le curseur pour écrire les propriétés utilisateur et OS (pour l'instant!)
            Console.SetCursorPosition(infoLeft, 2);
            WriteUser();
            Console.SetCursorPosition(infoLeft, 3);
            WriteOS();

            //retour à la case départ
            Console.SetCursorPosition(0, 22);
            Console.ReadKey(true);
        }

        private static void WriteOS()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("OS: ");
            Console.ResetColor();

            //j'utilise une classe que jai pris su internet pour facilement printer le nom de l'OS
            Console.Write(OSVersionInfo.Name);
        }

        private static void WriteUser()
        {
            //jme poigne les infos utilisateur via windowsidentity sous la forme MACHINE_NAME\USER_NAME
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            //je trouve la place ou est le "\" dans le string
            int sepindex = userName.IndexOf('\\');

            //je sépare l'username et le nom de la machine par rapport au "\"
            string machine = userName.Substring(0, sepindex).ToLower();
            string user = userName.Substring(sepindex + 1).ToLower();

            //Output the whole thing
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(user);
            Console.ResetColor();
            Console.Write('@');
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(machine);
            Console.ResetColor();
        }

        private static void DrawOs()
        {
            //le carré en haut a gauche
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
