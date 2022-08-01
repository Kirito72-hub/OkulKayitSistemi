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

    public partial class KC_Ogrenci : UserControl
    {
       
    
        public KC_Ogrenci()
        {
            InitializeComponent();
            
        }
        SqlConnection db = new SqlConnection("Data Source=*/Server nesnesi ctrl-F kullanabilirsiniz/*;Initial Catalog=Dershane; Integrated Security=True");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        
      
        // datagridview headers adilari degistirmek
        void FillDataGridView() 
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].HeaderText = "Sehir";
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].HeaderText = "Doğum Tarihi";
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[5].HeaderText = "Kayıt Tarihi";
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[6].HeaderText = "Telfon No";
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[7].HeaderText = "E-Posta";
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[8].HeaderText = "Durum";
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
        private void KC_Ogrenci_Load(object sender, EventArgs e)
        {
            //datagridview doldurmak
            db.Open();
            SqlDataAdapter sorgu = new SqlDataAdapter("select * from tbl_Ogrenci", db);
            DataTable dt = new DataTable();
            sorgu.Fill(dt);
            dataGridView1.DataSource = dt;
            FillDataGridView();
            UpdateFont();

            //ogrenci sayisi
            SqlCommand sorguCount = new SqlCommand("select count(*) from tbl_Ogrenci",db);
            Int32 OgrenciSayisi = (Int32)sorguCount.ExecuteScalar();
            label2.Text = OgrenciSayisi.ToString();
            //Devamli ogrenci sayisi
            SqlCommand sorguDevamli = new SqlCommand("select count(*) from tbl_Ogrenci Where OgrenciDurumu = 1", db);
            Int32 DevamliOgrenci = (Int32)sorguDevamli.ExecuteScalar();
            label7.Text = DevamliOgrenci.ToString();
            // Devamsiz ogrenci sayisi 
            SqlCommand sorguDevamsiz = new SqlCommand("select count(*) from tbl_Ogrenci Where OgrenciDurumu = 0", db);
            Int32 DevamsizOgrenci = (Int32)sorguDevamsiz.ExecuteScalar();
            label8.Text = DevamsizOgrenci.ToString();

            db.Close();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (Form_OgrenciEkle Ok = new Form_OgrenciEkle())
            {
                Ok.ShowDialog();
                this.OnLoad(e);
            } 
        }
        int index;
        int Scell;
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnKullanciSil.Visible = true;
            index = dataGridView1.CurrentCell.RowIndex;
            object value = dataGridView1.Rows[index].Cells[0].Value;
            Scell = (int)value;
            if (dataGridView1.AreAllCellsSelected(true))
            {
                btnSifirla.Visible = true;
            }
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kaydı Silmek istiyor musunuz?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                db.Open();
                SqlCommand sorguSil = new SqlCommand("delete from Tbl_Ogrenci where OgrenciID=@s1", db);
                sorguSil.Parameters.AddWithValue("@s1", Scell);
                sorguSil.ExecuteNonQuery();
                db.Close();
                MessageBox.Show("Öğrenci Kaydı Silindi");
                this.OnLoad(e);
            }
                
        }
        
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //--->double click te guncelleme formu acmak bosluklari ogrencinin bilgileri ile doluyken
            string str2 = "";
            //bosluk lar doldurmak icin double click yaptiktan sonra
            Form_OgrenciGuncelle F_OG = new Form_OgrenciGuncelle();
            F_OG.txtAd.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            F_OG.txtSoyad.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string str = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            F_OG.comboBoxDogumYeri.SelectedIndex = F_OG.comboBoxDogumYeri.FindStringExact(str);
            
            //datetimepicker cell deki degeri vermek (Dogum tarihi)
            ConstValue.dtpDate = DateTime.Parse(this.dataGridView1.CurrentRow.Cells[4].Value.ToString());
            str2 = ConstValue.dtpDate.ToString("dd/MM/yyyy"); 
            F_OG.dtpDogumTarih.Value = DateTime.ParseExact(str2, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            F_OG.txtTel.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            F_OG.txtEposta.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            ConstValue.Ogrenci_ID = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //Durum combobox doldurmak
            string str1 = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            if (str1 == "True")
            {
                str1 = "Devamlı";
                F_OG.label9.Text = "True";
            }
                
            else if (str1 == "0")
            {
                str1 = "False";
                F_OG.label9.Text = "False";
            }
            
            F_OG.txtDurum.SelectedIndex = F_OG.txtDurum.FindStringExact(str1);
            F_OG.ShowDialog();
            this.OnLoad(e);

        }
        private void btnSifirla_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnSifirla_Click_1(object sender, EventArgs e)
        {
            //databasei sifirlayacak button
            DialogResult dialogResult = MessageBox.Show("Kayıtları Gerçekten Silmek istiyormusunuz?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                db.Open();
                SqlCommand Sifirla = new SqlCommand("Delete from Tbl_Ogrenci;", db);
                SqlCommand sifirla1 = new SqlCommand("DBCC CHECKIDENT ('tbl_Ogrenci', RESEED, 0);", db);
                Sifirla.ExecuteNonQuery();
                sifirla1.ExecuteNonQuery();
                db.Close();
                MessageBox.Show("bütün kayıtlar Silindi !!!");
                this.OnLoad(e);
            }
        }
    }
}