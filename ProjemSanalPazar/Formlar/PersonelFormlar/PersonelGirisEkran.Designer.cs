namespace ProjemSanalPazar.Formlar.PersonelFormlar
{
    partial class PersonelGirisEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelGirisEkran));
            this.AnaMenuDonButon = new System.Windows.Forms.Button();
            this.PersonelGirisNumaraLabel = new System.Windows.Forms.Label();
            this.PersonelParolaLabel = new System.Windows.Forms.Label();
            this.PersonelNumarasıTextBox = new System.Windows.Forms.TextBox();
            this.PersonelParolaTextBox = new System.Windows.Forms.TextBox();
            this.PersonelGirisButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnaMenuDonButon
            // 
            this.AnaMenuDonButon.Image = ((System.Drawing.Image)(resources.GetObject("AnaMenuDonButon.Image")));
            this.AnaMenuDonButon.Location = new System.Drawing.Point(1, 0);
            this.AnaMenuDonButon.Name = "AnaMenuDonButon";
            this.AnaMenuDonButon.Size = new System.Drawing.Size(144, 95);
            this.AnaMenuDonButon.TabIndex = 7;
            this.AnaMenuDonButon.UseVisualStyleBackColor = true;
            this.AnaMenuDonButon.Click += new System.EventHandler(this.AnaMenuDonButon_Click);
            // 
            // PersonelGirisNumaraLabel
            // 
            this.PersonelGirisNumaraLabel.AutoSize = true;
            this.PersonelGirisNumaraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelGirisNumaraLabel.Location = new System.Drawing.Point(665, 395);
            this.PersonelGirisNumaraLabel.Name = "PersonelGirisNumaraLabel";
            this.PersonelGirisNumaraLabel.Size = new System.Drawing.Size(229, 29);
            this.PersonelGirisNumaraLabel.TabIndex = 8;
            this.PersonelGirisNumaraLabel.Text = "Personel Numarası";
            // 
            // PersonelParolaLabel
            // 
            this.PersonelParolaLabel.AutoSize = true;
            this.PersonelParolaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelParolaLabel.Location = new System.Drawing.Point(665, 492);
            this.PersonelParolaLabel.Name = "PersonelParolaLabel";
            this.PersonelParolaLabel.Size = new System.Drawing.Size(86, 29);
            this.PersonelParolaLabel.TabIndex = 8;
            this.PersonelParolaLabel.Text = "Parola";
            // 
            // PersonelNumarasıTextBox
            // 
            this.PersonelNumarasıTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelNumarasıTextBox.Location = new System.Drawing.Point(927, 395);
            this.PersonelNumarasıTextBox.MaxLength = 10;
            this.PersonelNumarasıTextBox.Name = "PersonelNumarasıTextBox";
            this.PersonelNumarasıTextBox.Size = new System.Drawing.Size(384, 36);
            this.PersonelNumarasıTextBox.TabIndex = 9;
            // 
            // PersonelParolaTextBox
            // 
            this.PersonelParolaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelParolaTextBox.Location = new System.Drawing.Point(927, 492);
            this.PersonelParolaTextBox.MaxLength = 20;
            this.PersonelParolaTextBox.Name = "PersonelParolaTextBox";
            this.PersonelParolaTextBox.Size = new System.Drawing.Size(384, 36);
            this.PersonelParolaTextBox.TabIndex = 9;
            // 
            // PersonelGirisButon
            // 
            this.PersonelGirisButon.Location = new System.Drawing.Point(855, 598);
            this.PersonelGirisButon.Name = "PersonelGirisButon";
            this.PersonelGirisButon.Size = new System.Drawing.Size(339, 87);
            this.PersonelGirisButon.TabIndex = 10;
            this.PersonelGirisButon.Text = "Giriş Yap";
            this.PersonelGirisButon.UseVisualStyleBackColor = true;
            this.PersonelGirisButon.Click += new System.EventHandler(this.PersonelGirisButon_Click);
            // 
            // PersonelGirisEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1770, 755);
            this.Controls.Add(this.PersonelGirisButon);
            this.Controls.Add(this.PersonelParolaTextBox);
            this.Controls.Add(this.PersonelNumarasıTextBox);
            this.Controls.Add(this.PersonelParolaLabel);
            this.Controls.Add(this.PersonelGirisNumaraLabel);
            this.Controls.Add(this.AnaMenuDonButon);
            this.Name = "PersonelGirisEkran";
            this.Text = "PersonelGirisEkran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PersonelGirisEkran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AnaMenuDonButon;
        private System.Windows.Forms.Label PersonelGirisNumaraLabel;
        private System.Windows.Forms.Label PersonelParolaLabel;
        private System.Windows.Forms.TextBox PersonelNumarasıTextBox;
        private System.Windows.Forms.TextBox PersonelParolaTextBox;
        private System.Windows.Forms.Button PersonelGirisButon;
    }
}