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
using ProjectValk.Forms;

namespace ProjectValk
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            

        }

        SqlConnection db = new SqlConnection("Data Source=*/Server nesnesi ctrl-F kullanabilirsiniz/*;Initial Catalog=Dershane; Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //Giris bilgileri database'e gore dogru mu yanlis mi ?
            db.Open();
            SqlDataAdapter sorgu = new SqlDataAdapter("SELECT COUNT(*) FROM Tbl_Kullanci WHERE KullanciAdi='" + txtBoxKullanci.Text + "' AND KullanciSifresi='" + txtBoxSifre.Text + "'", db);
            DataTable dt = new DataTable(); 
            sorgu.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                /* Kullanci ve sifre dogru girildiyse bu yeni Form'a gececek */
                ConstValue.KullanciAdi = txtBoxKullanci.Text;
                this.Hide();
                new Forms.Form_Dashboard().Show();
            }
            else
                MessageBox.Show("Kullanıcı Adı Ve Şifreyi Giriniz !!", "Butun Bosluklari Doldurun", MessageBoxButtons.OK, MessageBoxIcon.Error);
            db.Close();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new Forms.sifremiUnuttum().Show();
        }
    }

}


