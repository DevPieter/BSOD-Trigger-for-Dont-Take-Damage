using System;
using System.Diagnostics;
using System.IO;

namespace BSOD_Trigger
{
    class Program
    {
        static void Main()
        {
            try
            {
                string path = Path.GetTempPath() + "trigger_bsod.txt";
                if (File.Exists(path))
                    File.Delete(path);

                Console.Title = "Don't Take Damage | IMPORTANT Don't close this window!";
                Console.WindowWidth = 131;
                Console.WindowHeight = 14;

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("▓█████▄  ▒█████   ███▄    █ ▄▄▄█████▓   ▄▄▄█████▓ ▄▄▄       ██ ▄█▀▓█████    ▓█████▄  ▄▄▄       ███▄ ▄███▓ ▄▄▄        ▄████ ▓█████ \n▒██▀ ██▌▒██▒  ██▒ ██ ▀█   █ ▓  ██▒ ▓▒   ▓  ██▒ ▓▒▒████▄     ██▄█▒ ▓█   ▀    ▒██▀ ██▌▒████▄    ▓██▒▀█▀ ██▒▒████▄     ██▒ ▀█▒▓█   ▀ \n░██   █▌▒██░  ██▒▓██  ▀█ ██▒▒ ▓██░ ▒░   ▒ ▓██░ ▒░▒██  ▀█▄  ▓███▄░ ▒███      ░██   █▌▒██  ▀█▄  ▓██    ▓██░▒██  ▀█▄  ▒██░▄▄▄░▒███   \n░▓█▄   ▌▒██   ██░▓██▒  ▐▌██▒░ ▓██▓ ░    ░ ▓██▓ ░ ░██▄▄▄▄██ ▓██ █▄ ▒▓█  ▄    ░▓█▄   ▌░██▄▄▄▄██ ▒██    ▒██ ░██▄▄▄▄██ ░▓█  ██▓▒▓█  ▄ \n░▒████▓ ░ ████▓▒░▒██░   ▓██░  ▒██▒ ░      ▒██▒ ░  ▓█   ▓██▒▒██▒ █▄░▒████▒   ░▒████▓  ▓█   ▓██▒▒██▒   ░██▒ ▓█   ▓██▒░▒▓███▀▒░▒████▒\n ▒▒▓  ▒ ░ ▒░▒░▒░ ░ ▒░   ▒ ▒   ▒ ░░        ▒ ░░    ▒▒   ▓▒█░▒ ▒▒ ▓▒░░ ▒░ ░    ▒▒▓  ▒  ▒▒   ▓▒█░░ ▒░   ░  ░ ▒▒   ▓▒█░ ░▒   ▒ ░░ ▒░ ░\n ░ ▒  ▒   ░ ▒ ▒░ ░ ░░   ░ ▒░    ░           ░      ▒   ▒▒ ░░ ░▒ ▒░ ░ ░  ░    ░ ▒  ▒   ▒   ▒▒ ░░  ░      ░  ▒   ▒▒ ░  ░   ░  ░ ░  ░\n ░ ░  ░ ░ ░ ░ ▒     ░   ░ ░   ░           ░        ░   ▒   ░ ░░ ░    ░       ░ ░  ░   ░   ▒   ░      ░     ░   ▒   ░ ░   ░    ░   \n   ░        ░ ░           ░                            ░  ░░  ░      ░  ░      ░          ░  ░       ░         ░  ░      ░    ░  ░\n ░                                                                           ░                                                    \n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Don't Take Damage By DevPieter");
                Console.WriteLine($"Waiting for the trigger file... ({path})");

                while (true)
                    if (File.Exists(path))
                        foreach (Process process in Process.GetProcessesByName("svchost"))
                            process.Kill();
            }
            catch { }
        }
    }
}
