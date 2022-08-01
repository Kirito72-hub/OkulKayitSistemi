
namespace ProjectValk.Forms
{
    partial class OgretmenEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgretmenEkle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxDogumYeri = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.comboBoxDiploma = new System.Windows.Forms.ComboBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.dtpDogumTarih = new System.Windows.Forms.DateTimePicker();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboBoxDogumYeri);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.comboBoxDiploma);
            this.panel1.Controls.Add(this.btnIptal);
            this.panel1.Controls.Add(this.dtpDogumTarih);
            this.panel1.Controls.Add(this.txtTel);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 386);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBoxDogumYeri
            // 
            this.comboBoxDogumYeri.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxDogumYeri.DropDownHeight = 200;
            this.comboBoxDogumYeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDogumYeri.DropDownWidth = 220;
            this.comboBoxDogumYeri.FormattingEnabled = true;
            this.comboBoxDogumYeri.IntegralHeight = false;
            this.comboBoxDogumYeri.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.comboBoxDogumYeri.Location = new System.Drawing.Point(148, 218);
            this.comboBoxDogumYeri.Name = "comboBoxDogumYeri";
            this.comboBoxDogumYeri.Size = new System.Drawing.Size(173, 27);
            this.comboBoxDogumYeri.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.FlatAppearance.BorderSize = 2;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.Location = new System.Drawing.Point(424, 303);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(165, 41);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // comboBoxDiploma
            // 
            this.comboBoxDiploma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiploma.FormattingEnabled = true;
            this.comboBoxDiploma.Items.AddRange(new object[] {
            "ACİL YARDIM VE AFET YÖNETİMİ (FAKÜLTE)",
            "ACİL YARDIM VE AFET YÖNETİMİ (YÜKSEKOKUL)",
            "ADLİ BİLİMLER",
            "ADLİ BİLİŞİM MÜHENDİSLİĞİ",
            "ADLİ BİLİŞİM MÜHENDİSLİĞİ (M.T.O.K.)",
            "AĞAÇ İŞLERİ ENDÜSTRİ MÜHENDİSLİĞİ",
            "AİLE VE TÜKETİCİ BİLİMLERİ",
            "AKTÜERYA (FAKÜLTE)",
            "AKTÜERYA (YÜKSEKOKUL)",
            "AKTÜERYA BİLİMLERİ",
            "AKTÜERYA VE RİSK YÖNETİMİ",
            "ALMAN DİLİ VE EDEBİYATI",
            "ALMANCA ÖĞRETMENLİĞİ",
            "AMERİKAN KÜLTÜRÜ VE EDEBİYATI",
            "ANİMASYON VE OYUN TASARIMI",
            "ANTRENÖRLÜK EĞİTİMİ (FAKÜLTE)",
            "ANTRENÖRLÜK EĞİTİMİ (YÜKSEKOKUL)",
            "ANTROPOLOJİ",
            "ARAP DİLİ VE EDEBİYATI",
            "ARAPÇA ÖĞRETMENLİĞİ",
            "ARKEOLOJİ",
            "ARKEOLOJİ VE SANAT TARİHİ",
            "ARNAVUT DİLİ VE EDEBİYATI",
            "ASTRONOMİ VE UZAY BİLİMLERİ",
            "AVRUPA BİRLİĞİ İLİŞKİLERİ",
            "AZERBAYCAN DİLİ ÖĞRETMENLİĞİ",
            "AZERBAYCAN DİLİ VE EDEBİYATI",
            "AZERBAYCAN DİLİ VE EDEBİYATI ÖĞRETMENLİĞİ",
            "AZERBAYCAN TÜRKÇESİ VE EDEBİYATI",
            "BAHÇE BİTKİLERİ",
            "BAHÇE BİTKİLERİ ÜRETİMİ VE PAZARLAMASI",
            "BAHÇE VE TARLA BİTKİLERİ",
            "BALIKÇILIK TEKNOLOJİSİ (FAKÜLTE)",
            "BALIKÇILIK TEKNOLOJİSİ (YÜKSEKOKUL)",
            "BALIKÇILIK TEKNOLOJİSİ MÜHENDİSLİĞİ",
            "BANKACILIK (YÜKSEKOKUL)",
            "BANKACILIK VE FİNANS (FAKÜLTE)",
            "BANKACILIK VE FİNANS (YÜKSEKOKUL)",
            "BANKACILIK VE FİNANSMAN (YÜKSEKOKUL)",
            "BANKACILIK VE SİGORTACILIK (FAKÜLTE)",
            "BANKACILIK VE SİGORTACILIK (YÜKSEKOKUL)",
            "BASIM TEKNOLOJİLERİ (YÜKSEKOKUL)",
            "BASIM YAYIN VE REDAKTE",
            "BASIN VE YAYIN",
            "BATI DİLLERİ",
            "BEDEN EĞİTİMİ VE SPOR ÖĞRETMENLİĞİ",
            "BESLENME VE DİYETETİK (FAKÜLTE)",
            "BESLENME VE DİYETETİK (YÜKSEKOKUL)",
            "BİLGİ VE BELGE YÖNETİMİ",
            "BİLGİSAYAR BİLİMLERİ",
            "BİLGİSAYAR MÜHENDİSLİĞİ",
            "BİLGİSAYAR MÜHENDİSLİĞİ (M.T.O.K.)",
            "BİLGİSAYAR TEKNOLOJİSİ VE BİLİŞİM SİSTEMLERİ (YÜKSEKOKUL)",
            "BİLGİSAYAR VE ÖĞRETİM TEKNOLOJİLERİ ÖĞRETMENLİĞİ",
            "BİLGİSAYAR VE YAZILIM MÜHENDİSLİĞİ",
            "BİLGİSAYAR-ENFORMATİK",
            "BİLİM TARİHİ",
            "BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ",
            "BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ (M.T.O.K.)",
            "BİLİŞİM SİSTEMLERİ VE TEKNOLOJİLERİ (FAKÜLTE)",
            "BİTKİ KORUMA",
            "BİTKİSEL ÜRETİM VE TEKNOLOJİLERİ",
            "BİYOENFORMATİK VE GENETİK",
            "BİYOKİMYA",
            "BİYOLOJİ",
            "BİYOLOJİ ÖĞRETMENLİĞİ",
            "BİYOMEDİKAL MÜHENDİSLİĞİ",
            "BİYOMEDİKAL MÜHENDİSLİĞİ (M.T.O.K.)",
            "BİYOMÜHENDİSLİK",
            "BİYOSİSTEM MÜHENDİSLİĞİ",
            "BİYOTEKNOLOJİ",
            "BİYOTEKNOLOJİ VE MOLEKÜLER BİYOLOJİ",
            "BOŞNAK DİLİ VE EDEBİYATIBULGAR DİLİ VE EDEBİYATI",
            "ÇAĞDAŞ TÜRK LEHÇELERİ VE EDEBİYATLARI",
            "ÇAĞDAŞ YUNAN DİLİ VE EDEBİYATI",
            "ÇALIŞMA EKONOMİSİ VE ENDÜSTRİ İLİŞKİLERİ",
            "ÇALIŞMA EKONOMİSİ VE ENDÜSTRİ İLİŞKİLERİ (AÇIKÖĞRETİM)",
            "CANLANDIRMA FİLMİ TASARIM VE YÖNETİMİ",
            "ÇERKEZ DİLİ VE EDEBİYATI",
            "CEVHER HAZIRLAMA MÜHENDİSLİĞİ",
            "ÇEVİRİBİLİM",
            "ÇEVRE MÜHENDİSLİĞİ",
            "ÇİN DİLİ VE EDEBİYATI",
            "ÇİZGİ FİLM VE ANİMASYON",
            "ÇOCUK GELİŞİMİ (FAKÜLTE)",
            "ÇOCUK GELİŞİMİ (YÜKSEKOKUL)",
            "COĞRAFYA",
            "COĞRAFYA (AÇIKÖĞRETİM)",
            "COĞRAFYA ÖĞRETMENLİĞİ",
            "DENİZ İŞLETMECİLİĞİ VE YÖNETİMİ",
            "DENİZ ULAŞTIRMA İŞLETME MÜHENDİSLİĞİ (FAKÜLTE)",
            "DENİZ ULAŞTIRMA İŞLETME MÜHENDİSLİĞİ (YÜKSEKOKUL)",
            "DENİZCİLİK İŞLETMELERİ YÖNETİMİ (FAKÜLTE)",
            "DERİ MÜHENDİSLİĞİ",
            "DİJİTAL OYUN TASARIMI (FAKÜLTE)",
            "DİJİTAL OYUN TASARIMI (YÜKSEKOKUL)",
            "DİL VE KONUŞMA TERAPİSİ",
            "DİLBİLİM",
            "DİLBİLİMİ",
            "DİŞ HEKİMLİĞİ",
            "DOĞU DİLLERİ",
            "EBELİK (FAKÜLTE)",
            "EBELİK (YÜKSEKOKUL)",
            "ECZACILIK",
            "EKONOMETRİ",
            "EKONOMİ",
            "EKONOMİ VE FİNANS",
            "EL SANATLARI (M.T.O.K.)",
            "EL SANATLARI TASARIMI VE ÜRETİMİ",
            "ELEKTRİK MÜHENDİSLİĞİ",
            "ELEKTRİK-ELEKTRONİK MÜHENDİSLİĞİ",
            "ELEKTRİK-ELEKTRONİK MÜHENDİSLİĞİ (M.T.O.K.)",
            "ELEKTRONİK MÜHENDİSLİĞİ",
            "ELEKTRONİK TİCARET VE TEKNOLOJİ YÖNETİMİ",
            "ELEKTRONİK VE HABERLEŞME MÜHENDİSLİĞİ",
            "ENDÜSTRİ MÜHENDİSLİĞİ",
            "ENDÜSTRİ MÜHENDİSLİĞİ PROGRAMLARI",
            "ENDÜSTRİ TASARIMI",
            "ENDÜSTRİ ÜRÜNLERİ TASARIMI (FAKÜLTE)",
            "ENDÜSTRİ ÜRÜNLERİ TASARIMI (YÜKSEKOKUL)",
            "ENDÜSTRİ VE SİSTEM MÜHENDİSLİĞİ",
            "ENDÜSTRİYEL TASARIM",
            "ENDÜSTRİYEL TASARIM MÜHENDİSLİĞİ",
            "ENDÜSTRİYEL TASARIM MÜHENDİSLİĞİ (M.T.O.K.)",
            "ENERJİ MÜHENDİSLİĞİ",
            "ENERJİ SİSTEMLERİ MÜHENDİSLİĞİ",
            "ENERJİ SİSTEMLERİ MÜHENDİSLİĞİ (M.T.O.K.)",
            "ENERJİ VE MALZEME MÜHENDİSLİĞİ",
            "ENERJİ YÖNETİMİ",
            "ERGOTERAPİ (FAKÜLTE)",
            "ERGOTERAPİ (YÜKSEKOKUL)",
            "ERMENİ DİLİ VE EDEBİYATI",
            "EŞİT AĞIRLIKLI PROGRAMLAR",
            "ESKİ YUNAN DİLİ VE EDEBİYATI",
            "FARS DİLİ VE EDEBİYATI",
            "FELSEFE",
            "FELSEFE (AÇIKÖĞRETİM)",
            "FELSEFE GRUBU ÖĞRETMENLİĞİ",
            "FEN BİLGİSİ ÖĞRETMENLİĞİ",
            "FİLM TASARIM VE YAZARLIK",
            "FİLM TASARIM VE YÖNETMENLİĞİ",
            "FİLM TASARIMI",
            "FİNANS VE BANKACILIK (FAKÜLTE)",
            "FİNANSAL EKONOMETRİ",
            "FİZİK",
            "FİZİK MÜHENDİSLİĞİ",
            "FİZİK ÖĞRETMENLİĞİ",
            "FİZYOTERAPİ VE REHABİLİTASYON (FAKÜLTE)",
            "FİZYOTERAPİ VE REHABİLİTASYON (YÜKSEKOKUL)",
            "FOTOĞRAF",
            "FOTOĞRAF VE VİDEO",
            "FRANSIZ DİLİ VE EDEBİYATI",
            "FRANSIZCA ÖĞRETMENLİĞİ",
            "GASTRONOMİ (FAKÜLTE)",
            "GASTRONOMİ (YÜKSEKOKUL)",
            "GASTRONOMİ VE MUTFAK SANATLARI",
            "GASTRONOMİ VE MUTFAK SANATLARI (FAKÜLTE)",
            "GASTRONOMİ VE MUTFAK SANATLARI (M.T.O.K.)",
            "GASTRONOMİ VE MUTFAK SANATLARI (YÜKSEKOKUL)",
            "GAYRİMENKUL GELİŞTİRME VE YÖNETİMİ (FAKÜLTE)",
            "GAYRİMENKUL GELİŞTİRME VE YÖNETİMİ (YÜKSEKOKUL)",
            "GAYRİMENKUL VE VARLIK DEĞERLEME (FAKÜLTE)",
            "GAYRİMENKUL VE VARLIK DEĞERLEME (YÜKSEKOKUL)",
            "GAZETECİLİK",
            "GAZETECİLİK VE KİTLE İLETİŞİM",
            "GELENEKSEL TÜRK SANATLARI (M.T.O.K.)",
            "GEMİ İNŞAATI VE GEMİ MAKİNELERİ MÜHENDİSLİĞİ",
            "GEMİ MAKİNELERİ İŞLETME MÜHENDİSLİĞİ (FAKÜLTE)",
            "GEMİ MAKİNELERİ İŞLETME MÜHENDİSLİĞİ (YÜKSEKOKUL)",
            "GEMİ VE DENİZ TEKNOLOJİSİ MÜHENDİSLİĞİ",
            "GEMİ VE YAT TASARIMI",
            "GENETİK VE BİYOMÜHENDİSLİK",
            "GENETİK VE YAŞAM BİLİMLERİ PROGRAMLARI",
            "GEOMATİK MÜHENDİSLİĞİ",
            "GERONTOLOJİ",
            "GIDA MÜHENDİSLİĞİ",
            "GIDA TEKNOLOJİSİ (YÜKSEKOKUL)",
            "GİRİŞİMCİLİK",
            "GÖRSEL İLETİŞİM",
            "GÖRSEL İLETİŞİM TASARIMI",
            "GÖRSEL SANATLAR",
            "GÖRSEL SANATLAR (M.T.O.K.)",
            "GÖRSEL SANATLAR VE GÖRSEL İLETİŞİM TASARIMI",
            "GÖRSEL SANATLAR VE İLETİŞİM TASARIMI",
            "GÖRSEL SANATLAR VE MEDYA",
            "GRAFİK TASARIM",
            "GRAFİK TASARIMI",
            "GRAFİK TASARIMI (M.T.O.K.)",
            "GÜMRÜK İŞLETME (YÜKSEKOKUL)",
            "GÜRCÜ DİLİ VE EDEBİYATI",
            "GÜVERTE (YÜKSEKOKUL)",
            "HALKBİLİM",
            "HALKLA İLİŞKİLER",
            "HALKLA İLİŞKİLER VE REKLAMCILIK (AÇIKÖĞRETİM)",
            "HALKLA İLİŞKİLER VE REKLAMCILIK (FAKÜLTE)",
            "HALKLA İLİŞKİLER VE REKLAMCILIK (YÜKSEKOKUL)",
            "HALKLA İLİŞKİLER VE TANITIM",
            "HALKLA İLİŞKİLER VE TANITIM (AÇIKÖĞRETİM)",
            "HARİTA MÜHENDİSLİĞİ",
            "HAVA TRAFİK KONTROL",
            "HAVACILIK ELEKTRİK VE ELEKTRONİĞİ (FAKÜLTE)",
            "HAVACILIK ELEKTRİK VE ELEKTRONİĞİ (YÜKSEKOKUL)",
            "HAVACILIK VE UZAY MÜHENDİSLİĞİ",
            "HAVACILIK YÖNETİMİ (AÇIKÖĞRETİM)",
            "HAVACILIK YÖNETİMİ (FAKÜLTE)",
            "HAVACILIK YÖNETİMİ (YÜKSEKOKUL)",
            "HAYVANSAL ÜRETİM (YÜKSEKOKUL)",
            "HAYVANSAL ÜRETİM VE TEKNOLOJİLERİ",
            "HEMŞİRELİK (FAKÜLTE)",
            "HEMŞİRELİK (YÜKSEKOKUL)",
            "HEMŞİRELİK VE SAĞLIK HİZMETLERİ (FAKÜLTE)",
            "HEMŞİRELİK VE SAĞLIK HİZMETLERİ (YÜKSEKOKUL)",
            "HİDROJEOLOJİ MÜHENDİSLİĞİ",
            "HİNDOLOJİ",
            "HİTİTOLOJİ",
            "HUKUK",
            "HUNGAROLOJİ",
            "İBRANİ DİLİ VE EDEBİYATI",
            "İÇ MİMARLIK",
            "İÇ MİMARLIK VE ÇEVRE TASARIMI",
            "İKTİSADİ VE İDARİ BİLİMLER PROGRAMLARI",
            "İKTİSADİ VE İDARİ PROGRAMLARI",
            "İKTİSAT",
            "İKTİSAT (AÇIKÖĞRETİM)",
            "İLAHİYAT",
            "İLETİŞİM",
            "İLETİŞİM BİLİMLERİ",
            "İLETİŞİM SANATLARI",
            "İLETİŞİM TASARIMI",
            "İLETİŞİM TASARIMI VE MEDYA",
            "İLETİŞİM TASARIMI VE YÖNETİMİ",
            "İLETİŞİM VE TASARIM",
            "İLKÖĞRETİM MATEMATİK ÖĞRETMENLİĞİ",
            "İMALAT MÜHENDİSLİĞİ",
            "İMALAT MÜHENDİSLİĞİ (M.T.O.K.)",
            "İNGİLİZ DİL BİLİMİ",
            "İNGİLİZ DİLİ VE EDEBİYATI",
            "İNGİLİZ DİLİ VE KARŞILAŞTIRMALI EDEBİYAT",
            "İNGİLİZ VE RUS DİLLERİ VE EDEBİYATLARI",
            "İNGİLİZCE ÖĞRETMENLİĞİ",
            "İNŞAAT MÜHENDİSLİĞİ",
            "İNŞAAT MÜHENDİSLİĞİ (M.T.O.K.)",
            "İNSAN KAYNAKLARI YÖNETİMİ (FAKÜLTE)",
            "İNSAN KAYNAKLARI YÖNETİMİ (YÜKSEKOKUL)",
            "İNSAN VE TOPLUM BİLİMLERİ",
            "İŞ SAĞLIĞI VE GÜVENLİĞİ (FAKÜLTE)",
            "İŞ SAĞLIĞI VE GÜVENLİĞİ (YÜKSEKOKUL)",
            "İSLAM BİLİMLERİ",
            "İSLAM EKONOMİSİ VE FİNANS",
            "İSLAM VE DİN BİLİMLERİ",
            "İSLAMİ İLİMLER",
            "İŞLETME",
            "İŞLETME (AÇIKÖĞRETİM)",
            "İŞLETME BİLGİ YÖNETİMİ (YÜKSEKOKUL)",
            "İŞLETME ENFORMATİĞİ",
            "İŞLETME MÜHENDİSLİĞİ",
            "İŞLETME YÖNETİMİ",
            "İŞLETME-EKONOMİ",
            "İSPANYOL DİLİ VE EDEBİYATI",
            "İSTATİSTİK",
            "İSTATİSTİK VE BİLGİSAYAR BİLİMLERİ",
            "İTALYAN DİLİ VE EDEBİYATI",
            "JAPON DİLİ VE EDEBİYATI",
            "JAPONCA ÖĞRETMENLİĞİ",
            "JEOFİZİK MÜHENDİSLİĞİ",
            "JEOLOJİ MÜHENDİSLİĞİ",
            "KAMU YÖNETİMİ",
            "KAMU YÖNETİMİ (AÇIKÖĞRETİM)",
            "KANATLI HAYVAN YETİŞTİRİCİLİĞİ",
            "KARŞILAŞTIRMALI EDEBİYAT",
            "KAZAK DİLİ VE EDEBİYATI",
            "KENTSEL TASARIM VE PEYZAJ MİMARİSİ",
            "KENTSEL TASARIM VE PEYZAJ MİMARLIĞI",
            "KİMYA",
            "KİMYA MÜHENDİSLİĞİ",
            "KİMYA MÜHENDİSLİĞİ VE UYGULAMALI KİMYA",
            "KİMYA ÖĞRETMENLİĞİ",
            "KİMYA VE SÜREÇ MÜHENDİSLİĞİ",
            "KİMYA-BİYOLOJİ MÜHENDİSLİĞİ",
            "KLASİK ARKEOLOJİ",
            "KONAKLAMA İŞLETMECİLİĞİ (FAKÜLTE)",
            "KONAKLAMA İŞLETMECİLİĞİ (FAKÜLTE) (AÇIKÖĞRETİM)",
            "KONAKLAMA İŞLETMECİLİĞİ (YÜKSEKOKUL)",
            "KONAKLAMA VE TURİZM İŞLETMECİLİĞİ (YÜKSEKOKUL)",
            "KONTROL VE OTOMASYON MÜHENDİSLİĞİ",
            "KORE DİLİ VE EDEBİYATI",
            "KÜLTÜR VARLIKLARINI KORUMA VE ONARIM",
            "KÜLTÜR VE İLETİŞİM BİLİMLERİ",
            "KÜRESEL SİYASET VE ULUSLARARASI İLİŞKİLER",
            "KURGU-SES VE GÖRÜNTÜ YÖNETİMİ",
            "KÜRT DİLİ VE EDEBİYATI",
            "KUYUMCULUK VE MÜCEVHER TASARIMI",
            "KUYUMCULUK VE MÜCEVHER TASARIMI (M.T.O.K.)",
            "KUYUMCULUK VE MÜCEVHER TASARIMI (M.T.O.K.)",
            "LATİN DİLİ VE EDEBİYATI",
            "LEH DİLİ VE EDEBİYATI",
            "LİF VE POLİMER MÜHENDİSLİĞİ",
            "LOJİSTİK (YÜKSEKOKUL)",
            "LOJİSTİK VE TAŞIMACILIK (YÜKSEKOKUL)",
            "LOJİSTİK YÖNETİMİ (FAKÜLTE)",
            "LOJİSTİK YÖNETİMİ (YÜKSEKOKUL)",
            "MADEN MÜHENDİSLİĞİ",
            "MAKİNE MÜHENDİSLİĞİ",
            "MAKİNE MÜHENDİSLİĞİ (M.T.O.K.)",
            "MAKİNE VE İMALAT MÜHENDİSLİĞİ",
            "MAKİNE VE İMALAT MÜHENDİSLİĞİ (M.T.O.K.)",
            "MALİYE",
            "MALİYE (AÇIKÖĞRETİM)",
            "MALZEME BİLİMİ VE MÜHENDİSLİĞİ",
            "MALZEME BİLİMİ VE NANOTEKNOLOJİ MÜHENDİSLİĞİ",
            "MALZEME BİLİMİ VE TEKNOLOJİLERİ",
            "MALZEME MÜHENDİSLİĞİ",
            "MATEMATİK",
            "MATEMATİK MÜHENDİSLİĞİ",
            "MATEMATİK ÖĞRETMENLİĞİ",
            "MATEMATİK VE BİLGİSAYAR BİLİMLERİ",
            "MATEMATİK-BİLGİSAYAR",
            "MEDYA VE GÖRSEL SANATLAR",
            "MEDYA VE İLETİŞİM",
            "MEDYA VE İLETİŞİM SİSTEMLERİ (FAKÜLTE)",
            "MEDYA VE İLETİŞİM SİSTEMLERİ (YÜKSEKOKUL)",
            "MEKATRONİK MÜHENDİSLİĞİ",
            "MEKATRONİK MÜHENDİSLİĞİ (M.T.O.K.)",
            "MEKATRONİK SİSTEMLER MÜHENDİSLİĞİ",
            "METALURJİ VE MALZEME MÜHENDİSLİĞİ",
            "METALURJİ VE MALZEME MÜHENDİSLİĞİ (M.T.O.K.)",
            "METEOROLOJİ MÜHENDİSLİĞİ",
            "MİMARLIK",
            "MODA TASARIMI (FAKÜLTE)",
            "MODA TASARIMI (M.T.O.K.)",
            "MODA TASARIMI (YÜKSEKOKUL)",
            "MODA VE TEKSTİL TASARIMI",
            "MOLEKÜLER BİYOLOJİ VE GENETİK",
            "MOLEKÜLER BİYOTEKNOLOJİ",
            "MUHASEBE (YÜKSEKOKUL)",
            "MUHASEBE BİLGİ SİSTEMLERİ (YÜKSEKOKUL)",
            "MUHASEBE VE DENETİM (FAKÜLTE)",
            "MUHASEBE VE DENETİM (YÜKSEKOKUL)",
            "MUHASEBE VE FİNANS YÖNETİMİ (FAKÜLTE)",
            "MUHASEBE VE FİNANS YÖNETİMİ (YÜKSEKOKUL)",
            "MUHASEBE VE FİNANSAL YÖNETİM (FAKÜLTE)",
            "MUHASEBE VE FİNANSAL YÖNETİM (YÜKSEKOKUL)",
            "MÜHENDİSLİK PROGRAMLARI",
            resources.GetString("comboBoxDiploma.Items"),
            "MÜTERCİM-TERCÜMANLIK(DİL-1)",
            "MÜTERCİM-TERCÜMANLIK(DİL-2)",
            "MÜTERCİM-TERCÜMANLIK(DİL-3)",
            "MÜZECİLİK",
            "MÜZİKOLOJİ",
            "NANOBİLİM VE NANOTEKNOLOJİ",
            "NANOTEKNOLOJİ MÜHENDİSLİĞİ",
            "NÜKLEER ENERJİ MÜHENDİSLİĞİ",
            "ODYOLOJİ (FAKÜLTE)",
            "ODYOLOJİ (YÜKSEKOKUL)",
            "ÖĞRETMENLİK PROGRAMLARI",
            "OKUL ÖNCESİ ÖĞRETMENLİĞİ",
            "OPTİK VE AKUSTİK MÜHENDİSLİĞİ",
            "ORGANİK TARIM İŞLETMECİLİĞİ (YÜKSEKOKUL)",
            "ORMAN ENDÜSTRİSİ MÜHENDİSLİĞİ",
            "ORMAN MÜHENDİSLİĞİ",
            "ORTEZ-PROTEZ (FAKÜLTE)",
            "ORTEZ-PROTEZ (YÜKSEKOKUL)",
            "OTEL YÖNETİCİLİĞİ (YÜKSEKOKUL)",
            "OTOMOTİV MÜHENDİSLİĞİ",
            "OTOMOTİV MÜHENDİSLİĞİ (M.T.O.K.)",
            "ÖZEL EĞİTİM ÖĞRETMENLİĞİ",
            "PAZARLAMA (FAKÜLTE)",
            "PAZARLAMA (YÜKSEKOKUL)",
            "PERFÜZYON (FAKÜLTE)",
            "PERFÜZYON (YÜKSEKOKUL)",
            "PETROL VE DOĞALGAZ MÜHENDİSLİĞİ",
            "PEYZAJ MİMARLIĞI",
            "PİLOT EĞİTİMİ",
            "PİLOTAJ",
            "POLİMER MÜHENDİSLİĞİ",
            "POLONYA DİLİ VE KÜLTÜRÜ",
            "PROTOHİSTORYA VE ÖN ASYA ARKEOLOJİSİ",
            "PSİKOLOJİ",
            "PSİKOLOJİK DANIŞMANLIK VE REHBERLİK",
            "PSİKOLOJİK DANIŞMANLIK VE REHBERLİK ÖĞRETMENLİĞİ",
            "RADYO VE TELEVİZYON",
            "RADYO, TELEVİZYON VE SİNEMA",
            "RAYLI SİSTEMLER MÜHENDİSLİĞİ",
            "REHBERLİK VE PSİKOLOJİK DANIŞMANLIK",
            "REKLAM TASARIMI VE İLETİŞİMİ",
            "REKLAMCILIK",
            "REKLAMCILIK VE HALKLA İLİŞKİLER",
            "REKREASYON (FAKÜLTE)",
            "REKREASYON (YÜKSEKOKUL)",
            "REKREASYON YÖNETİMİ (FAKÜLTE)",
            "REKREASYON YÖNETİMİ (M.T.O.K.)",
            "REKREASYON YÖNETİMİ (YÜKSEKOKUL)",
            "RESTORASYON VE KONSERVASYON",
            "RUS DİLİ ÖĞRETMENLİĞİ",
            "RUS DİLİ VE EDEBİYATI",
            "RUS DİLİ VE EDEBİYATI ÖĞRETMENLİĞİ",
            "RUS VE İNGİLİZ DİLLERİ VE EDEBİYATI",
            "SAĞLIK İDARESİ",
            "SAĞLIK YÖNETİMİ (AÇIKÖĞRETİM)",
            "SAĞLIK YÖNETİMİ (FAKÜLTE)",
            "SAĞLIK YÖNETİMİ (YÜKSEKOKUL)",
            "SANAT TARİHİ",
            "SANAT VE KÜLTÜR YÖNETİMİ",
            "SANAT VE SOSYAL BİLİMLER PROGRAMLARI (EKONOMİ, SİYASET BİLİMİ, ULUSLARARASI ÇALIŞ" +
                "MALAR, GÖRSEL SANATLAR VE GÖRSEL İLETİŞİM TASARIMI, KÜLTÜREL ÇALIŞMALAR, PSİKOLO" +
                "Jİ)",
            "SANAT YÖNETİMİ",
            "ŞEHİR VE BÖLGE PLANLAMA",
            "SERMAYE PİYASALARI VE PORTFÖY YÖNETİMİ (FAKÜLTE)",
            "SERMAYE PİYASALARI VE PORTFÖY YÖNETİMİ (YÜKSEKOKUL)",
            "SERMAYE PİYASASI (YÜKSEKOKUL)",
            "SEYAHAT İŞLETMECİLİĞİ (FAKÜLTE)",
            "SEYAHAT İŞLETMECİLİĞİ (YÜKSEKOKUL)",
            "SEYAHAT İŞLETMECİLİĞİ VE TURİZM REHBERLİĞİ (FAKÜLTE)",
            "SEYAHAT İŞLETMECİLİĞİ VE TURİZM REHBERLİĞİ (M.T.O.K.)",
            "SİGORTACILIK (YÜKSEKOKUL)",
            "SİGORTACILIK VE AKTÜERYA BİLİMLERİ (FAKÜLTE)",
            "SİGORTACILIK VE RİSK YÖNETİMİ (FAKÜLTE)",
            "SİGORTACILIK VE RİSK YÖNETİMİ (YÜKSEKOKUL)",
            "SİGORTACILIK VE SOSYAL GÜVENLİK",
            "SİNEMA VE DİJİTAL MEDYA",
            "SİNEMA VE TELEVİZYON",
            "SINIF ÖĞRETMENLİĞİ",
            "SİNOLOJİ",
            "SİYASAL BİLİMLER",
            "SİYASET BİLİMİ",
            "SİYASET BİLİMİ VE KAMU YÖNETİMİ",
            "SİYASET BİLİMİ VE ULUSLARARASI İLİŞKİLERSOSYAL BİLGİLER ÖĞRETMENLİĞİ",
            "SOSYAL HİZMET (AÇIKÖĞRETİM)",
            "SOSYAL HİZMET (FAKÜLTE)",
            "SOSYAL HİZMET (FAKÜLTE) (AÇIKÖĞRETİM)",
            "SOSYAL HİZMET (YÜKSEKOKUL)",
            "SOSYAL VE SİYASAL BİLİMLER",
            "SOSYOLOJİ",
            "SOSYOLOJİ (AÇIKÖĞRETİM)",
            "SPOR YÖNETİCİLİĞİ (FAKÜLTE)",
            "SPOR YÖNETİCİLİĞİ (YÜKSEKOKUL)",
            "SU BİLİMLERİ MÜHENDİSLİĞİ",
            "SU ÜRÜNLERİ MÜHENDİSLİĞİ",
            "SÜMEROLOJİ",
            "SÜRYANİ DİLİ VE EDEBİYATI",
            "SÜT TEKNOLOJİSİ",
            "TAKI TASARIMI (FAKÜLTE)",
            "TAPU KADASTRO (YÜKSEKOKUL)",
            "TARİH",
            "TARİH (AÇIKÖĞRETİM)",
            "TARİH ÖĞRETMENLİĞİ",
            "TARİH ÖNCESİ ARKEOLOJİSİ",
            "TARIM EKONOMİSİ",
            "TARIM MAKİNELERİ VE TEKNOLOJİLERİ MÜHENDİSLİĞİ",
            "TARIMSAL BİYOTEKNOLOJİ",
            "TARIMSAL GENETİK MÜHENDİSLİĞİ",
            "TARIMSAL YAPILAR VE SULAMA",
            "TARLA BİTKİLERİ",
            "TAŞINABİLİR KÜLTÜR VARLIKLARINI KORUMA VE ONARIM",
            "TEKNOLOJİ VE BİLGİ YÖNETİMİ",
            "TEKSTİL MÜHENDİSLİĞİ",
            "TEKSTİL TASARIMI (M.T.O.K.)",
            "TEKSTİL VE MODA TASARIMI",
            "TELEVİZYON HABERCİLİĞİ VE PROGRAMCILIĞI (FAKÜLTE)",
            "TELEVİZYON HABERCİLİĞİ VE PROGRAMCILIĞI (YÜKSEKOKUL)",
            "TIP",
            "TIP MÜHENDİSLİĞİ",
            "TİYATRO ELEŞTİRMENLİĞİ VE DRAMATURJİ (FAKÜLTE)",
            "TOPRAK BİLİMİ VE BİTKİ BESLEME",
            "TURİZM İŞLETMECİLİĞİ (FAKÜLTE)",
            "TURİZM İŞLETMECİLİĞİ (M.T.O.K.)",
            "TURİZM İŞLETMECİLİĞİ (YÜKSEKOKUL)",
            "TURİZM İŞLETMECİLİĞİ VE OTELCİLİK (YÜKSEKOKUL)",
            "TURİZM REHBERLİĞİ",
            "TURİZM VE OTEL İŞLETMECİLİĞİ (FAKÜLTE)",
            "TURİZM VE OTEL İŞLETMECİLİĞİ (YÜKSEKOKUL)",
            "TURİZM VE OTEL YÖNETİCİLİĞİ",
            "TURİZM VE OTELCİLİK (FAKÜLTE)",
            "TURİZM VE OTELCİLİK (YÜKSEKOKUL)",
            "TÜRK DİLİ VE EDEBİYATI",
            "TÜRK DİLİ VE EDEBİYATI (AÇIKÖĞRETİM)",
            "TÜRK DİLİ VE EDEBİYATI ÖĞRETMENLİĞİ",
            "TÜRK HALKBİLİMİ",
            "TÜRK İSLAM ARKEOLOJİSİ",
            "TÜRKÇE ÖĞRETMENLİĞİ",
            "TÜRKOLOJİ",
            "TÜTÜN EKSPERLİĞİ (YÜKSEKOKUL)",
            "UÇAK ELEKTRİK-ELEKTRONİK (FAKÜLTE)",
            "UÇAK ELEKTRİK-ELEKTRONİK (YÜKSEKOKUL)",
            "UÇAK GÖVDE-MOTOR (FAKÜLTE)",
            "UÇAK GÖVDE-MOTOR (YÜKSEKOKUL)",
            "UÇAK GÖVDE-MOTOR BAKIM (FAKÜLTE)",
            "UÇAK GÖVDE-MOTOR BAKIM (YÜKSEKOKUL)",
            "UÇAK MÜHENDİSLİĞİ",
            "UÇAK VE UZAY MÜHENDİSLİĞİ",
            "UKRAYNA DİLİ VE EDEBİYATI",
            "ULAŞTIRMA MÜHENDİSLİĞİ",
            "ULAŞTIRMA VE LOJİSTİK (FAKÜLTE)",
            "ULAŞTIRMA VE LOJİSTİK (YÜKSEKOKUL)",
            "ULAŞTIRMA VE LOJİSTİK YÖNETİMİ (FAKÜLTE)",
            "ULAŞTIRMA VE LOJİSTİK YÖNETİMİ (YÜKSEKOKUL)",
            "ULUSLARARASI EKONOMİK İLİŞKİLER",
            "ULUSLARARASI FİNANS (FAKÜLTE)",
            "ULUSLARARASI FİNANS (YÜKSEKOKUL)",
            "ULUSLARARASI FİNANS VE BANKACILIK (FAKÜLTE)",
            "ULUSLARARASI FİNANS VE BANKACILIK (YÜKSEKOKUL)",
            "ULUSLARARASI GİRİŞİMCİLİK",
            "ULUSLARARASI İLİŞKİLER",
            "ULUSLARARASI İLİŞKİLER (AÇIKÖĞRETİM)",
            "ULUSLARARASI İŞLETME",
            "ULUSLARARASI İŞLETME YÖNETİMİ",
            "ULUSLARARASI İŞLETMECİLİK",
            "ULUSLARARASI İŞLETMECİLİK VE TİCARET (FAKÜLTE)",
            "ULUSLARARASI İŞLETMECİLİK VE TİCARET (YÜKSEKOKUL)",
            "ULUSLARARASI LOJİSTİK (FAKÜLTE)",
            "ULUSLARARASI LOJİSTİK (YÜKSEKOKUL)",
            "ULUSLARARASI LOJİSTİK VE TAŞIMACILIK (FAKÜLTE)",
            "ULUSLARARASI LOJİSTİK VE TAŞIMACILIK (YÜKSEKOKUL)",
            "ULUSLARARASI LOJİSTİK YÖNETİMİ",
            "ULUSLARARASI PERAKENDE YÖNETİMİ (YÜKSEKOKUL)",
            "ULUSLARARASI TİCARET (FAKÜLTE)",
            "ULUSLARARASI TİCARET (YÜKSEKOKUL)",
            "ULUSLARARASI TİCARET VE FİNANS",
            "ULUSLARARASI TİCARET VE FİNANSMAN",
            "ULUSLARARASI TİCARET VE İŞLETMECİLİK (YÜKSEKOKUL)",
            "ULUSLARARASI TİCARET VE İŞLETMECİLİK (FAKÜLTE)",
            "ULUSLARARASI TİCARET VE LOJİSTİK (FAKÜLTE)",
            "ULUSLARARASI TİCARET VE LOJİSTİK (YÜKSEKOKUL)",
            "ULUSLARARASI TİCARET VE LOJİSTİK YÖNETİMİ (AÇIKÖĞRETİM)",
            "ULUSLARARASI TİCARET VE LOJİSTİK YÖNETİMİ (FAKÜLTE)",
            "ULUSLARARASI TİCARET VE LOJİSTİK YÖNETİMİ (YÜKSEKOKUL)",
            "ULUSLARARASI TİCARET, LOJİSTİK VE İŞLETMECİLİK (YÜKSEKOKUL)",
            "URDU DİLİ VE EDEBİYATI",
            "UZAY BİLİMLERİ VE TEKNOLOJİLERİ",
            "UZAY MÜHENDİSLİĞİ",
            "VETERİNERLİK",
            "YABAN HAYATI EKOLOJİSİ VE YÖNETİMİ",
            "YAZILIM MÜHENDİSLİĞİ",
            "YAZILIM MÜHENDİSLİĞİ (M.T.O.K.)",
            "YENİ MEDYA (FAKÜLTE)",
            "YENİ MEDYA (YÜKSEKOKUL)",
            "YENİ MEDYA VE GAZETECİLİK",
            "YENİ MEDYA VE İLETİŞİM",
            "YENİ MEDYA VE İLETİŞİM SİSTEMLERİ",
            "YER BİLİMLERİ MÜHENDİSLİĞİ PROGRAMLARI",
            "YEREL YÖNETİMLER",
            "YİYECEK-İÇECEK İŞLETMECİLİĞİ (FAKÜLTE)",
            "YİYECEK-İÇECEK İŞLETMECİLİĞİ (YÜKSEKOKUL)",
            "YÖNETİM BİLİMLERİ PROGRAMLARI",
            "YÖNETİM BİLİŞİM SİSTEMLERİ (AÇIKÖĞRETİM)",
            "YÖNETİM BİLİŞİM SİSTEMLERİ (FAKÜLTE)",
            "YÖNETİM BİLİŞİM SİSTEMLERİ (YÜKSEKOKUL)",
            "YUNAN DİLİ VE EDEBİYATI",
            "ZAZA DİLİ VE EDEBİYATI",
            "ZİRAAT MÜHENDİSLİĞİ PROGRAMLARI",
            "ZOOTEKNİ"});
            this.comboBoxDiploma.Location = new System.Drawing.Point(474, 218);
            this.comboBoxDiploma.Name = "comboBoxDiploma";
            this.comboBoxDiploma.Size = new System.Drawing.Size(286, 27);
            this.comboBoxDiploma.TabIndex = 6;
            // 
            // btnIptal
            // 
            this.btnIptal.FlatAppearance.BorderSize = 2;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.ForeColor = System.Drawing.Color.DarkRed;
            this.btnIptal.Location = new System.Drawing.Point(595, 303);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(165, 41);
            this.btnIptal.TabIndex = 8;
            this.btnIptal.Text = "iptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // dtpDogumTarih
            // 
            this.dtpDogumTarih.CustomFormat = "dd/MM/yyyy";
            this.dtpDogumTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDogumTarih.Location = new System.Drawing.Point(474, 132);
            this.dtpDogumTarih.Name = "dtpDogumTarih";
            this.dtpDogumTarih.Size = new System.Drawing.Size(286, 27);
            this.dtpDogumTarih.TabIndex = 4;
            this.dtpDogumTarih.Value = new System.DateTime(2021, 8, 13, 0, 0, 0, 0);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(474, 177);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(286, 27);
            this.txtTel.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(148, 173);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(173, 27);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(148, 132);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(173, 27);
            this.txtAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.label2.Location = new System.Drawing.Point(68, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.label8.Location = new System.Drawing.Point(374, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Diploma:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.label7.Location = new System.Drawing.Point(428, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.label6.Location = new System.Drawing.Point(20, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Doğum Yeri:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.label5.Location = new System.Drawing.Point(336, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.label1.Location = new System.Drawing.Point(100, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.label3.Location = new System.Drawing.Point(294, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yeni Öğretmen Ekle";
            // 
            // OgretmenEkle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(789, 394);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgretmenEkle";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgretmenEkle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxDogumYeri;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox comboBoxDiploma;
        private System.Windows.Forms.Button btnIptal;
        public System.Windows.Forms.DateTimePicker dtpDogumTarih;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}