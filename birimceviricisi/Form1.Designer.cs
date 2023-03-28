namespace birimceviricisi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKapasiteCevir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmInc = new System.Windows.Forms.RadioButton();
            this.incCm = new System.Windows.Forms.RadioButton();
            this.txtUzunluk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUzunluk = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Değer";
            // 
            // txtDeger
            // 
            this.txtDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDeger.Location = new System.Drawing.Point(90, 64);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(105, 27);
            this.txtDeger.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "byte",
            "KB",
            "MB",
            "GB",
            "TB"});
            this.comboBox1.Location = new System.Drawing.Point(217, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(63, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "byte",
            "KB",
            "MB",
            "GB",
            "TB"});
            this.comboBox2.Location = new System.Drawing.Point(359, 64);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(63, 28);
            this.comboBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(217, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bu Birimden...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(359, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bu Birime Çevir";
            // 
            // btnKapasiteCevir
            // 
            this.btnKapasiteCevir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnKapasiteCevir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapasiteCevir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKapasiteCevir.Location = new System.Drawing.Point(478, 58);
            this.btnKapasiteCevir.Name = "btnKapasiteCevir";
            this.btnKapasiteCevir.Size = new System.Drawing.Size(74, 38);
            this.btnKapasiteCevir.TabIndex = 5;
            this.btnKapasiteCevir.Text = "Çevir";
            this.btnKapasiteCevir.UseVisualStyleBackColor = false;
            this.btnKapasiteCevir.Click += new System.EventHandler(this.btnKapasiteCevir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(568, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sonuç :";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSonuc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(647, 67);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(23, 22);
            this.lblSonuc.TabIndex = 7;
            this.lblSonuc.Text = "  ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmInc);
            this.groupBox1.Controls.Add(this.incCm);
            this.groupBox1.Location = new System.Drawing.Point(289, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ınc ve cm";
            // 
            // cmInc
            // 
            this.cmInc.AutoSize = true;
            this.cmInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmInc.Location = new System.Drawing.Point(16, 57);
            this.cmInc.Name = "cmInc";
            this.cmInc.Size = new System.Drawing.Size(98, 24);
            this.cmInc.TabIndex = 1;
            this.cmInc.TabStop = true;
            this.cmInc.Text = "cm->inc";
            this.cmInc.UseVisualStyleBackColor = true;
            this.cmInc.Click += new System.EventHandler(this.cmInc_Click);
            // 
            // incCm
            // 
            this.incCm.AutoSize = true;
            this.incCm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.incCm.Location = new System.Drawing.Point(16, 22);
            this.incCm.Name = "incCm";
            this.incCm.Size = new System.Drawing.Size(101, 24);
            this.incCm.TabIndex = 0;
            this.incCm.TabStop = true;
            this.incCm.Text = "inc->Cm";
            this.incCm.UseVisualStyleBackColor = true;
            this.incCm.Click += new System.EventHandler(this.incCm_Click);
            // 
            // txtUzunluk
            // 
            this.txtUzunluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUzunluk.Location = new System.Drawing.Point(126, 254);
            this.txtUzunluk.Name = "txtUzunluk";
            this.txtUzunluk.Size = new System.Drawing.Size(105, 27);
            this.txtUzunluk.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(65, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Değer";
            // 
            // lblUzunluk
            // 
            this.lblUzunluk.AutoSize = true;
            this.lblUzunluk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUzunluk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUzunluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUzunluk.Location = new System.Drawing.Point(647, 256);
            this.lblUzunluk.Name = "lblUzunluk";
            this.lblUzunluk.Size = new System.Drawing.Size(23, 22);
            this.lblUzunluk.TabIndex = 12;
            this.lblUzunluk.Text = "  ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(568, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sonuç :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUzunluk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUzunluk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKapasiteCevir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtDeger);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeger;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKapasiteCevir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cmInc;
        private System.Windows.Forms.RadioButton incCm;
        private System.Windows.Forms.TextBox txtUzunluk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUzunluk;
        private System.Windows.Forms.Label label7;
    }
}

