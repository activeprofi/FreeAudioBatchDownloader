namespace FreeAudioBatchDownloader.CUI
{
    internal class Program
    {
        private static ConsoleColor backColor;
        private static ConsoleColor foreColor;

        static void Main(string[] args)
        {
            SetConsoleColors(ConsoleColor.DarkBlue, ConsoleColor.White);
            Greetings();
            RestoreConsoleColors();
        }

        private static void SetConsoleColors(ConsoleColor backColor, ConsoleColor foreColor)
        {
            Program.backColor = Console.BackgroundColor;
            Program.foreColor = Console.ForegroundColor;

            Console.BackgroundColor = backColor;
            Console.ForegroundColor = foreColor;
        }

        private static void RestoreConsoleColors()
        {
            Console.BackgroundColor = backColor;
            Console.ForegroundColor = foreColor;
        }

        static void Greetings()
        {
            Console.WriteLine("Hello and welcome in");
            Console.WriteLine("FABD(Free Audio Batch Downloader)");
        }
    }
}
