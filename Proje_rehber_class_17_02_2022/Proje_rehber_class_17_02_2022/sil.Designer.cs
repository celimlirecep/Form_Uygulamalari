
namespace Proje_rehber_class_17_02_2022
{
    partial class sil
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
            this.dgvsiltablosu = new System.Windows.Forms.DataGridView();
            this.btnsil = new System.Windows.Forms.Button();
            this.btncık = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsiltablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvsiltablosu
            // 
            this.dgvsiltablosu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvsiltablosu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvsiltablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsiltablosu.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvsiltablosu.Location = new System.Drawing.Point(0, 0);
            this.dgvsiltablosu.Name = "dgvsiltablosu";
            this.dgvsiltablosu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvsiltablosu.Size = new System.Drawing.Size(616, 440);
            this.dgvsiltablosu.TabIndex = 0;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(36, 446);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(164, 50);
            this.btnsil.TabIndex = 1;
            this.btnsil.Text = "DELETE";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btncık
            // 
            this.btncık.Location = new System.Drawing.Point(225, 446);
            this.btncık.Name = "btncık";
            this.btncık.Size = new System.Drawing.Size(156, 50);
            this.btncık.TabIndex = 2;
            this.btncık.Text = "ÇIK";
            this.btncık.UseVisualStyleBackColor = true;
            this.btncık.Click += new System.EventHandler(this.btncık_Click);
            // 
            // sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(616, 535);
            this.Controls.Add(this.btncık);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.dgvsiltablosu);
            this.Name = "sil";
            this.Text = "sil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sil_FormClosing);
            this.Load += new System.EventHandler(this.sil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsiltablosu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsiltablosu;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btncık;
    }
}