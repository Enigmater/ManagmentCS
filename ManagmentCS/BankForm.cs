using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagmentCS.Classes;

namespace ManagmentCS
{
    public partial class BankForm : Form
    {
        internal Bank bank;
        internal Player player;
        public BankForm()
        {
            InitializeComponent();
        }

        internal BankForm(ref Player player, Bank bank)
        {
            InitializeComponent();
            this.player = player;
            this.bank = bank; 
        }

        private void button_accept_Click(object sender, EventArgs e)
        {
            this.Close();
            int URM, UFP, priceURM, priceUFP;
            URM = Convert.ToInt32(numericUpDown_amountURM.Value);
            UFP = Convert.ToInt32(numericUpDown_amountUFP.Value);
            priceURM = Convert.ToInt32(numericUpDown_priceURM.Value);
            priceUFP = Convert.ToInt32(numericUpDown_priceUFP.Value);
            player.BankRequest = new PlayerRequest(URM, UFP, priceURM, priceUFP);
            if (checkBox_bargainURM.Checked)
            {
                player.BankRequest.RequestURMApproved = true; 
            }
            else
            {
                player.BankRequest.RequestURMApproved = false;
            }
            if (checkBox_bargainUFP.Checked)
            {
                player.BankRequest.RequestUFPApproved = true;
            }
            else
            {
                player.BankRequest.RequestUFPApproved = false;
            }
        }
        private void checkBox_bargainURM_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_bargainURM.Checked)
            {
                numericUpDown_amountURM.Enabled = false;
                numericUpDown_priceURM.Enabled = false;
            }
            else
            {
                numericUpDown_amountURM.Enabled = true;
                numericUpDown_priceURM.Enabled = true;
            }
        }
        private void checkBox_bargainUFP_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_bargainUFP.Checked)
            {
                numericUpDown_amountUFP.Enabled = false;
                numericUpDown_priceUFP.Enabled = false;
            }
            else
            {
                numericUpDown_amountUFP.Enabled = true;
                numericUpDown_priceUFP.Enabled = true;
            }
        }
        private void BankForm_Load(object sender, EventArgs e)
        {
            numericUpDown_amountURM.Enabled = player.BankRequest.RequestURMApproved;
            numericUpDown_priceURM.Enabled = player.BankRequest.RequestURMApproved;
            numericUpDown_amountUFP.Enabled = player.BankRequest.RequestUFPApproved;
            numericUpDown_priceUFP.Enabled = player.BankRequest.RequestUFPApproved;

            checkBox_bargainURM.Checked = player.BankRequest.RequestURMApproved;
            checkBox_bargainUFP.Checked = player.BankRequest.RequestUFPApproved;

            numericUpDown_amountURM.Value = player.BankRequest.AvilableURM;
            numericUpDown_priceURM.Value = player.BankRequest.PriceURM;
            numericUpDown_amountUFP.Value = player.BankRequest.AvilableUFP;
            numericUpDown_priceUFP.Value = player.BankRequest.PriceUFP;

            label_URM.Text = String.Format("ЕСМ доступно: {0}", player.AmountURM);
            label_UFP.Text = String.Format("ЕГП доступно: {0}", player.AmountUFP);

            dataGridView_bank.Rows.Add(2);
            dataGridView_bank.Rows[0].HeaderCell.Value = "Количество";
            dataGridView_bank.Rows[1].HeaderCell.Value = "Цена за штуку";
            dataGridView_bank.Rows[0].Cells[0].Value = bank.AvilableURM;
            dataGridView_bank.Rows[0].Cells[1].Value = bank.AvilableUFP;
            dataGridView_bank.Rows[1].Cells[0].Value = bank.PriceURM;
            dataGridView_bank.Rows[1].Cells[1].Value = bank.PriceUFP;

            numericUpDown_amountURM.Maximum = bank.AvilableURM;
            numericUpDown_amountUFP.Maximum = (bank.AvilableUFP < player.AmountUFP) ? bank.AvilableUFP : player.AmountUFP;
            numericUpDown_priceURM.Minimum = bank.PriceURM;
            numericUpDown_priceUFP.Maximum = bank.PriceUFP;
        }
    }
}
