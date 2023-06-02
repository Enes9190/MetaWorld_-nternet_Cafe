using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaWorld_İnternet_Cafe
{
    public partial class frmKullanici : Form
    {
        public frmKullanici()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanici.KullaniciGirisi(txtKullaniciAdi,txtSifre); //kullanıcı girişi kontrol etme
            if (Kullanici.durum==true)
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else if (Kullanici.durum == false)
            {
                MessageBox.Show("Kullacı adı ve şifrenizi kontrol ediniz!..","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
