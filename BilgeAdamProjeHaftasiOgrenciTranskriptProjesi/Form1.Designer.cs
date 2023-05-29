namespace BilgeAdamProjeHaftasiOgrenciTranskriptProjesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnOgrenci = new Button();
            btnDers = new Button();
            btnDonem = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(247, 97);
            label1.TabIndex = 0;
            label1.Text = "Islemi Seciniz";
            // 
            // btnOgrenci
            // 
            btnOgrenci.Location = new Point(420, 58);
            btnOgrenci.Margin = new Padding(4);
            btnOgrenci.Name = "btnOgrenci";
            btnOgrenci.Size = new Size(211, 44);
            btnOgrenci.TabIndex = 1;
            btnOgrenci.Text = "Ogrenci Islemleri";
            btnOgrenci.UseVisualStyleBackColor = true;
            btnOgrenci.Click += btnOgrenci_Click;
            // 
            // btnDers
            // 
            btnDers.Location = new Point(711, 58);
            btnDers.Margin = new Padding(4);
            btnDers.Name = "btnDers";
            btnDers.Size = new Size(175, 44);
            btnDers.TabIndex = 2;
            btnDers.Text = "Ders Islemleri";
            btnDers.UseVisualStyleBackColor = true;
            btnDers.Click += btnDers_Click;
            // 
            // btnDonem
            // 
            btnDonem.Location = new Point(965, 58);
            btnDonem.Margin = new Padding(4);
            btnDonem.Name = "btnDonem";
            btnDonem.Size = new Size(199, 44);
            btnDonem.TabIndex = 3;
            btnDonem.Text = "Donem Islemleri";
            btnDonem.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1925, 855);
            Controls.Add(btnDonem);
            Controls.Add(btnDers);
            Controls.Add(btnOgrenci);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnOgrenci;
        private Button btnDers;
        private Button btnDonem;
    }
}