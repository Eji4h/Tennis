using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    public class Tennis
    {
        public static Dictionary<int, string> scoreDict =
            new Dictionary<int, string>();

        static Tennis()
        {
            scoreDict.Add(0, "LOVE");
            scoreDict.Add(1, "15");
            scoreDict.Add(2, "30");
            scoreDict.Add(3, "40");
        }

        public static List<GameRule> GameRuleList
        {
            get;
            set;
        }

        public static string GetResult(int playerA, int playerB)
        {
            string result;

            if (IsEqualScore(playerA, playerB))
                result = GetEqualResult(playerA);
            else
                result = GetNonEqulResult(playerA, playerB);

            return result;
        }

        private static bool IsEqualScore(int playerA, int playerB)
        {
            return playerA == playerB;
        }

        private static string GetEqualResult(int playerA)
        {
            string result = string.Empty;

            GameRuleList.ForEach(gameRule =>
                {
                    result += gameRule.GetResult(playerA);
                });

            return result;
        }

        private static string GetNonEqulResult(int playerA, int playerB)
        {
            string result = string.Empty;

            if (playerA == 5)
                result = "GAME FOR A";
            else if (playerA == 4)
                result = "ADVANTAGE-A";
            else
                result = scoreDict[playerA] + "-" + scoreDict[playerB];

            return result;
        }
    }
}
