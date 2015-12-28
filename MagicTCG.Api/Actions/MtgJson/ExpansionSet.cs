using System;
using System.IO;

namespace MagicTcg.Api.Actions.MtgJson
{
    internal class ExpansionSet : FileDownload
    {
        private readonly bool _includeExtras;
        protected string ExtrasFileCode => (_includeExtras) ? "-x" : String.Empty;

        public string ExpansionSetCode { get; protected set; }


        public ExpansionSet(string expansionSetCode, string downloadDirectory, bool includeExtras = false)
            : base(String.Empty, fileExtension: "json")
        {
            ExpansionSetCode = expansionSetCode;
            DownloadDirectory = downloadDirectory;
            _includeExtras = includeExtras;

            FileName = $"_{ExpansionSetCode}{ExtrasFileCode}.json";
            DestinationUri = Path.Combine($"{DownloadDirectory}", $"{FileName}");
            SourceUri = Path.Combine($"{Api.MtgJson.BaseApiUri}", $"_{FileName}");
        }
    }
}
