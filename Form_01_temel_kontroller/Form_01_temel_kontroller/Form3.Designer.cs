
namespace Form_01_temel_kontroller
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbKadin = new System.Windows.Forms.RadioButton();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lsvKisiler = new System.Windows.Forms.ListView();
            this.clmAdSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmCinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ad soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(68, 24);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 1;
            this.txtAdSoyad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "cinsiyet";
            // 
            // rdbKadin
            // 
            this.rdbKadin.AutoSize = true;
            this.rdbKadin.Location = new System.Drawing.Point(68, 56);
            this.rdbKadin.Name = "rdbKadin";
            this.rdbKadin.Size = new System.Drawing.Size(51, 17);
            this.rdbKadin.TabIndex = 2;
            this.rdbKadin.TabStop = true;
            this.rdbKadin.Text = "kadin";
            this.rdbKadin.UseVisualStyleBackColor = true;
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.Location = new System.Drawing.Point(125, 56);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(52, 17);
            this.rdbErkek.TabIndex = 3;
            this.rdbErkek.TabStop = true;
            this.rdbErkek.Text = "erkek";
            this.rdbErkek.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(183, 56);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lsvKisiler
            // 
            this.lsvKisiler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmAdSoyad,
            this.ClmCinsiyet});
            this.lsvKisiler.HideSelection = false;
            this.lsvKisiler.Location = new System.Drawing.Point(390, 12);
            this.lsvKisiler.Name = "lsvKisiler";
            this.lsvKisiler.Size = new System.Drawing.Size(238, 122);
            this.lsvKisiler.TabIndex = 5;
            this.lsvKisiler.UseCompatibleStateImageBehavior = false;
            this.lsvKisiler.View = System.Windows.Forms.View.Details;
            // 
            // clmAdSoyad
            // 
            this.clmAdSoyad.Text = "AD SOYAD";
            this.clmAdSoyad.Width = 157;
            // 
            // ClmCinsiyet
            // 
            this.ClmCinsiyet.Text = "CİNSİYET";
            this.ClmCinsiyet.Width = 81;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsvKisiler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.rdbErkek);
            this.Controls.Add(this.rdbKadin);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbKadin;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListView lsvKisiler;
        private System.Windows.Forms.ColumnHeader clmAdSoyad;
        private System.Windows.Forms.ColumnHeader ClmCinsiyet;
    }
}