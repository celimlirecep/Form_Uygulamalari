
namespace Proje_rehber_class_17_02_2022
{
    partial class formbolumler
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
            this.dgvBolumler = new System.Windows.Forms.DataGridView();
            this.lblBolumAD = new System.Windows.Forms.Label();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnyenikayit = new System.Windows.Forms.Button();
            this.btncik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolumler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBolumler
            // 
            this.dgvBolumler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBolumler.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvBolumler.Location = new System.Drawing.Point(0, 0);
            this.dgvBolumler.Name = "dgvBolumler";
            this.dgvBolumler.Size = new System.Drawing.Size(306, 379);
            this.dgvBolumler.TabIndex = 0;
            this.dgvBolumler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBolumler_CellEnter);
            // 
            // lblBolumAD
            // 
            this.lblBolumAD.Location = new System.Drawing.Point(330, 112);
            this.lblBolumAD.Name = "lblBolumAD";
            this.lblBolumAD.Size = new System.Drawing.Size(208, 43);
            this.lblBolumAD.TabIndex = 1;
            this.lblBolumAD.Text = "BOLÜM ADI :";
            // 
            // txtBolum
            // 
            this.txtBolum.Location = new System.Drawing.Point(333, 158);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(205, 20);
            this.txtBolum.TabIndex = 2;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(333, 212);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(82, 49);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(448, 212);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(90, 49);
            this.btnsil.TabIndex = 4;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnyenikayit
            // 
            this.btnyenikayit.Location = new System.Drawing.Point(333, 291);
            this.btnyenikayit.Name = "btnyenikayit";
            this.btnyenikayit.Size = new System.Drawing.Size(82, 56);
            this.btnyenikayit.TabIndex = 5;
            this.btnyenikayit.Text = "YENİ KAYIT";
            this.btnyenikayit.UseVisualStyleBackColor = true;
            this.btnyenikayit.Click += new System.EventHandler(this.btnyenikayit_Click);
            // 
            // btncik
            // 
            this.btncik.Location = new System.Drawing.Point(448, 291);
            this.btncik.Name = "btncik";
            this.btncik.Size = new System.Drawing.Size(90, 56);
            this.btncik.TabIndex = 6;
            this.btncik.Text = "ÇIK";
            this.btncik.UseVisualStyleBackColor = true;
            this.btncik.Click += new System.EventHandler(this.button1_Click);
            // 
            // formbolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 379);
            this.Controls.Add(this.btncik);
            this.Controls.Add(this.btnyenikayit);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtBolum);
            this.Controls.Add(this.lblBolumAD);
            this.Controls.Add(this.dgvBolumler);
            this.Name = "formbolumler";
            this.Text = "BÖLÜMLER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formbolumler_FormClosing);
            this.Load += new System.EventHandler(this.formbolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolumler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBolumler;
        private System.Windows.Forms.Label lblBolumAD;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnyenikayit;
        private System.Windows.Forms.Button btncik;
    }
}