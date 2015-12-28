using System.IO;

namespace MagicTcg.Api.Actions.Gatherer
{
    internal class ExpansionSetImage : FileDownload
    {
        protected ExpansionSetSymbolRarity Rarity;
        public string ExpansionSetCode { get; protected set; }

        public ExpansionSetImage(string fileName, string downloadDirectory, ExpansionSetSymbolRarity rarity)
            : base($"Image.ashx?type=symbol&set={fileName}&size=small&rarity={rarity.ToCode()}")
        {
            ExpansionSetCode = fileName;
            DownloadDirectory = downloadDirectory;
            Rarity = rarity;

            FileName = $"{Rarity.ToCode()}.{FileExtension}";
            DestinationUri = Path.Combine($"{DownloadDirectory}", $"{ExpansionSetCode}", $"{FileName}");
            SourceUri = Path.Combine($"{Api.Gatherer.BaseApiUri}", $"{ApiRoute}");
        }
    }
}
