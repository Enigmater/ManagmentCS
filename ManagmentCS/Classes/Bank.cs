using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentCS.Classes
{
    internal class Bank
    {
        public Bank()
        {
            AvilableURM = 0;
            AvilableUFP = 0;
            PriceURM = 0;
            PriceUFP = 0;
        }
        public Bank(int URM, int UFP, int priceURM, int priceUFP)
        {
            AvilableURM = URM;
            AvilableUFP = UFP;
            PriceURM = priceURM;   
            PriceUFP = priceUFP;         
        }
        public int AvilableURM { get; set; }
        public int AvilableUFP { get; set; }
        public int PriceURM { get; set; }
        public int PriceUFP { get; set; }
    }
}
