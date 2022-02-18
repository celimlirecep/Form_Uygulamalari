
namespace Proje_rehber_class_17_02_2022
{
    partial class formhastalar
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
            this.dgvduzeltmetablosu = new System.Windows.Forms.DataGridView();
            this.txtdegistir = new System.Windows.Forms.Button();
            this.txtcik = new System.Windows.Forms.Button();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnyenikayit = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvduzeltmetablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvduzeltmetablosu
            // 
            this.dgvduzeltmetablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvduzeltmetablosu.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvduzeltmetablosu.Location = new System.Drawing.Point(0, 0);
            this.dgvduzeltmetablosu.Name = "dgvduzeltmetablosu";
            this.dgvduzeltmetablosu.Size = new System.Drawing.Size(948, 399);
            this.dgvduzeltmetablosu.TabIndex = 0;
            this.dgvduzeltmetablosu.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvduzeltmetablosu_CellEnter);
            // 
            // txtdegistir
            // 
            this.txtdegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdegistir.Location = new System.Drawing.Point(83, 407);
            this.txtdegistir.Name = "txtdegistir";
            this.txtdegistir.Size = new System.Drawing.Size(171, 94);
            this.txtdegistir.TabIndex = 1;
            this.txtdegistir.Text = "DÜZELT";
            this.txtdegistir.UseVisualStyleBackColor = true;
            this.txtdegistir.Click += new System.EventHandler(this.txtdegistir_Click);
            // 
            // txtcik
            // 
            this.txtcik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcik.Location = new System.Drawing.Point(83, 528);
            this.txtcik.Name = "txtcik";
            this.txtcik.Size = new System.Drawing.Size(171, 105);
            this.txtcik.TabIndex = 1;
            this.txtcik.Text = "HOMEPAGE";
            this.txtcik.UseVisualStyleBackColor = true;
            this.txtcik.Click += new System.EventHandler(this.txtcik_Click);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(487, 447);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 2;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(487, 481);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtsoyad.TabIndex = 2;
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(487, 550);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(100, 20);
            this.txtadres.TabIndex = 2;
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(487, 584);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(100, 20);
            this.txttelefon.TabIndex = 2;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(487, 618);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(100, 20);
            this.txtmail.TabIndex = 2;
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(487, 515);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(100, 21);
            this.cmbcinsiyet.TabIndex = 3;
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(487, 413);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(100, 20);
            this.txttc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(374, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(374, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "AD :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(374, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "SOYAD :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(374, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "CİNSİYET :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(374, 549);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "ADRES :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(374, 583);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "TELEFON :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(374, 617);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "MAİL AD :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnyenikayit
            // 
            this.btnyenikayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyenikayit.Location = new System.Drawing.Point(688, 409);
            this.btnyenikayit.Name = "btnyenikayit";
            this.btnyenikayit.Size = new System.Drawing.Size(155, 94);
            this.btnyenikayit.TabIndex = 5;
            this.btnyenikayit.Text = "YENİKAYIT";
            this.btnyenikayit.UseVisualStyleBackColor = true;
            this.btnyenikayit.Click += new System.EventHandler(this.btnyenikayit_Click);
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(688, 539);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(155, 94);
            this.btnsil.TabIndex = 5;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // formhastalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(948, 644);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnyenikayit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbcinsiyet);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txttelefon);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txtcik);
            this.Controls.Add(this.txtdegistir);
            this.Controls.Add(this.dgvduzeltmetablosu);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "formhastalar";
            this.Text = "duzenle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.duzenle_FormClosing);
            this.Load += new System.EventHandler(this.duzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvduzeltmetablosu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvduzeltmetablosu;
        private System.Windows.Forms.Button txtdegistir;
        private System.Windows.Forms.Button txtcik;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnyenikayit;
        private System.Windows.Forms.Button btnsil;
    }
}