namespace BilgeAdamProjeHaftasiOgrenciTranskriptProjesi
{
    partial class Form3
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
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            btnEkle = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(1211, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(376, 904);
            listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 227);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(184, 277);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(184, 341);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(449, 53);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(112, 34);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 227);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 5;
            label1.Text = "Ders Adi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 283);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 6;
            label2.Text = "Kredi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 344);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 7;
            label3.Text = "Donemi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 62);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 8;
            label4.Text = "Ogrenci Adi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 119);
            label5.Name = "label5";
            label5.Size = new Size(133, 25);
            label5.TabIndex = 9;
            label5.Text = "Ogrenci Soyadi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 175);
            label6.Name = "label6";
            label6.Size = new Size(149, 25);
            label6.TabIndex = 10;
            label6.Text = "Kacinci Donemde";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(202, 62);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(202, 119);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(202, 175);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(464, 283);
            button1.Name = "button1";
            button1.Size = new Size(222, 34);
            button1.TabIndex = 14;
            button1.Text = "Dersleri Ogrenciye Ata";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1599, 936);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEkle);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Name = "Form3";
            Text = "Ders Islemleri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button btnEkle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
    }
}