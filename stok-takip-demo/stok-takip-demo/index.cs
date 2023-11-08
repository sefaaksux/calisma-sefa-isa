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
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_musteri_ekle ekle = new frm_musteri_ekle();
            ekle.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_musteri_listeleme listele = new frm_musteri_listeleme();
            listele.ShowDialog();
        }
    }
}
