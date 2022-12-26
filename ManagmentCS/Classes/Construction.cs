using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentCS.Classes
{
    internal class Construction
    { 
        private List<int> SimpleF;
        private List<int> UpgradeF;

        public Construction()
        {
            SimpleF = new List<int>(Enumerable.Repeat(0, 6));
            UpgradeF = new List<int>(Enumerable.Repeat(0, 6));
            SimpleF[0] = -1;
            SimpleF[1] = -1;
        }
        public Construction(int countSF, int countUF)
        {
            SimpleF = new List<int>(Enumerable.Repeat(0, 6));
            UpgradeF = new List<int>(Enumerable.Repeat(0, 6));
            for (int i = 0; i < countSF; i++)
            {
                SimpleF[i] = -1;
            }
            for (int i = 0; i < countUF; i++)
            {
                UpgradeF[i] = -1;
            }
        }

        public int GetAmountSF()
        {
            int count = 0;
            for (int i = 0; i < SimpleF.Count; i++)
            {
                if (SimpleF[i] > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public int GetAmountUF() 
        {
            int count = 0;
            for (int i = 0; i < UpgradeF.Count; i++)
            {
                if (UpgradeF[i] > 0)
                {
                    count++;
                }
            }
            return count;
        } 

        public int GetSF(int i)
        {
            return SimpleF[i];
        }

        public int GetUF(int i)
        {
            return UpgradeF[i];
        }

        public void PushSF(int i, int n)
        {
            SimpleF[i] = n;
        }


        public void PushUF(int i, int n)
        {
            UpgradeF[i] = n;
        }
    }
}
