namespace Lokanta_Otomasyonu
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PersonelGirisBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.giriskapatmabutonu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Adı:(murat)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 264);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(2, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Personel Şifresi:(1234)";
            // 
            // PersonelGirisBtn
            // 
            this.PersonelGirisBtn.BackColor = System.Drawing.Color.LightPink;
            this.PersonelGirisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PersonelGirisBtn.Location = new System.Drawing.Point(156, 330);
            this.PersonelGirisBtn.Name = "PersonelGirisBtn";
            this.PersonelGirisBtn.Size = new System.Drawing.Size(122, 40);
            this.PersonelGirisBtn.TabIndex = 4;
            this.PersonelGirisBtn.Text = "Giriş";
            this.PersonelGirisBtn.UseVisualStyleBackColor = false;
            this.PersonelGirisBtn.Click += new System.EventHandler(this.PersonelGirisBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // giriskapatmabutonu
            // 
            this.giriskapatmabutonu.BackColor = System.Drawing.Color.Aquamarine;
            this.giriskapatmabutonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giriskapatmabutonu.Location = new System.Drawing.Point(340, 428);
            this.giriskapatmabutonu.Name = "giriskapatmabutonu";
            this.giriskapatmabutonu.Size = new System.Drawing.Size(92, 31);
            this.giriskapatmabutonu.TabIndex = 6;
            this.giriskapatmabutonu.Text = "Programı Kapat";
            this.giriskapatmabutonu.UseVisualStyleBackColor = false;
            this.giriskapatmabutonu.Click += new System.EventHandler(this.giriskapatmabutonu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(60, 32);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(308, 53);
            this.label3.TabIndex = 7;
            this.label3.Text = "Personel Girişi\r\n(Lütfen personel adınızı ve şifrenizi giriniz)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // form1
            // 
            this.AcceptButton = this.PersonelGirisBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = global::Kütüphane_Otomasyonları_2.Properties.Resources.depositphotos_114995488_stock_illustration_vector_illustration_of_shawarma_ingredients_589x578;
            this.ClientSize = new System.Drawing.Size(442, 470);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.giriskapatmabutonu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PersonelGirisBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PersonelGirisBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button giriskapatmabutonu;
        private System.Windows.Forms.Label label3;
    }
}

