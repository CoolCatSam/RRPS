using System;
using System.Collections.Generic;
using System.Text;

namespace RRSP_Shared_Classes
{
    [Serializable]
    public class RPS_Data_Packet
    {
        public RPS_Types.RPS_Type RPS_Type { get => RPS_Type; set => RPS_Type = value; }

        public RPS_Data_Packet(RPS_Types.RPS_Type rPS_Type, RPS_Types.RPS_Type rPS_Type1)
        {
            RPS_Type = rPS_Type;
        }
    }
}
