namespace VeterinerProje
{
    partial class FormHastalar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnHastaVeSahipler = new System.Windows.Forms.Button();
            this.BtnHastaveRandevu = new System.Windows.Forms.Button();
            this.BtnHastaYas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1133, 495);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta Bilgileri";
            // 
            // BtnHastaVeSahipler
            // 
            this.BtnHastaVeSahipler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnHastaVeSahipler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHastaVeSahipler.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHastaVeSahipler.Location = new System.Drawing.Point(12, 621);
            this.BtnHastaVeSahipler.Name = "BtnHastaVeSahipler";
            this.BtnHastaVeSahipler.Size = new System.Drawing.Size(329, 63);
            this.BtnHastaVeSahipler.TabIndex = 2;
            this.BtnHastaVeSahipler.Text = "Hastalar ve Sahiplerini Listele(f)";
            this.BtnHastaVeSahipler.UseVisualStyleBackColor = false;
            this.BtnHastaVeSahipler.Click += new System.EventHandler(this.BtnHastaVeSahipler_Click);
            // 
            // BtnHastaveRandevu
            // 
            this.BtnHastaveRandevu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnHastaveRandevu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHastaveRandevu.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHastaveRandevu.Location = new System.Drawing.Point(814, 621);
            this.BtnHastaveRandevu.Name = "BtnHastaveRandevu";
            this.BtnHastaveRandevu.Size = new System.Drawing.Size(329, 63);
            this.BtnHastaveRandevu.TabIndex = 3;
            this.BtnHastaveRandevu.Text = "Hastaların Randevuları(f)";
            this.BtnHastaveRandevu.UseVisualStyleBackColor = false;
            this.BtnHastaveRandevu.Click += new System.EventHandler(this.BtnHastaveRandevu_Click);
            // 
            // BtnHastaYas
            // 
            this.BtnHastaYas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnHastaYas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHastaYas.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHastaYas.Location = new System.Drawing.Point(398, 621);
            this.BtnHastaYas.Name = "BtnHastaYas";
            this.BtnHastaYas.Size = new System.Drawing.Size(329, 63);
            this.BtnHastaYas.TabIndex = 4;
            this.BtnHastaYas.Text = "Hastaların Yaşlarını Listele(f)";
            this.BtnHastaYas.UseVisualStyleBackColor = false;
            this.BtnHastaYas.Click += new System.EventHandler(this.BtnHastaYas_Click);
            // 
            // FormHastalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1166, 761);
            this.Controls.Add(this.BtnHastaYas);
            this.Controls.Add(this.BtnHastaveRandevu);
            this.Controls.Add(this.BtnHastaVeSahipler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHastalar";
            this.Text = "FormHastalar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnHastaVeSahipler;
        private System.Windows.Forms.Button BtnHastaveRandevu;
        private System.Windows.Forms.Button BtnHastaYas;
    }
}