namespace IceCreamAutomation
{
    partial class frmMusteri
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
            this.paketler = new System.Windows.Forms.ListBox();
            this.sepet = new System.Windows.Forms.ListBox();
            this.total = new System.Windows.Forms.Label();
            this.porsiyon = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fiyatKulah = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.kulah = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.boyut = new System.Windows.Forms.ComboBox();
            this.kagithelva = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fiyatKilo = new System.Windows.Forms.ComboBox();
            this.kilo = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // paketler
            // 
            this.paketler.FormattingEnabled = true;
            this.paketler.ItemHeight = 16;
            this.paketler.Location = new System.Drawing.Point(12, 12);
            this.paketler.Name = "paketler";
            this.paketler.Size = new System.Drawing.Size(196, 676);
            this.paketler.TabIndex = 0;
            this.paketler.SelectedIndexChanged += new System.EventHandler(this.paketler_SelectedIndexChanged);
            // 
            // sepet
            // 
            this.sepet.FormattingEnabled = true;
            this.sepet.HorizontalScrollbar = true;
            this.sepet.ItemHeight = 16;
            this.sepet.Location = new System.Drawing.Point(214, 460);
            this.sepet.Name = "sepet";
            this.sepet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sepet.Size = new System.Drawing.Size(441, 228);
            this.sepet.TabIndex = 1;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.BackColor = System.Drawing.SystemColors.Control;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.total.ForeColor = System.Drawing.Color.SteelBlue;
            this.total.Location = new System.Drawing.Point(56, 18);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(55, 32);
            this.total.TabIndex = 5;
            this.total.Text = "0,0";
            // 
            // porsiyon
            // 
            this.porsiyon.FormattingEnabled = true;
            this.porsiyon.ItemHeight = 16;
            this.porsiyon.Location = new System.Drawing.Point(62, 33);
            this.porsiyon.Name = "porsiyon";
            this.porsiyon.Size = new System.Drawing.Size(153, 100);
            this.porsiyon.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(62, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Temizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(214, 695);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 47);
            this.button4.TabIndex = 8;
            this.button4.Text = "Temizle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(62, 170);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Porsiyon Ekle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.porsiyon);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(214, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 203);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Porsiyon";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(6, 97);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(43, 36);
            this.button11.TabIndex = 12;
            this.button11.Text = "<K";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 33);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(43, 39);
            this.button10.TabIndex = 11;
            this.button10.Text = ">E";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.fiyatKulah);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.kulah);
            this.groupBox2.Location = new System.Drawing.Point(442, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 203);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Külah";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "TL :";
            // 
            // fiyatKulah
            // 
            this.fiyatKulah.FormattingEnabled = true;
            this.fiyatKulah.Items.AddRange(new object[] {
            "0,5",
            "1,0",
            "1,5",
            "2,0",
            "2,5",
            "3,0",
            "3,5",
            "4,0",
            "4,5",
            "5,0"});
            this.fiyatKulah.Location = new System.Drawing.Point(106, 100);
            this.fiyatKulah.Name = "fiyatKulah";
            this.fiyatKulah.Size = new System.Drawing.Size(101, 24);
            this.fiyatKulah.TabIndex = 13;
            this.fiyatKulah.Text = "1,0";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 97);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(43, 36);
            this.button9.TabIndex = 12;
            this.button9.Text = "<K";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 33);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(43, 39);
            this.button8.TabIndex = 11;
            this.button8.Text = ">E";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(55, 170);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(153, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Külah Ekle";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(55, 139);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(153, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Temizle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // kulah
            // 
            this.kulah.FormattingEnabled = true;
            this.kulah.ItemHeight = 16;
            this.kulah.Location = new System.Drawing.Point(55, 33);
            this.kulah.Name = "kulah";
            this.kulah.Size = new System.Drawing.Size(153, 52);
            this.kulah.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button15);
            this.groupBox3.Controls.Add(this.button14);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.boyut);
            this.groupBox3.Controls.Add(this.kagithelva);
            this.groupBox3.Location = new System.Drawing.Point(214, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 203);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kağıt Helva";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(62, 168);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(153, 23);
            this.button15.TabIndex = 18;
            this.button15.Text = "KağıtHelva Ekle";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(62, 139);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(153, 23);
            this.button14.TabIndex = 17;
            this.button14.Text = "Temizle";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 41);
            this.button2.TabIndex = 16;
            this.button2.Text = "<K";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = ">E";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ç:";
            // 
            // boyut
            // 
            this.boyut.FormattingEnabled = true;
            this.boyut.Items.AddRange(new object[] {
            "Küçük",
            "Orta(Tost)",
            "Büyük"});
            this.boyut.Location = new System.Drawing.Point(114, 100);
            this.boyut.Name = "boyut";
            this.boyut.Size = new System.Drawing.Size(101, 24);
            this.boyut.TabIndex = 13;
            this.boyut.Text = "Büyük";
            // 
            // kagithelva
            // 
            this.kagithelva.FormattingEnabled = true;
            this.kagithelva.ItemHeight = 16;
            this.kagithelva.Location = new System.Drawing.Point(62, 33);
            this.kagithelva.Name = "kagithelva";
            this.kagithelva.Size = new System.Drawing.Size(153, 52);
            this.kagithelva.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button17);
            this.groupBox4.Controls.Add(this.button16);
            this.groupBox4.Controls.Add(this.button13);
            this.groupBox4.Controls.Add(this.button12);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.fiyatKilo);
            this.groupBox4.Controls.Add(this.kilo);
            this.groupBox4.Location = new System.Drawing.Point(442, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 203);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kilo";
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(55, 168);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(152, 23);
            this.button17.TabIndex = 18;
            this.button17.Text = "Kilo Ekle";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(55, 139);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(152, 23);
            this.button16.TabIndex = 17;
            this.button16.Text = "Temizle";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(6, 92);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(43, 41);
            this.button13.TabIndex = 16;
            this.button13.Text = "<K";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(6, 33);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(43, 39);
            this.button12.TabIndex = 15;
            this.button12.Text = ">E";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "TL :";
            // 
            // fiyatKilo
            // 
            this.fiyatKilo.FormattingEnabled = true;
            this.fiyatKilo.Items.AddRange(new object[] {
            "5,0",
            "6,0",
            "6,5",
            "7,0",
            "7,5",
            "8,0",
            "8,5",
            "9,0",
            "9,5",
            "10,0",
            "10,5",
            "11,0",
            "11,5",
            "12,0",
            "12,5",
            "13,0",
            "13,5",
            "14,0",
            "14,5",
            "15,0",
            "15,5",
            "16,0",
            "16,5",
            "17,0",
            "17,5",
            "18,0",
            "18,5",
            "19,0",
            "19,5",
            "20,0"});
            this.fiyatKilo.Location = new System.Drawing.Point(106, 100);
            this.fiyatKilo.Name = "fiyatKilo";
            this.fiyatKilo.Size = new System.Drawing.Size(101, 24);
            this.fiyatKilo.TabIndex = 13;
            this.fiyatKilo.Text = "1,0";
            this.fiyatKilo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // kilo
            // 
            this.kilo.FormattingEnabled = true;
            this.kilo.ItemHeight = 16;
            this.kilo.Location = new System.Drawing.Point(55, 33);
            this.kilo.Name = "kilo";
            this.kilo.Size = new System.Drawing.Size(153, 52);
            this.kilo.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.total);
            this.groupBox5.Location = new System.Drawing.Point(12, 694);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(184, 54);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fiyat (TL)";
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button18.Location = new System.Drawing.Point(508, 694);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(147, 49);
            this.button18.TabIndex = 14;
            this.button18.Text = "TAMAM !";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Chartreuse;
            this.button19.Location = new System.Drawing.Point(367, 694);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(135, 48);
            this.button19.TabIndex = 15;
            this.button19.Text = "ÖDENDİ !";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(672, 760);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sepet);
            this.Controls.Add(this.paketler);
            this.MaximizeBox = false;
            this.Name = "frmMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri";
            this.Load += new System.EventHandler(this.frmMusteri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox paketler;
        private System.Windows.Forms.ListBox sepet;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.ListBox porsiyon;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox kulah;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox fiyatKulah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox kagithelva;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox fiyatKilo;
        private System.Windows.Forms.ListBox kilo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox boyut;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
    }
}