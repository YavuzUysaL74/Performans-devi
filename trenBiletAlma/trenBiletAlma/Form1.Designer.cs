namespace trenBiletAlma
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.seferOlustur = new System.Windows.Forms.Button();
            this.kalisDuragi = new System.Windows.Forms.TextBox();
            this.varisDuragi = new System.Windows.Forms.TextBox();
            this.kalkisSaati = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.seferListele = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Tarih = new System.Windows.Forms.Label();
            this.kaklisTarihi = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.adminPanel = new System.Windows.Forms.Button();
            this.accessButton = new System.Windows.Forms.Button();
            this.systemRegisterButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yolcuSayı = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.kalkisAdmina = new System.Windows.Forms.Label();
            this.varisAdmin = new System.Windows.Forms.TextBox();
            this.kalkisAdmin = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tarihAdmin = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.koltukNoAdmin = new System.Windows.Forms.TextBox();
            this.saatAdmin = new System.Windows.Forms.TextBox();
            this.adTextAdmin = new System.Windows.Forms.TextBox();
            this.soyadTextAdmin = new System.Windows.Forms.TextBox();
            this.aktarButton = new System.Windows.Forms.Button();
            this.seferNoAdmin = new System.Windows.Forms.TextBox();
            this.ticketCreateButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.userSeferYazdır = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(182, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(465, 134);
            this.dataGridView1.TabIndex = 6;
            // 
            // seferOlustur
            // 
            this.seferOlustur.Location = new System.Drawing.Point(105, 150);
            this.seferOlustur.Name = "seferOlustur";
            this.seferOlustur.Size = new System.Drawing.Size(70, 37);
            this.seferOlustur.TabIndex = 7;
            this.seferOlustur.Text = "Sefer Oluştur";
            this.seferOlustur.UseVisualStyleBackColor = true;
            this.seferOlustur.Click += new System.EventHandler(this.button1_Click);
            // 
            // kalisDuragi
            // 
            this.kalisDuragi.Location = new System.Drawing.Point(76, 46);
            this.kalisDuragi.Name = "kalisDuragi";
            this.kalisDuragi.Size = new System.Drawing.Size(100, 20);
            this.kalisDuragi.TabIndex = 9;
            // 
            // varisDuragi
            // 
            this.varisDuragi.Location = new System.Drawing.Point(76, 72);
            this.varisDuragi.Name = "varisDuragi";
            this.varisDuragi.Size = new System.Drawing.Size(100, 20);
            this.varisDuragi.TabIndex = 10;
            // 
            // kalkisSaati
            // 
            this.kalkisSaati.Location = new System.Drawing.Point(75, 124);
            this.kalkisSaati.Name = "kalkisSaati";
            this.kalkisSaati.Size = new System.Drawing.Size(100, 20);
            this.kalkisSaati.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(-1, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kalkış Durağı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Varış Durağı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(8, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kalkış Saati:";
            // 
            // seferListele
            // 
            this.seferListele.Location = new System.Drawing.Point(830, 98);
            this.seferListele.Name = "seferListele";
            this.seferListele.Size = new System.Drawing.Size(75, 37);
            this.seferListele.TabIndex = 17;
            this.seferListele.Text = "Seferleri Listele";
            this.seferListele.UseVisualStyleBackColor = true;
            this.seferListele.Click += new System.EventHandler(this.seferListele_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "İzmir",
            "İstanbul",
            "Ankara",
            "Bursa",
            "Adana",
            "Antalya",
            "Bursa"});
            this.comboBox1.Location = new System.Drawing.Point(784, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "İzmir",
            "İstanbul",
            "Ankara",
            "Bursa",
            "Adana",
            "Antalya",
            "Bursa"});
            this.comboBox2.Location = new System.Drawing.Point(784, 76);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(781, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Varış Durağı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(781, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Kalkış Durağı:";
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Tarih
            // 
            this.Tarih.AutoSize = true;
            this.Tarih.ForeColor = System.Drawing.SystemColors.Control;
            this.Tarih.Location = new System.Drawing.Point(6, 101);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(67, 13);
            this.Tarih.TabIndex = 23;
            this.Tarih.Text = "Kalkış Tarihi:";
            // 
            // kaklisTarihi
            // 
            this.kaklisTarihi.Location = new System.Drawing.Point(76, 98);
            this.kaklisTarihi.Name = "kaklisTarihi";
            this.kaklisTarihi.Size = new System.Drawing.Size(100, 20);
            this.kaklisTarihi.TabIndex = 22;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(155, 41);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 24;
            this.registerButton.Text = "Kayıt Ol";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(155, 12);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 25;
            this.loginButton.Text = "Giriş Yap";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(49, 90);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 30;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(49, 64);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(100, 20);
            this.textBoxMail.TabIndex = 28;
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(49, 38);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(100, 20);
            this.textBoxSoyad.TabIndex = 27;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(48, 12);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(100, 20);
            this.textBoxAd.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Şifre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Mail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Soyad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Ad:";
            // 
            // adminPanel
            // 
            this.adminPanel.Location = new System.Drawing.Point(842, 231);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(84, 41);
            this.adminPanel.TabIndex = 36;
            this.adminPanel.Text = "Admin Paneli";
            this.adminPanel.UseVisualStyleBackColor = true;
            this.adminPanel.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // accessButton
            // 
            this.accessButton.BackColor = System.Drawing.Color.Lime;
            this.accessButton.Location = new System.Drawing.Point(81, 116);
            this.accessButton.Name = "accessButton";
            this.accessButton.Size = new System.Drawing.Size(68, 23);
            this.accessButton.TabIndex = 37;
            this.accessButton.Text = "Sisteme Gir";
            this.accessButton.UseVisualStyleBackColor = false;
            this.accessButton.Click += new System.EventHandler(this.accessButton_Click);
            // 
            // systemRegisterButton
            // 
            this.systemRegisterButton.BackColor = System.Drawing.Color.Red;
            this.systemRegisterButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.systemRegisterButton.Location = new System.Drawing.Point(55, 145);
            this.systemRegisterButton.Name = "systemRegisterButton";
            this.systemRegisterButton.Size = new System.Drawing.Size(94, 23);
            this.systemRegisterButton.TabIndex = 38;
            this.systemRegisterButton.Text = "Sisteme Kayıt Ol";
            this.systemRegisterButton.UseVisualStyleBackColor = false;
            this.systemRegisterButton.Click += new System.EventHandler(this.systemRegisterButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.yolcuSayı);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.kalkisAdmina);
            this.groupBox1.Controls.Add(this.varisAdmin);
            this.groupBox1.Controls.Add(this.kalkisAdmin);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.tarihAdmin);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.koltukNoAdmin);
            this.groupBox1.Controls.Add(this.saatAdmin);
            this.groupBox1.Controls.Add(this.adTextAdmin);
            this.groupBox1.Controls.Add(this.soyadTextAdmin);
            this.groupBox1.Controls.Add(this.aktarButton);
            this.groupBox1.Controls.Add(this.seferNoAdmin);
            this.groupBox1.Controls.Add(this.ticketCreateButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.seferOlustur);
            this.groupBox1.Controls.Add(this.kalisDuragi);
            this.groupBox1.Controls.Add(this.varisDuragi);
            this.groupBox1.Controls.Add(this.kalkisSaati);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.seferListele);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Tarih);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.kaklisTarihi);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(12, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(915, 358);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AdminPaneli";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // yolcuSayı
            // 
            this.yolcuSayı.Location = new System.Drawing.Point(75, 20);
            this.yolcuSayı.Name = "yolcuSayı";
            this.yolcuSayı.Size = new System.Drawing.Size(100, 20);
            this.yolcuSayı.TabIndex = 66;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(6, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 67;
            this.label14.Text = "Yolcu Sayısı:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(187, 331);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 13);
            this.label20.TabIndex = 64;
            this.label20.Text = "Varış:";
            // 
            // kalkisAdmina
            // 
            this.kalkisAdmina.AutoSize = true;
            this.kalkisAdmina.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kalkisAdmina.Location = new System.Drawing.Point(180, 305);
            this.kalkisAdmina.Name = "kalkisAdmina";
            this.kalkisAdmina.Size = new System.Drawing.Size(38, 13);
            this.kalkisAdmina.TabIndex = 63;
            this.kalkisAdmina.Text = "Kalkış:";
            // 
            // varisAdmin
            // 
            this.varisAdmin.Location = new System.Drawing.Point(224, 328);
            this.varisAdmin.Name = "varisAdmin";
            this.varisAdmin.Size = new System.Drawing.Size(100, 20);
            this.varisAdmin.TabIndex = 62;
            // 
            // kalkisAdmin
            // 
            this.kalkisAdmin.Location = new System.Drawing.Point(224, 302);
            this.kalkisAdmin.Name = "kalkisAdmin";
            this.kalkisAdmin.Size = new System.Drawing.Size(100, 20);
            this.kalkisAdmin.TabIndex = 61;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(429, 259);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 60;
            this.label16.Text = "Tarih";
            // 
            // tarihAdmin
            // 
            this.tarihAdmin.Location = new System.Drawing.Point(433, 275);
            this.tarihAdmin.Name = "tarihAdmin";
            this.tarihAdmin.Size = new System.Drawing.Size(100, 20);
            this.tarihAdmin.TabIndex = 59;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(535, 259);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 58;
            this.label15.Text = "Saat";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(331, 260);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 13);
            this.label18.TabIndex = 55;
            this.label18.Text = "Koltuk No";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(221, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Sefer No";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(117, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "Soyad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(15, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Ad";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // koltukNoAdmin
            // 
            this.koltukNoAdmin.Location = new System.Drawing.Point(330, 276);
            this.koltukNoAdmin.Name = "koltukNoAdmin";
            this.koltukNoAdmin.Size = new System.Drawing.Size(100, 20);
            this.koltukNoAdmin.TabIndex = 50;
            this.koltukNoAdmin.TextChanged += new System.EventHandler(this.koltukNoAdmin_TextChanged);
            this.koltukNoAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.koltukNoAdmin_KeyPress);
            // 
            // saatAdmin
            // 
            this.saatAdmin.Location = new System.Drawing.Point(539, 275);
            this.saatAdmin.Name = "saatAdmin";
            this.saatAdmin.Size = new System.Drawing.Size(100, 20);
            this.saatAdmin.TabIndex = 47;
            // 
            // adTextAdmin
            // 
            this.adTextAdmin.Location = new System.Drawing.Point(14, 276);
            this.adTextAdmin.Name = "adTextAdmin";
            this.adTextAdmin.Size = new System.Drawing.Size(100, 20);
            this.adTextAdmin.TabIndex = 46;
            // 
            // soyadTextAdmin
            // 
            this.soyadTextAdmin.Location = new System.Drawing.Point(120, 276);
            this.soyadTextAdmin.Name = "soyadTextAdmin";
            this.soyadTextAdmin.Size = new System.Drawing.Size(100, 20);
            this.soyadTextAdmin.TabIndex = 45;
            // 
            // aktarButton
            // 
            this.aktarButton.Location = new System.Drawing.Point(546, 158);
            this.aktarButton.Name = "aktarButton";
            this.aktarButton.Size = new System.Drawing.Size(101, 21);
            this.aktarButton.TabIndex = 43;
            this.aktarButton.Text = "Verileri Aktar";
            this.aktarButton.UseVisualStyleBackColor = true;
            this.aktarButton.Click += new System.EventHandler(this.aktarButton_Click);
            // 
            // seferNoAdmin
            // 
            this.seferNoAdmin.Location = new System.Drawing.Point(224, 276);
            this.seferNoAdmin.Name = "seferNoAdmin";
            this.seferNoAdmin.Size = new System.Drawing.Size(100, 20);
            this.seferNoAdmin.TabIndex = 42;
            // 
            // ticketCreateButton
            // 
            this.ticketCreateButton.Location = new System.Drawing.Point(804, 331);
            this.ticketCreateButton.Name = "ticketCreateButton";
            this.ticketCreateButton.Size = new System.Drawing.Size(101, 21);
            this.ticketCreateButton.TabIndex = 41;
            this.ticketCreateButton.Text = "Bilet Kaydı Oluştur";
            this.ticketCreateButton.UseVisualStyleBackColor = true;
            this.ticketCreateButton.Click += new System.EventHandler(this.ticketCreateButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(17, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(434, 150);
            this.dataGridView2.TabIndex = 40;
            // 
            // userSeferYazdır
            // 
            this.userSeferYazdır.Location = new System.Drawing.Point(361, 176);
            this.userSeferYazdır.Name = "userSeferYazdır";
            this.userSeferYazdır.Size = new System.Drawing.Size(90, 23);
            this.userSeferYazdır.TabIndex = 41;
            this.userSeferYazdır.Text = "Seferleri Göster";
            this.userSeferYazdır.UseVisualStyleBackColor = true;
            this.userSeferYazdır.Click += new System.EventHandler(this.userSeferYazdır_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "İzmir",
            "İstanbul",
            "Ankara",
            "Bursa",
            "Adana",
            "Antalya",
            "Bursa"});
            this.comboBox3.Location = new System.Drawing.Point(460, 39);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 68;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "İzmir",
            "İstanbul",
            "Ankara",
            "Bursa",
            "Adana",
            "Antalya",
            "Bursa"});
            this.comboBox4.Location = new System.Drawing.Point(460, 79);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(457, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Kalkış Durağı:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(457, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 71;
            this.label17.Text = "Varış Durağı:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.userSeferYazdır);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Location = new System.Drawing.Point(236, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 202);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 46);
            this.button1.TabIndex = 73;
            this.button1.Text = "Nasıl bilet alırım?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = global::trenBiletAlma.Properties.Resources.brian_matiash_motion_blur_train_wallpaper_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 646);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.systemRegisterButton);
            this.Controls.Add(this.accessButton);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.registerButton);
            this.Name = "Form1";
            this.Text = "59";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button seferOlustur;
        private System.Windows.Forms.TextBox kalisDuragi;
        private System.Windows.Forms.TextBox varisDuragi;
        private System.Windows.Forms.TextBox kalkisSaati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button seferListele;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label Tarih;
        private System.Windows.Forms.TextBox kaklisTarihi;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button adminPanel;
        private System.Windows.Forms.Button accessButton;
        private System.Windows.Forms.Button systemRegisterButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ticketCreateButton;
        private System.Windows.Forms.TextBox seferNoAdmin;
        private System.Windows.Forms.Button aktarButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox koltukNoAdmin;
        private System.Windows.Forms.TextBox saatAdmin;
        private System.Windows.Forms.TextBox adTextAdmin;
        private System.Windows.Forms.TextBox soyadTextAdmin;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tarihAdmin;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label kalkisAdmina;
        private System.Windows.Forms.TextBox varisAdmin;
        private System.Windows.Forms.TextBox kalkisAdmin;
        private System.Windows.Forms.TextBox yolcuSayı;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button userSeferYazdır;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}

