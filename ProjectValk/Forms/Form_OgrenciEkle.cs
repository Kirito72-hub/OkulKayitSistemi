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
using ProjectValk.KullanciControlUi;

namespace ProjectValk.Forms
{
    public partial class Form_OgrenciEkle : Form
    {
        public Form_OgrenciEkle()
        {
            InitializeComponent();
            
        }
        SqlConnection db = new SqlConnection("Data Source=*/Server nesnesi ctrl-F kullanabilirsiniz/*;Initial Catalog=Dershane; Integrated Security=True");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_OgrenciEkle_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DateTime dt_now = DateTime.Now;
            bool ch = true;

            if (txtAd.Text == "") { MessageBox.Show("Ad Giriniz!"); ch = false; }
            else if (txtSoyad.Text == "") { MessageBox.Show("Soyad Giriniz!"); ch = false; }
            else if (txtDurum.Text == "") { MessageBox.Show("Ogrenci Durumu Giriniz!"); ch = false; }  
            else if (txtTel.Text == "") { MessageBox.Show("Telefon Numersi Giriniz!"); ch = false; }
            else if (comboBoxDogumYeri.Text == "") { MessageBox.Show("Dogum Yeri Giriniz!"); ch = false;}
            if(ch == true)
            {
                DialogResult dialogResult = MessageBox.Show("Kaydı Eklemek istiyor musunuz?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    db.Open();
                    SqlCommand sorgu = new SqlCommand("Insert into tbl_Ogrenci (OgrenciAd, OgrenciSoyad, OgrenciSehir, OgrenciTel, OgrenciEposta, OgrenciDurumu, OgrenciDogumTarihi, OgrenciKayitTarihi) values(@s1,@s2,@s3,@s4,@s5,@s6,@s7,@s8)", db);
                    sorgu.Parameters.AddWithValue("@s1", txtAd.Text);
                    sorgu.Parameters.AddWithValue("@s2", txtSoyad.Text);
                    sorgu.Parameters.AddWithValue("@s3", comboBoxDogumYeri.Text);
                    sorgu.Parameters.AddWithValue("@s4", txtTel.Text);
                    sorgu.Parameters.AddWithValue("@s5", txtEposta.Text);
                    sorgu.Parameters.AddWithValue("@s6", label9.Text);
                    sorgu.Parameters.AddWithValue("@s7", dtpDogumTarih.Value);
                    sorgu.Parameters.AddWithValue("@s8", dt_now);

                    sorgu.ExecuteNonQuery();
                    db.Close();
                    this.Close();
                    MessageBox.Show("Kayıt Eklendi");
                }
            }
        }

        private void txtDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtDurum.Text == "Devamlı")
                label9.Text = "true";
            else if (txtDurum.Text == "Devamsız")
                label9.Text = "False";
        }

        private void dtpDogumTarih_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}

