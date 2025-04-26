namespace SporTakipProgramı
{
    partial class SporSalonuUyelikProgrami
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numericUpDownGun = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxAdres = new System.Windows.Forms.ListBox();
            this.listBoxTelefon = new System.Windows.Forms.ListBox();
            this.listBoxAdSoyad = new System.Windows.Forms.ListBox();
            this.labelSiparisAdres = new System.Windows.Forms.Label();
            this.labelSiparisAdSoyad = new System.Windows.Forms.Label();
            this.labelSiparisTelefon = new System.Windows.Forms.Label();
            this.listBoxUyelikturu = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxUyeSayisi = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxUcret = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGun)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(348, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(44, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Üye Sayısı :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(141, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(445, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 4;
            // 
            // numericUpDownGun
            // 
            this.numericUpDownGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownGun.Location = new System.Drawing.Point(141, 119);
            this.numericUpDownGun.Name = "numericUpDownGun";
            this.numericUpDownGun.Size = new System.Drawing.Size(100, 23);
            this.numericUpDownGun.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(348, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Üyelik Türü :";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 Aylık Üyelik",
            "3 Aylık Üyelik",
            "6 Aylık Üyelik",
            "1 Aylık VİP Üyelik",
            "3 Aylık VİP Üyelik",
            "6 Aylık VİP Üyelik"});
            this.comboBox1.Location = new System.Drawing.Point(445, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 25);
            this.comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(233, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Üye Ol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(353, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Üyelik Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(274, 164);
            this.textBoxAdres.Multiline = true;
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(150, 70);
            this.textBoxAdres.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(181, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Adres :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(170, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(337, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Spor Salonu Üyelik Formu";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // listBoxAdres
            // 
            this.listBoxAdres.FormattingEnabled = true;
            this.listBoxAdres.HorizontalScrollbar = true;
            this.listBoxAdres.Location = new System.Drawing.Point(179, 341);
            this.listBoxAdres.Name = "listBoxAdres";
            this.listBoxAdres.Size = new System.Drawing.Size(104, 95);
            this.listBoxAdres.TabIndex = 30;
            // 
            // listBoxTelefon
            // 
            this.listBoxTelefon.FormattingEnabled = true;
            this.listBoxTelefon.Location = new System.Drawing.Point(100, 341);
            this.listBoxTelefon.Name = "listBoxTelefon";
            this.listBoxTelefon.Size = new System.Drawing.Size(73, 95);
            this.listBoxTelefon.TabIndex = 29;
            // 
            // listBoxAdSoyad
            // 
            this.listBoxAdSoyad.FormattingEnabled = true;
            this.listBoxAdSoyad.HorizontalScrollbar = true;
            this.listBoxAdSoyad.Location = new System.Drawing.Point(10, 341);
            this.listBoxAdSoyad.Name = "listBoxAdSoyad";
            this.listBoxAdSoyad.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxAdSoyad.Size = new System.Drawing.Size(82, 95);
            this.listBoxAdSoyad.TabIndex = 28;
            // 
            // labelSiparisAdres
            // 
            this.labelSiparisAdres.AutoSize = true;
            this.labelSiparisAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSiparisAdres.Location = new System.Drawing.Point(205, 311);
            this.labelSiparisAdres.Name = "labelSiparisAdres";
            this.labelSiparisAdres.Size = new System.Drawing.Size(57, 22);
            this.labelSiparisAdres.TabIndex = 25;
            this.labelSiparisAdres.Text = "Adres";
            // 
            // labelSiparisAdSoyad
            // 
            this.labelSiparisAdSoyad.AutoSize = true;
            this.labelSiparisAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSiparisAdSoyad.Location = new System.Drawing.Point(12, 311);
            this.labelSiparisAdSoyad.Name = "labelSiparisAdSoyad";
            this.labelSiparisAdSoyad.Size = new System.Drawing.Size(96, 22);
            this.labelSiparisAdSoyad.TabIndex = 26;
            this.labelSiparisAdSoyad.Text = "Adı Soyadı";
            // 
            // labelSiparisTelefon
            // 
            this.labelSiparisTelefon.AutoSize = true;
            this.labelSiparisTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSiparisTelefon.Location = new System.Drawing.Point(107, 311);
            this.labelSiparisTelefon.Name = "labelSiparisTelefon";
            this.labelSiparisTelefon.Size = new System.Drawing.Size(71, 22);
            this.labelSiparisTelefon.TabIndex = 27;
            this.labelSiparisTelefon.Text = "Telefon";
            // 
            // listBoxUyelikturu
            // 
            this.listBoxUyelikturu.FormattingEnabled = true;
            this.listBoxUyelikturu.HorizontalScrollbar = true;
            this.listBoxUyelikturu.Location = new System.Drawing.Point(289, 341);
            this.listBoxUyelikturu.Name = "listBoxUyelikturu";
            this.listBoxUyelikturu.Size = new System.Drawing.Size(112, 95);
            this.listBoxUyelikturu.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(300, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 22);
            this.label7.TabIndex = 31;
            this.label7.Text = "Üyelik Türü";
            // 
            // listBoxUyeSayisi
            // 
            this.listBoxUyeSayisi.FormattingEnabled = true;
            this.listBoxUyeSayisi.HorizontalScrollbar = true;
            this.listBoxUyeSayisi.Location = new System.Drawing.Point(407, 341);
            this.listBoxUyeSayisi.Name = "listBoxUyeSayisi";
            this.listBoxUyeSayisi.Size = new System.Drawing.Size(112, 95);
            this.listBoxUyeSayisi.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(432, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 22);
            this.label8.TabIndex = 33;
            this.label8.Text = "Üye Sayısı";
            // 
            // listBoxUcret
            // 
            this.listBoxUcret.FormattingEnabled = true;
            this.listBoxUcret.Location = new System.Drawing.Point(525, 341);
            this.listBoxUcret.Name = "listBoxUcret";
            this.listBoxUcret.Size = new System.Drawing.Size(73, 95);
            this.listBoxUcret.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(532, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 22);
            this.label9.TabIndex = 35;
            this.label9.Text = "Ücret";
            // 
            // SporSalonuUyelikProgrami
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 505);
            this.Controls.Add(this.listBoxUcret);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBoxUyeSayisi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBoxUyelikturu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxAdres);
            this.Controls.Add(this.listBoxTelefon);
            this.Controls.Add(this.listBoxAdSoyad);
            this.Controls.Add(this.labelSiparisAdres);
            this.Controls.Add(this.labelSiparisAdSoyad);
            this.Controls.Add(this.labelSiparisTelefon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAdres);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownGun);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SporSalonuUyelikProgrami";
            this.Text = "Spor Salonu Üyelik Ekranı";
            this.Load += new System.EventHandler(this.SporSalonuUyelikProgrami_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownGun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxAdres;
        private System.Windows.Forms.ListBox listBoxTelefon;
        private System.Windows.Forms.ListBox listBoxAdSoyad;
        private System.Windows.Forms.Label labelSiparisAdres;
        private System.Windows.Forms.Label labelSiparisAdSoyad;
        private System.Windows.Forms.Label labelSiparisTelefon;
        private System.Windows.Forms.ListBox listBoxUyelikturu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxUyeSayisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxUcret;
        private System.Windows.Forms.Label label9;
    }
}

