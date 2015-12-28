using System.Net;

namespace MagicTcg.Api.Actions
{
    internal abstract class FileDownload
    {
        protected readonly string ApiRoute;
        protected readonly string FileExtension;

        protected string DownloadDirectory { get; set; }
        protected string FileName { get; set; }
        protected string SourceUri { get; set; }
        protected string DestinationUri { get; set; }


        protected FileDownload(string apiRoute, string fileExtension = "jpg")
        {
            ApiRoute = apiRoute;
            FileExtension = fileExtension;
        }

        public void Download()
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(SourceUri, DestinationUri);
            }
        }
    }
}
