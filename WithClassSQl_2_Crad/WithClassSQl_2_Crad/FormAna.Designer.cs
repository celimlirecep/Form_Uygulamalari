
namespace WithClassSQl_2_Crad
{
    partial class FormAna
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
            this.dgvHastalar = new System.Windows.Forms.DataGridView();
            this.btnYenikayit = new System.Windows.Forms.Button();
            this.btnDuzeltme = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHastalar
            // 
            this.dgvHastalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvHastalar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHastalar.Location = new System.Drawing.Point(12, 12);
            this.dgvHastalar.Name = "dgvHastalar";
            this.dgvHastalar.Size = new System.Drawing.Size(731, 223);
            this.dgvHastalar.TabIndex = 0;
            // 
            // btnYenikayit
            // 
            this.btnYenikayit.Location = new System.Drawing.Point(12, 241);
            this.btnYenikayit.Name = "btnYenikayit";
            this.btnYenikayit.Size = new System.Drawing.Size(94, 42);
            this.btnYenikayit.TabIndex = 1;
            this.btnYenikayit.Text = "YENİ KAYIT";
            this.btnYenikayit.UseVisualStyleBackColor = true;
            this.btnYenikayit.Click += new System.EventHandler(this.btnYenikayit_Click);
            // 
            // btnDuzeltme
            // 
            this.btnDuzeltme.Location = new System.Drawing.Point(112, 241);
            this.btnDuzeltme.Name = "btnDuzeltme";
            this.btnDuzeltme.Size = new System.Drawing.Size(103, 42);
            this.btnDuzeltme.TabIndex = 2;
            this.btnDuzeltme.Text = "DÜZELTME";
            this.btnDuzeltme.UseVisualStyleBackColor = true;
            this.btnDuzeltme.Click += new System.EventHandler(this.btnDuzeltme_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(232, 241);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(90, 42);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 305);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnDuzeltme);
            this.Controls.Add(this.btnYenikayit);
            this.Controls.Add(this.dgvHastalar);
            this.Name = "FormAna";
            this.Text = "ANA FORM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAna_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHastalar;
        private System.Windows.Forms.Button btnYenikayit;
        private System.Windows.Forms.Button btnDuzeltme;
        private System.Windows.Forms.Button btnsil;
    }
}

