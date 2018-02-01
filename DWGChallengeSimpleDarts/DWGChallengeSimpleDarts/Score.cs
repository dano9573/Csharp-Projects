using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace DWGChallengeSimpleDarts
{
    public class Score
    {
        public static void ScoreDart(Player player, Dart dart)
        {
            int score = 0;

            //Full dart board inner ring / outer ring
            if (dart.IsTriple) score = dart.Score * 3;
            else if (dart.IsDouble) score = dart.Score * 2;
            else score = dart.Score;

            //Bullseye inner ring / outer ring
            if (dart.IsTriple && dart.Score == 0) score = 50;
            else if (dart.Score == 0) score = 25;

            player.Score += score; 


        }


    }
}