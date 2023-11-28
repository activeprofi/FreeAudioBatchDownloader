namespace FreeAudioBatchDownloader.Model
{
    public class WebPage
    {
        private string _url;

        public string Url
        {
            get => _url;
            set
            {
                _url = value;
                HtmlCode = DownloadPageHtml();
            }
        }

        private string DownloadPageHtml()
        {
            HttpClient httpClient = new HttpClient();
            string htmlCode = httpClient.GetStringAsync(Url).Result;

            return htmlCode;
        }

        public string HtmlCode { get; private set; }

        public WebPage(string url)
        {
            Url = url;
        }
    }
}