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

namespace ProjectValk.KullanciControlUi
{
    public partial class KC_Kurs : UserControl
    {
        public KC_Kurs()
        {
            InitializeComponent();
        }
        SqlConnection db = new SqlConnection("Data Source=*/Server nesnesi ctrl-F kullanabilirsiniz/*;Initial Catalog=Dershane; Integrated Security=True");

        
        void FillDataGridView()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[1].HeaderText = "Kurs";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].HeaderText = "Fiyat";
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].HeaderText = "Süre";
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].HeaderText = "Öğretmen";
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.AutoResizeColumnHeadersHeight();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ClearSelection();
        }

        private void UpdateFont()
        {
            //Change cell font
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            }
        }
        private void btnKursEkle_Click(object sender, EventArgs e)
        {
            
            using (KursEkle Ke = new KursEkle())
            {
                Ke.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void KC_Kurs_Load(object sender, EventArgs e)
        {
            db.Open();
            SqlDataAdapter sorgu = new SqlDataAdapter("SELECT Tbl_Kurs.KursID,Tbl_Kurs.KursAdi, Tbl_Kurs.KursFiyati, Tbl_Kurs.KursSuresi, Tbl_Ogretmen.OgretmenAd +' '+ Tbl_Ogretmen.OgretmenSoyad FROM Tbl_Kurs INNER JOIN Tbl_Ogretmen ON Tbl_Kurs.OgretmenID = Tbl_Ogretmen.OgretmenID ;", db);
            DataTable dt = new DataTable();
            sorgu.Fill(dt);
            dataGridView1.DataSource = dt;
            FillDataGridView();
            UpdateFont();
            SqlCommand sayi = new SqlCommand("select count(*) from Tbl_Kurs", db);
            Int32 KursSayisi = (Int32)sayi.ExecuteScalar();
            label9.Text = KursSayisi.ToString();
            db.Close();
        }
        int index;
        int Scell;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnKursSil.Visible = true;
            index = dataGridView1.CurrentCell.RowIndex;
            object value = dataGridView1.Rows[index].Cells[0].Value;
            Scell = (int)value;

        }


        private void btnKursSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kursu Silmek istiyor musunuz?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                db.Open();
                SqlCommand sorguSil = new SqlCommand("delete from Tbl_Kurs where KursID=@s1", db);
                sorguSil.Parameters.AddWithValue("@s1", Scell);
                sorguSil.ExecuteNonQuery();
                db.Close();
                MessageBox.Show("Kurs Kaydı Silindi");
                this.OnLoad(e);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
