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
    public partial class frm_musteri_listeleme : Form
    {
        public frm_musteri_listeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-CMLR3TCH\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();

        private void frm_musteri_listeleme_Load(object sender, EventArgs e)
        {
            Kayit_Goster();
        }
        private void Kayit_Goster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from musteri", baglanti);
            adtr.Fill(daset, "musteri");
            dataGridView1.DataSource = daset.Tables["musteri"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtMail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update musteri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where tc=@tc", baglanti);
            cmd.Parameters.AddWithValue("@tc", txtTc.Text);
            cmd.Parameters.AddWithValue("@adsoyad", txtAd.Text);
            cmd.Parameters.AddWithValue("@telefon", txtTel.Text);
            cmd.Parameters.AddWithValue("@adres", txtAdres.Text);
            cmd.Parameters.AddWithValue("@email", txtMail.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["musteri"].Clear();
            Kayit_Goster();
            MessageBox.Show("bilgiler güncellendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = ("");
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from musteri where tc='" + dataGridView1.CurrentRow.Cells["tc"].Value.ToString() + "'", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["musteri"].Clear();
            Kayit_Goster();
            MessageBox.Show("kayıt silindi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = ("");
                }
            }
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from musteri where tc like'%" + txtTcAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
