using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaWorld_İnternet_Cafe
{
    public partial class frmMasaKapat : Form
    {
        public frmMasaKapat()
        {
            InitializeComponent();
        }

        private void btnMasaKapat_Click(object sender, EventArgs e)
        {
            string sqlsorgu = "update tblmasalar set durumu='BOŞ' where MasaID='" + txtMasaID.Text + "' ";
            SqlCommand komut=new SqlCommand();
            Veritabani.ESG(komut,sqlsorgu);
            string sqlsorgu2="delete from tblsepet where SepetID='"+txtID.Text+"' ";
            SqlCommand komut2 = new SqlCommand();
            Veritabani.ESG(komut2,sqlsorgu2);

            this.Close();

            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            form1.Yenile();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
