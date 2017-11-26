namespace CsFloor_Muhasebe
{
    partial class Fatura_Kayıt
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
            this.label1 = new System.Windows.Forms.Label();
            this.Cins = new System.Windows.Forms.TextBox();
            this.Miktar = new System.Windows.Forms.TextBox();
            this.Fiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sir_ad = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Sirk_ad = new System.Windows.Forms.TextBox();
            this.ver_d = new System.Windows.Forms.TextBox();
            this.hes_no = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kdv_i = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.eu_r = new System.Windows.Forms.TextBox();
            this.dl_r = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Ekle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.miktarbirimi = new System.Windows.Forms.ComboBox();
            this.parabirimi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cins";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cins
            // 
            this.Cins.Location = new System.Drawing.Point(181, 171);
            this.Cins.Name = "Cins";
            this.Cins.Size = new System.Drawing.Size(100, 20);
            this.Cins.TabIndex = 1;
            // 
            // Miktar
            // 
            this.Miktar.Location = new System.Drawing.Point(299, 171);
            this.Miktar.Name = "Miktar";
            this.Miktar.Size = new System.Drawing.Size(100, 20);
            this.Miktar.TabIndex = 2;
            this.Miktar.TextChanged += new System.EventHandler(this.Miktar_TextChanged);
            this.Miktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Miktar_KeyPress);
            // 
            // Fiyat
            // 
            this.Fiyat.Location = new System.Drawing.Point(513, 171);
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(100, 20);
            this.Fiyat.TabIndex = 3;
            this.Fiyat.TextChanged += new System.EventHandler(this.Fiyat_TextChanged);
            this.Fiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Fiyat_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Miktar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "fiyat";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sir_ad
            // 
            this.sir_ad.AutoSize = true;
            this.sir_ad.Location = new System.Drawing.Point(21, 68);
            this.sir_ad.Name = "sir_ad";
            this.sir_ad.Size = new System.Drawing.Size(74, 13);
            this.sir_ad.TabIndex = 15;
            this.sir_ad.Text = "Şirket Adı Seç";
            this.sir_ad.Click += new System.EventHandler(this.sir_ad_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(13, 128);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tahsilat No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Şirket Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Vergi Dairesi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Hesap No";
            // 
            // Sirk_ad
            // 
            this.Sirk_ad.Location = new System.Drawing.Point(262, 16);
            this.Sirk_ad.Multiline = true;
            this.Sirk_ad.Name = "Sirk_ad";
            this.Sirk_ad.Size = new System.Drawing.Size(225, 65);
            this.Sirk_ad.TabIndex = 24;
            this.Sirk_ad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ver_d
            // 
            this.ver_d.Location = new System.Drawing.Point(592, 47);
            this.ver_d.Name = "ver_d";
            this.ver_d.Size = new System.Drawing.Size(100, 20);
            this.ver_d.TabIndex = 25;
            // 
            // hes_no
            // 
            this.hes_no.Location = new System.Drawing.Point(592, 73);
            this.hes_no.Name = "hes_no";
            this.hes_no.Size = new System.Drawing.Size(100, 20);
            this.hes_no.TabIndex = 26;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(617, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(738, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "label8";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kdv_i
            // 
            this.kdv_i.Location = new System.Drawing.Point(761, 172);
            this.kdv_i.Name = "kdv_i";
            this.kdv_i.Size = new System.Drawing.Size(100, 20);
            this.kdv_i.TabIndex = 29;
            this.kdv_i.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kdv_i_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(786, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Kdv%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Euro:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Dolar:";
            // 
            // eu_r
            // 
            this.eu_r.Location = new System.Drawing.Point(45, 236);
            this.eu_r.Name = "eu_r";
            this.eu_r.Size = new System.Drawing.Size(100, 20);
            this.eu_r.TabIndex = 37;
            // 
            // dl_r
            // 
            this.dl_r.Location = new System.Drawing.Point(45, 262);
            this.dl_r.Name = "dl_r";
            this.dl_r.Size = new System.Drawing.Size(100, 20);
            this.dl_r.TabIndex = 38;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(209, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 221);
            this.dataGridView1.TabIndex = 39;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cins";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Miktar";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fiyat";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tutar";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "toplam";
            this.Column5.Name = "Column5";
            // 
            // Delete
            // 
            this.Delete.Image = global::CsFloor_Muhasebe.Properties.Resources.delete_icon;
            this.Delete.Location = new System.Drawing.Point(855, 357);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(73, 62);
            this.Delete.TabIndex = 40;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // button4
            // 
            this.button4.Image = global::CsFloor_Muhasebe.Properties.Resources.currency_euro_icon;
            this.button4.Location = new System.Drawing.Point(45, 288);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 33);
            this.button4.TabIndex = 33;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::CsFloor_Muhasebe.Properties.Resources.Home_icon;
            this.button3.Location = new System.Drawing.Point(789, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 67);
            this.button3.TabIndex = 31;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::CsFloor_Muhasebe.Properties.Resources.Cursor_Select_icon__1_;
            this.button2.Location = new System.Drawing.Point(39, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 51);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ekle
            // 
            this.Ekle.BackgroundImage = global::CsFloor_Muhasebe.Properties.Resources.add_1_icon;
            this.Ekle.Location = new System.Drawing.Point(789, 357);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(63, 65);
            this.Ekle.TabIndex = 8;
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CsFloor_Muhasebe.Properties.Resources.Actions_document_save_icon;
            this.button1.Location = new System.Drawing.Point(855, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 67);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // miktarbirimi
            // 
            this.miktarbirimi.FormattingEnabled = true;
            this.miktarbirimi.Location = new System.Drawing.Point(417, 170);
            this.miktarbirimi.Name = "miktarbirimi";
            this.miktarbirimi.Size = new System.Drawing.Size(70, 21);
            this.miktarbirimi.TabIndex = 41;
            // 
            // parabirimi
            // 
            this.parabirimi.FormattingEnabled = true;
            this.parabirimi.Location = new System.Drawing.Point(617, 170);
            this.parabirimi.Name = "parabirimi";
            this.parabirimi.Size = new System.Drawing.Size(57, 21);
            this.parabirimi.TabIndex = 42;
            // 
            // Fatura_Kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 507);
            this.Controls.Add(this.parabirimi);
            this.Controls.Add(this.miktarbirimi);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dl_r);
            this.Controls.Add(this.eu_r);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.kdv_i);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.hes_no);
            this.Controls.Add(this.ver_d);
            this.Controls.Add(this.Sirk_ad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.sir_ad);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Fiyat);
            this.Controls.Add(this.Miktar);
            this.Controls.Add(this.Cins);
            this.Controls.Add(this.label1);
            this.Name = "Fatura_Kayıt";
            this.Text = "Fatura Kayıt";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cins;
        private System.Windows.Forms.TextBox Miktar;
        private System.Windows.Forms.TextBox Fiyat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label sir_ad;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Sirk_ad;
        private System.Windows.Forms.TextBox ver_d;
        private System.Windows.Forms.TextBox hes_no;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox kdv_i;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox eu_r;
        private System.Windows.Forms.TextBox dl_r;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ComboBox miktarbirimi;
        private System.Windows.Forms.ComboBox parabirimi;
    }
}

