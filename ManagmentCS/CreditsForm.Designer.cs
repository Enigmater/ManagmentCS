namespace ManagmentCS
{
    partial class CreditsForm
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
            this.panel_title = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_info = new System.Windows.Forms.Panel();
            this.panel_debt = new System.Windows.Forms.Panel();
            this.label_debtsAmount = new System.Windows.Forms.Label();
            this.label_debts = new System.Windows.Forms.Label();
            this.panel_money = new System.Windows.Forms.Panel();
            this.label_moneyAmount = new System.Windows.Forms.Label();
            this.label_money = new System.Windows.Forms.Label();
            this.panel_table = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_tableTitle = new System.Windows.Forms.Label();
            this.panel_accept = new System.Windows.Forms.Panel();
            this.button_accept = new System.Windows.Forms.Button();
            this.panel_btns = new System.Windows.Forms.Panel();
            this.radioButton_SFdebt = new System.Windows.Forms.RadioButton();
            this.radioButton_UFdebt = new System.Windows.Forms.RadioButton();
            this.button_getDebt = new System.Windows.Forms.Button();
            this.panel_title.SuspendLayout();
            this.panel_info.SuspendLayout();
            this.panel_debt.SuspendLayout();
            this.panel_money.SuspendLayout();
            this.panel_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_accept.SuspendLayout();
            this.panel_btns.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_title
            // 
            this.panel_title.Controls.Add(this.label_title);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(1144, 85);
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
            this.label_title.Size = new System.Drawing.Size(1144, 85);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Кредиты";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_info
            // 
            this.panel_info.Controls.Add(this.panel_debt);
            this.panel_info.Controls.Add(this.panel_money);
            this.panel_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_info.Location = new System.Drawing.Point(0, 85);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(1144, 209);
            this.panel_info.TabIndex = 4;
            // 
            // panel_debt
            // 
            this.panel_debt.Controls.Add(this.label_debtsAmount);
            this.panel_debt.Controls.Add(this.label_debts);
            this.panel_debt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_debt.Location = new System.Drawing.Point(566, 0);
            this.panel_debt.Name = "panel_debt";
            this.panel_debt.Size = new System.Drawing.Size(578, 209);
            this.panel_debt.TabIndex = 2;
            // 
            // label_debtsAmount
            // 
            this.label_debtsAmount.BackColor = System.Drawing.Color.Red;
            this.label_debtsAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_debtsAmount.Location = new System.Drawing.Point(0, 98);
            this.label_debtsAmount.Name = "label_debtsAmount";
            this.label_debtsAmount.Size = new System.Drawing.Size(578, 38);
            this.label_debtsAmount.TabIndex = 3;
            this.label_debtsAmount.Text = "$$$";
            this.label_debtsAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_debts
            // 
            this.label_debts.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_debts.Location = new System.Drawing.Point(0, 0);
            this.label_debts.Name = "label_debts";
            this.label_debts.Size = new System.Drawing.Size(578, 98);
            this.label_debts.TabIndex = 2;
            this.label_debts.Text = "Сумма долга:";
            this.label_debts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_money
            // 
            this.panel_money.Controls.Add(this.label_moneyAmount);
            this.panel_money.Controls.Add(this.label_money);
            this.panel_money.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_money.Location = new System.Drawing.Point(0, 0);
            this.panel_money.Name = "panel_money";
            this.panel_money.Size = new System.Drawing.Size(566, 209);
            this.panel_money.TabIndex = 1;
            // 
            // label_moneyAmount
            // 
            this.label_moneyAmount.BackColor = System.Drawing.Color.SeaGreen;
            this.label_moneyAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_moneyAmount.Location = new System.Drawing.Point(0, 98);
            this.label_moneyAmount.Name = "label_moneyAmount";
            this.label_moneyAmount.Size = new System.Drawing.Size(566, 38);
            this.label_moneyAmount.TabIndex = 1;
            this.label_moneyAmount.Text = "$$$";
            this.label_moneyAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_money
            // 
            this.label_money.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_money.Location = new System.Drawing.Point(0, 0);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(566, 98);
            this.label_money.TabIndex = 0;
            this.label_money.Text = "Имеющийся капитал:";
            this.label_money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_table
            // 
            this.panel_table.Controls.Add(this.dataGridView1);
            this.panel_table.Controls.Add(this.label_tableTitle);
            this.panel_table.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_table.Location = new System.Drawing.Point(0, 294);
            this.panel_table.Name = "panel_table";
            this.panel_table.Size = new System.Drawing.Size(1144, 166);
            this.panel_table.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amount,
            this.date,
            this.Type});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1144, 108);
            this.dataGridView1.TabIndex = 0;
            // 
            // amount
            // 
            this.amount.FillWeight = 80.21391F;
            this.amount.HeaderText = "Сумма";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // date
            // 
            this.date.FillWeight = 85.06044F;
            this.date.HeaderText = "Выплата через";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.FillWeight = 134.7257F;
            this.Type.HeaderText = "Тип фабрики";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // label_tableTitle
            // 
            this.label_tableTitle.BackColor = System.Drawing.Color.Teal;
            this.label_tableTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_tableTitle.Location = new System.Drawing.Point(0, 0);
            this.label_tableTitle.Name = "label_tableTitle";
            this.label_tableTitle.Size = new System.Drawing.Size(1144, 58);
            this.label_tableTitle.TabIndex = 1;
            this.label_tableTitle.Text = "Ссуды на выплату:";
            this.label_tableTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_accept
            // 
            this.panel_accept.BackColor = System.Drawing.Color.Teal;
            this.panel_accept.Controls.Add(this.button_accept);
            this.panel_accept.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_accept.Location = new System.Drawing.Point(0, 630);
            this.panel_accept.MaximumSize = new System.Drawing.Size(0, 101);
            this.panel_accept.Name = "panel_accept";
            this.panel_accept.Size = new System.Drawing.Size(1144, 90);
            this.panel_accept.TabIndex = 6;
            // 
            // button_accept
            // 
            this.button_accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(220)))), ((int)(((byte)(176)))));
            this.button_accept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
            this.button_accept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button_accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_accept.ForeColor = System.Drawing.Color.White;
            this.button_accept.Location = new System.Drawing.Point(432, 16);
            this.button_accept.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(275, 60);
            this.button_accept.TabIndex = 3;
            this.button_accept.Text = "Подтвердить";
            this.button_accept.UseVisualStyleBackColor = false;
            this.button_accept.Click += new System.EventHandler(this.button_accept_Click);
            // 
            // panel_btns
            // 
            this.panel_btns.Controls.Add(this.radioButton_SFdebt);
            this.panel_btns.Controls.Add(this.radioButton_UFdebt);
            this.panel_btns.Controls.Add(this.button_getDebt);
            this.panel_btns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_btns.Location = new System.Drawing.Point(0, 460);
            this.panel_btns.Name = "panel_btns";
            this.panel_btns.Size = new System.Drawing.Size(1144, 170);
            this.panel_btns.TabIndex = 11;
            // 
            // radioButton_SFdebt
            // 
            this.radioButton_SFdebt.AutoSize = true;
            this.radioButton_SFdebt.Location = new System.Drawing.Point(20, 16);
            this.radioButton_SFdebt.Name = "radioButton_SFdebt";
            this.radioButton_SFdebt.Size = new System.Drawing.Size(414, 32);
            this.radioButton_SFdebt.TabIndex = 8;
            this.radioButton_SFdebt.TabStop = true;
            this.radioButton_SFdebt.Text = "Взять кредить под обычную фабрику";
            this.radioButton_SFdebt.UseVisualStyleBackColor = true;
            // 
            // radioButton_UFdebt
            // 
            this.radioButton_UFdebt.AutoSize = true;
            this.radioButton_UFdebt.Location = new System.Drawing.Point(20, 58);
            this.radioButton_UFdebt.Name = "radioButton_UFdebt";
            this.radioButton_UFdebt.Size = new System.Drawing.Size(530, 32);
            this.radioButton_UFdebt.TabIndex = 9;
            this.radioButton_UFdebt.TabStop = true;
            this.radioButton_UFdebt.Text = "Взять кредит под автоматизированную фабрику";
            this.radioButton_UFdebt.UseVisualStyleBackColor = true;
            // 
            // button_getDebt
            // 
            this.button_getDebt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(220)))), ((int)(((byte)(176)))));
            this.button_getDebt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
            this.button_getDebt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button_getDebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_getDebt.ForeColor = System.Drawing.Color.White;
            this.button_getDebt.Location = new System.Drawing.Point(20, 103);
            this.button_getDebt.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.button_getDebt.Name = "button_getDebt";
            this.button_getDebt.Size = new System.Drawing.Size(275, 60);
            this.button_getDebt.TabIndex = 7;
            this.button_getDebt.Text = "Взять кредит";
            this.button_getDebt.UseVisualStyleBackColor = false;
            this.button_getDebt.Click += new System.EventHandler(this.button_getDebt_Click);
            // 
            // CreditsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(1144, 720);
            this.ControlBox = false;
            this.Controls.Add(this.panel_btns);
            this.Controls.Add(this.panel_accept);
            this.Controls.Add(this.panel_table);
            this.Controls.Add(this.panel_info);
            this.Controls.Add(this.panel_title);
            this.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1162, 767);
            this.MinimumSize = new System.Drawing.Size(1162, 767);
            this.Name = "CreditsForm";
            this.Text = "Кредиты";
            this.Load += new System.EventHandler(this.CreditsForm_Load);
            this.panel_title.ResumeLayout(false);
            this.panel_info.ResumeLayout(false);
            this.panel_debt.ResumeLayout(false);
            this.panel_money.ResumeLayout(false);
            this.panel_table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_accept.ResumeLayout(false);
            this.panel_btns.ResumeLayout(false);
            this.panel_btns.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.Panel panel_debt;
        private System.Windows.Forms.Label label_debtsAmount;
        private System.Windows.Forms.Label label_debts;
        private System.Windows.Forms.Panel panel_money;
        private System.Windows.Forms.Label label_moneyAmount;
        private System.Windows.Forms.Label label_money;
        private System.Windows.Forms.Panel panel_table;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.Label label_tableTitle;
        private System.Windows.Forms.Panel panel_accept;
        private System.Windows.Forms.Button button_accept;
        private System.Windows.Forms.Panel panel_btns;
        private System.Windows.Forms.RadioButton radioButton_SFdebt;
        private System.Windows.Forms.RadioButton radioButton_UFdebt;
        private System.Windows.Forms.Button button_getDebt;
    }
}