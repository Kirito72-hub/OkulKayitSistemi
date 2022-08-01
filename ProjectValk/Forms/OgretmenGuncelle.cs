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
    public partial class OgretmenGuncelle : Form
    {
        public OgretmenGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection db = new SqlConnection("Data Source=*/Server nesnesi ctrl-F kullanabilirsiniz/*;Initial Catalog=Dershane; Integrated Security=True");

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bool ch = true;
            if (txtAd.Text == "") { MessageBox.Show("Ad Numersi Giriniz!"); ch = false; }
            else if (txtSoyad.Text == "") { MessageBox.Show("Soyad Giriniz!"); ch = false; }
            else if (comboBoxDiploma.Text == "") { MessageBox.Show("Ogrenci Durumu Giriniz!"); ch = false; }
            else if (txtTel.Text == "") { MessageBox.Show("Telefon Numersi Giriniz!"); ch = false; }
            else if (comboBoxDogumYeri.Text == "") { MessageBox.Show("Dogum Yeri Giriniz!"); ch = false; }
            if (ch == true)
            {
                DialogResult dialogResult = MessageBox.Show("Kaydı Eklemek istiyor musunuz?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    db.Open();
                    SqlCommand guncelle = new SqlCommand("update Tbl_Ogretmen set OgretmenAd=@s1, OgretmenSoyad=@s2, OgretmenTel=@s3, OgretmenSehir=@s4, OgretmenDiploma=@s5, OgretmenDogumTarihi=@s6 where OgretmenID=@s7", db);
                    guncelle.Parameters.AddWithValue("@s1", txtAd.Text);
                    guncelle.Parameters.AddWithValue("@s2", txtSoyad.Text);
                    guncelle.Parameters.AddWithValue("@s3", txtTel.Text);
                    guncelle.Parameters.AddWithValue("@s4", comboBoxDogumYeri.Text);
                    guncelle.Parameters.AddWithValue("@s5", comboBoxDiploma.Text);
                    guncelle.Parameters.AddWithValue("@s6", dtpDogumTarih.Value);
                    guncelle.Parameters.AddWithValue("@s7", ConstValue.OgretmenID);

                    guncelle.ExecuteNonQuery();
                    db.Close();
                    this.Close();
                    MessageBox.Show("Kayıt güncellendi");
                }
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
