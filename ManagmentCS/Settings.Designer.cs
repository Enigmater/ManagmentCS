namespace ManagmentCS
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_leftSide = new System.Windows.Forms.Panel();
            this.label_roundtime = new System.Windows.Forms.Label();
            this.numericUpDown_roundtime = new System.Windows.Forms.NumericUpDown();
            this.label_player = new System.Windows.Forms.Label();
            this.numericUpDown_players = new System.Windows.Forms.NumericUpDown();
            this.button_backToMenu = new System.Windows.Forms.Button();
            this.panel_title = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_leftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_roundtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_players)).BeginInit();
            this.panel_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_leftSide
            // 
            this.panel_leftSide.Controls.Add(this.label_roundtime);
            this.panel_leftSide.Controls.Add(this.numericUpDown_roundtime);
            this.panel_leftSide.Controls.Add(this.label_player);
            this.panel_leftSide.Controls.Add(this.numericUpDown_players);
            this.panel_leftSide.Controls.Add(this.button_backToMenu);
            this.panel_leftSide.Controls.Add(this.panel_title);
            this.panel_leftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_leftSide.Location = new System.Drawing.Point(0, 0);
            this.panel_leftSide.MinimumSize = new System.Drawing.Size(375, 0);
            this.panel_leftSide.Name = "panel_leftSide";
            this.panel_leftSide.Size = new System.Drawing.Size(375, 406);
            this.panel_leftSide.TabIndex = 1;
            // 
            // label_roundtime
            // 
            this.label_roundtime.AutoSize = true;
            this.label_roundtime.Location = new System.Drawing.Point(21, 203);
            this.label_roundtime.Name = "label_roundtime";
            this.label_roundtime.Size = new System.Drawing.Size(144, 28);
            this.label_roundtime.TabIndex = 5;
            this.label_roundtime.Text = "Время на ход";
            // 
            // numericUpDown_roundtime
            // 
            this.numericUpDown_roundtime.Location = new System.Drawing.Point(26, 237);
            this.numericUpDown_roundtime.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_roundtime.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_roundtime.Name = "numericUpDown_roundtime";
            this.numericUpDown_roundtime.Size = new System.Drawing.Size(302, 36);
            this.numericUpDown_roundtime.TabIndex = 4;
            this.numericUpDown_roundtime.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label_player
            // 
            this.label_player.AutoSize = true;
            this.label_player.Location = new System.Drawing.Point(21, 109);
            this.label_player.Name = "label_player";
            this.label_player.Size = new System.Drawing.Size(216, 28);
            this.label_player.TabIndex = 3;
            this.label_player.Text = "Количество игроков";
            // 
            // numericUpDown_players
            // 
            this.numericUpDown_players.Location = new System.Drawing.Point(26, 143);
            this.numericUpDown_players.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_players.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_players.Name = "numericUpDown_players";
            this.numericUpDown_players.Size = new System.Drawing.Size(302, 36);
            this.numericUpDown_players.TabIndex = 2;
            this.numericUpDown_players.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // button_backToMenu
            // 
            this.button_backToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(220)))), ((int)(((byte)(176)))));
            this.button_backToMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_backToMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
            this.button_backToMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button_backToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_backToMenu.Location = new System.Drawing.Point(0, 339);
            this.button_backToMenu.Name = "button_backToMenu";
            this.button_backToMenu.Size = new System.Drawing.Size(375, 67);
            this.button_backToMenu.TabIndex = 1;
            this.button_backToMenu.Text = "Вернуться в меню";
            this.button_backToMenu.UseVisualStyleBackColor = false;
            this.button_backToMenu.Click += new System.EventHandler(this.button_backToMenu_Click);
            // 
            // panel_title
            // 
            this.panel_title.Controls.Add(this.label_title);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(375, 112);
            this.panel_title.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_title.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(168)))), ((int)(((byte)(124)))));
            this.label_title.Location = new System.Drawing.Point(0, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(375, 112);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Настрйоки";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(357, 406);
            this.ControlBox = false;
            this.Controls.Add(this.panel_leftSide);
            this.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(375, 453);
            this.MinimumSize = new System.Drawing.Size(375, 453);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel_leftSide.ResumeLayout(false);
            this.panel_leftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_roundtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_players)).EndInit();
            this.panel_title.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_leftSide;
        private System.Windows.Forms.Label label_roundtime;
        private System.Windows.Forms.NumericUpDown numericUpDown_roundtime;
        private System.Windows.Forms.Label label_player;
        private System.Windows.Forms.NumericUpDown numericUpDown_players;
        private System.Windows.Forms.Button button_backToMenu;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Label label_title;
    }
}