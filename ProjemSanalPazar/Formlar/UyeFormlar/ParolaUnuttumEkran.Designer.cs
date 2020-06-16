namespace ProjemSanalPazar.Formlar
{
    partial class ParolaUnuttumEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParolaUnuttumEkran));
            this.EpostaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TelefonTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AnaMenuDonButon = new System.Windows.Forms.Button();
            this.ParolaGonderButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EpostaTextBox
            // 
            this.EpostaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EpostaTextBox.ForeColor = System.Drawing.Color.Red;
            this.EpostaTextBox.Location = new System.Drawing.Point(867, 513);
            this.EpostaTextBox.MaxLength = 50;
            this.EpostaTextBox.Name = "EpostaTextBox";
            this.EpostaTextBox.Size = new System.Drawing.Size(398, 36);
            this.EpostaTextBox.TabIndex = 7;
            this.EpostaTextBox.Text = "Örnek; samet.ocsoy@gmail.com";
            this.EpostaTextBox.Enter += new System.EventHandler(this.EpostaTextBox_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(663, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "E-Posta:";
            // 
            // TelefonTextBox
            // 
            this.TelefonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TelefonTextBox.ForeColor = System.Drawing.Color.Red;
            this.TelefonTextBox.Location = new System.Drawing.Point(867, 436);
            this.TelefonTextBox.MaxLength = 11;
            this.TelefonTextBox.Name = "TelefonTextBox";
            this.TelefonTextBox.Size = new System.Drawing.Size(398, 36);
            this.TelefonTextBox.TabIndex = 9;
            this.TelefonTextBox.Text = "Örnek; 05447258236";
            this.TelefonTextBox.TextChanged += new System.EventHandler(this.TelefonTextBox_TextChanged);
            this.TelefonTextBox.Enter += new System.EventHandler(this.TelefonTextBox_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(663, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefon:";
            // 
            // AnaMenuDonButon
            // 
            this.AnaMenuDonButon.Image = ((System.Drawing.Image)(resources.GetObject("AnaMenuDonButon.Image")));
            this.AnaMenuDonButon.Location = new System.Drawing.Point(-1, 1);
            this.AnaMenuDonButon.Name = "AnaMenuDonButon";
            this.AnaMenuDonButon.Size = new System.Drawing.Size(144, 95);
            this.AnaMenuDonButon.TabIndex = 10;
            this.AnaMenuDonButon.UseVisualStyleBackColor = true;
            this.AnaMenuDonButon.Click += new System.EventHandler(this.AnaMenuDonButon_Click);
            // 
            // ParolaGonderButon
            // 
            this.ParolaGonderButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ParolaGonderButon.Location = new System.Drawing.Point(779, 610);
            this.ParolaGonderButon.Name = "ParolaGonderButon";
            this.ParolaGonderButon.Size = new System.Drawing.Size(354, 72);
            this.ParolaGonderButon.TabIndex = 11;
            this.ParolaGonderButon.Text = "Şifremi Mail Adresime Gönder";
            this.ParolaGonderButon.UseVisualStyleBackColor = true;
            // 
            // ParolaUnuttumEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 749);
            this.Controls.Add(this.ParolaGonderButon);
            this.Controls.Add(this.AnaMenuDonButon);
            this.Controls.Add(this.TelefonTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EpostaTextBox);
            this.Controls.Add(this.label5);
            this.Name = "ParolaUnuttumEkran";
            this.Text = "ParolaUnuttumEkran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ParolaUnuttumEkran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EpostaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TelefonTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AnaMenuDonButon;
        private System.Windows.Forms.Button ParolaGonderButon;
    }
}