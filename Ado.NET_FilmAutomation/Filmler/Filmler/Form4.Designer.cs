
namespace Filmler
{
    partial class Form4
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
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_tur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_sure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_puan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_calisan = new System.Windows.Forms.ComboBox();
            this.comboBox_odul = new System.Windows.Forms.ComboBox();
            this.button_ekle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.button_getir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(79, 12);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(100, 20);
            this.textBox_ad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Film Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Film Türü";
            // 
            // textBox_tur
            // 
            this.textBox_tur.Location = new System.Drawing.Point(79, 58);
            this.textBox_tur.Name = "textBox_tur";
            this.textBox_tur.Size = new System.Drawing.Size(100, 20);
            this.textBox_tur.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Film Süre";
            // 
            // textBox_sure
            // 
            this.textBox_sure.Location = new System.Drawing.Point(79, 106);
            this.textBox_sure.Name = "textBox_sure";
            this.textBox_sure.Size = new System.Drawing.Size(100, 20);
            this.textBox_sure.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Film Puanı";
            // 
            // textBox_puan
            // 
            this.textBox_puan.Location = new System.Drawing.Point(79, 152);
            this.textBox_puan.Name = "textBox_puan";
            this.textBox_puan.Size = new System.Drawing.Size(100, 20);
            this.textBox_puan.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Çalışan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ödül";
            // 
            // comboBox_calisan
            // 
            this.comboBox_calisan.FormattingEnabled = true;
            this.comboBox_calisan.Location = new System.Drawing.Point(79, 203);
            this.comboBox_calisan.Name = "comboBox_calisan";
            this.comboBox_calisan.Size = new System.Drawing.Size(121, 21);
            this.comboBox_calisan.TabIndex = 10;
            // 
            // comboBox_odul
            // 
            this.comboBox_odul.FormattingEnabled = true;
            this.comboBox_odul.Location = new System.Drawing.Point(79, 249);
            this.comboBox_odul.Name = "comboBox_odul";
            this.comboBox_odul.Size = new System.Drawing.Size(121, 21);
            this.comboBox_odul.TabIndex = 11;
            // 
            // button_ekle
            // 
            this.button_ekle.Location = new System.Drawing.Point(287, 320);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(75, 23);
            this.button_ekle.TabIndex = 12;
            this.button_ekle.Text = "Film Ekle";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // button_sil
            // 
            this.button_sil.Location = new System.Drawing.Point(405, 320);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(75, 23);
            this.button_sil.TabIndex = 13;
            this.button_sil.Text = "Film Sil";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // button_guncelle
            // 
            this.button_guncelle.Location = new System.Drawing.Point(534, 320);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(89, 23);
            this.button_guncelle.TabIndex = 14;
            this.button_guncelle.Text = "Film Güncelle";
            this.button_guncelle.UseVisualStyleBackColor = true;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // button_getir
            // 
            this.button_getir.Location = new System.Drawing.Point(658, 320);
            this.button_getir.Name = "button_getir";
            this.button_getir.Size = new System.Drawing.Size(75, 23);
            this.button_getir.TabIndex = 15;
            this.button_getir.Text = "Film Getir";
            this.button_getir.UseVisualStyleBackColor = true;
            this.button_getir.Click += new System.EventHandler(this.button_getir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(287, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 252);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_getir);
            this.Controls.Add(this.button_guncelle);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.button_ekle);
            this.Controls.Add(this.comboBox_odul);
            this.Controls.Add(this.comboBox_calisan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_puan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_sure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_tur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ad);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_tur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_sure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_puan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_calisan;
        private System.Windows.Forms.ComboBox comboBox_odul;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.Button button_getir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}