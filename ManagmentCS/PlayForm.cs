using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ManagmentCS.Classes;

namespace ManagmentCS
{
    public partial class PlayForm : Form
    {
        Player[] player;
        Bank bank;
        Game game;
        Time timeStruct;
        public PlayForm()
        {
            InitializeComponent();
            game = new Game();
            bank = new Bank();
            timeStruct = new Time();
        }

        private void UpdFactoryInfo()
        {
            player[game.PlayerID - 1].CountSimpleFactory = 0;
            player[game.PlayerID - 1].CountUpgradeFactory = 0;
            for (int i = 0; i < 6; i++)
            {
                if (player[game.PlayerID - 1].Constr.GetSF(i) == -1)
                {
                    player[game.PlayerID - 1].CountSimpleFactory++;
                }
                if (player[game.PlayerID - 1].Constr.GetUF(i) == -1)
                {
                    player[game.PlayerID - 1].CountUpgradeFactory++;
                }
            }
        }
        private void NextStep()
        {
            int step_old = game.Step;
            int id_old = game.PlayerID;
            game.NextPlayer(player, bank);
            if (game.PlayerID == id_old)
            {
                MessageBox.Show("Ничья! Победителей нет!", "Внимание!");
                Form frm = Application.OpenForms[0];
                frm.Show();
                this.Close();
                return;
            }
            int winner_id = game.WinnerCheck(player);
            if (winner_id != -1)
            {
                EndGame(winner_id);
            }
            else
            {
                if (game.Step != step_old)
                {
                    ChangeLevel();
                    game.BankRequest(player, bank);
                    game.CheckLosers(player);
                    winner_id = game.WinnerCheck(player);
                    if (winner_id != -1)
                    {
                        EndGame(winner_id);
                    }
                    GenerateBank();
                }
                player[game.PlayerID - 1].BankRequest.Clear();
                timeStruct.min = 0;
                timeStruct.sec = 0;
            }
            UpdFactoryInfo();
        }
        private void EndGame(int player_id)
        {
            MessageBox.Show(String.Format("Победитель: Игрок №{0}", player_id), "Внимание!");
            Form frm = Application.OpenForms[0];
            frm.Show();
            this.Close();
        }
        private void GeneratePlayers()
        {
            string[] param = new string[2];
            param = File.ReadAllLines("Setting.txt");
            Player.count = 0;
            Player[] players = new Player[Convert.ToInt32(param[0])];
            for (int i = 0; i < Convert.ToInt32(param[0]); i++)
            {
                players[i] = new Player();
            }
            this.player = players;
            game.Roundtime = Convert.ToInt32(param[1]);      
        }
        private void GenerateGame()
        {
            timer.Start();
            timer_updInfo.Start();
            GeneratePlayers();
            GenerateBank();
            UpdGameInfo();
            timeStruct.hour = 0;
            timeStruct.min = 0;
            timeStruct.sec = 0;
        }
        private void GenerateBank()
        {
            int URM = 0, UFP = 0, priceURM = 0, priceUFP = 0;
            int countPlayer = Player.count;
            switch (game.Level)
            {
                case 1:
                    URM = countPlayer;
                    priceURM = 800;
                    UFP = countPlayer * 3;
                    priceUFP = 6500;
                    break;
                case 2:
                    URM = (int) (countPlayer * 1.5);
                    priceURM = 650;
                    UFP = (int) (countPlayer * 2.5);
                    priceUFP = 6000;
                    break;
                case 3:
                    URM = countPlayer * 2;
                    priceURM = 500;
                    UFP = countPlayer * 2;
                    priceUFP = 5500;
                    break;
                case 4:
                    URM = (int) (countPlayer * 2.5);
                    priceURM = 400;
                    UFP = (int) (countPlayer * 1.5);
                    priceUFP = 5000;
                    break;
                case 5:
                    URM = countPlayer * 3;
                    priceURM = 300;
                    UFP = countPlayer;
                    priceUFP = 4500;
                    break;
            }
            bank = new Bank(URM, UFP, priceURM, priceUFP);
        }
        private void UpdGameInfo()
        {
            label_step.Text = String.Format("Прошло месяцев: {0}", game.Step);
            label_player.Text = String.Format("Ходит игрок №{0}", game.PlayerID);
            label_timer.Text = String.Format("Прошло времени: {0:D2}:{1:D2}:{2:D2}", timeStruct.hour, timeStruct.min, timeStruct.sec);

            label_info1.Text = String.Format("Деньги: {0}$\nМатериалы/продукты: {1}/{2}\nКредиты: {3}\nОбычные фабрики: {4}/{5}\nАвтоматизированные фабрики: {6}/{7}",
                player[0].Money,
                player[0].AmountURM,
                player[0].AmountUFP,
                player[0].DebtsSum(),
                player[0].CountSimpleFactory,
                player[0].Constr.GetAmountSF(),
                player[0].CountUpgradeFactory,
                player[0].Constr.GetAmountUF()
            );

            label_info2.Text = String.Format("Деньги: {0}$\nМатериалы/продукты: {1}/{2}\nКредиты: {3}\nОбычные фабрики: {4}/{5}\nАвтоматизированные фабрики: {6}/{7}",
                player[1].Money,
                player[1].AmountURM,
                player[1].AmountUFP,
                player[1].DebtsSum(),
                player[1].CountSimpleFactory,
                player[1].Constr.GetAmountSF(),
                player[1].CountUpgradeFactory,
                player[1].Constr.GetAmountUF()
            );

            if (Player.StartCount > 2)
            {
                panel_thirdPl.Visible = true;
                label_info3.Text = String.Format("Деньги: {0}$\nМатериалы/продукты: {1}/{2}\nКредиты: {3}\nОбычные фабрики: {4}/{5}\nАвтоматизированные фабрики: {6}/{7}",
                    player[2].Money,
                    player[2].AmountURM,
                    player[2].AmountUFP,
                    player[2].DebtsSum(),
                    player[2].CountSimpleFactory,
                    player[2].Constr.GetAmountSF(),
                    player[2].CountUpgradeFactory,
                    player[2].Constr.GetAmountUF()
                );
            }
            if (Player.StartCount > 3)
            {
                panel_fourthPl.Visible = true;
                label_info4.Text = String.Format("Деньги: {0}$\nМатериалы/продукты: {1}/{2}\nКредиты: {3}\nОбычные фабрики: {4}/{5}\nАвтоматизированные фабрики: {6}/{7}",
                    player[3].Money,
                    player[3].AmountURM,
                    player[3].AmountUFP,
                    player[3].DebtsSum(),
                    player[3].CountSimpleFactory,
                    player[3].Constr.GetAmountSF(),
                    player[3].CountUpgradeFactory,
                    player[3].Constr.GetAmountUF()
                );
            }
        }
        private void ChangeLevel()
        {
            Random rand = new Random();
            int chance = rand.Next(0, 100);

            switch (game.Level)
            {
                case 1:
                    if (chance < 30)
                    {
                        game.Level = 2;
                    }
                    break;
                case 2:
                    if (chance < 30)
                    {
                        game.Level = 1;
                    }
                    else if (chance > 60)
                    {
                        game.Level = 3;
                    }
                    break;
                case 3:
                    if (chance < 20)
                    {
                        game.Level = 2;
                    }
                    else if (chance > 65)
                    {
                        game.Level = 4;
                    }
                    break;
                case 4:
                    if (chance < 15)
                    {
                        game.Level = 3;
                    }
                    else if (chance > 75)
                    {
                        game.Level = 5;
                    }
                    break;
                case 5:
                    if (chance < 10)
                    {
                        game.Level = 4;
                    }
                    break;
            }
        }
        private void button_bank_Click(object sender, EventArgs e)
        {
            BankForm frm = new BankForm(ref player[game.PlayerID - 1], bank);
            frm.ShowDialog();
        }

        private void button_production_Click(object sender, EventArgs e)
        {
            UpdFactoryInfo();
            ProductionForm frm = new ProductionForm(ref player[game.PlayerID - 1]);
            frm.ShowDialog();
        }

        private void button_credits_Click(object sender, EventArgs e)
        {
            CreditsForm frm = new CreditsForm(ref player[game.PlayerID - 1]);
            frm.ShowDialog();
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            HelpForm frm = new HelpForm();
            frm.ShowDialog();
            frm.Text = "Помощь";
        }

        private void button_nextPlayer_Click(object sender, EventArgs e)
        {
            NextStep();
        }

        private void button_giveup_Click(object sender, EventArgs e)
        {
            game.AddLoser(game.PlayerID);
            int winner_id = game.WinnerCheck(player);
            if (winner_id != -1)
            {
               EndGame(winner_id);
            }
            else
            {
                NextStep();
            }
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {
            GenerateGame();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeStruct.hour < 59)
            {
                if (timeStruct.min < 59)
                {
                    if (timeStruct.sec < 59)
                    {
                        timeStruct.sec++;
                    }
                    else
                    {
                        timeStruct.min++;
                        timeStruct.sec = 0;
                    }
                }
                else
                {
                    timeStruct.hour++;
                    timeStruct.min = 0;
                }
            }
            if (timeStruct.min > 0 && timeStruct.min == game.Roundtime)
            {
                NextStep();
            }
        }

        private void timer_updInfo_Tick(object sender, EventArgs e)
        {
            UpdGameInfo();
        }
    }
}
