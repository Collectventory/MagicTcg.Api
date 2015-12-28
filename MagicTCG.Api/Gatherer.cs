using MagicTcg.Api.Actions.Gatherer;

namespace MagicTcg.Api
{
    public class Gatherer
    {
        /// <summary>
        /// The base Api path for the Gatherer at Wizards.com.
        /// </summary>
        public const string BaseApiUri = @"http://gatherer.wizards.com/Handlers/";

        /// <summary>
        /// Downloads the card image for the provided <paramref name="multiverseID">multiverseID</paramref> as a.jpg image
        /// to the provided <paramref name="downloadDirectory">downloadDirectory</paramref>.
        /// 
        /// The downloaded file's name will be "<paramref name="multiverseID">multiverseID</paramref>.jpg".
        /// <example>
        /// <code>
        /// /* Downloads a the 1011 card image to the C://CardImages directory */
        /// var gatherer = new Gatherer();
        /// gatherer.DownloadCardImage(1011, @"C:/CardImages");
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="multiverseID">The multiverseID of the card you would like the image of.</param>
        /// <param name="downloadDirectory">The directory to save the downloaded image in.</param>
        public void DownloadCardImage(int multiverseID, string downloadDirectory)
        {
            if (multiverseID < 1) return;

            var download = new CardImage(multiverseID.ToString(), downloadDirectory);
            download.Download();
        }


        /// <summary>
        /// Downloads the expansion set symbol for the provided <paramref name="expansionSetCode">Expansion Set Code</paramref>
        /// as a.jpg image to a subdirectory with the name of the set <paramref name="expansionSetCode">Expansion Set Code</paramref>
        /// in the provided <paramref name="downloadDirectory">Download Directory</paramref> for all possible
        /// different rarities.
        /// 
        /// The downloaded file's name will be the RarityCode.jpg" for each rarity.
        /// 
        /// <example>
        /// <code>
        /// /* Downloads a the 1011 card image to the C://CardImages//SHM directory */
        /// var gatherer = new Gatherer();
        /// gatherer.DownloadExpansionSetSymbol("SHM", @"C:/CardImages", ExpansionSetSymbolRarity.Rare);
        /// /* The file downloaded is R.jpg */
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="expansionSetCode">The Expansion Set Code of the card you would like the expansion set images of.</param>
        /// <param name="downloadDirectory">The base directory to save the downloaded images in.</param>
        /// <param name="rarity">The rarity version of the symbol to download.</param>
        public void DownloadExpansionSetSymbol(string expansionSetCode, string downloadDirectory, ExpansionSetSymbolRarity rarity)
        {
            var imageDownload = new ExpansionSetImage(expansionSetCode, downloadDirectory, rarity);
            imageDownload.Download();
        }


        /// <summary>
        /// Downloads the expansion set symbol for the provided <paramref name="expansionSetCode">Expansion Set Code</paramref>
        /// as a.jpg image to a subdirectory with the name of the set <paramref name="expansionSetCode">Expansion Set Code</paramref>
        /// in the provided <paramref name="downloadDirectory">Download Directory</paramref> for all possible
        /// different rarities.
        /// 
        /// The downloaded file's name will be the RarityCode.jpg" for each rarity.
        /// 
        /// <example>
        /// <code>
        /// /* Downloads a the 1011 card image to the C://CardImages//SHM directory */
        /// /* The files downloaded are C.jpg, U.jpg, R.jpg, M.jpg */
        /// var gatherer = new Gatherer();
        /// gatherer.DownloadExpansionSetSymbols("SHM", @"C:/CardImages");
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="expansionSetCode">The Expansion Set Code of the card you would like the expansion set images of.</param>
        /// <param name="downloadDirectory">The base directory to save the downloaded images in.</param>
        public void DownloadExpansionSetSymbols(string expansionSetCode, string downloadDirectory)
        {
            foreach (var rarity in default(ExpansionSetSymbolRarity).ToList())
            {
                DownloadExpansionSetSymbol(expansionSetCode, downloadDirectory, rarity);
            }
        }
    }
}
