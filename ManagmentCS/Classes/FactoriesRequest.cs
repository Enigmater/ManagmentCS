using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentCS.Classes
{
    internal class FactoriesRequest
    {
        public int URM_SF { get; set; }
        public int URM_UF { get; set; }
        public int priceURM_SF { get; set; }
        public int priceURM_UF { get; set; }

        public void Clear()
        {
            URM_SF = 0;
            URM_UF = 0;
            priceURM_SF = 0;
            priceURM_UF = 0;
        }
    }
}
