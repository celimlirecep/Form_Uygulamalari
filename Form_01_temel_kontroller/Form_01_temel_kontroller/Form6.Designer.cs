
namespace Form_01_temel_kontroller
{
    partial class Form6
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
            this.lblSayi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSonuc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbTek = new System.Windows.Forms.RadioButton();
            this.rdbCift = new System.Windows.Forms.RadioButton();
            this.lstBildiklerim = new System.Windows.Forms.ListBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.timerSüre = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblSayi
            // 
            this.lblSayi.BackColor = System.Drawing.Color.OrangeRed;
            this.lblSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi.Location = new System.Drawing.Point(12, 0);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(209, 117);
            this.lblSayi.TabIndex = 0;
            this.lblSayi.Text = "100";
            this.lblSayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSayi.Click += new System.EventHandler(this.lblSayi_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSonuc
            // 
            this.lblSonuc.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(12, 123);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(265, 70);
            this.lblSonuc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(266, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 82);
            this.label1.TabIndex = 2;
            this.label1.Text = "SENİN TAHMİNİN :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbTek
            // 
            this.rdbTek.AutoSize = true;
            this.rdbTek.Location = new System.Drawing.Point(303, 100);
            this.rdbTek.Name = "rdbTek";
            this.rdbTek.Size = new System.Drawing.Size(46, 17);
            this.rdbTek.TabIndex = 3;
            this.rdbTek.TabStop = true;
            this.rdbTek.Text = "TEK";
            this.rdbTek.UseVisualStyleBackColor = true;
            // 
            // rdbCift
            // 
            this.rdbCift.AutoSize = true;
            this.rdbCift.Location = new System.Drawing.Point(303, 123);
            this.rdbCift.Name = "rdbCift";
            this.rdbCift.Size = new System.Drawing.Size(48, 17);
            this.rdbCift.TabIndex = 4;
            this.rdbCift.TabStop = true;
            this.rdbCift.Text = "ÇİFT";
            this.rdbCift.UseVisualStyleBackColor = true;
            // 
            // lstBildiklerim
            // 
            this.lstBildiklerim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstBildiklerim.FormattingEnabled = true;
            this.lstBildiklerim.ItemHeight = 25;
            this.lstBildiklerim.Location = new System.Drawing.Point(303, 175);
            this.lstBildiklerim.Name = "lstBildiklerim";
            this.lstBildiklerim.Size = new System.Drawing.Size(141, 79);
            this.lstBildiklerim.TabIndex = 5;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Maroon;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReturn.Location = new System.Drawing.Point(12, 206);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(275, 48);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "YENİDEN BAŞLA";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // timerSüre
            // 
            this.timerSüre.Interval = 1000;
            this.timerSüre.Tick += new System.EventHandler(this.timerSüre_Tick);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 276);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lstBildiklerim);
            this.Controls.Add(this.rdbCift);
            this.Controls.Add(this.rdbTek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblSayi);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbTek;
        private System.Windows.Forms.RadioButton rdbCift;
        private System.Windows.Forms.ListBox lstBildiklerim;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Timer timerSüre;
    }
}