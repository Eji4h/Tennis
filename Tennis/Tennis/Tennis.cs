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
           
            if (playerA == 5 && playerB == 3)
            {
                result = "GAME FOR A";
            }
            else if (playerA == 4 && playerB == 3)
            {
                result = "ADVANTAGE-A";
            }
            else if (playerA == 3 && playerB == 3)
            {
                result = "DEUCE";
            }

            if(playerB == 3)
            {
                result = SetScoreWhenPlayerBIs3(playerA);
            }
            else if (playerA == 3 && playerB == 2)
            {
                result = "40-30";
            }
            else if (playerA == 0 && playerB == 0)
            {
                result = "LOVE-LOVE";
            }
            else result = SetScoreWhenPlayerAIs1Or2(playerA, playerB);

            return result;
        }

        private static string SetScoreWhenPlayerBIs3(int playerA)
        {
            string result;

            switch (playerA)
            {
                case 5:
                    result = "GAME FOR A";
                    break;
                case 4:
                    result = "ADVANTAGE-A";
                    break;
                case 3:
                    result = "DEUCE";
                    break;
                default: throw new ArgumentOutOfRangeException();
            }

            return result;

        }

        private static string SetScoreWhenPlayerAIs1Or2(int playerA, int playerB)
        {
            string result = scoreDict[playerA] + "-";
            string bResult = playerA == playerB ? "ALL" : scoreDict[playerB];

            result += bResult;
            return result;
        }
    }
}
