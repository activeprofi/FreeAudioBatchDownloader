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
            throw new NotImplementedException();
        }

        public string HtmlCode { get; set; }

        public WebPage(string url)
        {
            Url = url;
        }
    }
}