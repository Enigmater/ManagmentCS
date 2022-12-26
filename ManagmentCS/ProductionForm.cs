using ManagmentCS.Classes;
using ManagmentCS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagmentCS
{
    public partial class ProductionForm : Form
    {
        Player player;
        int SFcost;
        int UFcost;
        public ProductionForm()
        {
            InitializeComponent();
            SFcost = 5000;
            UFcost = 10000;
        }
        internal ProductionForm(ref Player player)
        {
            InitializeComponent();
            this.player = player;
            SFcost = 5000;
            UFcost = 10000;
        }

        private void CreateButtons()
        {

            ComponentResourceManager resources = new ComponentResourceManager(typeof(ManagmentCS.ProductionForm));
            for (int i = 0; i < 6; i++)
            {
                Button btn = new Button();
                btn.Dock = DockStyle.Right;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Size = new System.Drawing.Size(253, 100);
                btn.Name = "btn_SF" + (i + 1);
                btn.UseVisualStyleBackColor = true;
                btn.Click += ButtonOnClick;

                int countSF = player.CountSimpleFactory;
                if (player.Constr.GetSF(i) == 0)
                {
                    btn.Text = "Обычный завод" + "\n Построить: 5000$";
                    btn.BackColor = System.Drawing.Color.Gray;
                }
                else if (player.Constr.GetSF(i) == -1)
                {
                    btn.Text = "Обычный завод №" + (i + 1);
                }
                else
                {
                    btn.Text = "Обычный завод №" + (i + 1) + "\nПостроится через: " + player.Constr.GetSF(i) + " месяцев";
                }
                /*btn.Text = L"Завод " + (i + 1) + "\n Улучшение: 7000$";*/

                if (i % 2 == 0)
                {
                    this.panel_topSF.Controls.Add(btn);
                }
                else
                {
                    this.panel_bottomSF.Controls.Add(btn);
                }

            }

            for (int i = 0; i < 6; i++)
            {
                Button btn = new Button();
                btn.Dock = DockStyle.Right;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Size = new System.Drawing.Size(253, 100);
                btn.Name = "btn_UF" + (i + 1);
                btn.UseVisualStyleBackColor = true;
                btn.Click += ButtonOnClick;

                int countUF = player.CountSimpleFactory;

                if (player.Constr.GetUF(i) == 0)
                {
                    btn.Text = "Улучшенный завод" + "\n Построить: 10000$";
                    btn.BackColor = System.Drawing.Color.Gray;
                }
                else if (player.Constr.GetUF(i) == -1)
                {
                    btn.Text = "Улучшенный завод №" + (i + 1);
                }
                else
                {
                    btn.Text = "Улучшенный завод №" + (i + 1) + "\nПостроится через: " + player.Constr.GetUF(i) + " месяцев";
                }

                if (i % 2 == 0)
                {
                    this.panel_topUF.Controls.Add(btn);
                }
                else
                {
                    this.panel_bottomAF.Controls.Add(btn);
                }

            }
        }
        private void ButtonOnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            for (int i = 1; i < 7; i++)
            {
                if (player.Constr.GetSF(i - 1) == 0 && btn.Name == "btn_SF" + i)
                {
                    if (player.Money < 5000)
                    {
                        MessageBox.Show("Недостаточно денег!", "Внимание!");
                        return;
                    }
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите построить фабрику?", "Внимание!", MessageBoxButtons.YesNo);
                    
                    if (result == DialogResult.Yes) 
                    { 
                        player.Constr.PushSF(i - 1, 5);
                        player.decreaseMoney(this.SFcost);
                    }
                }

                if (player.Constr.GetUF(i - 1) == 0 && btn.Name == "btn_UF" + i)
                {
                    if (player.Money < 10000)
                    {
                        MessageBox.Show("Недостаточно денег!", "Внимание!");
                        return;
                    }
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите построить фабрику?", "Внимание!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Вы построите авто фабрику #" + i);
                        player.Constr.PushUF(i - 1, 7);
                        player.decreaseMoney(this.UFcost);
                    }
                }
            }
            label_info.Text = "Кол-во ЕСМ: " + player.AmountURM + "\nДенег: " + player.Money;
            if (numericUpDown_URM1.Value * 2000 > player.Money)
            {
                numericUpDown_URM1.Maximum = (int)(player.Money / 2000);
            };
            if (numericUpDown_URM2.Value * 3000 > player.Money)
            {
                numericUpDown_URM2.Maximum = (int)(player.Money / 3000);
            };
            CreateButtons();
        }
        private void numericUpDown_URM1_ValueChanged(object sender, EventArgs e)
        {
            if (player.CountSimpleFactory < (player.AmountURM - numericUpDown_URM2.Value))
            {
                numericUpDown_URM1.Maximum = player.CountSimpleFactory;
            }
            else
            {
                numericUpDown_URM1.Maximum = (player.AmountURM - numericUpDown_URM2.Value < 6) ? player.AmountURM - numericUpDown_URM2.Value : 6;
            }

            if (player.AmountURM - numericUpDown_URM1.Value < 12)
            {
                if ((player.AmountURM - numericUpDown_URM1.Value) % 2 == 0)
                {
                    numericUpDown_URM2.Maximum = player.AmountURM - numericUpDown_URM1.Value;
                }
                else
                {
                    numericUpDown_URM2.Maximum = player.AmountURM - numericUpDown_URM1.Value - 1;
                }
            }
            else
            {
                numericUpDown_URM2.Maximum = 12;
            }

            if (numericUpDown_URM1.Value * 2000 > player.Money)
            {
                numericUpDown_URM1.Maximum = (int)(player.Money / 2000);
            };

            label_costSF.Text = "Итого: " + numericUpDown_URM1.Value * 2000 + "$";
        }
        private void numericUpDown_URM2_ValueChanged(object sender, EventArgs e)
        {
            if (player.CountUpgradeFactory <= (player.AmountURM - numericUpDown_URM1.Value) / 2)
            {
                numericUpDown_URM2.Maximum = player.CountUpgradeFactory * 2;
            }
            else
            {
                if (player.AmountURM - numericUpDown_URM1.Value < 12)
                {
                    if ((player.AmountURM - numericUpDown_URM1.Value) % 2 == 0)
                    {
                        numericUpDown_URM2.Maximum = player.AmountURM - numericUpDown_URM1.Value;
                    }
                    else
                    {
                        numericUpDown_URM2.Maximum = player.AmountURM - numericUpDown_URM1.Value - 1;
                    }
                }
                else
                {
                    numericUpDown_URM2.Maximum = 12;
                }
            }
            numericUpDown_URM1.Maximum = (player.AmountURM - numericUpDown_URM2.Value < 6) ? player.AmountURM - numericUpDown_URM2.Value : 6;

            if (numericUpDown_URM2.Value * 1500 > player.Money)
            {
                if ((player.Money / 3000) % 2 == 0)
                {
                    numericUpDown_URM2.Maximum = (int)(player.Money / 3000);
                }
                else
                {
                    numericUpDown_URM2.Maximum = (int)(player.Money / 3000) - 1;
                }
            };

            label_costUF.Text ="Итого: " + numericUpDown_URM2.Value / 2 * 3000 + "$";
        }
        private void button_accept_Click(object sender, EventArgs e)
        {
            player.FactoriesReq.Clear();
            player.FactoriesReq.URM_SF = (Convert.ToInt32(numericUpDown_URM1.Value));
            player.FactoriesReq.URM_UF = (Convert.ToInt32(numericUpDown_URM2.Value));
            player.FactoriesReq.priceURM_SF = (Convert.ToInt32(numericUpDown_URM1.Value * 2000));
            player.FactoriesReq.priceURM_UF = (Convert.ToInt32(numericUpDown_URM2.Value * 3000));
            this.Close();
        }
        private void ProductionForm_Load(object sender, EventArgs e)
        {
            label_URM1.Text = "Доступно для переработки " + player.CountSimpleFactory + " ЕСМ";
            label_URM2.Text = "Доступно для переработки " + player.CountSimpleFactory * 2 + " ЕСМ";
            label_info.Text = "Кол-во ЕСМ: " + player.AmountURM + "\nДенег: " + player.Money;
            numericUpDown_URM1.Maximum = 6;
            numericUpDown_URM2.Maximum = 6;
            if (player.CountUpgradeFactory == 0)
            {
                numericUpDown_URM2.Enabled = false;
            }
            label_costSF.Text = "Итого: 0$";
            CreateButtons();
        }
    }
}
