namespace FreeAudioBatchDownloader.Model
{
    public class WebPage
    {
        private readonly object _lockObject = new();

        public WebPage(string url)
        {
            Url = url;
        }

        private string _url;

        public string Url
        {
            get => _url;
            set
            {
                _url = value;
                HtmlCode = DownloadHtml();
            }
        }

        public string HtmlCode { get; private set; }

        private string DownloadHtml()
        {
            var htmlCode = String.Empty;
            Thread thread = new(() =>
            {
                HttpClient httpClient = new();
                lock (_lockObject)
                {
                    htmlCode = httpClient.GetStringAsync(Url).Result;
                }
            });

            thread.Start();
            thread.Join();

            return htmlCode;
        }
    }
}