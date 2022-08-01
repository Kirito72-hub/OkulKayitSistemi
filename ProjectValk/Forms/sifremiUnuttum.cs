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
    public partial class sifremiUnuttum : Form
    {
        public sifremiUnuttum()
        {
            InitializeComponent();
        }
        SqlConnection db = new SqlConnection("Data Source=*/Server nesnesi ctrl-F kullanabilirsiniz/*;Initial Catalog=Dershane; Integrated Security=True");
        private void btnGonder_Click(object sender, EventArgs e)
        {
            db.Open();
            SqlDataAdapter sorgu = new SqlDataAdapter("select count(*) from tbl_Kullanci where ID='" + txtID.Text +"'and KullanciAdi='" + txtKullanciAd.Text + "'", db);
            DataTable dt = new DataTable();
            sorgu.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                string sifre = "";
                SqlCommand sifregotur = new SqlCommand("Select KullanciSifresi from tbl_Kullanci where ID='" + txtID.Text + "'", db);
                sifregotur.Parameters.AddWithValue("@s1", sifre);
                sifre = sifregotur.ExecuteScalar().ToString();
                MessageBox.Show("Sifreniz: "+ sifre);
            }
            else
                MessageBox.Show("Kullanıcı Adı Veya ID Yanlıştır !!", "Butun Bosluklari Doldurun", MessageBoxButtons.OK, MessageBoxIcon.Error);
            db.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
