using System;
using System.IO;

namespace MagicTcg.Api.Actions.MtgJson
{
    internal class ExpansionSet : FileDownload
    {
        public string ExpansionSetCode { get; protected set; }


        public ExpansionSet(string expansionSetCode, string downloadDirectory, bool includeExtras = false)
            : base(String.Empty, fileExtension: "json")
        {
            ExpansionSetCode = expansionSetCode;
            DownloadDirectory = downloadDirectory;
            IncludeExtras = includeExtras;

            FileName = $"{ExpansionSetCode}{ExtrasCode}.{FileExtension}";
            DestinationUri = Path.Combine($"{DownloadDirectory}", $"_{FileName}");
            SourceUri = Path.Combine($"{Api.MtgJson.BaseApiUri}", $"{FileName}");
        }
    }
}
