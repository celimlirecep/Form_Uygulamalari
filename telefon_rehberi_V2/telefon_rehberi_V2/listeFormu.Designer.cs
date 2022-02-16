
namespace telefon_rehberi_V2
{
    partial class listeFormu
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
            this.dgvkisiler = new System.Windows.Forms.DataGridView();
            this.btnduzelt = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnkapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkisiler)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvkisiler
            // 
            this.dgvkisiler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvkisiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkisiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvkisiler.Location = new System.Drawing.Point(0, 0);
            this.dgvkisiler.Name = "dgvkisiler";
            this.dgvkisiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvkisiler.Size = new System.Drawing.Size(468, 192);
            this.dgvkisiler.TabIndex = 0;
            this.dgvkisiler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkisiler_CellEnter);
            // 
            // btnduzelt
            // 
            this.btnduzelt.Location = new System.Drawing.Point(0, 198);
            this.btnduzelt.Name = "btnduzelt";
            this.btnduzelt.Size = new System.Drawing.Size(99, 49);
            this.btnduzelt.TabIndex = 1;
            this.btnduzelt.Text = "DÜZENLE";
            this.btnduzelt.UseVisualStyleBackColor = true;
            this.btnduzelt.Click += new System.EventHandler(this.btnduzelt_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(0, 253);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(99, 44);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbcinsiyet);
            this.panel1.Controls.Add(this.txttel);
            this.panel1.Controls.Add(this.txtsoyad);
            this.panel1.Controls.Add(this.txtad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(113, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 94);
            this.panel1.TabIndex = 3;
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(99, 47);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(100, 21);
            this.cmbcinsiyet.TabIndex = 2;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(99, 70);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 1;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(99, 25);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtsoyad.TabIndex = 1;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(99, 3);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "TELEFON :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CİNSİYET :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "SOYAD :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD :";
            // 
            // btnkapat
            // 
            this.btnkapat.BackColor = System.Drawing.Color.DarkRed;
            this.btnkapat.Location = new System.Drawing.Point(369, 202);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(93, 95);
            this.btnkapat.TabIndex = 4;
            this.btnkapat.Text = "SONLANDIR";
            this.btnkapat.UseVisualStyleBackColor = false;
            // 
            // listeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 305);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnduzelt);
            this.Controls.Add(this.dgvkisiler);
            this.Name = "listeFormu";
            this.Text = "liste";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.listeFormu_FormClosing);
            this.Load += new System.EventHandler(this.listeFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkisiler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvkisiler;
        private System.Windows.Forms.Button btnduzelt;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkapat;
    }
}