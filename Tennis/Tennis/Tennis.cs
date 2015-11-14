using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    public class Tennis
    {
        public static object GetScore(int p1, int p2)
        {
            if (p1 == 1 && p2 == 0)
            {
                return "15-LOVE";
            }
            else if (p1 == 1 && p2 == 1)
            {
                return "15-ALL";
            }

            return "LOVE-LOVE";
        }
    }
}
