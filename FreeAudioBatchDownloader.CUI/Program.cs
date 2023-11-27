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
            RestoreConsoleColors();
        }

        private static void SetConsoleColors(ConsoleColor backColor, ConsoleColor foreColor)
        {
            Program._backColor = Console.BackgroundColor;
            Program._foreColor = Console.ForegroundColor;

            Console.BackgroundColor = backColor;
            Console.ForegroundColor = foreColor;
        }

        private static void RestoreConsoleColors()
        {
            Console.BackgroundColor = _backColor;
            Console.ForegroundColor = _foreColor;
        }

        static void Greetings()
        {
            Console.WriteLine("Hello and welcome in");
            Console.WriteLine("FABD(Free Audio Batch Downloader)");
        }
    }
}
