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
    public partial class KC_Kullanci : UserControl
    {
        public KC_Kullanci()
        {
            InitializeComponent();
        }
        SqlConnection db = new SqlConnection("Data Source=*/Server nesnesi ctrl-F kullanabilirsiniz/*;Initial Catalog=Dershane; Integrated Security=True");

        // datagridview headers adilari degistirmek
        void FillDataGridView()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[1].HeaderText = "Kullancı";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            
            dataGridView1.AutoResizeColumnHeadersHeight();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ClearSelection();

        }
        //datagridview daki Yazi ayarlari yaptirmak
        private void UpdateFont()
        {
            //Change cell font
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            }
        }

        private void KC_Kullanci_Load(object sender, EventArgs e)
        {
            db.Open();
            SqlDataAdapter sorgu = new SqlDataAdapter("select ID,KullanciAdi from tbl_Kullanci", db);
            DataTable dt = new DataTable();
            sorgu.Fill(dt);
            dataGridView1.DataSource = dt;
            FillDataGridView();
            UpdateFont();

            SqlCommand Osayi = new SqlCommand("select count(*) from tbl_Kullanci",db);
            label9.Text = Osayi.ExecuteScalar().ToString();

            db.Close();
        }

        private void btnOgretmenEkle_Click(object sender, EventArgs e)
        {
        }

        private void btnOgretmenSil_Click(object sender, EventArgs e)
        {
        }


        int index;
        int Scell;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnKullanciEkle_Click(object sender, EventArgs e)
        {
            
            using (KullanciEkle Ke= new KullanciEkle())
            {
                Ke.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void btnKullanciSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kaydı Silmek istiyor musunuz?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                
                using (KullanciSilmekConf Ksc = new KullanciSilmekConf())
                {
                    Ksc.ShowDialog();
                    this.OnLoad(e);
                }
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnKullanciSil.Visible = true;
            index = dataGridView1.CurrentCell.RowIndex;
            object value = dataGridView1.Rows[index].Cells[0].Value;
            Scell = (int)value;
            ConstValue.GlobalClickedCell = Scell;
            
        }
    }
}
