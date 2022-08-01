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
    public partial class KC_Ogretmen : UserControl
    {
        public KC_Ogretmen()
        {
            InitializeComponent();
        }

        SqlConnection db = new SqlConnection("Data Source=*/Server nesnesi ctrl-F kullanabilirsiniz/*;Initial Catalog=Dershane; Integrated Security=True");

        void FillDataGridView()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].HeaderText = "Telefon";
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].HeaderText = "Şehir";
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[5].HeaderText = "Diploma";
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[6].HeaderText = "Doğum Tarihi";
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";

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
        private void KC_Ogretmen_Load(object sender, EventArgs e)
        {
            {
                //datagridview doldurmak
                db.Open();
                SqlDataAdapter sorgu = new SqlDataAdapter("select * from Tbl_Ogretmen", db);
                DataTable dt = new DataTable();
                sorgu.Fill(dt);
                dataGridView1.DataSource = dt;
                FillDataGridView();
                UpdateFont();
                

                //Ogretmen sayisi
                SqlCommand sorguCount = new SqlCommand("select count(*) from tbl_Ogretmen", db);
                Int32 OgretmenSayisi = (Int32)sorguCount.ExecuteScalar();
                label9.Text = OgretmenSayisi.ToString();
                db.Close();
            }
        }
        private void btnOgretmenEkle_Click(object sender, EventArgs e)
        {
            using (OgretmenEkle Oe = new OgretmenEkle())
            {
                Oe.ShowDialog();
                this.OnLoad(e);
            }
        }
        int index;
        int Scell;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOgretmenSil.Visible = true;
            index = dataGridView1.CurrentCell.RowIndex;
            object value = dataGridView1.Rows[index].Cells[0].Value;
            Scell = (int)value;
            if (dataGridView1.AreAllCellsSelected(true))
            {
                btnSifirla.Visible = true;
            }
        }

        private void btnOgretmenSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kaydı Silmek istiyor musunuz?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                db.Open();
                SqlCommand sorguSil = new SqlCommand("delete from Tbl_Ogretmen where OgretmenID=@s1", db);
                sorguSil.Parameters.AddWithValue("@s1", Scell);
                sorguSil.ExecuteNonQuery();
                db.Close();
                MessageBox.Show("Öğretmen Kaydı Silindi");
                this.OnLoad(e);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //--->double click te guncelleme formu acmak bosluklari ogrencinin bilgileri ile doluyken
            string str2 = "";
            //bosluk lar doldurmak icin double click yaptiktan sonra
            OgretmenGuncelle F_OG = new OgretmenGuncelle();
            F_OG.txtAd.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            F_OG.txtSoyad.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            F_OG.txtTel.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string str = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            F_OG.comboBoxDogumYeri.SelectedIndex = F_OG.comboBoxDogumYeri.FindStringExact(str);
            string str1 = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            F_OG.comboBoxDiploma.SelectedIndex = F_OG.comboBoxDiploma.FindStringExact(str1);


            //datetimepicker cell deki degeri vermek (Dogum tarihi)
            ConstValue.dtpDate = DateTime.Parse(this.dataGridView1.CurrentRow.Cells[6].Value.ToString());
            str2 = ConstValue.dtpDate.ToString("dd/MM/yyyy");
            F_OG.dtpDogumTarih.Value = DateTime.ParseExact(str2, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);


            ConstValue.OgretmenID = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
            
            F_OG.ShowDialog();
            this.OnLoad(e);
        }
        private void btnSifirla_Click(object sender, EventArgs e)
        {
            //databasei sifirlayacak button
            DialogResult dialogResult = MessageBox.Show("Kayıtları Gerçekten Silmek istiyormusunuz?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                db.Open();
                SqlCommand Sifirla = new SqlCommand("Delete from tbl_Ogretmen;", db);
                SqlCommand sifirla1 = new SqlCommand("DBCC CHECKIDENT ('tbl_Ogretmen', RESEED, 0);", db);
                Sifirla.ExecuteNonQuery();
                sifirla1.ExecuteNonQuery();
                db.Close();
                MessageBox.Show("bütün kayıtlar Silindi !!!");
                this.OnLoad(e);
            }
        }
    }
}