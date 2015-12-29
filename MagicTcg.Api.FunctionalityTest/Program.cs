using System;
using System.Collections.Generic;
using System.IO;
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

            var downloadDirectory = Path.GetTempPath();

            mtgJson.DownloadExpansionSet("SHM", downloadDirectory);
            mtgJson.DownloadExpansionSet("CON", downloadDirectory);
            mtgJson.DownloadExpansionSet("WWK", downloadDirectory);

            mtgJson.DownloadAllExpansions(downloadDirectory);
            mtgJson.DownloadAllExpansions(downloadDirectory, true);
        }
    }
}
