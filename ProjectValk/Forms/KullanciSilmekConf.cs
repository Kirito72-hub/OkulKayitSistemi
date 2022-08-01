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
    public partial class KullanciSilmekConf : Form
    {
        public KullanciSilmekConf()
        {
            InitializeComponent();
        }
        SqlConnection db = new SqlConnection("Data Source=*/Server nesnesi ctrl-F kullanabilirsiniz/*;Initial Catalog=Dershane; Integrated Security=True");

        

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ConstValue.KullanciSilmekConfDegeri = "0";
            db.Open();
            SqlDataAdapter kontrol = new SqlDataAdapter("SELECT COUNT(*) FROM Tbl_Kullanci WHERE KullanciAdi='" + txtKullanciAd.Text + "' AND KullanciSifresi='" + txtSifre.Text + "'", db);
            
            DataTable dt = new DataTable();
            kontrol.Fill(dt);
            db.Close();
            if (dt.Rows[0][0].ToString() == "1")
            {
                db.Open();
                SqlCommand Kullanci_sil = new SqlCommand("delete from tbl_Kullanci where ID=@s1", db);
                Kullanci_sil.Parameters.AddWithValue("@s1", ConstValue.GlobalClickedCell);
                Kullanci_sil.ExecuteNonQuery();
                db.Close();
                this.Close();
                MessageBox.Show("Kullancı Kaydı Silindi");
                
            }
            else
                MessageBox.Show("Kullanıcı Adı Ve Şifreyi Giriniz !!", "Butun Bosluklari Doldurun", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KullanciSilmekConf_Load(object sender, EventArgs e)
        {

        }
    }
}
