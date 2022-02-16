
namespace Telefon_Rehberi_V1
{
    partial class Form2
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
            this.dgvKisiler = new System.Windows.Forms.DataGridView();
            this.btnYenikisi = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdberkek = new System.Windows.Forms.RadioButton();
            this.rdbkadin = new System.Windows.Forms.RadioButton();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnara = new System.Windows.Forms.Button();
            this.txtara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKisiler
            // 
            this.dgvKisiler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvKisiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKisiler.Location = new System.Drawing.Point(20, 45);
            this.dgvKisiler.Name = "dgvKisiler";
            this.dgvKisiler.ReadOnly = true;
            this.dgvKisiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKisiler.Size = new System.Drawing.Size(247, 232);
            this.dgvKisiler.TabIndex = 0;
            this.dgvKisiler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKisiler_CellClick);
            this.dgvKisiler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKisiler_CellEnter);
            // 
            // btnYenikisi
            // 
            this.btnYenikisi.Location = new System.Drawing.Point(302, 226);
            this.btnYenikisi.Name = "btnYenikisi";
            this.btnYenikisi.Size = new System.Drawing.Size(74, 51);
            this.btnYenikisi.TabIndex = 1;
            this.btnYenikisi.Text = "YENİ KİSİ";
            this.btnYenikisi.UseVisualStyleBackColor = true;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(462, 226);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(74, 51);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(382, 226);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(74, 51);
            this.btnkaydet.TabIndex = 1;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "İSİM ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOY İSİM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "CİNSİYET";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "TEL NO";
            // 
            // rdberkek
            // 
            this.rdberkek.AutoSize = true;
            this.rdberkek.Location = new System.Drawing.Point(440, 131);
            this.rdberkek.Name = "rdberkek";
            this.rdberkek.Size = new System.Drawing.Size(61, 17);
            this.rdberkek.TabIndex = 4;
            this.rdberkek.TabStop = true;
            this.rdberkek.Text = "ERKEK";
            this.rdberkek.UseVisualStyleBackColor = true;
            // 
            // rdbkadin
            // 
            this.rdbkadin.AutoSize = true;
            this.rdbkadin.Location = new System.Drawing.Point(376, 133);
            this.rdbkadin.Name = "rdbkadin";
            this.rdbkadin.Size = new System.Drawing.Size(58, 17);
            this.rdbkadin.TabIndex = 4;
            this.rdbkadin.TabStop = true;
            this.rdbkadin.Text = "KADIN";
            this.rdbkadin.UseVisualStyleBackColor = true;
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(388, 68);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(100, 20);
            this.txtisim.TabIndex = 5;
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(388, 94);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(100, 20);
            this.txtsoyisim.TabIndex = 5;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(388, 156);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 5;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(399, 45);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "0";
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(147, 19);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(75, 23);
            this.btnara.TabIndex = 7;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(41, 19);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(100, 20);
            this.txtara.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtsoyisim);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.rdbkadin);
            this.Controls.Add(this.rdberkek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnYenikisi);
            this.Controls.Add(this.dgvKisiler);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKisiler;
        private System.Windows.Forms.Button btnYenikisi;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdberkek;
        private System.Windows.Forms.RadioButton rdbkadin;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.TextBox txtara;
    }
}