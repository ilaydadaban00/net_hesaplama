namespace sorunet_hesaplama
{
    partial class Form1
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblYanlıs = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.cmbYanlis = new System.Windows.Forms.ComboBox();
            this.cmbDogru = new System.Windows.Forms.ComboBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(112, 218);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "net";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblYanlıs
            // 
            this.lblYanlıs.AutoSize = true;
            this.lblYanlıs.Location = new System.Drawing.Point(27, 86);
            this.lblYanlıs.Name = "lblYanlıs";
            this.lblYanlıs.Size = new System.Drawing.Size(33, 13);
            this.lblYanlıs.TabIndex = 5;
            this.lblYanlıs.Text = "yanlış";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(27, 132);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(34, 13);
            this.label.TabIndex = 6;
            this.label.Text = "doğru";
            // 
            // cmbYanlis
            // 
            this.cmbYanlis.FormattingEnabled = true;
            this.cmbYanlis.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "",
            "7",
            "8",
            "9",
            "10"});
            this.cmbYanlis.Location = new System.Drawing.Point(112, 86);
            this.cmbYanlis.Name = "cmbYanlis";
            this.cmbYanlis.Size = new System.Drawing.Size(121, 21);
            this.cmbYanlis.TabIndex = 7;
            // 
            // cmbDogru
            // 
            this.cmbDogru.FormattingEnabled = true;
            this.cmbDogru.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "",
            "7",
            "8",
            "9",
            "10"});
            this.cmbDogru.Location = new System.Drawing.Point(112, 132);
            this.cmbDogru.Name = "cmbDogru";
            this.cmbDogru.Size = new System.Drawing.Size(121, 21);
            this.cmbDogru.TabIndex = 8;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(27, 175);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(22, 13);
            this.lblSonuc.TabIndex = 9;
            this.lblSonuc.Text = "net";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 314);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.cmbDogru);
            this.Controls.Add(this.cmbYanlis);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblYanlıs);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "soru sayısı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblYanlıs;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cmbYanlis;
        private System.Windows.Forms.ComboBox cmbDogru;
        private System.Windows.Forms.Label lblSonuc;
    }
}

