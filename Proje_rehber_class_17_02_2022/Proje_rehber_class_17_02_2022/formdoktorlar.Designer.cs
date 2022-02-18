
namespace Proje_rehber_class_17_02_2022
{
    partial class formdoktorlar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsicilNo = new System.Windows.Forms.TextBox();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.cmbbolum = new System.Windows.Forms.ComboBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SİCİL NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "AD SOYAD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "TEL :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "MAİL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "BOLUM :";
            // 
            // txtsicilNo
            // 
            this.txtsicilNo.Location = new System.Drawing.Point(128, 27);
            this.txtsicilNo.Name = "txtsicilNo";
            this.txtsicilNo.Size = new System.Drawing.Size(100, 20);
            this.txtsicilNo.TabIndex = 1;
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(128, 49);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtadsoyad.TabIndex = 1;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(128, 75);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 1;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(128, 105);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(100, 20);
            this.txtmail.TabIndex = 1;
            // 
            // cmbbolum
            // 
            this.cmbbolum.FormattingEnabled = true;
            this.cmbbolum.Location = new System.Drawing.Point(128, 136);
            this.cmbbolum.Name = "cmbbolum";
            this.cmbbolum.Size = new System.Drawing.Size(100, 21);
            this.cmbbolum.TabIndex = 2;
            this.cmbbolum.SelectedIndexChanged += new System.EventHandler(this.cmbbolum_SelectedIndexChanged);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(277, 224);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(134, 52);
            this.btnkaydet.TabIndex = 3;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // formdoktorlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 288);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.cmbbolum);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.txtsicilNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formdoktorlar";
            this.Text = "formdoktorlar";
            this.Load += new System.EventHandler(this.formdoktorlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsicilNo;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.ComboBox cmbbolum;
        private System.Windows.Forms.Button btnkaydet;
    }
}