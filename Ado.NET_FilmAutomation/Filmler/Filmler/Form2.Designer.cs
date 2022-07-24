
namespace Filmler
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Ad = new System.Windows.Forms.TextBox();
            this.textBox_Soyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Tel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Adres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_Ekle = new System.Windows.Forms.Button();
            this.button_Sil = new System.Windows.Forms.Button();
            this.button_Guncelle = new System.Windows.Forms.Button();
            this.button_Getir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calısan Adi";
            // 
            // textBox_Ad
            // 
            this.textBox_Ad.Location = new System.Drawing.Point(94, 41);
            this.textBox_Ad.Name = "textBox_Ad";
            this.textBox_Ad.Size = new System.Drawing.Size(100, 20);
            this.textBox_Ad.TabIndex = 1;
            // 
            // textBox_Soyad
            // 
            this.textBox_Soyad.Location = new System.Drawing.Point(94, 89);
            this.textBox_Soyad.Name = "textBox_Soyad";
            this.textBox_Soyad.Size = new System.Drawing.Size(100, 20);
            this.textBox_Soyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Calısan Soyadı";
            // 
            // textBox_Tel
            // 
            this.textBox_Tel.Location = new System.Drawing.Point(94, 144);
            this.textBox_Tel.Name = "textBox_Tel";
            this.textBox_Tel.Size = new System.Drawing.Size(100, 20);
            this.textBox_Tel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Calısan Adres";
            // 
            // textBox_Adres
            // 
            this.textBox_Adres.Location = new System.Drawing.Point(94, 186);
            this.textBox_Adres.Name = "textBox_Adres";
            this.textBox_Adres.Size = new System.Drawing.Size(100, 20);
            this.textBox_Adres.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Calısan Tel";
            // 
            // Button_Ekle
            // 
            this.Button_Ekle.Location = new System.Drawing.Point(94, 243);
            this.Button_Ekle.Name = "Button_Ekle";
            this.Button_Ekle.Size = new System.Drawing.Size(75, 23);
            this.Button_Ekle.TabIndex = 8;
            this.Button_Ekle.Text = "Ekle";
            this.Button_Ekle.UseVisualStyleBackColor = true;
            this.Button_Ekle.Click += new System.EventHandler(this.Button_Ekle_Click);
            // 
            // button_Sil
            // 
            this.button_Sil.Location = new System.Drawing.Point(94, 289);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(75, 23);
            this.button_Sil.TabIndex = 9;
            this.button_Sil.Text = "Sil";
            this.button_Sil.UseVisualStyleBackColor = true;
            this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click);
            // 
            // button_Guncelle
            // 
            this.button_Guncelle.Location = new System.Drawing.Point(94, 341);
            this.button_Guncelle.Name = "button_Guncelle";
            this.button_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.button_Guncelle.TabIndex = 10;
            this.button_Guncelle.Text = "Guncelle";
            this.button_Guncelle.UseVisualStyleBackColor = true;
            this.button_Guncelle.Click += new System.EventHandler(this.button_Guncelle_Click);
            // 
            // button_Getir
            // 
            this.button_Getir.Location = new System.Drawing.Point(94, 389);
            this.button_Getir.Name = "button_Getir";
            this.button_Getir.Size = new System.Drawing.Size(75, 23);
            this.button_Getir.TabIndex = 11;
            this.button_Getir.Text = "Calısan Getir";
            this.button_Getir.UseVisualStyleBackColor = true;
            this.button_Getir.Click += new System.EventHandler(this.button_Getir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(247, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(489, 310);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ara";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(474, 391);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Getir);
            this.Controls.Add(this.button_Guncelle);
            this.Controls.Add(this.button_Sil);
            this.Controls.Add(this.Button_Ekle);
            this.Controls.Add(this.textBox_Adres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Tel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Soyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Ad);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Ad;
        private System.Windows.Forms.TextBox textBox_Soyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Tel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Adres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_Ekle;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.Button button_Guncelle;
        private System.Windows.Forms.Button button_Getir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}