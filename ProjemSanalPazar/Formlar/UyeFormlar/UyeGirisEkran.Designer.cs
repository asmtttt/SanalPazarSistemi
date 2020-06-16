namespace ProjemSanalPazar.Formlar
{
    partial class AlisverisPaketlerEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlisverisPaketlerEkran));
            this.ParolaTextBox = new System.Windows.Forms.TextBox();
            this.EpostaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AnaMenuDonButon = new System.Windows.Forms.Button();
            this.UyeGirisButon = new System.Windows.Forms.Button();
            this.ParolaUnuttumLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ParolaTextBox
            // 
            this.ParolaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ParolaTextBox.ForeColor = System.Drawing.Color.Red;
            this.ParolaTextBox.Location = new System.Drawing.Point(879, 509);
            this.ParolaTextBox.MaxLength = 10;
            this.ParolaTextBox.Name = "ParolaTextBox";
            this.ParolaTextBox.Size = new System.Drawing.Size(398, 36);
            this.ParolaTextBox.TabIndex = 4;
            this.ParolaTextBox.Text = "En Fazla 10 Karakter Giriniz";
            this.ParolaTextBox.Enter += new System.EventHandler(this.ParolaTextBox_Enter);
            // 
            // EpostaTextBox
            // 
            this.EpostaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EpostaTextBox.ForeColor = System.Drawing.Color.Red;
            this.EpostaTextBox.Location = new System.Drawing.Point(879, 431);
            this.EpostaTextBox.MaxLength = 50;
            this.EpostaTextBox.Name = "EpostaTextBox";
            this.EpostaTextBox.Size = new System.Drawing.Size(398, 36);
            this.EpostaTextBox.TabIndex = 5;
            this.EpostaTextBox.Text = "Örnek; samet.ocsoy@gmail.com";
            this.EpostaTextBox.Enter += new System.EventHandler(this.EpostaTextBox_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(675, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Parola:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(675, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "E-Posta:";
            // 
            // AnaMenuDonButon
            // 
            this.AnaMenuDonButon.Image = ((System.Drawing.Image)(resources.GetObject("AnaMenuDonButon.Image")));
            this.AnaMenuDonButon.Location = new System.Drawing.Point(1, 0);
            this.AnaMenuDonButon.Name = "AnaMenuDonButon";
            this.AnaMenuDonButon.Size = new System.Drawing.Size(144, 95);
            this.AnaMenuDonButon.TabIndex = 6;
            this.AnaMenuDonButon.UseVisualStyleBackColor = true;
            this.AnaMenuDonButon.Click += new System.EventHandler(this.AnaMenuDonButon_Click);
            // 
            // UyeGirisButon
            // 
            this.UyeGirisButon.Location = new System.Drawing.Point(838, 641);
            this.UyeGirisButon.Name = "UyeGirisButon";
            this.UyeGirisButon.Size = new System.Drawing.Size(239, 73);
            this.UyeGirisButon.TabIndex = 7;
            this.UyeGirisButon.Text = "Giriş Yap";
            this.UyeGirisButon.UseVisualStyleBackColor = true;
            this.UyeGirisButon.Click += new System.EventHandler(this.UyeGirisButon_Click);
            // 
            // ParolaUnuttumLinkLabel
            // 
            this.ParolaUnuttumLinkLabel.AutoSize = true;
            this.ParolaUnuttumLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ParolaUnuttumLinkLabel.Location = new System.Drawing.Point(874, 586);
            this.ParolaUnuttumLinkLabel.Name = "ParolaUnuttumLinkLabel";
            this.ParolaUnuttumLinkLabel.Size = new System.Drawing.Size(170, 26);
            this.ParolaUnuttumLinkLabel.TabIndex = 8;
            this.ParolaUnuttumLinkLabel.TabStop = true;
            this.ParolaUnuttumLinkLabel.Text = "Parola Unuttum!";
            this.ParolaUnuttumLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ParolaUnuttumLinkLabel_LinkClicked);
            // 
            // UyeGirisEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1770, 755);
            this.Controls.Add(this.ParolaUnuttumLinkLabel);
            this.Controls.Add(this.UyeGirisButon);
            this.Controls.Add(this.AnaMenuDonButon);
            this.Controls.Add(this.ParolaTextBox);
            this.Controls.Add(this.EpostaTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "UyeGirisEkran";
            this.Text = "UyeGirisEkran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UyeGirisEkran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ParolaTextBox;
        private System.Windows.Forms.TextBox EpostaTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AnaMenuDonButon;
        private System.Windows.Forms.Button UyeGirisButon;
        private System.Windows.Forms.LinkLabel ParolaUnuttumLinkLabel;
    }
}