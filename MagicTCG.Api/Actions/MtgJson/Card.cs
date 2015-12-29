using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTcg.Api.Actions.MtgJson
{
    internal class Card : FileDownload
    {
        public Card(string downloadDirectory, bool includeExtras = false)
            : base(String.Empty, fileExtension: "json")
        {
            DownloadDirectory = downloadDirectory;
            IncludeExtras = includeExtras;

            FileName = $"AllCards{ExtrasCode}.{FileExtension}";
            DestinationUri = Path.Combine($"{DownloadDirectory}", $"_{FileName}");
            SourceUri = Path.Combine($"{Api.MtgJson.BaseApiUri}", $"{FileName}");
        }
    }
}
