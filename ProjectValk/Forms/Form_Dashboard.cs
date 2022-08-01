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
using ProjectValk.KullanciControlUi;

namespace ProjectValk.Forms
{
    public partial class Form_Dashboard : Form
    {
        int Panelwidth;
        bool isCollapsed;
        public Form_Dashboard()
        {
            InitializeComponent();
            timerTime.Start();
            Panelwidth = panelLeft.Width;
            isCollapsed = false;
            btnDrawerBack.Visible = false;
            
        }
        SqlConnection db = new SqlConnection("Data Source=*/Server nesnesi ctrl-F kullanabilirsiniz/*;Initial Catalog=Dershane; Integrated Security=True");

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= Panelwidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 59)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {

           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerTime_Tick_1(object sender, EventArgs e)
        {
            this.labelTime.Text = DateTime.Now.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDrawer_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnDrawer.Visible = false;
            btnDrawerBack.Visible = true;
        }

        private void btnDrawerBack_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnDrawerBack.Visible = false;
            btnDrawer.Visible = true;
        }

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            //Hos geldiniz Kullanci adi gostermek!
            label5.Text = ConstValue.KullanciAdi;
        }

        private void addControls(UserControl uc)
        {
            panelControl.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelControl.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            KC_Ogrenci KC_o = new KC_Ogrenci();
            addControls(KC_o);
            

        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            KC_AnaSayfa KC = new KC_AnaSayfa();
            addControls(KC);
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKullanci_Click(object sender, EventArgs e)
        {
            KC_Kullanci KC_k = new KC_Kullanci();
            addControls(KC_k);
        }

     
        private void btnKurs_Click(object sender, EventArgs e)
        {
            KC_Kurs KC_Ku = new KC_Kurs();
            addControls(KC_Ku);
        }

        private void btnOgretmen_Click(object sender, EventArgs e)
        {
            KC_Ogretmen KC_Og = new KC_Ogretmen();
            addControls(KC_Og);
        }
    }
}
