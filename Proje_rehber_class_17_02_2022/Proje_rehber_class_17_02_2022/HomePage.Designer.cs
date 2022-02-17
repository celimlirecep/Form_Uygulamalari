
namespace Proje_rehber_class_17_02_2022
{
    partial class HomePage
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
            this.dgvHastalar = new System.Windows.Forms.DataGridView();
            this.btnYenikayit = new System.Windows.Forms.Button();
            this.btnduzelt = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btncik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHastalar
            // 
            this.dgvHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHastalar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvHastalar.Location = new System.Drawing.Point(0, 0);
            this.dgvHastalar.Name = "dgvHastalar";
            this.dgvHastalar.Size = new System.Drawing.Size(928, 382);
            this.dgvHastalar.TabIndex = 0;
            // 
            // btnYenikayit
            // 
            this.btnYenikayit.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnYenikayit.Location = new System.Drawing.Point(27, 388);
            this.btnYenikayit.Name = "btnYenikayit";
            this.btnYenikayit.Size = new System.Drawing.Size(161, 69);
            this.btnYenikayit.TabIndex = 1;
            this.btnYenikayit.Text = "YENİKAYIT";
            this.btnYenikayit.UseVisualStyleBackColor = false;
            this.btnYenikayit.Click += new System.EventHandler(this.btnYenikayit_Click);
            // 
            // btnduzelt
            // 
            this.btnduzelt.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnduzelt.Location = new System.Drawing.Point(279, 388);
            this.btnduzelt.Name = "btnduzelt";
            this.btnduzelt.Size = new System.Drawing.Size(161, 69);
            this.btnduzelt.TabIndex = 1;
            this.btnduzelt.Text = "DÜZENLE";
            this.btnduzelt.UseVisualStyleBackColor = false;
            this.btnduzelt.Click += new System.EventHandler(this.btnduzelt_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSil.Location = new System.Drawing.Point(531, 388);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(161, 69);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btncik
            // 
            this.btncik.BackColor = System.Drawing.Color.SaddleBrown;
            this.btncik.Location = new System.Drawing.Point(783, 388);
            this.btncik.Name = "btncik";
            this.btncik.Size = new System.Drawing.Size(137, 69);
            this.btncik.TabIndex = 2;
            this.btncik.Text = "QUİT";
            this.btncik.UseVisualStyleBackColor = false;
            this.btncik.Click += new System.EventHandler(this.btncik_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(928, 510);
            this.Controls.Add(this.btncik);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnduzelt);
            this.Controls.Add(this.btnYenikayit);
            this.Controls.Add(this.dgvHastalar);
            this.Name = "HomePage";
            this.Text = "HOMEPAGE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHastalar;
        private System.Windows.Forms.Button btnYenikayit;
        private System.Windows.Forms.Button btnduzelt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btncik;
    }
}

