
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
            this.btnHASTALAR = new System.Windows.Forms.Button();
            this.btncik = new System.Windows.Forms.Button();
            this.btnbolum = new System.Windows.Forms.Button();
            this.btnrandevu = new System.Windows.Forms.Button();
            this.tblrandevutakip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHASTALAR
            // 
            this.btnHASTALAR.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnHASTALAR.Location = new System.Drawing.Point(27, 23);
            this.btnHASTALAR.Name = "btnHASTALAR";
            this.btnHASTALAR.Size = new System.Drawing.Size(161, 69);
            this.btnHASTALAR.TabIndex = 1;
            this.btnHASTALAR.Text = "HASTALAR";
            this.btnHASTALAR.UseVisualStyleBackColor = false;
            this.btnHASTALAR.Click += new System.EventHandler(this.btnHASTALAR_Click);
            // 
            // btncik
            // 
            this.btncik.BackColor = System.Drawing.Color.SaddleBrown;
            this.btncik.Location = new System.Drawing.Point(27, 108);
            this.btncik.Name = "btncik";
            this.btncik.Size = new System.Drawing.Size(161, 69);
            this.btncik.TabIndex = 2;
            this.btncik.Text = "QUİT";
            this.btncik.UseVisualStyleBackColor = false;
            this.btncik.Click += new System.EventHandler(this.btncik_Click);
            // 
            // btnbolum
            // 
            this.btnbolum.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnbolum.Location = new System.Drawing.Point(27, 205);
            this.btnbolum.Name = "btnbolum";
            this.btnbolum.Size = new System.Drawing.Size(161, 69);
            this.btnbolum.TabIndex = 2;
            this.btnbolum.Text = "BOLUMLER";
            this.btnbolum.UseVisualStyleBackColor = false;
            this.btnbolum.Click += new System.EventHandler(this.btnbolum_Click);
            // 
            // btnrandevu
            // 
            this.btnrandevu.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnrandevu.Location = new System.Drawing.Point(215, 23);
            this.btnrandevu.Name = "btnrandevu";
            this.btnrandevu.Size = new System.Drawing.Size(161, 69);
            this.btnrandevu.TabIndex = 1;
            this.btnrandevu.Text = "RANDEVU AL";
            this.btnrandevu.UseVisualStyleBackColor = false;
            this.btnrandevu.Click += new System.EventHandler(this.btnrandevu_Click);
            // 
            // tblrandevutakip
            // 
            this.tblrandevutakip.BackColor = System.Drawing.Color.SaddleBrown;
            this.tblrandevutakip.Location = new System.Drawing.Point(215, 108);
            this.tblrandevutakip.Name = "tblrandevutakip";
            this.tblrandevutakip.Size = new System.Drawing.Size(161, 69);
            this.tblrandevutakip.TabIndex = 1;
            this.tblrandevutakip.Text = "RANDEVU TAKİP";
            this.tblrandevutakip.UseVisualStyleBackColor = false;
            this.tblrandevutakip.Click += new System.EventHandler(this.tblrandevutakip_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(701, 286);
            this.Controls.Add(this.btnbolum);
            this.Controls.Add(this.btncik);
            this.Controls.Add(this.tblrandevutakip);
            this.Controls.Add(this.btnrandevu);
            this.Controls.Add(this.btnHASTALAR);
            this.Name = "HomePage";
            this.Text = "HOMEPAGE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHASTALAR;
        private System.Windows.Forms.Button btncik;
        private System.Windows.Forms.Button btnbolum;
        private System.Windows.Forms.Button btnrandevu;
        private System.Windows.Forms.Button tblrandevutakip;
    }
}

