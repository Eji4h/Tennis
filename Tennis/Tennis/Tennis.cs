using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    public class Tennis
    {
        public static Dictionary<int, string> scoreDict = new Dictionary<int, string>();

        static Tennis()
        {
            scoreDict.Add(0, "LOVE");
            scoreDict.Add(1, "15");
            scoreDict.Add(2, "30");
            scoreDict.Add(3, "40");
        }

        public static string GetScore(int playerA, int playerB)
        {
            string result;
            if (playerA == playerB)
            {
                result = SetEqualScore(playerA, playerB);
            }
            else
            {
                result = SetNonEqulScore(playerA, playerB);
            }

            return result;
        }

        private static string SetEqualScore(int playerA, int playerB)
        {
            string result = string.Empty;

            if (playerA == 3)
                result = "DEUCE";
            else if (playerA == 0)
                result = scoreDict[playerA] + "-" + scoreDict[playerB];
            else
                result = scoreDict[playerA] + "-ALL";

            return result;
        }


        private static string SetNonEqulScore(int playerA, int playerB)
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
