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
    public partial class KursEkle : Form
    {
        public KursEkle()
        {
            InitializeComponent();
        }
        SqlConnection db = new SqlConnection("Data Source=*/Server nesnesi ctrl-F kullanabilirsiniz/*;Initial Catalog=Dershane; Integrated Security=True");
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxOgretmen_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void KursEkle_Load(object sender, EventArgs e)
        {
            db.Open();
            SqlDataAdapter getOgretmen = new SqlDataAdapter("select OgretmenAd, OgretmenSoyad from tbl_Ogretmen", db);
            DataTable dt = new DataTable();
            getOgretmen.Fill(dt);
            string s = "";
            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                string name = dt.Rows[i]["OgretmenAd"].ToString();
                string surname = dt.Rows[i]["OgretmenSoyad"].ToString();
                if (!comboBoxOgretmen.Items.Contains(s))
                {
                    comboBoxOgretmen.Items.Add(name + " " + surname);
                }
            }
            db.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool ch = true;
            if (txtAd.Text == "") { MessageBox.Show("Kurs Adı Giriniz!"); ch = false; }
            else if (txtFiyat.Text == "") { MessageBox.Show("Fiyat Giriniz!"); ch = false; }
            else if (txtSure.Text == "") { MessageBox.Show("Süre Giriniz!"); ch = false; }
            else if (comboBoxOgretmen.Text == "") { MessageBox.Show("Öğretmen Üyeliği Seçiniz!"); ch = false; }
            if (ch == true)
            {
                DialogResult dialogResult = MessageBox.Show("Kursu Eklemek istiyor musunuz?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    db.Open();
                    string strOgretmenFullAd = comboBoxOgretmen.SelectedItem.ToString();
                    var OgretmenFullAd = strOgretmenFullAd.Split(' ');
                    string strOgretmenAd = OgretmenFullAd[0];
                    string strOgretmenSoyad = OgretmenFullAd[1];
                    SqlCommand IDGetir = new SqlCommand("select OgretmenID from Tbl_Ogretmen where OgretmenAd='" + strOgretmenAd + "'and OgretmenSoyad='" + strOgretmenSoyad + "'", db);

                    Int32 OgretmenID = (Int32)IDGetir.ExecuteScalar();
                    SqlCommand sorgu = new SqlCommand("Insert into tbl_Kurs (KursAdi, KursFiyati, KursSuresi, OgretmenID ) values(@s1,@s2,@s3,@s4)", db);
                    sorgu.Parameters.AddWithValue("@s1", txtAd.Text);
                    sorgu.Parameters.AddWithValue("@s2", txtFiyat.Text);
                    sorgu.Parameters.AddWithValue("@s3", txtSure.Text);
                    sorgu.Parameters.AddWithValue("@s4", OgretmenID);
                    

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
    }
}
/*System.Data.SqlClient.SqlException: 'The INSERT statement conflicted with the FOREIGN KEY constraint "FK_Tbl_Kurs_Tbl_Ogretmen". The conflict occurred in database "Dershane", table "dbo.Tbl_Ogretmen", column 'OgretmenID'.
The statement has been terminated.'*/
//sql cant select Turkish characters