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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void button_backToMenu_Click(object sender, EventArgs e)
        {
            Form form;
            if (this.Text == "Справка")
            {
                form = Application.OpenForms[0];
                form.Show();
            }
            this.Close();
        }

        private void linkLabel_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string msg = "Каждый игрок платит:\n300 долл. за каждую имеющуюся у него ЕСМ\n500 долл. за каждую наличную ЕГП\n1000 долл. за владение каждой обычной фабрикой\n1500 долл. — за владение автоматизированной\n1% от суммы непогашенных кредитов";
            MessageBox.Show(msg, "Постоянные издержки");
        }

        private void linkLabel_2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string msg = "Каждый игрок тайно от других готовит заявку на ЕСМ на текущий месяц.\nВ заявке указывается требуемое число ЕСМ и предлагается цена не ниже банковской минимальной\n(запрос нуля ЕСМ или предложение цены ниже минимальной автоматически исключает игрока из торгов в этом месяце).\nВсе заявки ЕСМ распределяются между игроками в порядке убывания предложенной цены.\nЕсли сырья не хватает на всех, заявки с предложением более низкой цены не удовлетворяются.\nПри прочих равных условиях сырье достается самому старшему игроку.\nИгроки платят за сырье при его получении. ";
            MessageBox.Show(msg, "Банк");
        }

        private void linkLabel_3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string msg = "Каждый игрок может заявить, сколько ЕСМ он собирается переработать в ЕГП в текущем месяце и на каких фабриках.\nКаждый игрок обязан тут же покрыть расходы на производство.\nОбычная фабрика может за месяц переработать одну ЕСМ при затратах в 2000 долл.\nАвтоматизированная фабрика может переработать 2 ЕСМ при затратах в 3000 долл";
            MessageBox.Show(msg, "Производство");
        }

        private void linkLabel_4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string msg = "Кредиты обеспечиваются имеющимися у игрока фабриками:\nПод обычную фабрику дается сумма 5000 долл.\nпод автоматизированную — 10 000 долл.\nБанк немедленно выплачивает сумму кредита игроку.\nСрок погашения ссуды истекает через 12 месяцев — например, кредит, взятый в 3-м месяце, возвращать надо в 15-м.\nНельзя погашать кредиты раньше срока.";
            MessageBox.Show(msg, "Кредиты");
        }

        private void linkLabel_5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string msg = "Игроки могут строить новые фабрики.\nОбычная фабрика стоит 5000 долл. и начинает давать продукцию на 5-й месяц после начала строительства\nАвтоматизированная фабрика стоит 10 000 долл и дает продукцию на 7-й месяц после начала строительства";
            MessageBox.Show(msg, "Строительство");
        }
    }
}
