using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int count;

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);

        private void Form2_Load(object sender, EventArgs e)
        {
            button_Sil.Enabled = false;
            button_Guncelle.Enabled = false;

        }

        private void Button_Ekle_Click(object sender, EventArgs e)
        {
            if (textBox_Ad.Text !="" && textBox_Soyad.Text !="" && textBox_Tel.Text != "" && textBox_Adres.Text !="")
            {
                SqlCommand cmd = new SqlCommand("insert into Calisanlar (CalisanAd ,CalisanSoyad,CalisanTel, CalisanAdres, durum) values (@ad,@soyad,@tel,@adres,1)", conn);

                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {

                        conn.Open();
                        cmd.Parameters.AddWithValue("@ad", textBox_Ad.Text);
                        cmd.Parameters.AddWithValue("@soyad", textBox_Soyad.Text);
                        cmd.Parameters.AddWithValue("@tel", textBox_Tel.Text);
                        cmd.Parameters.AddWithValue("@adres", textBox_Adres.Text);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                        Temizle();
                        Getir();
                    }
                    else
                    {
                        conn.Close();
                        Temizle();
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("Hata");
                }
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız");
            }
  
        }

     

        private void button_Getir_Click(object sender, EventArgs e)
        {
            Getir();
        }

        private void Getir()
        {
            SqlDataAdapter dap = new SqlDataAdapter("select  c.CalisanAd ,c.CalisanSoyad,c.CalisanTel, c.CalisanAdres , c.CalisanID from Calisanlar c where c.durum=1",conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[4].Visible = false;

        }
        private void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Text = "";
                }
            }
            button_Guncelle.Enabled = false;
            Button_Ekle.Enabled = true;
            button_Sil.Enabled = false;
        }


        private void button_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update  Calisanlar set durum=0 where CalisanID=@id",conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@id", count);
            cmd.ExecuteNonQuery();
            conn.Close();
            Temizle();
            Getir();
        }

       

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                textBox_Ad.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox_Soyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox_Tel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox_Adres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                count = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
            }
            button_Sil.Enabled = true;
            button_Guncelle.Enabled = true;
            Button_Ekle.Enabled = false;

        }

        private void button_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Calisanlar set CalisanAd = @ad, CalisanSoyad=@soyad, CalisanTel=@tel, CalisanAdres=@adres where CalisanID=@id", conn);

            conn.Open();
            cmd.Parameters.AddWithValue("@id", count);
            cmd.Parameters.AddWithValue("@ad", textBox_Ad.Text);
            cmd.Parameters.AddWithValue("@soyad", textBox_Soyad.Text);
            cmd.Parameters.AddWithValue("@tel", textBox_Tel.Text);
            cmd.Parameters.AddWithValue("@adres", textBox_Adres.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            Temizle();
            Getir();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("Convert(" + dataGridView1.Columns[0].DataPropertyName + ",System.String) like '" + textBox1.Text + "%'");
            dataGridView1.DataSource = bs;
        }
    }
}
