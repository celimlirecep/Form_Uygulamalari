
namespace Proje_rehber_class_17_02_2022
{
    partial class formrandevu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txthasta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbbolum = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lstdoktorlar = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnCik = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpsaat = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHastalar
            // 
            this.dgvHastalar.AllowUserToAddRows = false;
            this.dgvHastalar.AllowUserToDeleteRows = false;
            this.dgvHastalar.AllowUserToResizeColumns = false;
            this.dgvHastalar.AllowUserToResizeRows = false;
            this.dgvHastalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHastalar.Location = new System.Drawing.Point(12, 12);
            this.dgvHastalar.Name = "dgvHastalar";
            this.dgvHastalar.ReadOnly = true;
            this.dgvHastalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHastalar.Size = new System.Drawing.Size(299, 287);
            this.dgvHastalar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "HASTA :";
            // 
            // txthasta
            // 
            this.txthasta.BackColor = System.Drawing.Color.Chocolate;
            this.txthasta.Location = new System.Drawing.Point(428, 12);
            this.txthasta.Name = "txthasta";
            this.txthasta.Size = new System.Drawing.Size(142, 20);
            this.txthasta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "BOLUM :";
            // 
            // cmbbolum
            // 
            this.cmbbolum.BackColor = System.Drawing.Color.Chocolate;
            this.cmbbolum.FormattingEnabled = true;
            this.cmbbolum.Location = new System.Drawing.Point(428, 39);
            this.cmbbolum.Name = "cmbbolum";
            this.cmbbolum.Size = new System.Drawing.Size(142, 21);
            this.cmbbolum.TabIndex = 4;
            this.cmbbolum.SelectedIndexChanged += new System.EventHandler(this.cmbbolum_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DOCTOR :";
            // 
            // dtpTarih
            // 
            this.dtpTarih.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(428, 199);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(142, 20);
            this.dtpTarih.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "RANDEVU TARİHİ: ";
            // 
            // lstdoktorlar
            // 
            this.lstdoktorlar.BackColor = System.Drawing.Color.Chocolate;
            this.lstdoktorlar.FormattingEnabled = true;
            this.lstdoktorlar.Location = new System.Drawing.Point(428, 66);
            this.lstdoktorlar.Name = "lstdoktorlar";
            this.lstdoktorlar.Size = new System.Drawing.Size(142, 121);
            this.lstdoktorlar.TabIndex = 6;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Sienna;
            this.btnKaydet.Location = new System.Drawing.Point(347, 276);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnCik
            // 
            this.btnCik.BackColor = System.Drawing.Color.Sienna;
            this.btnCik.Location = new System.Drawing.Point(455, 276);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(75, 23);
            this.btnCik.TabIndex = 8;
            this.btnCik.Text = "ÇIK";
            this.btnCik.UseVisualStyleBackColor = false;
            this.btnCik.Click += new System.EventHandler(this.btnCik_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "SAAT :";
            // 
            // dtpsaat
            // 
            this.dtpsaat.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dtpsaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpsaat.Location = new System.Drawing.Point(428, 238);
            this.dtpsaat.Name = "dtpsaat";
            this.dtpsaat.Size = new System.Drawing.Size(142, 20);
            this.dtpsaat.TabIndex = 5;
            // 
            // formrandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(588, 311);
            this.Controls.Add(this.btnCik);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lstdoktorlar);
            this.Controls.Add(this.dtpsaat);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cmbbolum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txthasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHastalar);
            this.Name = "formrandevu";
            this.Text = "RANDEVU OLUŞTUR";
            this.Load += new System.EventHandler(this.formrandevu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHastalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbbolum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstdoktorlar;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnCik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpsaat;
    }
}