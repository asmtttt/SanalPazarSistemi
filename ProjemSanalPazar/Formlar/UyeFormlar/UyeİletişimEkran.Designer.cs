namespace ProjemSanalPazar.Formlar
{
    partial class UyeİletişimEkran
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeİletişimEkran));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AnaMenuDonButon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.anketAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anketLinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anketBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanalPazarSistemiUygulamaOdevDataSet1 = new ProjemSanalPazar.SanalPazarSistemiUygulamaOdevDataSet1();
            this.anketBilgiTableAdapter = new ProjemSanalPazar.SanalPazarSistemiUygulamaOdevDataSet1TableAdapters.AnketBilgiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanalPazarSistemiUygulamaOdevDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(795, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(923, 667);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = " 444 7 444";
            // 
            // AnaMenuDonButon
            // 
            this.AnaMenuDonButon.Image = ((System.Drawing.Image)(resources.GetObject("AnaMenuDonButon.Image")));
            this.AnaMenuDonButon.Location = new System.Drawing.Point(-1, 0);
            this.AnaMenuDonButon.Name = "AnaMenuDonButon";
            this.AnaMenuDonButon.Size = new System.Drawing.Size(144, 95);
            this.AnaMenuDonButon.TabIndex = 32;
            this.AnaMenuDonButon.UseVisualStyleBackColor = true;
            this.AnaMenuDonButon.Click += new System.EventHandler(this.AnaMenuDonButon_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anketAdDataGridViewTextBoxColumn,
            this.anketLinkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.anketBilgiBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(352, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1331, 144);
            this.dataGridView1.TabIndex = 33;
            // 
            // anketAdDataGridViewTextBoxColumn
            // 
            this.anketAdDataGridViewTextBoxColumn.DataPropertyName = "AnketAd";
            this.anketAdDataGridViewTextBoxColumn.HeaderText = "Anket Adı";
            this.anketAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.anketAdDataGridViewTextBoxColumn.Name = "anketAdDataGridViewTextBoxColumn";
            this.anketAdDataGridViewTextBoxColumn.Width = 300;
            // 
            // anketLinkDataGridViewTextBoxColumn
            // 
            this.anketLinkDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.anketLinkDataGridViewTextBoxColumn.DataPropertyName = "AnketLink";
            this.anketLinkDataGridViewTextBoxColumn.HeaderText = "Anket Linki";
            this.anketLinkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.anketLinkDataGridViewTextBoxColumn.Name = "anketLinkDataGridViewTextBoxColumn";
            // 
            // anketBilgiBindingSource
            // 
            this.anketBilgiBindingSource.DataMember = "AnketBilgi";
            this.anketBilgiBindingSource.DataSource = this.sanalPazarSistemiUygulamaOdevDataSet1;
            // 
            // sanalPazarSistemiUygulamaOdevDataSet1
            // 
            this.sanalPazarSistemiUygulamaOdevDataSet1.DataSetName = "SanalPazarSistemiUygulamaOdevDataSet1";
            this.sanalPazarSistemiUygulamaOdevDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anketBilgiTableAdapter
            // 
            this.anketBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // UyeİletişimEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1739, 893);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AnaMenuDonButon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UyeİletişimEkran";
            this.Text = "UyeİletişimEkran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UyeİletişimEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanalPazarSistemiUygulamaOdevDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AnaMenuDonButon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SanalPazarSistemiUygulamaOdevDataSet1 sanalPazarSistemiUygulamaOdevDataSet1;
        private System.Windows.Forms.BindingSource anketBilgiBindingSource;
        private SanalPazarSistemiUygulamaOdevDataSet1TableAdapters.AnketBilgiTableAdapter anketBilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn anketAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anketLinkDataGridViewTextBoxColumn;
    }
}