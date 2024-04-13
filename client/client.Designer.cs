namespace client
{
    partial class client
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
            this.txt_Nhan = new System.Windows.Forms.TextBox();
            this.txt_Gui = new System.Windows.Forms.TextBox();
            this.btn_GuiFile = new System.Windows.Forms.Button();
            this.btn_GuiTinNhan = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnGuiCauHinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Nhan
            // 
            this.txt_Nhan.Location = new System.Drawing.Point(50, 12);
            this.txt_Nhan.Multiline = true;
            this.txt_Nhan.Name = "txt_Nhan";
            this.txt_Nhan.Size = new System.Drawing.Size(534, 343);
            this.txt_Nhan.TabIndex = 0;
            // 
            // txt_Gui
            // 
            this.txt_Gui.Location = new System.Drawing.Point(50, 380);
            this.txt_Gui.Name = "txt_Gui";
            this.txt_Gui.Size = new System.Drawing.Size(100, 22);
            this.txt_Gui.TabIndex = 1;
            // 
            // btn_GuiFile
            // 
            this.btn_GuiFile.Location = new System.Drawing.Point(237, 380);
            this.btn_GuiFile.Name = "btn_GuiFile";
            this.btn_GuiFile.Size = new System.Drawing.Size(75, 23);
            this.btn_GuiFile.TabIndex = 3;
            this.btn_GuiFile.Text = "Gửi File";
            this.btn_GuiFile.UseVisualStyleBackColor = true;
            this.btn_GuiFile.Click += new System.EventHandler(this.btn_GuiFile_Click_1);
            // 
            // btn_GuiTinNhan
            // 
            this.btn_GuiTinNhan.Location = new System.Drawing.Point(156, 380);
            this.btn_GuiTinNhan.Name = "btn_GuiTinNhan";
            this.btn_GuiTinNhan.Size = new System.Drawing.Size(75, 23);
            this.btn_GuiTinNhan.TabIndex = 4;
            this.btn_GuiTinNhan.Text = "GỬi Tin Nhắn";
            this.btn_GuiTinNhan.UseVisualStyleBackColor = true;
            this.btn_GuiTinNhan.Click += new System.EventHandler(this.btn_GuiTinNhan_Click_1);
            // 
            // btnGuiCauHinh
            // 
            this.btnGuiCauHinh.Location = new System.Drawing.Point(361, 362);
            this.btnGuiCauHinh.Name = "btnGuiCauHinh";
            this.btnGuiCauHinh.Size = new System.Drawing.Size(75, 23);
            this.btnGuiCauHinh.TabIndex = 5;
            this.btnGuiCauHinh.Text = "CauHinh";
            this.btnGuiCauHinh.UseVisualStyleBackColor = true;
            this.btnGuiCauHinh.Click += new System.EventHandler(this.btnGuiCauHinh_Click);
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 430);
            this.Controls.Add(this.btnGuiCauHinh);
            this.Controls.Add(this.btn_GuiTinNhan);
            this.Controls.Add(this.btn_GuiFile);
            this.Controls.Add(this.txt_Gui);
            this.Controls.Add(this.txt_Nhan);
            this.Name = "client";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nhan;
        private System.Windows.Forms.TextBox txt_Gui;
        private System.Windows.Forms.Button btn_GuiFile;
        private System.Windows.Forms.Button btn_GuiTinNhan;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnGuiCauHinh;
    }
}

