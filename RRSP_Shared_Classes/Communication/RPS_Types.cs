using System;
using System.Collections.Generic;
using System.Text;

namespace RRSP_Shared_Classes
{
    public class RPS_Types
    {
        public enum RPS_Type
        {
            ROCK,
            PAPER,
            SCISSORS
        }

        public static RPS_Type GetWinningType(RPS_Type Type)
        {
            switch (Type)
            {
                case RPS_Type.ROCK:
                    return RPS_Type.PAPER;
                case RPS_Type.PAPER:
                    return RPS_Type.SCISSORS;
                case RPS_Type.SCISSORS:
                    return RPS_Type.ROCK;
                default:
                    // Will never get here, but when we do, Rock conquers all
                    return RPS_Type.ROCK;
            }
        }

        public static RPS_Type GetLosingType(RPS_Type Type)
        {
            switch (Type)
            {
                case RPS_Type.ROCK:
                    return RPS_Type.SCISSORS;
                case RPS_Type.PAPER:
                    return RPS_Type.ROCK;
                case RPS_Type.SCISSORS:
                    return RPS_Type.PAPER;
                default:
                    // Will never get here, but when we do, Paper sucks
                    return RPS_Type.PAPER;
            }
        }
    }
}
