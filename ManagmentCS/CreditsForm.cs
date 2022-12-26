using ManagmentCS.Classes;
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
    public partial class CreditsForm : Form
    {
        Player player;
        public CreditsForm()
        {
            InitializeComponent();
        }
        internal CreditsForm(ref Player player)
        {
            InitializeComponent();
            this.player = player;
        }

        private void UpdInfo()
        {
            label_moneyAmount.Text = Convert.ToString(player.Money) + "$";
            label_debtsAmount.Text = Convert.ToString(player.DebtsSum()) + "$";

            radioButton_SFdebt.Text = String.Format("Взять кредить под обычную фабрику (Доступно {0})", player.CountSimpleFactory - player.CountSFDebts());
            radioButton_UFdebt.Text = String.Format("Взять кредит под автоматизированную фабрику (Доступно {0})", player.CountUpgradeFactory - player.CountUFDebts());

            if (player.CountSimpleFactory - player.CountSFDebts() == 0)
            {
                radioButton_SFdebt.Enabled = false;
                radioButton_SFdebt.Checked = false;
            }

            if (player.CountUpgradeFactory - player.CountUFDebts() == 0)
            {
                radioButton_UFdebt.Enabled = false;
                radioButton_UFdebt.Checked = false;
            }

            dataGridView1.Rows.Clear();

            /*dataGridView1.Columns.Clear();*/

            int size = player.Debts.Count();
            for (int i = 0; i < size; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = player.Debts[i].Amount;
                dataGridView1.Rows[i].Cells[1].Value = player.Debts[i].Term;
                string TypeF;
                if (player.Debts[i].Type == "SF")
                {
                    TypeF = "Обычная фабрика";
                }
                else
                {
                    TypeF = "Автоматизированная фабрика";
                }
                dataGridView1.Rows[i].Cells[2].Value = TypeF;
            }
        }

        private void button_getDebt_Click(object sender, EventArgs e)
        {
            Credits debt = new Credits();
            if (radioButton_SFdebt.Checked || radioButton_UFdebt.Checked)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите взять кредит?", "Внимание!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (radioButton_SFdebt.Checked == true)
                    {
                        debt.Amount = (5000);
                        debt.Term = (12);
                        debt.Type = ("SF");
                    }
                    if (radioButton_UFdebt.Checked == true)
                    {
                        debt.Amount = (10000);
                        debt.Term = (12);
                        debt.Type = ("UF");
                    }
                    player.Debts.Add(debt);
                    player.increaseMoney(debt.Amount);

                    UpdInfo();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Для начала выберите тип кредита!", "Внимание!");
                return;
            }
        }

        private void button_accept_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreditsForm_Load(object sender, EventArgs e)
        {
            UpdInfo();
        }
    }
}
