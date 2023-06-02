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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        Button btn;
        private void SecileneGöre(object sender, MouseEventArgs e) //süreli veya sınırsız seçme 
        {
            btn = sender as Button;

            if (btn.BackColor == Color.OrangeRed)
            {

                süreliMasaAçmaİsteğiGönderToolStripMenuItem.Visible = false;
                sınırsızSüreliMasaAçmaİsteğiGönderToolStripMenuItem.Visible= false;
            }

            if(btn.BackColor == Color.PaleGreen)
            {

                süreliMasaAçmaİsteğiGönderToolStripMenuItem.Visible = true;
                sınırsızSüreliMasaAçmaİsteğiGönderToolStripMenuItem.Visible = true;

            }
           
        }
        RadioButton radio;
        private void RadioButtonSeciliyeGore(object sender, EventArgs e)
        {
            radio = sender as RadioButton;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'internetCafeDataSet.TBLSaatUcreti' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLSaatUcretiTableAdapter.Fill(this.internetCafeDataSet.TBLSaatUcreti);
            radioButton1.Checked = true;
            Yenile();
            comboBosMasalar.Text = "";
        }

        public void Yenile()
        {
            Veritabani.SepetListele(dataGridView1);
            Veritabani.ListviewdeKayitlariGoster(listView1);
            Veritabani.ComboyaBosMasaGetir(comboBosMasalar);

            foreach(Control item in Controls)
            {
                if (item is Button)
                {
                    if (item.Name != btnMasaAc.Name)
                    {
                        Veritabani.baglanti.Open();
                        SqlCommand komut = new SqlCommand("select *from tblmasalar", Veritabani.baglanti);
                        SqlDataReader dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            if (dr["durumu"].ToString() == "BOŞ" && dr["Masalar"].ToString() == item.Text)
                            {
                                item.BackColor = Color.PaleGreen;
                            }
                            if (dr["durumu"].ToString() == "DOLU" && dr["Masalar"].ToString() == item.Text)
                            {
                                item.BackColor = Color.OrangeRed;
                            }
                        }
                        Veritabani.baglanti.Close();

                    }
                }

            }
        }

        private void btnMasaAc_Click(object sender, EventArgs e)
        {
            if (Kullanici.KullaniciID==1)
            {
                string sqlsorgu = "insert into tblsepet(masaID,masa,acilisturu,baslangic,tarih) values('" + comboBosMasalar.Text.Substring(5) + "','" + comboBosMasalar.Text + "','" + radio.Text + "','" + DateTime.Parse(DateTime.Now.ToString()) + "','" + DateTime.Now.ToString() + "')";
                SqlCommand komut = new SqlCommand();
                Veritabani.ESG(komut, sqlsorgu);
                MessageBox.Show(comboBosMasalar.Text.Substring(5) + "  nolu masa açıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Yenile();
                radioButton1.Checked = true;
                
            }
            else
            {
                MessageBox.Show("Böyle bir yetkiniz yoktur!..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Hesapla"].Index)
            {
                if (comboSaatUcreti.Text != "")
                {
                    DateTime BitisTarihi = DateTime.Now;
                    DateTime BaslangicTarihi = DateTime.Parse(dataGridView1.CurrentRow.Cells["BaslamaSaati"].Value.ToString());
                    TimeSpan saatfarki = BitisTarihi - BaslangicTarihi;
                    double saatfarki2 = saatfarki.TotalHours;
                    dataGridView1.CurrentRow.Cells["Sure"].Value = saatfarki2.ToString("0.00");
                    double toplamtutar = saatfarki2 * double.Parse(comboSaatUcreti.Text);
                    dataGridView1.CurrentRow.Cells["Tutar"].Value = toplamtutar.ToString("0.00");
                    dataGridView1.CurrentRow.Cells["BitisSaati"].Value = BitisTarihi;

                }
                if(comboSaatUcreti.Text == "")
                {
                    MessageBox.Show("Önve saat ücreti belirtilmelidir!..","Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            if (e.ColumnIndex == dataGridView1.Columns["MasaKapat"].Index)
            {
                if (dataGridView1.CurrentRow.Cells["BitisSaati"].Value!=null) {
                    frmMasaKapat frm = new frmMasaKapat();

                    frm.txtID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                    frm.txtMasaID.Text = dataGridView1.CurrentRow.Cells["Masa_ID"].Value.ToString();
                    frm.txtMasa.Text = dataGridView1.CurrentRow.Cells["_Masa"].Value.ToString();
                    frm.txtAcilisTuru.Text = dataGridView1.CurrentRow.Cells["AçılışSeçeneği"].Value.ToString();
                    frm.txtBaslamaSaati.Text = dataGridView1.CurrentRow.Cells["BaslamaSaati"].Value.ToString();
                    frm.txtBitisSaati.Text = dataGridView1.CurrentRow.Cells["BitisSaati"].Value.ToString();
                    frm.txtSaatUcreti.Text = comboSaatUcreti.Text;
                    frm.txtSure.Text = dataGridView1.CurrentRow.Cells["Sure"].Value.ToString();
                    frm.txtTutar.Text = dataGridView1.CurrentRow.Cells["Tutar"].Value.ToString();
                    frm.txtTarih.Text = dataGridView1.CurrentRow.Cells["_Tarih"].Value.ToString();

                    frm.ShowDialog();
                }
                else if (dataGridView1.CurrentRow.Cells["BitisSaati"].Value == null)
                {

                    MessageBox.Show("Önce hesaplama yapılmalıdır.","Uyari!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }
    }
}
