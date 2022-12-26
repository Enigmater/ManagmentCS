namespace ManagmentCS
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_leftSide = new System.Windows.Forms.Panel();
            this.panel_rightSide = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_help = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_startGame = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.label_logo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.panel_logo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_leftSide
            // 
            this.panel_leftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_leftSide.Location = new System.Drawing.Point(0, 0);
            this.panel_leftSide.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel_leftSide.Name = "panel_leftSide";
            this.panel_leftSide.Size = new System.Drawing.Size(250, 453);
            this.panel_leftSide.TabIndex = 0;
            // 
            // panel_rightSide
            // 
            this.panel_rightSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_rightSide.Location = new System.Drawing.Point(501, 0);
            this.panel_rightSide.Name = "panel_rightSide";
            this.panel_rightSide.Size = new System.Drawing.Size(250, 453);
            this.panel_rightSide.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_menu);
            this.panel1.Controls.Add(this.panel_logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 453);
            this.panel1.TabIndex = 2;
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.button_help);
            this.panel_menu.Controls.Add(this.button_exit);
            this.panel_menu.Controls.Add(this.button_settings);
            this.panel_menu.Controls.Add(this.button_startGame);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_menu.Location = new System.Drawing.Point(0, 70);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(251, 383);
            this.panel_menu.TabIndex = 1;
            // 
            // button_help
            // 
            this.button_help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(232)))), ((int)(((byte)(187)))));
            this.button_help.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_help.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(237)))), ((int)(((byte)(192)))));
            this.button_help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(242)))), ((int)(((byte)(197)))));
            this.button_help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(237)))), ((int)(((byte)(192)))));
            this.button_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_help.Location = new System.Drawing.Point(0, 271);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(251, 56);
            this.button_help.TabIndex = 3;
            this.button_help.Text = "Справка";
            this.button_help.UseVisualStyleBackColor = false;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Red;
            this.button_exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(113)))), ((int)(((byte)(84)))));
            this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(118)))), ((int)(((byte)(89)))));
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(113)))), ((int)(((byte)(84)))));
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Location = new System.Drawing.Point(0, 327);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(251, 56);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "Выйти из игры";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_settings
            // 
            this.button_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(232)))), ((int)(((byte)(187)))));
            this.button_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_settings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(237)))), ((int)(((byte)(192)))));
            this.button_settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(242)))), ((int)(((byte)(197)))));
            this.button_settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(237)))), ((int)(((byte)(192)))));
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.Location = new System.Drawing.Point(0, 56);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(251, 56);
            this.button_settings.TabIndex = 1;
            this.button_settings.Text = "Настройки";
            this.button_settings.UseVisualStyleBackColor = false;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // button_startGame
            // 
            this.button_startGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(232)))), ((int)(((byte)(187)))));
            this.button_startGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_startGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(237)))), ((int)(((byte)(192)))));
            this.button_startGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(242)))), ((int)(((byte)(197)))));
            this.button_startGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(237)))), ((int)(((byte)(192)))));
            this.button_startGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_startGame.Location = new System.Drawing.Point(0, 0);
            this.button_startGame.Name = "button_startGame";
            this.button_startGame.Size = new System.Drawing.Size(251, 56);
            this.button_startGame.TabIndex = 0;
            this.button_startGame.Text = "Начать игру";
            this.button_startGame.UseVisualStyleBackColor = false;
            this.button_startGame.Click += new System.EventHandler(this.button_startGame_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.label_logo);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(251, 70);
            this.panel_logo.TabIndex = 0;
            // 
            // label_logo
            // 
            this.label_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_logo.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_logo.ForeColor = System.Drawing.Color.White;
            this.label_logo.Location = new System.Drawing.Point(0, 0);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(251, 70);
            this.label_logo.TabIndex = 0;
            this.label_logo.Text = "Менеджмент";
            this.label_logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(197)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(751, 453);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_rightSide);
            this.Controls.Add(this.panel_leftSide);
            this.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджмент";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel_menu.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_leftSide;
        private System.Windows.Forms.Panel panel_rightSide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_startGame;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Label label_logo;
    }
}

