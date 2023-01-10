namespace Đồ_án_cuối_năm
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_AppName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pn_History = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pn_History.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.lb_AppName);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.pb_Logo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 116);
            this.panel1.TabIndex = 3;
            // 
            // lb_AppName
            // 
            this.lb_AppName.AutoSize = true;
            this.lb_AppName.BackColor = System.Drawing.Color.Transparent;
            this.lb_AppName.Font = new System.Drawing.Font("SVN-Appleberry", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AppName.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_AppName.Location = new System.Drawing.Point(118, -9);
            this.lb_AppName.Name = "lb_AppName";
            this.lb_AppName.Size = new System.Drawing.Size(281, 118);
            this.lb_AppName.TabIndex = 7;
            this.lb_AppName.Text = "Sinder";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SVN-Appleberry", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(12, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 44);
            this.label9.TabIndex = 6;
            this.label9.Text = "Lịch sử tin nhắn";
            // 
            // pn_History
            // 
            this.pn_History.BackColor = System.Drawing.Color.LightCoral;
            this.pn_History.Controls.Add(this.label2);
            this.pn_History.Controls.Add(this.label1);
            this.pn_History.Location = new System.Drawing.Point(44, 205);
            this.pn_History.Name = "pn_History";
            this.pn_History.Size = new System.Drawing.Size(606, 670);
            this.pn_History.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SVN-Appleberry", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(323, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 44);
            this.label2.TabIndex = 9;
            this.label2.Text = "lần cuối trò chuyện";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SVN-Appleberry", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "tên người đc nhắn";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSalmon;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(645, 9);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(48, 48);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pb_Logo
            // 
            this.pb_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Logo.BackgroundImage")));
            this.pb_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Logo.Location = new System.Drawing.Point(12, 9);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(100, 100);
            this.pb_Logo.TabIndex = 1;
            this.pb_Logo.TabStop = false;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(705, 918);
            this.Controls.Add(this.pn_History);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_History.ResumeLayout(false);
            this.pn_History.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_AppName;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pn_History;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}