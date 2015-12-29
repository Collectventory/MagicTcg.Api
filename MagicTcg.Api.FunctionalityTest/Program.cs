using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTcg.Api.FunctionalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var mtgJson = new MtgJson();

            mtgJson.DownloadExpansionSet("SHM", @"C:/CardDownloads");
            mtgJson.DownloadExpansionSet("CON", @"C:/CardDownloads");
            mtgJson.DownloadExpansionSet("WWK", @"C:/CardDownloads");

            mtgJson.DownloadAllExpansions(@"C:\CardDownloads");
            mtgJson.DownloadAllExpansions(@"C:\CardDownloads", true);
        }
    }
}
