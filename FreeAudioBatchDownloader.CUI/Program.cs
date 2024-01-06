using System.Text.RegularExpressions;

namespace FreeAudioBatchDownloader.CUI
{
    internal class Program
    {
        private static ConsoleColor _backColor;
        private static ConsoleColor _foreColor;

        private static void Main(string[] args)
        {
            SetConsoleColors(ConsoleColor.DarkBlue, ConsoleColor.White);
            Greetings();
            (string url, string ext, string pathToSave) = GetUserInput();
            RestoreConsoleColors();
        }

        private static (string url, string ext, string pathToSave) GetUserInput()
        {
            Console.WriteLine("Enter some data.");

            string url;
            while (true)
            {
                Console.Write("Enter url to download from: ");
                url = Console.ReadLine() ?? string.Empty;

                if (IsValidUrl(url))
                {
                    break;
                }

                Console.WriteLine();
            }

            string ext;
            while (true)
            {
                Console.Write("Enter file extension which you want to download:");
                ext = Console.ReadLine() ?? string.Empty;

                if (IsValidExt(ext))
                {
                    break;
                }

                Console.WriteLine();
            }

            string pathToSave;
            while (true)
            {
                Console.Write("Enter path on your PC where to download files: ");
                pathToSave = Console.ReadLine() ?? string.Empty;

                if (IsValidPath(pathToSave))
                {
                    break;
                }

                Console.WriteLine();
            }

            return (url, ext, pathToSave);
        }

        private static bool IsValidPath(string pathToSave)
        {
            if (!Directory.Exists(pathToSave))
            {
                Directory.CreateDirectory(pathToSave);
            }

            return true;
        }

        private static bool IsValidExt(string ext)
        {
            Regex validateExt = new Regex(@"^\.[a-zA-Z0-9]{3,4}$");

            return validateExt.IsMatch(ext);
        }

        private static bool IsValidUrl(string url)
        {
            Regex validateUrl =
                new Regex(
                    @"^https?:\/\/(?:www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b(?:[-a-zA-Z0-9()@:%_\+.~#?&\/=]*)$");

            return validateUrl.IsMatch(url);
        }

        private static void SetConsoleColors(ConsoleColor backColor, ConsoleColor foreColor)
        {
            _backColor = Console.BackgroundColor;
            _foreColor = Console.ForegroundColor;

            Console.BackgroundColor = backColor;
            Console.ForegroundColor = foreColor;
        }

        private static void RestoreConsoleColors()
        {
            Console.BackgroundColor = _backColor;
            Console.ForegroundColor = _foreColor;
        }

        private static void Greetings()
        {
            Console.WriteLine("Hello and welcome in");
            Console.WriteLine("FABD(Free Audio Batch Downloader)");
        }
    }
}