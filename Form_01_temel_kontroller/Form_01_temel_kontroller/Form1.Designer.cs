
namespace Form_01_temel_kontroller
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
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblsayi = new System.Windows.Forms.Label();
            this.txtHarf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuyukharf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbKadin = new System.Windows.Forms.RadioButton();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbhayir = new System.Windows.Forms.RadioButton();
            this.rdbEvet = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(254, 20);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 20);
            this.txtSayi.TabIndex = 0;
            this.txtSayi.TextChanged += new System.EventHandler(this.txtSayi_TextChanged);
            this.txtSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "sadece sayi girisi :";
            // 
            // lblsayi
            // 
            this.lblsayi.AutoSize = true;
            this.lblsayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsayi.Location = new System.Drawing.Point(388, 15);
            this.lblsayi.Name = "lblsayi";
            this.lblsayi.Size = new System.Drawing.Size(0, 25);
            this.lblsayi.TabIndex = 2;
            // 
            // txtHarf
            // 
            this.txtHarf.Location = new System.Drawing.Point(254, 58);
            this.txtHarf.Name = "txtHarf";
            this.txtHarf.Size = new System.Drawing.Size(100, 20);
            this.txtHarf.TabIndex = 3;
            this.txtHarf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHarf_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Harf Girisi";
            // 
            // txtBuyukharf
            // 
            this.txtBuyukharf.Location = new System.Drawing.Point(254, 104);
            this.txtBuyukharf.Name = "txtBuyukharf";
            this.txtBuyukharf.Size = new System.Drawing.Size(100, 20);
            this.txtBuyukharf.TabIndex = 5;
            this.txtBuyukharf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuyukharf_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "buyuk harf girisi";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox1.Location = new System.Drawing.Point(254, 146);
            this.maskedTextBox1.Mask = "(+90)--000-000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(163, 26);
            this.maskedTextBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "TELEFON NO: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbKadin);
            this.groupBox1.Controls.Add(this.rdbErkek);
            this.groupBox1.Location = new System.Drawing.Point(393, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 52);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "cinsiyet";
            // 
            // rdbKadin
            // 
            this.rdbKadin.AutoSize = true;
            this.rdbKadin.Location = new System.Drawing.Point(19, 25);
            this.rdbKadin.Name = "rdbKadin";
            this.rdbKadin.Size = new System.Drawing.Size(51, 17);
            this.rdbKadin.TabIndex = 1;
            this.rdbKadin.TabStop = true;
            this.rdbKadin.Text = "kadın";
            this.rdbKadin.UseVisualStyleBackColor = true;
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.Location = new System.Drawing.Point(112, 25);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(52, 17);
            this.rdbErkek.TabIndex = 0;
            this.rdbErkek.TabStop = true;
            this.rdbErkek.Text = "erkek";
            this.rdbErkek.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbhayir);
            this.panel1.Controls.Add(this.rdbEvet);
            this.panel1.Location = new System.Drawing.Point(254, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 24);
            this.panel1.TabIndex = 10;
            // 
            // rdbhayir
            // 
            this.rdbhayir.AutoSize = true;
            this.rdbhayir.Location = new System.Drawing.Point(59, 4);
            this.rdbhayir.Name = "rdbhayir";
            this.rdbhayir.Size = new System.Drawing.Size(58, 17);
            this.rdbhayir.TabIndex = 10;
            this.rdbhayir.TabStop = true;
            this.rdbhayir.Text = "HAYIR";
            this.rdbhayir.UseVisualStyleBackColor = true;
            // 
            // rdbEvet
            // 
            this.rdbEvet.AutoSize = true;
            this.rdbEvet.Location = new System.Drawing.Point(3, 3);
            this.rdbEvet.Name = "rdbEvet";
            this.rdbEvet.Size = new System.Drawing.Size(53, 17);
            this.rdbEvet.TabIndex = 9;
            this.rdbEvet.TabStop = true;
            this.rdbEvet.Text = "EVET";
            this.rdbEvet.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(31, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "bugünkü keyfin: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(254, 239);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "İSTABUL",
            "ANKARA",
            "İZMİR",
            "SİVAS"});
            this.comboBox1.Location = new System.Drawing.Point(450, 151);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(450, 178);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(497, 296);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(160, 51);
            this.btnForm2.TabIndex = 14;
            this.btnForm2.Text = "FORM 2 Yİ AÇ";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txtBuyukharf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHarf);
            this.Controls.Add(this.lblsayi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsayi;
        private System.Windows.Forms.TextBox txtHarf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuyukharf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbKadin;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbhayir;
        private System.Windows.Forms.RadioButton rdbEvet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnForm2;
    }
}

