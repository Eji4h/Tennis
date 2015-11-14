﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    public class Tennis
    {
        public static string GetScore(int playerA, int playerB)
        {
            string result;

            if (playerA == 1 && playerB == 0)
            {
                result = "15-LOVE";
            }
            else if (playerA == 1 && playerB == 1)
            {
                result = "15-ALL";
            }
            else if(playerA == 2 && playerB == 1)
            {
                result = "30-15";
            }
            else
            {
                result = "LOVE-LOVE";
            }

            return result;
        }
    }
}
