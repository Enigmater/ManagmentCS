using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentCS.Classes
{
    internal class Game
    {
        public int Level { get; set; }
        public int Step { get; set; }
        public int Roundtime { get; set; }
        public int PlayerID { get; set; }

        private List<int> losePlayerID;

        public Game()
        {
            Level = 1;
            Step = 1;
            Roundtime = 3;
            PlayerID = 1;
            losePlayerID = new List<int>();
        }
        public void NextPlayer(Player[] player, Bank bank)
        {
            bool playerIsLoser = PlayerIsLoser(this.PlayerID);
            int id = PlayerID - 1;
            if (!playerIsLoser)
            {
                // Издержки
                int debts = player[id].DebtsSum() / 100;
                int URM = player[id].AmountURM * 300;
                int UFP = player[id].AmountUFP * 500;
                int SF = player[id].CountSimpleFactory * 1000;
                int UF = player[id].CountUpgradeFactory * 1500;
                int deduction = debts + URM + UFP + SF + UF;
                player[id].decreaseMoney(deduction);

                // Кредиты
                for (int i = 0; i < player[id].Debts.Count; i++)
                {
                    player[id].Debts[i].Term -= 1;
                    if (player[id].Debts[i].Term == 0)
                    {
                        player[id].decreaseMoney(player[id].Debts[i].Amount);
                        player[id].Debts.RemoveAt(i);
                    }
                }            
            
                // Переработка
                int CountURM = player[id].FactoriesReq.URM_SF + player[id].FactoriesReq.URM_UF;
                int PriceURM = player[id].FactoriesReq.priceURM_SF + player[id].FactoriesReq.priceURM_UF;
                player[id].decreaseURM(CountURM);
                player[id].increaseUFP(CountURM);
                player[id].decreaseMoney(PriceURM);
                player[id].FactoriesReq.Clear();

                // Заводы
                for (int i = 0; i < 6; i++)
                {
                    if (player[id].Constr.GetSF(i) > 0)
                    {
                        player[id].Constr.PushSF(i, player[id].Constr.GetSF(i) - 1);
                        if (player[id].Constr.GetSF(i) == 0)
                        {
                            player[id].Constr.PushSF(i, -1);
                            player[id].CountSimpleFactory = (player[id].CountSimpleFactory + 1);
                        }
                        
                    }

                    if (player[id].Constr.GetUF(i) > 0)
                    {
                        player[id].Constr.PushUF(i, player[id].Constr.GetUF(i) - 1);
                        if (player[id].Constr.GetUF(i) == 0)
                        {
                            player[id].Constr.PushUF(i, -1);
                            player[id].CountUpgradeFactory = (player[id].CountUpgradeFactory + 1);
                        }
                    }
                }
            }

            // След. игрок
            int maxID = FindMaxID(player);
            if (maxID == 0)
            {
                return;
            }
            if (PlayerID >= maxID)
            {
                PlayerID = 1;
                Step++;
            }
            else
            {
                PlayerID++;
            }
            do
            {
                if (!PlayerIsLoser(PlayerID))
                {
                    break;
                }

                if (PlayerID == maxID)
                {
                    PlayerID = 1;
                }
                else
                {
                    PlayerID++;
                }
            } while (PlayerIsLoser(PlayerID));

            if (WinnerCheck(player) != -1)
            {
                return;
            }
        }
        public void BankRequest(Player[] player, Bank bank)
        {
            List<Player> requests = new List<Player>();
            for (int i = 0; i < Player.count; i++)
            {
                if (!PlayerIsLoser(i + 1) && player[i].BankRequest.RequestURMApproved)
                {
                    requests.Add(player[i]);
                }
            }
            requests.Sort(delegate (Player x, Player y)
            {
                return y.BankRequest.PriceURM.CompareTo(x.BankRequest.PriceURM);
            });

            int countURM = bank.AvilableURM;
            int issuedURM = 0, costIssuedURM = 0;
            for (int i = 0; i < requests.Count; i++)
            {
                if (countURM > 0)
                {
                    if (countURM - requests[i].BankRequest.AvilableURM > 0)
                    {
                        issuedURM = requests[i].BankRequest.AvilableURM;
                    }
                    else
                    {
                        issuedURM = countURM;
                    }
                    costIssuedURM = issuedURM * requests[i].BankRequest.PriceURM;
                    player[requests[i].PlayerID].increaseURM(issuedURM);
                    player[requests[i].PlayerID].decreaseMoney(costIssuedURM);
                    countURM -= issuedURM;
                }
                else
                {
                    break;
                }     
            }


            requests.Clear();
            for (int i = 0; i < Player.count; i++)
            {
                if (!PlayerIsLoser(i + 1) && player[i].BankRequest.RequestUFPApproved)
                {
                    requests.Add(player[i]);
                }
            }

            requests.Sort(delegate (Player x, Player y)
            {
                return x.BankRequest.PriceUFP.CompareTo(y.BankRequest.PriceUFP);
            });

            int countUFP = bank.AvilableUFP;
            int issuedUFP = 0, costIssuedUFP = 0;
            for (int i = 0; i < requests.Count; i++)
            {
                if (countUFP > 0)
                {
                    if (countUFP - requests[i].BankRequest.AvilableUFP > 0)
                    {
                        issuedUFP = requests[i].BankRequest.AvilableUFP;
                    }
                    else
                    {
                        issuedUFP = countUFP;
                    }
                    costIssuedUFP = issuedUFP * requests[i].BankRequest.PriceUFP;
                    player[requests[i].PlayerID].decreaseUFP(issuedUFP);
                    player[requests[i].PlayerID].increaseMoney(costIssuedUFP);
                    countUFP -= issuedUFP;
                }
                else
                {
                    break;
                }
            }
        }
        public void CheckLosers(Player[] player)
        {
            for (int i = 0; i < Player.StartCount; i++)
            {
                if (!PlayerIsLoser(i + 1) && player[i].Money < 0)
                {
                    losePlayerID.Add(player[i].PlayerID + 1);
                    Player.count--;
                }
            }
        }
        public void AddLoser(int player_id)
        {
            losePlayerID.Add(player_id);
            Player.count--;
        }
        public int FindMaxID(Player[] player)
        {
            int max = 0;
            for (int i = 0; i < Player.StartCount; i++)
            {
                int id = player[i].PlayerID + 1;
                int find = 0;
                find = losePlayerID.Find(x => x == id);
                if (find == 0 && player[i].PlayerID + 1 > max)
                {
                    max = id;
                }
            }
            return max;
        }
        public int WinnerCheck(Player[] player)
        {
            if (Player.count == 1)
            {
                for (int i = 0; i < Player.StartCount; i++)
                {
                    int id = player[i].PlayerID + 1;
                    int find = 0;
                    find = losePlayerID.Find(x => x == id);
                    if (find == 0)
                    {
                        return id;
                    }
                }
            }
            return -1;
        }
        public bool PlayerIsLoser(int player_id)
        {
            int find = 0;
            find = losePlayerID.Find(x => x == player_id);
            return find != 0;
        }

    }
}
