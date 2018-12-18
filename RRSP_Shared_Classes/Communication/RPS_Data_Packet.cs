using System;
using System.Collections.Generic;
using System.Text;

namespace RRSP_Shared_Classes
{
    [Serializable]
    public class RPS_Data_Packet
    {
        private RPS_Types.RPS_Type rpsType;
        public RPS_Types.RPS_Type RPS_Type { get => this.rpsType; set => this.rpsType = value; }

        public RPS_Data_Packet(RPS_Types.RPS_Type rPS_Type)
        {
            rpsType = rPS_Type;
        }
    }
}
