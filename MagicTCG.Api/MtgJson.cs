using System;
using MagicTcg.Api.Actions.MtgJson;

namespace MagicTcg.Api
{
    public class MtgJson
    {
        /// <summary>
        /// The base Api path for MtgJson at mtgjson.com.
        /// </summary>
        public const string BaseApiUri = @"http://mtgjson.com/json/";

        /// <summary>
        /// Downloads the card image for the provided <paramref name="expansionSetCode">multiverseID</paramref> as a.jpg image
        /// to the provided <paramref name="downloadDirectory">downloadDirectory</paramref>.
        /// 
        /// The downloaded file's name will be "<paramref name="expansionSetCode">multiverseID</paramref>.jpg".
        /// <example>
        /// <code>
        /// /* Downloads a the 1011 card image to the C://CardImages directory */
        /// var gatherer = new MtgJson();
        /// gatherer.DownloadExpansionSet("SHM", @"C:/CardImages", true);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="expansionSetCode">The multiverseID of the card you would like the image of.</param>
        /// <param name="downloadDirectory">The directory to save the downloaded image in.</param>
        /// <param name="includeExtras">Indicates if the extras should be included in the download</param>
        public void DownloadExpansionSet(string expansionSetCode, string downloadDirectory, bool includeExtras = false)
        {
            if (String.IsNullOrEmpty(expansionSetCode)) return;

            var download = new ExpansionSet(expansionSetCode, downloadDirectory, includeExtras);
            download.Download();
        }


        /// <summary>
        /// Downloads the card image for the provided <paramref name="expansionSetCode">multiverseID</paramref> as a.jpg image
        /// to the provided <paramref name="downloadDirectory">downloadDirectory</paramref>.
        /// 
        /// The downloaded file's name will be "<paramref name="expansionSetCode">multiverseID</paramref>.jpg".
        /// <example>
        /// <code>
        /// /* Downloads a the 1011 card image to the C://CardImages directory */
        /// var gatherer = new MtgJson();
        /// gatherer.DownloadExpansionSet("SHM", @"C:/CardImages", true);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="downloadDirectory">The directory to save the downloaded file</param>
        /// <param name="includeExtras">Indicates if the extras should be included in the download</param>
        public void DownloadAllExpansions(string downloadDirectory, bool includeExtras = false)
        {
            DownloadExpansionSet("AllSets", downloadDirectory, includeExtras);
        }


        public void DownloadAllCards(string downloadDirectory, bool includeExtras = false)
        {
            var download = new Card(downloadDirectory, includeExtras);
            download.Download();
        }
    }
}
