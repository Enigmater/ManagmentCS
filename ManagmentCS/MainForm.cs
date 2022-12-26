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
using System.Xml.Serialization;

namespace ManagmentCS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string CreateErrorMessage(string what, string code, string filename)
        {
            string error = "Ошибка при открытии фалйа " + filename + "!\n" + what + "\nКод ошибки: " + code;
            return error;
        }

        private void CreateSettingsFile(int countPlayers, int roundtime)
        {
            File.WriteAllText("Setting.txt", countPlayers + "\n" + roundtime);
        }
        private void button_startGame_Click(object sender, EventArgs e)
        {
            PlayForm frm = new PlayForm();
            frm.Show();
            this.Hide();
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            Settings frm = new Settings();
            frm.Show();
            this.Hide();
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            HelpForm frm = new HelpForm();
            frm.Show();
            frm.Text = "Справка";
            this.Hide();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateSettingsFile(2, 3);
        }
    }
}
