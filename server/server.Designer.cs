namespace server
{
    partial class server
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
            this.ChaxBox = new System.Windows.Forms.Panel();
            this.txt_TinNhan = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_DanhBa = new System.Windows.Forms.TextBox();
            this.btn_GuiTinNhan = new System.Windows.Forms.Button();
            this.btn_GuiFile = new System.Windows.Forms.Button();
            this.txt_NhapTinNhan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TatMayClient = new System.Windows.Forms.Button();
            this.ChaxBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChaxBox
            // 
            this.ChaxBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChaxBox.Controls.Add(this.txt_TinNhan);
            this.ChaxBox.Location = new System.Drawing.Point(12, 22);
            this.ChaxBox.Name = "ChaxBox";
            this.ChaxBox.Size = new System.Drawing.Size(442, 440);
            this.ChaxBox.TabIndex = 0;
            // 
            // txt_TinNhan
            // 
            this.txt_TinNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TinNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TinNhan.Location = new System.Drawing.Point(0, 0);
            this.txt_TinNhan.Multiline = true;
            this.txt_TinNhan.Name = "txt_TinNhan";
            this.txt_TinNhan.Size = new System.Drawing.Size(440, 438);
            this.txt_TinNhan.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_DanhBa);
            this.panel2.Location = new System.Drawing.Point(460, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 439);
            this.panel2.TabIndex = 1;
            // 
            // txt_DanhBa
            // 
            this.txt_DanhBa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DanhBa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_DanhBa.Enabled = false;
            this.txt_DanhBa.Location = new System.Drawing.Point(0, 0);
            this.txt_DanhBa.Multiline = true;
            this.txt_DanhBa.Name = "txt_DanhBa";
            this.txt_DanhBa.Size = new System.Drawing.Size(218, 439);
            this.txt_DanhBa.TabIndex = 0;
            // 
            // btn_GuiTinNhan
            // 
            this.btn_GuiTinNhan.Location = new System.Drawing.Point(221, 467);
            this.btn_GuiTinNhan.Name = "btn_GuiTinNhan";
            this.btn_GuiTinNhan.Size = new System.Drawing.Size(113, 57);
            this.btn_GuiTinNhan.TabIndex = 2;
            this.btn_GuiTinNhan.Text = "Gửi Tin Nhắn";
            this.btn_GuiTinNhan.UseVisualStyleBackColor = true;
            this.btn_GuiTinNhan.Click += new System.EventHandler(this.btn_GuiTinNhan_Click);
            // 
            // btn_GuiFile
            // 
            this.btn_GuiFile.Location = new System.Drawing.Point(340, 468);
            this.btn_GuiFile.Name = "btn_GuiFile";
            this.btn_GuiFile.Size = new System.Drawing.Size(114, 56);
            this.btn_GuiFile.TabIndex = 3;
            this.btn_GuiFile.Text = "Gửi FIle";
            this.btn_GuiFile.UseVisualStyleBackColor = true;
            this.btn_GuiFile.Click += new System.EventHandler(this.btn_GuiFile_Click);
            // 
            // txt_NhapTinNhan
            // 
            this.txt_NhapTinNhan.Location = new System.Drawing.Point(13, 469);
            this.txt_NhapTinNhan.Multiline = true;
            this.txt_NhapTinNhan.Name = "txt_NhapTinNhan";
            this.txt_NhapTinNhan.Size = new System.Drawing.Size(202, 55);
            this.txt_NhapTinNhan.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Bạ";
            // 
            // btn_TatMayClient
            // 
            this.btn_TatMayClient.Location = new System.Drawing.Point(460, 467);
            this.btn_TatMayClient.Name = "btn_TatMayClient";
            this.btn_TatMayClient.Size = new System.Drawing.Size(101, 57);
            this.btn_TatMayClient.TabIndex = 6;
            this.btn_TatMayClient.Text = "Tắt CLinet";
            this.btn_TatMayClient.UseVisualStyleBackColor = true;
            this.btn_TatMayClient.Click += new System.EventHandler(this.btn_TatMayClient_Click);
            // 
            // server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 538);
            this.Controls.Add(this.btn_TatMayClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NhapTinNhan);
            this.Controls.Add(this.btn_GuiFile);
            this.Controls.Add(this.btn_GuiTinNhan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ChaxBox);
            this.Name = "server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ChaxBox.ResumeLayout(false);
            this.ChaxBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ChaxBox;
        private System.Windows.Forms.TextBox txt_TinNhan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_DanhBa;
        private System.Windows.Forms.Button btn_GuiTinNhan;
        private System.Windows.Forms.Button btn_GuiFile;
        private System.Windows.Forms.TextBox txt_NhapTinNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TatMayClient;
    }
}

