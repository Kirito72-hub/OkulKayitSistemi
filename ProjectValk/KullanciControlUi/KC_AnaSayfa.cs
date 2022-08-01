using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Data.SqlClient;
using ProjectValk.Forms;

namespace ProjectValk.KullanciControlUi
{
    public partial class KC_AnaSayfa : UserControl
    {
        public KC_AnaSayfa()
        {
            InitializeComponent();
        }
        
        SqlConnection db = new SqlConnection("Data Source=*/Server nesnesi ctrl-F kullanabilirsiniz/*;Initial Catalog=Dershane; Integrated Security=True");

        void FillDataGridView()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[1].HeaderText = "Ad Soyad";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.AutoResizeColumnHeadersHeight();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ClearSelection();

            dataGridView2.Columns[0].HeaderText = "ID";
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView2.Columns[1].HeaderText = "Ad Soyad";
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.AutoResizeColumnHeadersHeight();
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.ClearSelection();

            dataGridView3.Columns[0].HeaderText = "ID";
            dataGridView3.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView3.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView3.Columns[1].HeaderText = "Ad Soyad";
            dataGridView3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView3.AutoResizeColumnHeadersHeight();
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView3.ClearSelection();

        }

        private void UpdateFont()
        {
            //Change cell font
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            }
            foreach (DataGridViewColumn c in dataGridView2.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            }
            foreach (DataGridViewColumn c in dataGridView3.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            }
        }

        private void KC_AnaSayfa_Load(object sender, EventArgs e)
        {
            db.Open();
            SqlDataAdapter sorgu = new SqlDataAdapter("Select OgrenciID,concat(OgrenciAd,' ',OgrenciSoyad) From Tbl_Ogrenci", db);
            DataTable dt = new DataTable();
            sorgu.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlDataAdapter sorgu1 = new SqlDataAdapter("Select OgretmenID,concat(OgretmenAd,' ',OgretmenSoyad) From Tbl_Ogretmen", db);
            DataTable dt1 = new DataTable();
            sorgu1.Fill(dt1);
            dataGridView2.DataSource = dt1;

            SqlDataAdapter sorgu2 = new SqlDataAdapter("Select KursID,KursAdi From Tbl_Kurs", db);
            DataTable dt2 = new DataTable();
            sorgu2.Fill(dt2);
            dataGridView3.DataSource = dt2;

            FillDataGridView();
            UpdateFont();
            db.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
