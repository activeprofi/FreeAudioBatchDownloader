namespace FreeAudioBatchDownloader.Model
{
    public class WebPage
    {
        public string URL { get; init; }
        public string HtmlCode { get; set; }

        public WebPage(string url)
        {
            URL = url;
        }
    }
}
