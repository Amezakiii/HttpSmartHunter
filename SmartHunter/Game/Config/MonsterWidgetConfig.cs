using System.Text.RegularExpressions;
using SmartHunter.Core.Config;

namespace SmartHunter.Game.Config
{
    public class MonsterWidgetConfig : WidgetConfig
    {
        // em[0-9]|ems[0-9]|gm[0-9]
        public string IncludeMonsterIdRegex = "em[0-9]";
        public string IncludePartGroupIdRegex = ".*";
        public string IncludePartSoftenGroupIdRegex = ".*";
        public string IncludeStatusEffectGroupIdRegex = ".*";
        public bool ShowUnchangedMonsters = true;
        public float HideMonstersAfterSeconds = 999f;
        public bool ShowParts = true;
        public bool ShowUnchangedParts = false;
        public float HidePartsAfterSeconds = 12f;
        public bool ShowSoftenParts = true;
        public float HideSoftenPartsAfterSeconds = 6f;
        public bool ShowStatusEffects = true;
        public bool ShowUnchangedStatusEffects = false;
        public float HideStatusEffectsAfterSeconds = 12f;

        public bool ShowSize = true;
        public bool ShowCrown = true;
        public bool ShowBars = true;
        public bool ShowNumbers = true;
        public bool ShowPercents = false;
        public bool UseAnimations = false;
        public bool ShowOnlySelectedMonster = true;
        public bool AlwaysShowParts = false;
        public bool UseNetworkServer = false;

        public MonsterWidgetConfig(float x, float y) : base(x, y)
        {
        }

        public bool MatchIncludeMonsterIdRegex(string monsterId)
        {
            return new Regex(IncludeMonsterIdRegex).IsMatch(monsterId);
        }

        public bool MatchIncludePartGroupIdRegex(string groupId)
        {
            return new Regex(IncludePartGroupIdRegex).IsMatch(groupId);
        }

        public bool MatchIncludePartSoftenGroupIdRegex(string groupId)
        {
            return new Regex(IncludePartSoftenGroupIdRegex).IsMatch(groupId);
        }

        public bool MatchIncludeStatusEffectGroupIdRegex(string groupId)
        {
            return new Regex(IncludeStatusEffectGroupIdRegex).IsMatch(groupId);
        }
    }
}
