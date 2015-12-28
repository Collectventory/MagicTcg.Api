using System.IO;

namespace MagicTcg.Api.Actions.Gatherer
{
    internal class CardImage : FileDownload
    {
        protected string ImageName { get; set; }

        public CardImage(string fileName, string downloadDirectory)
            : base($"Image.ashx?multiverseid={fileName}&type=card")
        {
            ImageName = fileName;
            DownloadDirectory = downloadDirectory;

            FileName = $"{ImageName}.{FileExtension}";
            DestinationUri = Path.Combine($"{DownloadDirectory}", $"{FileName}");
            SourceUri = Path.Combine($"{Api.Gatherer.BaseApiUri}", $"{ApiRoute}");
        }
    }
}
