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

namespace ManagmentCS
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button_backToMenu_Click(object sender, EventArgs e)
        {
            int countPlayers = Convert.ToInt32(numericUpDown_players.Value);
            int roundtime = Convert.ToInt32(numericUpDown_roundtime.Value);
            File.WriteAllText("Setting.txt", countPlayers + "\n" + roundtime);
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            string[] param = new string[2];
            param = File.ReadAllLines("Setting.txt");
            numericUpDown_players.Value = Convert.ToInt32(param[0]);
            numericUpDown_roundtime.Value = Convert.ToInt32(param[1]);
        }
    }
}
