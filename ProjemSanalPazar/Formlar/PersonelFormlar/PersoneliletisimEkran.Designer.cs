namespace ProjemSanalPazar.Formlar.PersonelFormlar
{
    partial class PersoneliletisimEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersoneliletisimEkran));
            this.label1 = new System.Windows.Forms.Label();
            this.PersoneliletisimAnketLinkTextBox = new System.Windows.Forms.TextBox();
            this.AnaMenuDonButon = new System.Windows.Forms.Button();
            this.PersoneliletisimAnketLinkButon = new System.Windows.Forms.Button();
            this.PersoneliletisimAnketAdLabel = new System.Windows.Forms.Label();
            this.PersoneliletisimAnketAdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(136, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(661, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eklemek İstediğiniz Anketin Link\'ini Giriniz:";
            // 
            // PersoneliletisimAnketLinkTextBox
            // 
            this.PersoneliletisimAnketLinkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersoneliletisimAnketLinkTextBox.Location = new System.Drawing.Point(882, 213);
            this.PersoneliletisimAnketLinkTextBox.Name = "PersoneliletisimAnketLinkTextBox";
            this.PersoneliletisimAnketLinkTextBox.Size = new System.Drawing.Size(1002, 36);
            this.PersoneliletisimAnketLinkTextBox.TabIndex = 1;
            // 
            // AnaMenuDonButon
            // 
            this.AnaMenuDonButon.Image = ((System.Drawing.Image)(resources.GetObject("AnaMenuDonButon.Image")));
            this.AnaMenuDonButon.Location = new System.Drawing.Point(0, -1);
            this.AnaMenuDonButon.Name = "AnaMenuDonButon";
            this.AnaMenuDonButon.Size = new System.Drawing.Size(144, 95);
            this.AnaMenuDonButon.TabIndex = 32;
            this.AnaMenuDonButon.UseVisualStyleBackColor = true;
            this.AnaMenuDonButon.Click += new System.EventHandler(this.AnaMenuDonButon_Click);
            // 
            // PersoneliletisimAnketLinkButon
            // 
            this.PersoneliletisimAnketLinkButon.BackColor = System.Drawing.Color.SeaGreen;
            this.PersoneliletisimAnketLinkButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersoneliletisimAnketLinkButon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PersoneliletisimAnketLinkButon.Location = new System.Drawing.Point(703, 293);
            this.PersoneliletisimAnketLinkButon.Name = "PersoneliletisimAnketLinkButon";
            this.PersoneliletisimAnketLinkButon.Size = new System.Drawing.Size(620, 99);
            this.PersoneliletisimAnketLinkButon.TabIndex = 33;
            this.PersoneliletisimAnketLinkButon.Text = "Anketi Sisteme Ekle";
            this.PersoneliletisimAnketLinkButon.UseVisualStyleBackColor = false;
            this.PersoneliletisimAnketLinkButon.Click += new System.EventHandler(this.PersoneliletisimAnketLinkButon_Click);
            // 
            // PersoneliletisimAnketAdLabel
            // 
            this.PersoneliletisimAnketAdLabel.AutoSize = true;
            this.PersoneliletisimAnketAdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersoneliletisimAnketAdLabel.Location = new System.Drawing.Point(625, 125);
            this.PersoneliletisimAnketAdLabel.Name = "PersoneliletisimAnketAdLabel";
            this.PersoneliletisimAnketAdLabel.Size = new System.Drawing.Size(172, 39);
            this.PersoneliletisimAnketAdLabel.TabIndex = 34;
            this.PersoneliletisimAnketAdLabel.Text = "Anket Adı:";
            // 
            // PersoneliletisimAnketAdTextBox
            // 
            this.PersoneliletisimAnketAdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersoneliletisimAnketAdTextBox.Location = new System.Drawing.Point(882, 128);
            this.PersoneliletisimAnketAdTextBox.Name = "PersoneliletisimAnketAdTextBox";
            this.PersoneliletisimAnketAdTextBox.Size = new System.Drawing.Size(476, 36);
            this.PersoneliletisimAnketAdTextBox.TabIndex = 35;
            // 
            // PersoneliletisimEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1792, 760);
            this.Controls.Add(this.PersoneliletisimAnketAdTextBox);
            this.Controls.Add(this.PersoneliletisimAnketAdLabel);
            this.Controls.Add(this.PersoneliletisimAnketLinkButon);
            this.Controls.Add(this.AnaMenuDonButon);
            this.Controls.Add(this.PersoneliletisimAnketLinkTextBox);
            this.Controls.Add(this.label1);
            this.Name = "PersoneliletisimEkran";
            this.Text = "PersoneliletisimEkran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PersoneliletisimEkran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PersoneliletisimAnketLinkTextBox;
        private System.Windows.Forms.Button AnaMenuDonButon;
        private System.Windows.Forms.Button PersoneliletisimAnketLinkButon;
        private System.Windows.Forms.Label PersoneliletisimAnketAdLabel;
        private System.Windows.Forms.TextBox PersoneliletisimAnketAdTextBox;
    }
}