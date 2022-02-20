
namespace Proje_rehber_class_17_02_2022
{
    partial class form_Randevu_Onizleme
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
            this.dgvrandevuOnizleme = new System.Windows.Forms.DataGridView();
            this.tblcik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrandevuOnizleme)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvrandevuOnizleme
            // 
            this.dgvrandevuOnizleme.AllowUserToAddRows = false;
            this.dgvrandevuOnizleme.AllowUserToDeleteRows = false;
            this.dgvrandevuOnizleme.AllowUserToOrderColumns = true;
            this.dgvrandevuOnizleme.AllowUserToResizeColumns = false;
            this.dgvrandevuOnizleme.AllowUserToResizeRows = false;
            this.dgvrandevuOnizleme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvrandevuOnizleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrandevuOnizleme.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvrandevuOnizleme.Location = new System.Drawing.Point(0, 0);
            this.dgvrandevuOnizleme.Name = "dgvrandevuOnizleme";
            this.dgvrandevuOnizleme.ReadOnly = true;
            this.dgvrandevuOnizleme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrandevuOnizleme.Size = new System.Drawing.Size(861, 287);
            this.dgvrandevuOnizleme.TabIndex = 0;
            // 
            // tblcik
            // 
            this.tblcik.Location = new System.Drawing.Point(12, 313);
            this.tblcik.Name = "tblcik";
            this.tblcik.Size = new System.Drawing.Size(129, 67);
            this.tblcik.TabIndex = 1;
            this.tblcik.Text = "ÇIK";
            this.tblcik.UseVisualStyleBackColor = true;
            this.tblcik.Click += new System.EventHandler(this.tblcik_Click);
            // 
            // form_Randevu_Onizleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 409);
            this.Controls.Add(this.tblcik);
            this.Controls.Add(this.dgvrandevuOnizleme);
            this.Name = "form_Randevu_Onizleme";
            this.Text = "form_Randevu_Onizleme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_Randevu_Onizleme_FormClosing);
            this.Load += new System.EventHandler(this.form_Randevu_Onizleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrandevuOnizleme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvrandevuOnizleme;
        private System.Windows.Forms.Button tblcik;
    }
}