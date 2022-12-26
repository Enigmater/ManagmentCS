using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentCS.Classes
{
    internal class Player
    {
        public Construction Constr;
        public FactoriesRequest FactoriesReq;
        public PlayerRequest BankRequest;
        public List<Credits> Debts;

        public Player()
        {
            CountSimpleFactory = 2;
            CountUpgradeFactory = 2;
            AmountURM = 4;
            AmountUFP = 2;
            Money = 10000;
            PlayerID += count++;
            StartCount = count;
            Constr = new Construction(CountSimpleFactory, CountUpgradeFactory);
            BankRequest = new PlayerRequest();
            FactoriesReq = new FactoriesRequest();
            Debts = new List<Credits>();
        }

        public static int count { get; set; }
        public static int StartCount { get; set; }
        public int PlayerID { get; set; }
        public int CountSimpleFactory { get; set; }
        public int CountUpgradeFactory { get; set; }
        public int AmountURM { get; set; }
        public int AmountUFP { get; set; }
        public int Money { get; set; }

        public void increaseMoney(int money)
        {
            Money += money;
        }
        public void decreaseMoney(int money)
        {
            Money -= money;
        }
        public void increaseURM(int URM)
        {
            AmountURM += URM;
        }
        public void decreaseURM(int URM)
        {
            AmountURM -= URM;
        }
        public void increaseUFP(int UFP)
        {
            AmountUFP += UFP;
        }
        public void decreaseUFP(int UFP)
        {
            AmountUFP -= UFP;
        }

        public int DebtsSum()
        {
            int sum = 0;
            for (int i = 0; i < Debts.Count; i++)
            {
                sum += Debts[i].Amount;
            }
            return sum;
        }

        public int CountSFDebts()
        {
            int count = 0;
            for (int i = 0; i < Debts.Count(); i++)
            {
                if (Debts[i].Type == "SF")
                {
                    count++;
                }
            }
            return count;
        }
        public int CountUFDebts()
        {
            int count = 0;
            for (int i = 0; i < Debts.Count(); i++)
            {
                if (Debts[i].Type == "UF")
                {
                    count++;
                }
            }
            return count;
        }
    }
}
