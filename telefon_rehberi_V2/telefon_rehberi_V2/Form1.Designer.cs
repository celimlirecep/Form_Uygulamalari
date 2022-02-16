
namespace telefon_rehberi_V2
{
    partial class Form1
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
            this.btnyeni = new System.Windows.Forms.Button();
            this.btnliste = new System.Windows.Forms.Button();
            this.byncikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnyeni
            // 
            this.btnyeni.Location = new System.Drawing.Point(12, 12);
            this.btnyeni.Name = "btnyeni";
            this.btnyeni.Size = new System.Drawing.Size(133, 74);
            this.btnyeni.TabIndex = 0;
            this.btnyeni.Text = "YENİ KAYIT";
            this.btnyeni.UseVisualStyleBackColor = true;
            this.btnyeni.Click += new System.EventHandler(this.btnyeni_Click);
            // 
            // btnliste
            // 
            this.btnliste.Location = new System.Drawing.Point(12, 94);
            this.btnliste.Name = "btnliste";
            this.btnliste.Size = new System.Drawing.Size(133, 74);
            this.btnliste.TabIndex = 1;
            this.btnliste.Text = "LİSTE";
            this.btnliste.UseVisualStyleBackColor = true;
            this.btnliste.Click += new System.EventHandler(this.btnliste_Click);
            // 
            // byncikis
            // 
            this.byncikis.Location = new System.Drawing.Point(12, 174);
            this.byncikis.Name = "byncikis";
            this.byncikis.Size = new System.Drawing.Size(133, 74);
            this.byncikis.TabIndex = 2;
            this.byncikis.Text = "ÇIKIŞ";
            this.byncikis.UseVisualStyleBackColor = true;
            this.byncikis.Click += new System.EventHandler(this.byncikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 269);
            this.Controls.Add(this.byncikis);
            this.Controls.Add(this.btnliste);
            this.Controls.Add(this.btnyeni);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TELEFON REHBERİ V2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnyeni;
        private System.Windows.Forms.Button btnliste;
        private System.Windows.Forms.Button byncikis;
    }
}

