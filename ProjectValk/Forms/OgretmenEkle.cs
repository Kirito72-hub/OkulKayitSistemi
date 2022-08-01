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
    public partial class OgretmenEkle : Form
    {
        public OgretmenEkle()
        {
            InitializeComponent();
        }
        SqlConnection db = new SqlConnection("Data Source=*/Server nesnesi ctrl-F kullanabilirsiniz/*;Initial Catalog=Dershane; Integrated Security=True");
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            bool ch = true;

            if (txtAd.Text == "") { MessageBox.Show("Ad Giriniz!"); ch = false; }
            else if (txtSoyad.Text == "") { MessageBox.Show("Soyad Giriniz!"); ch = false; }
            else if (comboBoxDiploma.Text == "") { MessageBox.Show("Diploma Seçiniz!"); ch = false; }
            else if (txtTel.Text == "") { MessageBox.Show("Telefon Numersi Giriniz!"); ch = false; }
            else if (comboBoxDogumYeri.Text == "") { MessageBox.Show("Doğum Yeri Giriniz!"); ch = false; }
            if (ch == true)
            {
                DialogResult dialogResult = MessageBox.Show("Kaydı Eklemek istiyor musunuz?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    db.Open();
                    SqlCommand sorgu = new SqlCommand("Insert into Tbl_Ogretmen (OgretmenAd, OgretmenSoyad, OgretmenSehir, OgretmenTel, OgretmenDiploma, OgretmenDogumTarihi) values(@s1,@s2,@s3,@s4,@s5,@s6)", db);
                    sorgu.Parameters.AddWithValue("@s1", txtAd.Text);
                    sorgu.Parameters.AddWithValue("@s2", txtSoyad.Text);
                    sorgu.Parameters.AddWithValue("@s3", comboBoxDogumYeri.Text);
                    sorgu.Parameters.AddWithValue("@s4", txtTel.Text);
                    sorgu.Parameters.AddWithValue("@s5", comboBoxDiploma.Text);
                    sorgu.Parameters.AddWithValue("@s6", dtpDogumTarih.Value);

                    sorgu.ExecuteNonQuery();
                    db.Close();
                    this.Close();
                    MessageBox.Show("Kayıt Eklendi");
                }
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
