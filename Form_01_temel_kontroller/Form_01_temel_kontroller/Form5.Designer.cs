
namespace Form_01_temel_kontroller
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.rdbCift = new System.Windows.Forms.RadioButton();
            this.rdbTek = new System.Windows.Forms.RadioButton();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvSonuclar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.DarkRed;
            this.buttonStart.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStart.Location = new System.Drawing.Point(12, 104);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(222, 67);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "START/STOP";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // rdbCift
            // 
            this.rdbCift.AutoSize = true;
            this.rdbCift.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbCift.Location = new System.Drawing.Point(31, 63);
            this.rdbCift.Name = "rdbCift";
            this.rdbCift.Size = new System.Drawing.Size(94, 35);
            this.rdbCift.TabIndex = 1;
            this.rdbCift.TabStop = true;
            this.rdbCift.Text = "ÇİFT";
            this.rdbCift.UseVisualStyleBackColor = true;
            // 
            // rdbTek
            // 
            this.rdbTek.AutoSize = true;
            this.rdbTek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbTek.Location = new System.Drawing.Point(158, 63);
            this.rdbTek.Name = "rdbTek";
            this.rdbTek.Size = new System.Drawing.Size(85, 35);
            this.rdbTek.TabIndex = 2;
            this.rdbTek.TabStop = true;
            this.rdbTek.Text = "TEK";
            this.rdbTek.UseVisualStyleBackColor = true;
            // 
            // lblsonuc
            // 
            this.lblsonuc.BackColor = System.Drawing.Color.Aqua;
            this.lblsonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsonuc.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblsonuc.Location = new System.Drawing.Point(12, 184);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(222, 60);
            this.lblsonuc.TabIndex = 3;
            this.lblsonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(294, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 111);
            this.label1.TabIndex = 4;
            this.label1.Text = "100";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 43);
            this.label2.TabIndex = 5;
            this.label2.Text = "TEK Mİ ÇİFTMİ BELİRLE SONRADA BAŞLAT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsvSonuclar
            // 
            this.lsvSonuclar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvSonuclar.HideSelection = false;
            this.lsvSonuclar.Location = new System.Drawing.Point(293, 131);
            this.lsvSonuclar.Name = "lsvSonuclar";
            this.lsvSonuclar.Size = new System.Drawing.Size(205, 113);
            this.lsvSonuclar.TabIndex = 6;
            this.lsvSonuclar.UseCompatibleStateImageBehavior = false;
            this.lsvSonuclar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SAYI";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SENİN CEVABİN";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 147;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(567, 281);
            this.Controls.Add(this.lsvSonuclar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.rdbTek);
            this.Controls.Add(this.rdbCift);
            this.Controls.Add(this.buttonStart);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form5";
            this.Text = "                                               TEK Mİ  YOKSA ÇİFT Mİ?";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.RadioButton rdbCift;
        private System.Windows.Forms.RadioButton rdbTek;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsvSonuclar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}