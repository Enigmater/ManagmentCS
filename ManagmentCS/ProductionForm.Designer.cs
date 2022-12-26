namespace ManagmentCS
{
    partial class ProductionForm
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
            this.panel_title = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_accept = new System.Windows.Forms.Panel();
            this.button_accept = new System.Windows.Forms.Button();
            this.panel_factories = new System.Windows.Forms.Panel();
            this.panel_UF = new System.Windows.Forms.Panel();
            this.panel_rightAF = new System.Windows.Forms.Panel();
            this.panel_bottomAF = new System.Windows.Forms.Panel();
            this.panel_topUF = new System.Windows.Forms.Panel();
            this.panel_leftAF = new System.Windows.Forms.Panel();
            this.label_costUF = new System.Windows.Forms.Label();
            this.numericUpDown_URM2 = new System.Windows.Forms.NumericUpDown();
            this.label_URM2 = new System.Windows.Forms.Label();
            this.label_UF = new System.Windows.Forms.Label();
            this.panel_btw = new System.Windows.Forms.Panel();
            this.label_info = new System.Windows.Forms.Label();
            this.panel_SF = new System.Windows.Forms.Panel();
            this.panel_rightSF = new System.Windows.Forms.Panel();
            this.panel_bottomSF = new System.Windows.Forms.Panel();
            this.panel_topSF = new System.Windows.Forms.Panel();
            this.panel_leftSF = new System.Windows.Forms.Panel();
            this.label_costSF = new System.Windows.Forms.Label();
            this.numericUpDown_URM1 = new System.Windows.Forms.NumericUpDown();
            this.label_URM1 = new System.Windows.Forms.Label();
            this.label_SF = new System.Windows.Forms.Label();
            this.panel_title.SuspendLayout();
            this.panel_accept.SuspendLayout();
            this.panel_factories.SuspendLayout();
            this.panel_UF.SuspendLayout();
            this.panel_rightAF.SuspendLayout();
            this.panel_leftAF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_URM2)).BeginInit();
            this.panel_btw.SuspendLayout();
            this.panel_SF.SuspendLayout();
            this.panel_rightSF.SuspendLayout();
            this.panel_leftSF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_URM1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_title
            // 
            this.panel_title.Controls.Add(this.label_title);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(1003, 96);
            this.panel_title.TabIndex = 1;
            // 
            // label_title
            // 
            this.label_title.BackColor = System.Drawing.Color.Teal;
            this.label_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_title.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_title.Location = new System.Drawing.Point(0, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(1003, 96);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Заводы";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_accept
            // 
            this.panel_accept.BackColor = System.Drawing.Color.Teal;
            this.panel_accept.Controls.Add(this.button_accept);
            this.panel_accept.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_accept.Location = new System.Drawing.Point(0, 544);
            this.panel_accept.Name = "panel_accept";
            this.panel_accept.Size = new System.Drawing.Size(1003, 101);
            this.panel_accept.TabIndex = 4;
            // 
            // button_accept
            // 
            this.button_accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(220)))), ((int)(((byte)(176)))));
            this.button_accept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
            this.button_accept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button_accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_accept.ForeColor = System.Drawing.Color.White;
            this.button_accept.Location = new System.Drawing.Point(412, 17);
            this.button_accept.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(275, 67);
            this.button_accept.TabIndex = 8;
            this.button_accept.Text = "Подтвердить";
            this.button_accept.UseVisualStyleBackColor = false;
            this.button_accept.Click += new System.EventHandler(this.button_accept_Click);
            // 
            // panel_factories
            // 
            this.panel_factories.Controls.Add(this.panel_UF);
            this.panel_factories.Controls.Add(this.panel_btw);
            this.panel_factories.Controls.Add(this.panel_SF);
            this.panel_factories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_factories.Location = new System.Drawing.Point(0, 96);
            this.panel_factories.MinimumSize = new System.Drawing.Size(0, 627);
            this.panel_factories.Name = "panel_factories";
            this.panel_factories.Size = new System.Drawing.Size(1003, 627);
            this.panel_factories.TabIndex = 6;
            // 
            // panel_UF
            // 
            this.panel_UF.Controls.Add(this.panel_rightAF);
            this.panel_UF.Controls.Add(this.panel_leftAF);
            this.panel_UF.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_UF.Location = new System.Drawing.Point(0, 301);
            this.panel_UF.MaximumSize = new System.Drawing.Size(0, 224);
            this.panel_UF.MinimumSize = new System.Drawing.Size(0, 224);
            this.panel_UF.Name = "panel_UF";
            this.panel_UF.Size = new System.Drawing.Size(1003, 224);
            this.panel_UF.TabIndex = 2;
            // 
            // panel_rightAF
            // 
            this.panel_rightAF.Controls.Add(this.panel_bottomAF);
            this.panel_rightAF.Controls.Add(this.panel_topUF);
            this.panel_rightAF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_rightAF.Location = new System.Drawing.Point(268, 0);
            this.panel_rightAF.Name = "panel_rightAF";
            this.panel_rightAF.Size = new System.Drawing.Size(735, 224);
            this.panel_rightAF.TabIndex = 1;
            // 
            // panel_bottomAF
            // 
            this.panel_bottomAF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bottomAF.Location = new System.Drawing.Point(0, 112);
            this.panel_bottomAF.Name = "panel_bottomAF";
            this.panel_bottomAF.Size = new System.Drawing.Size(735, 112);
            this.panel_bottomAF.TabIndex = 1;
            // 
            // panel_topUF
            // 
            this.panel_topUF.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_topUF.Location = new System.Drawing.Point(0, 0);
            this.panel_topUF.Name = "panel_topUF";
            this.panel_topUF.Size = new System.Drawing.Size(735, 112);
            this.panel_topUF.TabIndex = 0;
            // 
            // panel_leftAF
            // 
            this.panel_leftAF.Controls.Add(this.label_costUF);
            this.panel_leftAF.Controls.Add(this.numericUpDown_URM2);
            this.panel_leftAF.Controls.Add(this.label_URM2);
            this.panel_leftAF.Controls.Add(this.label_UF);
            this.panel_leftAF.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_leftAF.Location = new System.Drawing.Point(0, 0);
            this.panel_leftAF.Name = "panel_leftAF";
            this.panel_leftAF.Size = new System.Drawing.Size(268, 224);
            this.panel_leftAF.TabIndex = 0;
            // 
            // label_costUF
            // 
            this.label_costUF.AutoSize = true;
            this.label_costUF.Location = new System.Drawing.Point(3, 197);
            this.label_costUF.Name = "label_costUF";
            this.label_costUF.Size = new System.Drawing.Size(100, 28);
            this.label_costUF.TabIndex = 6;
            this.label_costUF.Text = "Итого: 0$";
            // 
            // numericUpDown_URM2
            // 
            this.numericUpDown_URM2.BackColor = System.Drawing.Color.Teal;
            this.numericUpDown_URM2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_URM2.ForeColor = System.Drawing.Color.White;
            this.numericUpDown_URM2.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_URM2.Location = new System.Drawing.Point(6, 158);
            this.numericUpDown_URM2.Name = "numericUpDown_URM2";
            this.numericUpDown_URM2.ReadOnly = true;
            this.numericUpDown_URM2.Size = new System.Drawing.Size(249, 32);
            this.numericUpDown_URM2.TabIndex = 5;
            this.numericUpDown_URM2.ValueChanged += new System.EventHandler(this.numericUpDown_URM2_ValueChanged);
            // 
            // label_URM2
            // 
            this.label_URM2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_URM2.Location = new System.Drawing.Point(0, 67);
            this.label_URM2.Name = "label_URM2";
            this.label_URM2.Size = new System.Drawing.Size(268, 78);
            this.label_URM2.TabIndex = 4;
            this.label_URM2.Text = "Доступно ЕСМ для переработки:\r\n";
            // 
            // label_UF
            // 
            this.label_UF.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_UF.Location = new System.Drawing.Point(0, 0);
            this.label_UF.Name = "label_UF";
            this.label_UF.Size = new System.Drawing.Size(268, 67);
            this.label_UF.TabIndex = 3;
            this.label_UF.Text = "Автоматизированные фабрики";
            this.label_UF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_btw
            // 
            this.panel_btw.BackColor = System.Drawing.Color.Teal;
            this.panel_btw.Controls.Add(this.label_info);
            this.panel_btw.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_btw.Location = new System.Drawing.Point(0, 224);
            this.panel_btw.Name = "panel_btw";
            this.panel_btw.Size = new System.Drawing.Size(1003, 77);
            this.panel_btw.TabIndex = 4;
            // 
            // label_info
            // 
            this.label_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_info.Location = new System.Drawing.Point(0, 0);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(1003, 77);
            this.label_info.TabIndex = 4;
            this.label_info.Text = "Кол-во ЕСМ: ";
            this.label_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_SF
            // 
            this.panel_SF.Controls.Add(this.panel_rightSF);
            this.panel_SF.Controls.Add(this.panel_leftSF);
            this.panel_SF.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SF.Location = new System.Drawing.Point(0, 0);
            this.panel_SF.MaximumSize = new System.Drawing.Size(0, 224);
            this.panel_SF.MinimumSize = new System.Drawing.Size(0, 224);
            this.panel_SF.Name = "panel_SF";
            this.panel_SF.Size = new System.Drawing.Size(1003, 224);
            this.panel_SF.TabIndex = 1;
            // 
            // panel_rightSF
            // 
            this.panel_rightSF.Controls.Add(this.panel_bottomSF);
            this.panel_rightSF.Controls.Add(this.panel_topSF);
            this.panel_rightSF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_rightSF.Location = new System.Drawing.Point(268, 0);
            this.panel_rightSF.Name = "panel_rightSF";
            this.panel_rightSF.Size = new System.Drawing.Size(735, 224);
            this.panel_rightSF.TabIndex = 1;
            // 
            // panel_bottomSF
            // 
            this.panel_bottomSF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bottomSF.Location = new System.Drawing.Point(0, 112);
            this.panel_bottomSF.Name = "panel_bottomSF";
            this.panel_bottomSF.Size = new System.Drawing.Size(735, 112);
            this.panel_bottomSF.TabIndex = 1;
            // 
            // panel_topSF
            // 
            this.panel_topSF.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_topSF.Location = new System.Drawing.Point(0, 0);
            this.panel_topSF.Name = "panel_topSF";
            this.panel_topSF.Size = new System.Drawing.Size(735, 112);
            this.panel_topSF.TabIndex = 0;
            // 
            // panel_leftSF
            // 
            this.panel_leftSF.Controls.Add(this.label_costSF);
            this.panel_leftSF.Controls.Add(this.numericUpDown_URM1);
            this.panel_leftSF.Controls.Add(this.label_URM1);
            this.panel_leftSF.Controls.Add(this.label_SF);
            this.panel_leftSF.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_leftSF.Location = new System.Drawing.Point(0, 0);
            this.panel_leftSF.Name = "panel_leftSF";
            this.panel_leftSF.Size = new System.Drawing.Size(268, 224);
            this.panel_leftSF.TabIndex = 0;
            // 
            // label_costSF
            // 
            this.label_costSF.AutoSize = true;
            this.label_costSF.Location = new System.Drawing.Point(3, 193);
            this.label_costSF.Name = "label_costSF";
            this.label_costSF.Size = new System.Drawing.Size(100, 28);
            this.label_costSF.TabIndex = 3;
            this.label_costSF.Text = "Итого: 0$";
            // 
            // numericUpDown_URM1
            // 
            this.numericUpDown_URM1.BackColor = System.Drawing.Color.Teal;
            this.numericUpDown_URM1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_URM1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown_URM1.Location = new System.Drawing.Point(6, 149);
            this.numericUpDown_URM1.Name = "numericUpDown_URM1";
            this.numericUpDown_URM1.ReadOnly = true;
            this.numericUpDown_URM1.Size = new System.Drawing.Size(249, 32);
            this.numericUpDown_URM1.TabIndex = 2;
            this.numericUpDown_URM1.ValueChanged += new System.EventHandler(this.numericUpDown_URM1_ValueChanged);
            // 
            // label_URM1
            // 
            this.label_URM1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_URM1.Location = new System.Drawing.Point(0, 67);
            this.label_URM1.Name = "label_URM1";
            this.label_URM1.Size = new System.Drawing.Size(268, 78);
            this.label_URM1.TabIndex = 1;
            this.label_URM1.Text = "Доступно ЕСМ для переработки:\r\n";
            // 
            // label_SF
            // 
            this.label_SF.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_SF.Location = new System.Drawing.Point(0, 0);
            this.label_SF.Name = "label_SF";
            this.label_SF.Size = new System.Drawing.Size(268, 67);
            this.label_SF.TabIndex = 0;
            this.label_SF.Text = "Обычные\r\nфабрики";
            this.label_SF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(1003, 645);
            this.ControlBox = false;
            this.Controls.Add(this.panel_accept);
            this.Controls.Add(this.panel_factories);
            this.Controls.Add(this.panel_title);
            this.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1021, 692);
            this.MinimumSize = new System.Drawing.Size(1021, 692);
            this.Name = "ProductionForm";
            this.Text = "Производство";
            this.Load += new System.EventHandler(this.ProductionForm_Load);
            this.panel_title.ResumeLayout(false);
            this.panel_accept.ResumeLayout(false);
            this.panel_factories.ResumeLayout(false);
            this.panel_UF.ResumeLayout(false);
            this.panel_rightAF.ResumeLayout(false);
            this.panel_leftAF.ResumeLayout(false);
            this.panel_leftAF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_URM2)).EndInit();
            this.panel_btw.ResumeLayout(false);
            this.panel_SF.ResumeLayout(false);
            this.panel_rightSF.ResumeLayout(false);
            this.panel_leftSF.ResumeLayout(false);
            this.panel_leftSF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_URM1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panel_accept;
        private System.Windows.Forms.Button button_accept;
        private System.Windows.Forms.Panel panel_factories;
        private System.Windows.Forms.Panel panel_UF;
        private System.Windows.Forms.Panel panel_rightAF;
        private System.Windows.Forms.Panel panel_bottomAF;
        private System.Windows.Forms.Panel panel_topUF;
        private System.Windows.Forms.Panel panel_leftAF;
        private System.Windows.Forms.Label label_costUF;
        private System.Windows.Forms.NumericUpDown numericUpDown_URM2;
        private System.Windows.Forms.Label label_URM2;
        private System.Windows.Forms.Label label_UF;
        private System.Windows.Forms.Panel panel_btw;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Panel panel_SF;
        private System.Windows.Forms.Panel panel_rightSF;
        private System.Windows.Forms.Panel panel_bottomSF;
        private System.Windows.Forms.Panel panel_topSF;
        private System.Windows.Forms.Panel panel_leftSF;
        private System.Windows.Forms.Label label_costSF;
        private System.Windows.Forms.NumericUpDown numericUpDown_URM1;
        private System.Windows.Forms.Label label_URM1;
        private System.Windows.Forms.Label label_SF;
    }
}