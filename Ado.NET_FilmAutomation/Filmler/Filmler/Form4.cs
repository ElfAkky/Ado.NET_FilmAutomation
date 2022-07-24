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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
        DataTable dt;
        DataSet ds;
        int count;
        private void Form4_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("Select CalisanAd+' '+CalisanSoyad as AdSoyad ,CalisanID from Calisanlar", conn);
            dt = new DataTable("Calisan");
            ds = new DataSet();
            dap.Fill(dt);
            ds.Tables.Add(dt);
            comboBox_calisan.DataSource = ds.Tables["Calisan"];
            comboBox_calisan.DisplayMember = "AdSoyad";
            comboBox_calisan.ValueMember = "CalisanID";

            SqlDataAdapter dap1 = new SqlDataAdapter("select OdulAd+' '+OdulAlan as Odul,OdulID from Oduller", conn);
            dt = new DataTable("Odul");
            ds = new DataSet();
            dap1.Fill(dt);
            ds.Tables.Add(dt);
            comboBox_odul.DataSource = ds.Tables["Odul"];
            comboBox_odul.DisplayMember = "Odul";
            comboBox_odul.ValueMember = "OdulID";

            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox cbox = (ComboBox)item;
                    cbox.Text = ""; 
                }
            }


            button_sil.Enabled = false;
            button_guncelle.Enabled = false;

        }

        private void button_getir_Click(object sender, EventArgs e)
        {
            Getir();
        }
        private void button_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Filmlerr (FilmAd ,FilmTur,FilmSure,FilmPuan,CalisanID,OdulID,durum) values (@ad,@tur,@sure,@puan,Convert(int,@calisan),Convert(int,@odul),1)", conn);
            conn.Open();
           
            if (textBox_ad.Text != "" && textBox_tur.Text != "" && textBox_puan.Text != "" && textBox_sure.Text != "" && comboBox_calisan.Text != "" && comboBox_odul.Text != "")
            {
                cmd.Parameters.AddWithValue("@ad", textBox_ad.Text);
                cmd.Parameters.AddWithValue("@tur", textBox_tur.Text);
                cmd.Parameters.AddWithValue("@sure", textBox_sure.Text);
                cmd.Parameters.AddWithValue("@puan", textBox_puan.Text);
                cmd.Parameters.AddWithValue("@calisan", comboBox_calisan.SelectedValue);
                cmd.Parameters.AddWithValue("@odul", comboBox_odul.SelectedValue);
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız");
            }

            cmd.ExecuteNonQuery();
            conn.Close();
            Temizle();
            Getir();
        }

       
        private void Getir()
        {
            SqlDataAdapter dap = new SqlDataAdapter("select f.FilmAd, f.FilmTur, f.FilmSure, f.FilmPuan, c.CalisanAd +' '+ c.CalisanSoyad as 'Calisanlar', od.OdulAd+' '+od.OdulAlan as Odul, f.FilmID from  Filmlerr f Full outer join Calisanlar c on  f.CalisanID = c.CalisanID Full outer join Oduller od on f.OdulID = od.OdulID where f.durum = 1", conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[6].Visible = false;
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
 SqlCommand cmd = new SqlCommand("update Filmlerr set FilmAd=@ad,FilmTur=@tur,FilmSure=@sure,FilmPuan=@puan,CalisanID=Convert(int,@cID),OdulID=Convert(int,@oID) where FilmID=Convert(int,@ID)", conn);

            conn.Open();
            cmd.Parameters.AddWithValue("@ad", textBox_ad.Text);
            cmd.Parameters.AddWithValue("@tur", textBox_tur.Text);
            cmd.Parameters.AddWithValue("@sure", textBox_sure.Text);
            cmd.Parameters.AddWithValue("@puan", textBox_puan.Text);
            cmd.Parameters.AddWithValue("@cID", comboBox_calisan.SelectedValue);
            cmd.Parameters.AddWithValue("@oID", comboBox_odul.SelectedValue);
            cmd.Parameters.AddWithValue("@ID", count);
            cmd.ExecuteNonQuery();
            conn.Close();
            Temizle();
            Getir();
            MessageBox.Show("Kayıt başarıyla güncellendi");
            button_guncelle.Enabled = false;
            button_sil.Enabled = false;

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                textBox_ad.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox_tur.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox_sure.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox_puan.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboBox_calisan.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                comboBox_odul.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            count = (int)dataGridView1.CurrentRow.Cells[6].Value;
            button_ekle.Enabled = false;
            button_sil.Enabled = true;
            button_guncelle.Enabled = true;

        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Filmlerr set durum = 0 where FilmID=Convert(int,@ID)", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@ID", count);
            cmd.ExecuteNonQuery();
            conn.Close();
            Temizle();
            Getir();
            MessageBox.Show("Kayıt başarıyla silindi");
            button_guncelle.Enabled = false;
            button_sil.Enabled = false;
        }
        private void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Text = "";
                }
                if (item is ComboBox)
                {
                    ComboBox cbox = (ComboBox)item;
                    cbox.Text = "";
                }

            }
            button_ekle.Enabled = true;
            button_guncelle.Enabled = false;
            button_sil.Enabled = false;
        }
    }
}
