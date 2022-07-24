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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
        private void Form1_Load(object sender, EventArgs e)
        {
            Getir();
        }

        private void button_Filmler_Click(object sender, EventArgs e)
        {
            Getir();
            Temizle();
        }


        private void textBox_Ara_TextChanged(object sender, EventArgs e)
        {
            Getir();
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("Convert(" + dataGridView1.Columns[0].DataPropertyName + ",System.String) like '" + textBox_Ara.Text + "%'");
            dataGridView1.DataSource = bs;
        }
        private void Getir()
        {
            SqlDataAdapter dap = new SqlDataAdapter("select f.FilmAd, f.FilmTur, f.FilmSure, f.FilmPuan, c.CalisanAd +' '+ c.CalisanSoyad as 'Calisanlar', od.OdulAd, od.OdulAlan, f.FilmID from  Filmlerr f Full outer join Calisanlar c on  f.CalisanID = c.CalisanID Full outer join Oduller od on f.OdulID = od.OdulID where f.durum = 1",conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[7].Visible = false;
        }
        private void Temizle()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Text = "";
                }

            }
        }
    }
}
