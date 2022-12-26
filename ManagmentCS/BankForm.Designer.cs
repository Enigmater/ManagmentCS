namespace ManagmentCS
{
    partial class BankForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_title = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_table = new System.Windows.Forms.Panel();
            this.dataGridView_bank = new System.Windows.Forms.DataGridView();
            this.AviableURM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AviableUFP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_accept = new System.Windows.Forms.Panel();
            this.button_accept = new System.Windows.Forms.Button();
            this.panel_input = new System.Windows.Forms.Panel();
            this.panel_rightSide = new System.Windows.Forms.Panel();
            this.label_UFP = new System.Windows.Forms.Label();
            this.checkBox_bargainUFP = new System.Windows.Forms.CheckBox();
            this.label_priceUFM = new System.Windows.Forms.Label();
            this.label_amountUFM = new System.Windows.Forms.Label();
            this.numericUpDown_priceUFP = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_amountUFP = new System.Windows.Forms.NumericUpDown();
            this.panel_leftSide = new System.Windows.Forms.Panel();
            this.label_URM = new System.Windows.Forms.Label();
            this.checkBox_bargainURM = new System.Windows.Forms.CheckBox();
            this.label_priceURM = new System.Windows.Forms.Label();
            this.label_AmountURM = new System.Windows.Forms.Label();
            this.numericUpDown_priceURM = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_amountURM = new System.Windows.Forms.NumericUpDown();
            this.panel_title.SuspendLayout();
            this.panel_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bank)).BeginInit();
            this.panel_accept.SuspendLayout();
            this.panel_input.SuspendLayout();
            this.panel_rightSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_priceUFP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amountUFP)).BeginInit();
            this.panel_leftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_priceURM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amountURM)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_title
            // 
            this.panel_title.Controls.Add(this.label_title);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(1002, 100);
            this.panel_title.TabIndex = 1;
            // 
            // label_title
            // 
            this.label_title.BackColor = System.Drawing.Color.Teal;
            this.label_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_title.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_title.Location = new System.Drawing.Point(0, 0);
            this.label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(1002, 100);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Банк";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_table
            // 
            this.panel_table.Controls.Add(this.dataGridView_bank);
            this.panel_table.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_table.Location = new System.Drawing.Point(0, 100);
            this.panel_table.Name = "panel_table";
            this.panel_table.Size = new System.Drawing.Size(1002, 96);
            this.panel_table.TabIndex = 3;
            // 
            // dataGridView_bank
            // 
            this.dataGridView_bank.AllowUserToAddRows = false;
            this.dataGridView_bank.AllowUserToDeleteRows = false;
            this.dataGridView_bank.AllowUserToResizeColumns = false;
            this.dataGridView_bank.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridView_bank.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_bank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_bank.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_bank.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
            this.dataGridView_bank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_bank.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_bank.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_bank.ColumnHeadersHeight = 29;
            this.dataGridView_bank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AviableURM,
            this.AviableUFP});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_bank.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_bank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_bank.EnableHeadersVisualStyles = false;
            this.dataGridView_bank.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
            this.dataGridView_bank.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridView_bank.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_bank.Name = "dataGridView_bank";
            this.dataGridView_bank.ReadOnly = true;
            this.dataGridView_bank.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.NullValue = "Значение";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_bank.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_bank.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_bank.RowTemplate.Height = 24;
            this.dataGridView_bank.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_bank.Size = new System.Drawing.Size(1002, 96);
            this.dataGridView_bank.TabIndex = 1;
            // 
            // AviableURM
            // 
            this.AviableURM.HeaderText = "ЕМП";
            this.AviableURM.MinimumWidth = 6;
            this.AviableURM.Name = "AviableURM";
            this.AviableURM.ReadOnly = true;
            // 
            // AviableUFP
            // 
            this.AviableUFP.HeaderText = "ЕГП";
            this.AviableUFP.MinimumWidth = 6;
            this.AviableUFP.Name = "AviableUFP";
            this.AviableUFP.ReadOnly = true;
            // 
            // panel_accept
            // 
            this.panel_accept.Controls.Add(this.button_accept);
            this.panel_accept.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_accept.Location = new System.Drawing.Point(0, 393);
            this.panel_accept.Name = "panel_accept";
            this.panel_accept.Size = new System.Drawing.Size(1002, 60);
            this.panel_accept.TabIndex = 4;
            // 
            // button_accept
            // 
            this.button_accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(220)))), ((int)(((byte)(176)))));
            this.button_accept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
            this.button_accept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button_accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_accept.ForeColor = System.Drawing.Color.White;
            this.button_accept.Location = new System.Drawing.Point(376, 0);
            this.button_accept.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(275, 67);
            this.button_accept.TabIndex = 7;
            this.button_accept.Text = "Подтвердить";
            this.button_accept.UseVisualStyleBackColor = false;
            this.button_accept.Click += new System.EventHandler(this.button_accept_Click);
            // 
            // panel_input
            // 
            this.panel_input.Controls.Add(this.panel_rightSide);
            this.panel_input.Controls.Add(this.panel_leftSide);
            this.panel_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_input.Location = new System.Drawing.Point(0, 196);
            this.panel_input.Name = "panel_input";
            this.panel_input.Size = new System.Drawing.Size(1002, 197);
            this.panel_input.TabIndex = 9;
            // 
            // panel_rightSide
            // 
            this.panel_rightSide.Controls.Add(this.label_UFP);
            this.panel_rightSide.Controls.Add(this.checkBox_bargainUFP);
            this.panel_rightSide.Controls.Add(this.label_priceUFM);
            this.panel_rightSide.Controls.Add(this.label_amountUFM);
            this.panel_rightSide.Controls.Add(this.numericUpDown_priceUFP);
            this.panel_rightSide.Controls.Add(this.numericUpDown_amountUFP);
            this.panel_rightSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_rightSide.Location = new System.Drawing.Point(500, 0);
            this.panel_rightSide.MaximumSize = new System.Drawing.Size(550, 0);
            this.panel_rightSide.Name = "panel_rightSide";
            this.panel_rightSide.Size = new System.Drawing.Size(502, 197);
            this.panel_rightSide.TabIndex = 1;
            // 
            // label_UFP
            // 
            this.label_UFP.AutoSize = true;
            this.label_UFP.Location = new System.Drawing.Point(189, 9);
            this.label_UFP.Name = "label_UFP";
            this.label_UFP.Size = new System.Drawing.Size(150, 28);
            this.label_UFP.TabIndex = 7;
            this.label_UFP.Text = "ЕГП доступно: ";
            // 
            // checkBox_bargainUFP
            // 
            this.checkBox_bargainUFP.AutoSize = true;
            this.checkBox_bargainUFP.Location = new System.Drawing.Point(12, 9);
            this.checkBox_bargainUFP.Name = "checkBox_bargainUFP";
            this.checkBox_bargainUFP.Size = new System.Drawing.Size(155, 32);
            this.checkBox_bargainUFP.TabIndex = 6;
            this.checkBox_bargainUFP.Text = "Продать ЕГП";
            this.checkBox_bargainUFP.UseVisualStyleBackColor = true;
            this.checkBox_bargainUFP.CheckedChanged += new System.EventHandler(this.checkBox_bargainUFP_CheckedChanged);
            // 
            // label_priceUFM
            // 
            this.label_priceUFM.AutoSize = true;
            this.label_priceUFM.Location = new System.Drawing.Point(7, 129);
            this.label_priceUFM.Name = "label_priceUFM";
            this.label_priceUFM.Size = new System.Drawing.Size(153, 28);
            this.label_priceUFM.TabIndex = 5;
            this.label_priceUFM.Text = "Цена за штуку";
            // 
            // label_amountUFM
            // 
            this.label_amountUFM.AutoSize = true;
            this.label_amountUFM.Location = new System.Drawing.Point(7, 48);
            this.label_amountUFM.Name = "label_amountUFM";
            this.label_amountUFM.Size = new System.Drawing.Size(201, 28);
            this.label_amountUFM.TabIndex = 4;
            this.label_amountUFM.Text = "Кол-во на продажу";
            // 
            // numericUpDown_priceUFP
            // 
            this.numericUpDown_priceUFP.BackColor = System.Drawing.Color.Teal;
            this.numericUpDown_priceUFP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_priceUFP.ForeColor = System.Drawing.Color.White;
            this.numericUpDown_priceUFP.Location = new System.Drawing.Point(12, 164);
            this.numericUpDown_priceUFP.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_priceUFP.Name = "numericUpDown_priceUFP";
            this.numericUpDown_priceUFP.Size = new System.Drawing.Size(474, 32);
            this.numericUpDown_priceUFP.TabIndex = 3;
            // 
            // numericUpDown_amountUFP
            // 
            this.numericUpDown_amountUFP.BackColor = System.Drawing.Color.Teal;
            this.numericUpDown_amountUFP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_amountUFP.ForeColor = System.Drawing.Color.White;
            this.numericUpDown_amountUFP.Location = new System.Drawing.Point(12, 80);
            this.numericUpDown_amountUFP.Name = "numericUpDown_amountUFP";
            this.numericUpDown_amountUFP.Size = new System.Drawing.Size(474, 32);
            this.numericUpDown_amountUFP.TabIndex = 2;
            // 
            // panel_leftSide
            // 
            this.panel_leftSide.Controls.Add(this.label_URM);
            this.panel_leftSide.Controls.Add(this.checkBox_bargainURM);
            this.panel_leftSide.Controls.Add(this.label_priceURM);
            this.panel_leftSide.Controls.Add(this.label_AmountURM);
            this.panel_leftSide.Controls.Add(this.numericUpDown_priceURM);
            this.panel_leftSide.Controls.Add(this.numericUpDown_amountURM);
            this.panel_leftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_leftSide.Location = new System.Drawing.Point(0, 0);
            this.panel_leftSide.MaximumSize = new System.Drawing.Size(550, 0);
            this.panel_leftSide.Name = "panel_leftSide";
            this.panel_leftSide.Size = new System.Drawing.Size(500, 197);
            this.panel_leftSide.TabIndex = 0;
            // 
            // label_URM
            // 
            this.label_URM.AutoSize = true;
            this.label_URM.Location = new System.Drawing.Point(207, 9);
            this.label_URM.Name = "label_URM";
            this.label_URM.Size = new System.Drawing.Size(157, 28);
            this.label_URM.TabIndex = 5;
            this.label_URM.Text = "ЕСМ доступно: ";
            // 
            // checkBox_bargainURM
            // 
            this.checkBox_bargainURM.AutoSize = true;
            this.checkBox_bargainURM.Location = new System.Drawing.Point(13, 9);
            this.checkBox_bargainURM.Name = "checkBox_bargainURM";
            this.checkBox_bargainURM.Size = new System.Drawing.Size(170, 32);
            this.checkBox_bargainURM.TabIndex = 4;
            this.checkBox_bargainURM.Text = "Закупить ЕСМ";
            this.checkBox_bargainURM.UseVisualStyleBackColor = true;
            this.checkBox_bargainURM.CheckedChanged += new System.EventHandler(this.checkBox_bargainURM_CheckedChanged);
            // 
            // label_priceURM
            // 
            this.label_priceURM.AutoSize = true;
            this.label_priceURM.Location = new System.Drawing.Point(8, 129);
            this.label_priceURM.Name = "label_priceURM";
            this.label_priceURM.Size = new System.Drawing.Size(153, 28);
            this.label_priceURM.TabIndex = 3;
            this.label_priceURM.Text = "Цена за штуку";
            // 
            // label_AmountURM
            // 
            this.label_AmountURM.AutoSize = true;
            this.label_AmountURM.Location = new System.Drawing.Point(8, 48);
            this.label_AmountURM.Name = "label_AmountURM";
            this.label_AmountURM.Size = new System.Drawing.Size(192, 28);
            this.label_AmountURM.TabIndex = 2;
            this.label_AmountURM.Text = "Кол-во на закупку";
            // 
            // numericUpDown_priceURM
            // 
            this.numericUpDown_priceURM.BackColor = System.Drawing.Color.Teal;
            this.numericUpDown_priceURM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_priceURM.ForeColor = System.Drawing.Color.White;
            this.numericUpDown_priceURM.Location = new System.Drawing.Point(13, 164);
            this.numericUpDown_priceURM.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_priceURM.Name = "numericUpDown_priceURM";
            this.numericUpDown_priceURM.Size = new System.Drawing.Size(474, 32);
            this.numericUpDown_priceURM.TabIndex = 1;
            // 
            // numericUpDown_amountURM
            // 
            this.numericUpDown_amountURM.BackColor = System.Drawing.Color.Teal;
            this.numericUpDown_amountURM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_amountURM.ForeColor = System.Drawing.Color.White;
            this.numericUpDown_amountURM.Location = new System.Drawing.Point(13, 80);
            this.numericUpDown_amountURM.Name = "numericUpDown_amountURM";
            this.numericUpDown_amountURM.Size = new System.Drawing.Size(474, 32);
            this.numericUpDown_amountURM.TabIndex = 0;
            // 
            // BankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(1002, 453);
            this.ControlBox = false;
            this.Controls.Add(this.panel_input);
            this.Controls.Add(this.panel_accept);
            this.Controls.Add(this.panel_table);
            this.Controls.Add(this.panel_title);
            this.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximumSize = new System.Drawing.Size(1020, 500);
            this.MinimumSize = new System.Drawing.Size(1020, 500);
            this.Name = "BankForm";
            this.Text = "BankForm";
            this.Load += new System.EventHandler(this.BankForm_Load);
            this.panel_title.ResumeLayout(false);
            this.panel_table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bank)).EndInit();
            this.panel_accept.ResumeLayout(false);
            this.panel_input.ResumeLayout(false);
            this.panel_rightSide.ResumeLayout(false);
            this.panel_rightSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_priceUFP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amountUFP)).EndInit();
            this.panel_leftSide.ResumeLayout(false);
            this.panel_leftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_priceURM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amountURM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panel_table;
        private System.Windows.Forms.DataGridView dataGridView_bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn AviableURM;
        private System.Windows.Forms.DataGridViewTextBoxColumn AviableUFP;
        private System.Windows.Forms.Panel panel_accept;
        private System.Windows.Forms.Button button_accept;
        private System.Windows.Forms.Panel panel_input;
        private System.Windows.Forms.Panel panel_rightSide;
        private System.Windows.Forms.Label label_UFP;
        private System.Windows.Forms.CheckBox checkBox_bargainUFP;
        private System.Windows.Forms.Label label_priceUFM;
        private System.Windows.Forms.Label label_amountUFM;
        private System.Windows.Forms.NumericUpDown numericUpDown_priceUFP;
        private System.Windows.Forms.NumericUpDown numericUpDown_amountUFP;
        private System.Windows.Forms.Panel panel_leftSide;
        private System.Windows.Forms.Label label_URM;
        private System.Windows.Forms.CheckBox checkBox_bargainURM;
        private System.Windows.Forms.Label label_priceURM;
        private System.Windows.Forms.Label label_AmountURM;
        private System.Windows.Forms.NumericUpDown numericUpDown_priceURM;
        private System.Windows.Forms.NumericUpDown numericUpDown_amountURM;
    }
}