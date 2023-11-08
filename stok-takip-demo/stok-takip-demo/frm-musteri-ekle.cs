using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace stok_takip_demo
{
    public partial class frm_musteri_ekle : Form
    {

        public frm_musteri_ekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-CMLR3TCH\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True");
        private void frm_musteri_ekle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into musteri(tc,adsoyad,telefon,adres,email) values(@tc,@adsoyad,@telefon,@adres,@email)", baglanti);
            cmd.Parameters.AddWithValue("@tc",txtTc.Text);
            cmd.Parameters.AddWithValue("@adsoyad", txtAd.Text);
            cmd.Parameters.AddWithValue("@telefon", txtTel.Text);
            cmd.Parameters.AddWithValue("@adres", txtAdres.Text);
            cmd.Parameters.AddWithValue("@email", txtMail.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("bilgiler kaydedilmiştir");
            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = ("");
                }
            }
        }
    }
}
