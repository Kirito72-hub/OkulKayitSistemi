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
    public partial class KullanciEkle : Form
    {
        public KullanciEkle()
        {
            InitializeComponent();
        }
        SqlConnection db = new SqlConnection("Data Source=*/Server nesnesi ctrl-F kullanabilirsiniz/*;Initial Catalog=Dershane; Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Kullanci eklemek kodu
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DateTime dt_now = DateTime.Now;
            bool ch = true;

            if (txtKullanciAd.Text == "") { MessageBox.Show("Kullancı Adı Giriniz!"); ch = false; }
            else if (txtSifre.Text == "") { MessageBox.Show("Şifre Giriniz!"); ch = false; }

            if (ch == true)
            {
                DialogResult dialogResult = MessageBox.Show("Yeni Kullancı oluşturmak istiyor musunuz?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    db.Open();
                    SqlCommand Kullanci_info = new SqlCommand("Insert into tbl_Kullanci (KullanciAdi, KullanciSifresi) values(@s1,@s2)", db);
                    Kullanci_info.Parameters.AddWithValue("@s1", txtKullanciAd.Text);
                    Kullanci_info.Parameters.AddWithValue("@s2", txtSifre.Text);
                    Kullanci_info.ExecuteNonQuery();
                    db.Close();
                    this.Close();
                    MessageBox.Show("Yeni Kullancı Oluşturuldu !!");
                    
                }
            }
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}