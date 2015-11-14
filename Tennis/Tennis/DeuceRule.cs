using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    public abstract class GameRule
    {
        protected const int StartScore = 0;
        protected const int DueceScore = 3;

        public abstract string GetResult(int score);
    }

    public class DeuceRule : GameRule
    {

        public override string GetResult(int score)
        {
            if (score == DueceScore)
                return "DEUCE";
            return "";
        }
    }

    public class StartGameRule : GameRule
    {
        public override string GetResult(int score)
        {
            if (score == StartScore)
                return "LOVE-LOVE";
            return "";
        }
    }

    public class EqualScoreRule : GameRule
    {
        public override string GetResult(int score)
        {
            if (score > StartScore && score < DueceScore)
                return Tennis.scoreDict[score] + "-ALL";
            return "";
        }
    }
}
