using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicTcg.Api.Actions.Gatherer
{
    public enum ExpansionSetSymbolRarity
    {
        Common,
        Uncommon,
        Rare,
        Mythic
    }


    public static class ExpansionSetSymbolRarityExt
    {
        public static IEnumerable<ExpansionSetSymbolRarity> ToList(this ExpansionSetSymbolRarity rarity)
        {
            var values = Enum.GetValues(typeof (ExpansionSetSymbolRarity))
                             .OfType<ExpansionSetSymbolRarity>();
            return values;
        } 


        public static string ToCode(this ExpansionSetSymbolRarity rarity)
        {
            var rarityCode = String.Empty;
            switch (rarity)
            {
                case ExpansionSetSymbolRarity.Common:
                    rarityCode = "C";
                    break;
                case ExpansionSetSymbolRarity.Uncommon:
                    rarityCode = "U";
                    break;
                case ExpansionSetSymbolRarity.Rare:
                    rarityCode = "R";
                    break;
                case ExpansionSetSymbolRarity.Mythic:
                    rarityCode = "M";
                    break;
                default:
                    rarityCode = String.Empty;
                    break;
            }

            return rarityCode;
        }
    }
}
