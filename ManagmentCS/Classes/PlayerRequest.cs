using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentCS.Classes
{
    internal class PlayerRequest : Bank
    {
        public PlayerRequest() : base()
        {
            RequestURMApproved = false;
            RequestUFPApproved = false;
        }
        public PlayerRequest(int URM, int UFP, int priceURM, int priceUFP) : base(URM, UFP, priceURM, priceUFP)
        {
            RequestURMApproved = false;
            RequestUFPApproved = false;
        }
        public bool RequestURMApproved { get; set; }
        public bool RequestUFPApproved { get; set; }
        public void Clear()
        {
            AvilableURM = 0;
            AvilableUFP = 0;
            PriceURM = 0;
            PriceUFP = 0;
            RequestURMApproved = false;
            RequestUFPApproved = false;
        }
    }
}
