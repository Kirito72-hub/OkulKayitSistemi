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


namespace ProjectValk.Forms
{
    public partial class Form_OgrenciGuncelle : Form
    {
        public Form_OgrenciGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection db = new SqlConnection("Data Source=*/Server nesnesi ctrl-F kullanabilirsiniz/*;Initial Catalog=Dershane; Integrated Security=True");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void Form_OgrenciGuncelle_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void dtpDogumTarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool ch = true;
            if (txtAd.Text == "") { MessageBox.Show("Ad Numersi Giriniz!"); ch = false; }
            else if (txtSoyad.Text == "") { MessageBox.Show("Soyad Giriniz!"); ch = false; }
            else if (txtDurum.Text == "") { MessageBox.Show("Ogrenci Durumu Giriniz!"); ch = false; }
            else if (txtTel.Text == "") { MessageBox.Show("Telefon Numersi Giriniz!"); ch = false; }
            else if (comboBoxDogumYeri.Text == "") { MessageBox.Show("Dogum Yeri Giriniz!"); ch = false; }
            if (ch == true)
            {
                DialogResult dialogResult = MessageBox.Show("Kaydı Eklemek istiyor musunuz?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    db.Open();
                    SqlCommand guncelle = new SqlCommand("update tbl_Ogrenci set OgrenciAd=@s1, OgrenciSoyad=@s2, OgrenciSehir=@s3, OgrenciTel=@s4, OgrenciEposta=@s5, OgrenciDurumu=@s6, OgrenciDogumTarihi=@s7 where OgrenciID=@s8", db);
                    guncelle.Parameters.AddWithValue("@s1", txtAd.Text);
                    guncelle.Parameters.AddWithValue("@s2", txtSoyad.Text);
                    guncelle.Parameters.AddWithValue("@s3", comboBoxDogumYeri.Text);
                    guncelle.Parameters.AddWithValue("@s4", txtTel.Text);
                    guncelle.Parameters.AddWithValue("@s5", txtEposta.Text);
                    guncelle.Parameters.AddWithValue("@s6", label9.Text);
                    guncelle.Parameters.AddWithValue("@s7", dtpDogumTarih.Value);
                    guncelle.Parameters.AddWithValue("@s8", ConstValue.Ogrenci_ID);

                    guncelle.ExecuteNonQuery();
                    db.Close();
                    this.Close();
                    MessageBox.Show("Kayıt güncellendi");
                    
                }
            }

        }

        private void txtDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtDurum.Text == "Devamlı")
                label9.Text = "true";
            else if (txtDurum.Text == "Devamsız")
                label9.Text = "false";
        }
    }
}
