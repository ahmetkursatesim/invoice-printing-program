using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace CsFloor_Muhasebe
{
    public partial class Fatura_Kayıt : Form
    {
        private double Euro = 0.0;
        private double Dolar = 0.0;
        private DataSet dsDovizKur;
        string toplam1 ;
        double toplam = 0;
        string kdv1;
        string genel_toplam1;
        string yazı;
       public  int sayı1;
       string cins1,cins2,cins3,cins4,cins5,cins6,cins7,cins8,cins9,cins10,cins11,cins12,cins13,cins14,cins15;
       string miktar1,miktar2,miktar3,miktar4,miktar5,miktar6,miktar7,miktar8,miktar9,miktar10,miktar11,miktar12,miktar13,miktar14,miktar15;
       string fiyat1,fiyat2,fiyat3,fiyat4,fiyat5,fiyat6,fiyat7,fiyat8,fiyat9,fiyat10,fiyat11,fiyat12,fiyat13,fiyat14,fiyat15;
       string tutar1, tutar2, tutar3, tutar4, tutar5, tutar6, tutar7, tutar8, tutar9, tutar10, tutar11, tutar12, tutar13, tutar14, tutar15;
        string mk1,mk2,mk3,mk4,mk5,mk6,mk7,mk8,mk9,mk10,mk11,mk12,mk13,mk14,mk15;
        string pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8, pb9, pb10, pb11, pb12, pb13, pb14, pb15;
        public Fatura_Kayıt()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
  OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;

          con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\\Database\\CsFloor1.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select sirket_adı from csFloor_fatura";
                cmd.ExecuteNonQuery();
      
     
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
            comboBox1.Items.Add( dr["sirket_adı"].ToString());
               
             
            
            }
            con.Close();
            comboBox2.Items.Add(1);
            comboBox2.Items.Add(2);
            comboBox2.Items.Add(3);
            comboBox2.Items.Add(4);
            comboBox2.Items.Add(5);
            comboBox2.Items.Add(6);
            comboBox2.Items.Add(7);
            comboBox2.Items.Add(8);
            comboBox2.Items.Add(9);
            comboBox2.Items.Add(10);
            comboBox2.Items.Add(11);
            comboBox2.Items.Add(12);
            comboBox2.Items.Add(13);
            comboBox2.Items.Add(14);
            comboBox2.Items.Add(15);
            miktarbirimi.Items.Add("Adet");
            miktarbirimi.Items.Add("m2");
            miktarbirimi.Items.Add("m");
            miktarbirimi.Items.Add("tane");
            parabirimi.Items.Add("TL");
            dsDovizKur = new DataSet();
            dsDovizKur.ReadXml(@"http://www.tcmb.gov.tr/kurlar/today.xml");
            DataRow mr = dsDovizKur.Tables[1].Rows[0];
            Dolar = Convert.ToDouble(mr[4].ToString().Replace('.', ','));
            mr = dsDovizKur.Tables[1].Rows[3];
            Euro = Convert.ToDouble(mr[4].ToString().Replace('.', ','));
          dl_r.Text = "" + Dolar;
           eu_r.Text = "" + Euro;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con;
            OleDbDataAdapter da;
            OleDbCommand cmd;
            DataSet ds;




            if (kdv_i.Text != "" && Sirk_ad.Text!="" && ver_d.Text!="" && hes_no.Text!="")
            {

                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\\Database\\CsFloor1.accdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                double kdv = toplam * Double.Parse(kdv_i.Text) / 100;
                kdv1 = "" + kdv;
                kdv1 = string.Format("{0:#,##0.00}", double.Parse(kdv1));
                double Genel_toplam = toplam + kdv;
                genel_toplam1 = "" + Genel_toplam;
               genel_toplam1 = string.Format("{0:#,##0.00}", double.Parse(genel_toplam1));
                MessageBox.Show("Kdv:" + kdv1);
                MessageBox.Show("Toplam" + toplam1);
                MessageBox.Show("genel Toplam" + genel_toplam1);
                decimal yazı2 = Decimal.Parse(genel_toplam1);
                yazı = yaziyaCevir(yazı2);
                cmd.CommandText = "insert into csFloor_fatura (Cins1,Cins2,Cins3,Cins4,Cins5,Cins6,Cins7,Cins8,Cins9,Cins10,Cins11,Cins12,Cins13,Cins14,Cins15,Miktar1,Miktar2,Miktar3,Miktar4,Miktar5,Miktar6,Miktar7,Miktar8,Miktar9,Miktar10,Miktar11,Miktar12,Miktar13,Miktar14,Miktar15,Fiyat1,Fiyat2,Fiyat3,Fiyat4,Fiyat5,Fiyat6,Fiyat7,Fiyat8,Fiyat9,Fiyat10,Fiyat11,Fiyat12,Fiyat13,Fiyat14,Fiyat15,Tarih,Saat,Hesap_no,Vergi_no,tutar1,tutar2,tutar3,tutar4,tutar5,tutar6,tutar7,tutar8,tutar9,tutar10,tutar11,tutar12,tutar13,tutar14,tutar15,sirket_adı,Toplam,Kdv,Genel_Toplam,Yazı,mk1,mk2,mk3,mk4,mk5,mk6,mk7,mk8,mk9,mk10,mk11,mk12,mk13,mk14,mk15,pb1,pb2,pb3,pb4,pb5,pb6,pb7,pb8,pb9,pb10,pb11,pb12,pb13,pb14,pb15) values ('" + cins1 + "','" + cins2 + "','" + cins3 + "','" + cins4 + "','" + cins5 + "','" + cins6 + "','" + cins7 + "','" + cins8 + "','" + cins9 + "','" + cins10 + "','" + cins11 + "','" + cins12 + "','" + cins13 + "','" + cins14 + "','" + cins15 + "','" + miktar1 + "','" + miktar2 + "','" + miktar3 + "','" + miktar4 + "','" + miktar5 + "','" + miktar6 + "','" + miktar7 + "','" + miktar8 + "','" + miktar9 + "','" + miktar10 + "','" + miktar11 + "','" + miktar12 + "','" + miktar13 + "','" + miktar14 + "','" + miktar15 + "','" + fiyat1 + "','" + fiyat2 + "','" + fiyat3 + "','" + fiyat4 + "','" + fiyat5 + "','" + fiyat6 + "','" + fiyat7 + "','" + fiyat8 + "','" + fiyat9 + "','" + fiyat10 + "','" + fiyat11 + "','" + fiyat12 + "','" + fiyat13 + "','" + fiyat14 + "','" + fiyat15 + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + label8.Text + "','" + hes_no.Text + "','" + ver_d.Text + "','" + tutar1 + "','" + tutar2 + "','" + tutar3 + "','" + tutar4 + "','" + tutar5 + "','" + tutar6 + "','" + tutar7 + "','" + tutar8 + "','" + tutar9 + "','" + tutar10 + "','" + tutar11 + "','" + tutar12 + "','" + tutar13 + "','" + tutar14 + "','" + tutar15 + "','" + Sirk_ad.Text + "','" + toplam1 + "','" + kdv1 + "','" + genel_toplam1 + "','" + yazı + "','" + mk1 + "','" + mk2 + "','" + mk3 + "','" + mk4 + "','" + mk5 + "','" + mk6 + "','" + mk7 + "','" + mk8 + "','" + mk9 + "','" + mk10 + "','" + mk11 + "','" + mk12 + "','" + mk13 + "','" + mk14 + "','" + mk15+ "','" + pb1 + "','" + pb2+ "','" + pb3 + "','" + pb4 + "','" + pb5 + "','" + pb6 + "','" + pb7 + "','" + pb8 + "','" + pb9 + "','" + pb10 + "','" + pb11 + "','" + pb12 + "','" + pb13 + "','" + pb14 + "','" + pb15 + "') ";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kayıt Tamamlandı");
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\\Database\\CsFloor1.accdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select sirket_adı from csFloor_fatura";
                cmd.ExecuteNonQuery();


                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["sirket_adı"].ToString());



                }
                con.Close();
                toplam1 = null;
                genel_toplam1 = null;
                kdv1 = null;

                cins1=null;
                cins2=null;
                cins3=null;
                cins4=null;
                cins5=null;
                cins6=null;
                cins7 = null;
                    cins8 = null;
                cins9=null;
                    cins10=null;
                cins11=null;
                    cins12=null;
                cins13=null;
                cins14=null;
                cins15=null;
                miktar1=null;
                    miktar2=null;
                miktar3=null;
                    miktar4=null;
                miktar5=null;
                    miktar6=null;
                miktar7=null;
                    miktar8=null;
                miktar9=null;
                    miktar10=null;
                miktar11=null;
                    miktar12=null;
                    miktar13 = null;
                    miktar14 = null;
                    miktar15 = null;
                fiyat1= null;
                    fiyat2= null;
                fiyat3= null;
                    fiyat4= null;
                fiyat5= null;
                    fiyat6= null;
                fiyat7= null;
                    fiyat8= null;
                fiyat9= null;
                    fiyat10= null;
                fiyat11= null;
                    fiyat12= null;
                fiyat13= null;
                fiyat14 = null;
                fiyat15 = null;
                tutar1= null;
                    tutar2= null;
                tutar3= null;
                    tutar4= null;
                tutar5= null;
                    tutar6= null;
                tutar7= null;
                    tutar8= null;
                tutar9= null;
                    tutar10= null;
                tutar11= null;
                    tutar12= null;
                tutar13= null;
                tutar14 = null;
                tutar15 = null;
                mk1 = null;
                mk2=null;
                mk3=null;
                mk4=null;
                mk5=null;
                mk6=null;
                mk7=null;
                mk8=null;
                mk9=null;
                mk10=null;
                mk11=null;
                mk12=null;
                mk13=null;
                mk14 = null;
                mk15=null;
                pb1 = null;
                pb2 = null;
                pb3 = null;
                pb4 = null;
                pb5 = null;
                pb6 = null;
                pb7 = null;
                pb8 = null;
                pb9 = null;
                pb10 = null;
                pb11 = null;
                pb12 = null;
                pb13 = null;
                pb14 = null;
                pb15 = null;
                sayı1 = 0;
                dataGridView1.Rows.Clear();

            }
            else
            {

                if (Sirk_ad.Text == "")
                {


                    MessageBox.Show("Şirket adı  Alanını Doldurunuz.");

                }
                if (ver_d.Text == "")
                {
                    MessageBox.Show("Vergidairesi   Alanını Doldurunuz.");

                }

                if (hes_no.Text == "")
                {
                    MessageBox.Show("hesap no alanı doldurunuz");

                }
                if (kdv_i.Text == "")
                {

                    MessageBox.Show("Kdv Alanını Doldurunuz.");

                }
             
               

            }
            

        }

        private string yaziyaCevir(decimal genel_toplam1)
        {
            string sTutar = genel_toplam1.ToString("F2").Replace('.', ','); // Replace('.',',') ondalık ayracının . olma durumu için            
            string lira = sTutar.Substring(0, sTutar.IndexOf(',')); //tutarın tam kısmı
            string kurus = sTutar.Substring(sTutar.IndexOf(',') + 1, 2);
            string yazi = "";

            string[] birler = { "", "BİR", "İKİ", "Üç", "DÖRT", "BEŞ", "ALTI", "YEDİ", "SEKİZ", "DOKUZ" };
            string[] onlar = { "", "ON", "YİRMİ", "OTUZ", "KIRK", "ELLİ", "ALTMIŞ", "YETMİŞ", "SEKSEN", "DOKSAN" };
            string[] binler = { "KATRİLYON", "TRİLYON", "MİLYAR", "MİLYON", "BİN", "" }; //KATRİLYON'un önüne ekleme yapılarak artırabilir.

            int grupSayisi = 6; //sayıdaki 3'lü grup sayısı. katrilyon içi 6. (1.234,00 daki grup sayısı 2'dir.)
            //KATRİLYON'un başına ekleyeceğiniz her değer için grup sayısını artırınız.

            lira = lira.PadLeft(grupSayisi * 3, '0'); //sayının soluna '0' eklenerek sayı 'grup sayısı x 3' basakmaklı yapılıyor.            

            string grupDegeri;

            for (int i = 0; i < grupSayisi * 3; i += 3) //sayı 3'erli gruplar halinde ele alınıyor.
            {
                grupDegeri = "";

                if (lira.Substring(i, 1) != "0")
                    grupDegeri += birler[Convert.ToInt32(lira.Substring(i, 1))] + "YÜZ"; //yüzler                

                if (grupDegeri == "BİRYÜZ") //biryüz düzeltiliyor.
                    grupDegeri = "YÜZ";

                grupDegeri += onlar[Convert.ToInt32(lira.Substring(i + 1, 1))]; //onlar

                grupDegeri += birler[Convert.ToInt32(lira.Substring(i + 2, 1))]; //birler                

                if (grupDegeri != "") //binler
                    grupDegeri += binler[i / 3];

                if (grupDegeri == "BİRBİN") //birbin düzeltiliyor.
                    grupDegeri = "BİN";

                yazi += grupDegeri;
            }

            if (yazi != "")
                yazi += " TL ";

            int yaziUzunlugu = yazi.Length;

            if (kurus.Substring(0, 1) != "0") //kuruş onlar
                yazi += onlar[Convert.ToInt32(kurus.Substring(0, 1))];

            if (kurus.Substring(1, 1) != "0") //kuruş birler
                yazi += birler[Convert.ToInt32(kurus.Substring(1, 1))];

            if (yazi.Length > yaziUzunlugu)
                yazi += " Kr.";
            else
                yazi += "SIFIR Kr.";

            return yazi;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Ekle_Click(object sender, EventArgs e)
        {

           

          

            if (Miktar.Text !="" && Fiyat.Text != "" && Cins.Text != "")
            {
                sayı1++;
                MessageBox.Show("" + sayı1);
           


                if (sayı1 == 1)
                {

                    cins1 = Cins.Text;
                    miktar1 = Miktar.Text;
                    fiyat1 = Fiyat.Text;
                    tutar1 = "" + Double.Parse(Miktar.Text) * Double.Parse(Fiyat.Text);
                    tutar1 = string.Format("{0:#,##0.00}", double.Parse(tutar1));

                    toplam = Double.Parse(tutar1);
                    toplam1 = "" + toplam;
                    toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                    mk1 = miktarbirimi.SelectedItem.ToString();
                    pb1 = parabirimi.SelectedItem.ToString();
                    MessageBox.Show("Toplam:" + toplam1);
                    dataGridView1.Rows.Add();

                    dataGridView1.Rows[0].Cells[0].Value = cins1;
                    dataGridView1.Rows[0].Cells[1].Value = miktar1;
                    dataGridView1.Rows[0].Cells[2].Value = fiyat1;
                   
                    dataGridView1.Rows[0].Cells[3].Value = tutar1;
                    dataGridView1.Rows[0].Cells[4].Value = toplam1;
                    

                }
                if (sayı1 == 2)
                {

                    cins2 = Cins.Text;
                    miktar2 = Miktar.Text;
                    fiyat2 = Fiyat.Text;
                    tutar2 = "" + Double.Parse(Miktar.Text) * Double.Parse(Fiyat.Text);
                    tutar2 = string.Format("{0:#,##0.00}", double.Parse(tutar2));
                    toplam = Double.Parse(tutar1) + Double.Parse(tutar2);
                    toplam1 = "" + toplam;
                    toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                    MessageBox.Show("Toplam:" + toplam1);
                    mk2 = miktarbirimi.SelectedItem.ToString();
                    pb2 = parabirimi.SelectedItem.ToString();
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[1].Cells[0].Value = cins2;
                    dataGridView1.Rows[1].Cells[1].Value = miktar2;
                    dataGridView1.Rows[1].Cells[2].Value = fiyat2;

                    dataGridView1.Rows[1].Cells[3].Value = tutar2;
                    dataGridView1.Rows[1].Cells[4].Value = toplam1;
                    
                }
                if (sayı1 == 3)
                {

                    cins3 = Cins.Text;
                    miktar3 = Miktar.Text;
                    fiyat3 = Fiyat.Text;
                    tutar3 = "" + Double.Parse(Miktar.Text) * Double.Parse(Fiyat.Text);
                    tutar3 = string.Format("{0:#,##0.00}", double.Parse(tutar3));
                    toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3);
                    toplam1 = "" + toplam;
                    toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                    MessageBox.Show("Toplam:" + toplam1);
                    mk3 = miktarbirimi.SelectedItem.ToString();
                    pb3 = parabirimi.SelectedItem.ToString();
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[2].Cells[0].Value = cins3;
                    dataGridView1.Rows[2].Cells[1].Value = miktar3;
                    dataGridView1.Rows[2].Cells[2].Value = fiyat3;

                    dataGridView1.Rows[2].Cells[3].Value = tutar3;
                    dataGridView1.Rows[2].Cells[4].Value = toplam1;
                    
                  
                }
                if (sayı1 == 4)
                {

                    cins4 = Cins.Text;
                    miktar4 = Miktar.Text;
                    fiyat4 = Fiyat.Text;
                    tutar4 = "" + Double.Parse(Miktar.Text) * Double.Parse(Fiyat.Text);
                    tutar4 = string.Format("{0:#,##0.00}", double.Parse(tutar4));
                    toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4);
                    toplam1 = "" + toplam;
                    toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                    MessageBox.Show("Toplam:" + toplam1);
                    mk4 = miktarbirimi.SelectedItem.ToString();
                    pb4 = parabirimi.SelectedItem.ToString();
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[3].Cells[0].Value = cins4;
                    dataGridView1.Rows[3].Cells[1].Value = miktar4;
                    dataGridView1.Rows[3].Cells[2].Value = fiyat4;

                    dataGridView1.Rows[3].Cells[3].Value = tutar4;
                    dataGridView1.Rows[3].Cells[4].Value = toplam1;
                } 
                    
                if (sayı1 == 5)
                {

                    cins5 = Cins.Text;
                    miktar5 = Miktar.Text;
                    fiyat5 = Fiyat.Text;
                    tutar5 = "" + Double.Parse(Miktar.Text) * Double.Parse(Fiyat.Text);
                    tutar5 = string.Format("{0:#,##0.00}", double.Parse(tutar5));
                    toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4) + Double.Parse(tutar5);
                    toplam1 = "" + toplam;
                    toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                    MessageBox.Show("Toplam:" + toplam1);
                    mk5 = miktarbirimi.SelectedItem.ToString();
                    pb5 = parabirimi.SelectedItem.ToString();
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[4].Cells[0].Value = cins5;
                    dataGridView1.Rows[4].Cells[1].Value = miktar5;
                    dataGridView1.Rows[4].Cells[2].Value = fiyat5;

                    dataGridView1.Rows[4].Cells[3].Value = tutar5;
                    dataGridView1.Rows[4].Cells[4].Value = toplam1;
                    
                }
                if (sayı1 == 6)
                {

                    cins6 = Cins.Text;
                    miktar6 = Miktar.Text;
                    fiyat6 = Fiyat.Text;
                    tutar6 = "" + Double.Parse(Miktar.Text) * Double.Parse(Fiyat.Text);
                    tutar6 = string.Format("{0:#,##0.00}", double.Parse(tutar6));
                    toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4) + Double.Parse(tutar5) + Double.Parse(tutar6);
                    toplam1 = "" + toplam;
                    toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                    MessageBox.Show("Toplam:" + toplam1);
                    mk6 = miktarbirimi.SelectedItem.ToString();
                    pb6 = parabirimi.SelectedItem.ToString();
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[5].Cells[0].Value = cins6;
                    dataGridView1.Rows[5].Cells[1].Value = miktar6;
                    dataGridView1.Rows[5].Cells[2].Value = fiyat6;

                    dataGridView1.Rows[5].Cells[3].Value = tutar6;
                    dataGridView1.Rows[5].Cells[4].Value = toplam1;
                    
                }
                if (sayı1 == 7)
                {
                  
                    cins7 = Cins.Text;
                    miktar7 = Miktar.Text;
                    fiyat7 = Fiyat.Text;
                    tutar7 = "" + Double.Parse(Miktar.Text) * Double.Parse(Fiyat.Text);
                    tutar7 = string.Format("{0:#,##0.00}", double.Parse(tutar7));
                    toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4) + Double.Parse(tutar5) + Double.Parse(tutar6) + Double.Parse(tutar7);
                    toplam1 = "" + toplam;
                    toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                    MessageBox.Show("Toplam:" + toplam1);
                    mk7 = miktarbirimi.SelectedItem.ToString();
                    pb7 = parabirimi.SelectedItem.ToString();
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[6].Cells[0].Value = cins7;
                    dataGridView1.Rows[6].Cells[1].Value = miktar7;
                    dataGridView1.Rows[6].Cells[2].Value = fiyat7;

                    dataGridView1.Rows[6].Cells[3].Value = tutar7;
                    dataGridView1.Rows[6].Cells[4].Value = toplam1;
                    

                }
                if (sayı1 == 8)
                {
                    
                    cins8 = Cins.Text;
                    miktar8 = Miktar.Text;
                    fiyat8 = Fiyat.Text;
                    tutar8 = "" + Double.Parse(Miktar.Text) * Double.Parse(Fiyat.Text);
                    tutar8 = string.Format("{0:#,##0.00}", double.Parse(tutar8));
                    toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4) + Double.Parse(tutar5) + Double.Parse(tutar6) + Double.Parse(tutar7) + Double.Parse(tutar8);
                    toplam1 = "" + toplam;
                    toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                    MessageBox.Show("Toplam:" + toplam1);
                    mk8 = miktarbirimi.SelectedItem.ToString();
                    pb8 = parabirimi.SelectedItem.ToString();
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[7].Cells[0].Value = cins8;
                    dataGridView1.Rows[7].Cells[1].Value = miktar8;
                    dataGridView1.Rows[7].Cells[2].Value = fiyat8;

                    dataGridView1.Rows[7].Cells[3].Value = tutar8;
                    dataGridView1.Rows[7].Cells[4].Value = toplam1;
                    
                }
                if (sayı1 == 9)
                {

                    cins9 = Cins.Text;
                    miktar9 = Miktar.Text;
                    fiyat9 = Fiyat.Text;
                    tutar9 = "" + Double.Parse(Miktar.Text) * Double.Parse(Fiyat.Text);
                    tutar9 = string.Format("{0:#,##0.00}", double.Parse(tutar9));
                    toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4) + Double.Parse(tutar5) + Double.Parse(tutar6) + Double.Parse(tutar7) + Double.Parse(tutar8) + Double.Parse(tutar9);
                    toplam1 = "" + toplam;
                    toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                    MessageBox.Show("Toplam:" + toplam1);
                    mk9 = miktarbirimi.SelectedItem.ToString();
                    pb9 = parabirimi.SelectedItem.ToString();
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[8].Cells[0].Value = cins9;
                    dataGridView1.Rows[8].Cells[1].Value = miktar9;
                    dataGridView1.Rows[8].Cells[2].Value = fiyat9;

                    dataGridView1.Rows[8].Cells[3].Value = tutar9;
                    dataGridView1.Rows[8].Cells[4].Value = toplam1;
                    
                }
                if (sayı1 == 10)
                {

                    cins10 = Cins.Text;
                    miktar10 = Miktar.Text;
                    fiyat10 = Fiyat.Text;
                    tutar10 = "" + Double.Parse(Miktar.Text) * Double.Parse(Fiyat.Text);
                    tutar10 = string.Format("{0:#,##0.00}", double.Parse(tutar10));
                    toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4) + Double.Parse(tutar5) + Double.Parse(tutar6) + Double.Parse(tutar7) + Double.Parse(tutar8) + Double.Parse(tutar9) + Double.Parse(tutar10);
                    toplam1 = "" + toplam;
                    toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                    MessageBox.Show("Toplam:" + toplam1);
                    mk10 = miktarbirimi.SelectedItem.ToString();
                    pb10 = parabirimi.SelectedItem.ToString();
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[9].Cells[0].Value = cins10;
                    dataGridView1.Rows[9].Cells[1].Value = miktar10;
                    dataGridView1.Rows[9].Cells[2].Value = fiyat10;

                    dataGridView1.Rows[9].Cells[3].Value = tutar10;
                    dataGridView1.Rows[9].Cells[4].Value = toplam1;
                    
                }
                if (sayı1 == 11)
                {

                    cins11 = Cins.Text;
                    miktar11 = Miktar.Text;
                    fiyat11 = Fiyat.Text;
                    tutar11 = "" + Double.Parse(Miktar.Text) * Double.Parse(Fiyat.Text);
                    tutar11 = string.Format("{0:#,##0.00}", double.Parse(tutar11));
                    toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4) + Double.Parse(tutar5) + Double.Parse(tutar6) + Double.Parse(tutar7) + Double.Parse(tutar8) + Double.Parse(tutar9) + Double.Parse(tutar10) + Double.Parse(tutar11);
                    toplam1 = "" + toplam;
                    toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                    MessageBox.Show("Toplam:" + toplam1);
                    mk11 = miktarbirimi.SelectedItem.ToString();
                    pb11 = parabirimi.SelectedItem.ToString();
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[10].Cells[0].Value = cins11;
                    dataGridView1.Rows[10].Cells[1].Value = miktar11;
                    dataGridView1.Rows[10].Cells[2].Value = fiyat11;

                    dataGridView1.Rows[10].Cells[3].Value = tutar11;
                    dataGridView1.Rows[10].Cells[4].Value = toplam1;
                    
                }
                if (sayı1 == 12)
                {

                    cins12 = Cins.Text;
                    miktar12 = Miktar.Text;
                    fiyat12 = Fiyat.Text;
                    tutar12 = "" + Double.Parse(Miktar.Text) * Double.Parse(Fiyat.Text);
                    tutar12 = string.Format("{0:#,##0.00}", double.Parse(tutar12));

                    toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4) + Double.Parse(tutar5) + Double.Parse(tutar6) + Double.Parse(tutar7) + Double.Parse(tutar8) + Double.Parse(tutar9) + Double.Parse(tutar10) + Double.Parse(tutar11) + Double.Parse(tutar12);
                    toplam1 = "" + toplam;
                    toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                    MessageBox.Show("Toplam:" + toplam1);
                    mk12 = miktarbirimi.SelectedItem.ToString();
                    pb12 = parabirimi.SelectedItem.ToString();
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[11].Cells[0].Value = cins12;
                    dataGridView1.Rows[11].Cells[1].Value = miktar12;
                    dataGridView1.Rows[11].Cells[2].Value = fiyat12;

                    dataGridView1.Rows[11].Cells[3].Value = tutar12;
                    dataGridView1.Rows[11].Cells[4].Value = toplam1;
                    
                }
                if (sayı1 == 13)
                {

                    cins13 = Cins.Text;
                    miktar13 = Miktar.Text;
                    fiyat13 = Fiyat.Text;
                    tutar13 = "" + Double.Parse(Miktar.Text) * Double.Parse(Fiyat.Text);
                    tutar13 = string.Format("{0:#,##0.00}", double.Parse(tutar13));
                    toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4) + Double.Parse(tutar5) + Double.Parse(tutar6) + Double.Parse(tutar7) + Double.Parse(tutar8) + Double.Parse(tutar9) + Double.Parse(tutar10) + Double.Parse(tutar11) + Double.Parse(tutar12) + Double.Parse(tutar13);
                    toplam1 = "" + toplam;
                    toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                    MessageBox.Show("Toplam:" + toplam1);
                    mk13 = miktarbirimi.SelectedItem.ToString();
                    pb13 = parabirimi.SelectedItem.ToString();
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[12].Cells[0].Value = cins13;
                    dataGridView1.Rows[12].Cells[1].Value = miktar13;
                    dataGridView1.Rows[12].Cells[2].Value = fiyat13;

                    dataGridView1.Rows[12].Cells[3].Value = tutar13;
                    dataGridView1.Rows[12].Cells[4].Value = toplam1;
                    
                }
                if (sayı1 == 14)
                {

                    cins14 = Cins.Text;
                    miktar14 = Miktar.Text;
                    fiyat14 = Fiyat.Text;
                    tutar14 = "" + Double.Parse(Miktar.Text) * Double.Parse(Fiyat.Text);
                    tutar14 = string.Format("{0:#,##0.00}", double.Parse(tutar14));
                    toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4) + Double.Parse(tutar5) + Double.Parse(tutar6) + Double.Parse(tutar7) + Double.Parse(tutar8) + Double.Parse(tutar9) + Double.Parse(tutar10) + Double.Parse(tutar11) + Double.Parse(tutar12) + Double.Parse(tutar13) + Double.Parse(tutar14);
                    toplam1 = "" + toplam;
                    toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                    MessageBox.Show("Toplam:" + toplam1);
                    mk14 = miktarbirimi.SelectedItem.ToString();
                    pb14 = parabirimi.SelectedItem.ToString();
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[13].Cells[0].Value = cins14;
                    dataGridView1.Rows[13].Cells[1].Value = miktar14;
                    dataGridView1.Rows[13].Cells[2].Value = fiyat14;

                    dataGridView1.Rows[13].Cells[3].Value = tutar14;
                    dataGridView1.Rows[13].Cells[4].Value = toplam1;
                    
                }
                if (sayı1 == 15)
                {

                    cins15 = Cins.Text;
                    miktar15 = Miktar.Text;
                    fiyat15 = Fiyat.Text;
                    tutar15 = "" + Double.Parse(Miktar.Text) * Double.Parse(Fiyat.Text);
                    tutar15 = string.Format("{0:#,##0.00}", double.Parse(tutar15));
                    toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4) + Double.Parse(tutar5) + Double.Parse(tutar6) + Double.Parse(tutar7) + Double.Parse(tutar8) + Double.Parse(tutar9) + Double.Parse(tutar10) + Double.Parse(tutar11) + Double.Parse(tutar12) + Double.Parse(tutar13) + Double.Parse(tutar14) + Double.Parse(tutar15);
                    toplam1 = "" + toplam;
                    toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                    MessageBox.Show("Toplam:" + toplam1);
                    mk15 = miktarbirimi.SelectedItem.ToString();
                    pb15 = parabirimi.SelectedItem.ToString();
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[14].Cells[0].Value = cins15;
                    dataGridView1.Rows[14].Cells[1].Value = miktar15;
                    dataGridView1.Rows[14].Cells[2].Value = fiyat15;

                    dataGridView1.Rows[14].Cells[3].Value = tutar15;
                    dataGridView1.Rows[14].Cells[4].Value = toplam1;
                    
                }

            }
            else
            {
              if (Cins.Text == "")
                {
                    MessageBox.Show("Cins Alanını Doldurunuz");
                }
                if(Miktar.Text==""){
                    MessageBox.Show("Miktar Alanını Doldurunuz");
                }
                if (Fiyat.Text == "")
                {
                   MessageBox.Show("Fiyat Alanını Doldurunuz");
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection con;
            OleDbDataAdapter da;
            OleDbCommand cmd;
            DataSet ds;
        
            if (comboBox1.SelectedItem !=null && comboBox2.SelectedItem!=null )
            {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\\Database\\CsFloor1.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select sirket_adı,Cins1,Cins2,Cins3,Cins4,Cins5,Cins6,Cins7,Cins8,Cins9,Cins10,Cins11,Cins12,Cins13,Cins14,Cins15,Miktar1,Miktar2,Miktar3,Miktar4,Miktar5,Miktar6,Miktar7,Miktar8,Miktar9,Miktar10,Miktar11,Miktar12,Miktar13,Miktar14,Miktar15,Fiyat1,Fiyat2,Fiyat3,Fiyat4,Fiyat5,Fiyat6,Fiyat7,Fiyat8,Fiyat9,Fiyat10,Fiyat11,Fiyat12,Fiyat13,Fiyat14,Fiyat15,Kdv,Vergi_no,Hesap_no from csFloor_fatura where sirket_adı='" + comboBox1.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();

                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (comboBox2.SelectedItem.ToString().Equals("1"))
                    {
                        Cins.Text = dr["Cins1"].ToString();
                        Miktar.Text = dr["Miktar1"].ToString();
                        Fiyat.Text = dr["fiyat1"].ToString();

                    }
                    if (comboBox2.SelectedItem.ToString().Equals("2"))
                    {
                        Cins.Text = dr["Cins2"].ToString();
                        Miktar.Text = dr["Miktar2"].ToString();
                        Fiyat.Text = dr["fiyat2"].ToString();

                    }
                    if (comboBox2.SelectedItem.ToString().Equals("3"))
                    {
                        Cins.Text = dr["Cins3"].ToString();
                        Miktar.Text = dr["Miktar3"].ToString();
                        Fiyat.Text = dr["fiyat3"].ToString();

                    }
                    if (comboBox2.SelectedItem.ToString().Equals("4"))
                    {
                        Cins.Text = dr["Cins4"].ToString();
                        Miktar.Text = dr["Miktar4"].ToString();
                        Fiyat.Text = dr["fiyat4"].ToString();

                    }
                    if (comboBox2.SelectedItem.ToString().Equals("5"))
                    {
                        Cins.Text = dr["Cins5"].ToString();
                        Miktar.Text = dr["Miktar5"].ToString();
                        Fiyat.Text = dr["fiyat5"].ToString();

                    }
                    if (comboBox2.SelectedItem.ToString().Equals("6"))
                    {
                        Cins.Text = dr["Cins6"].ToString();
                        Miktar.Text = dr["Miktar6"].ToString();
                        Fiyat.Text = dr["fiyat6"].ToString();

                    }
                    if (comboBox2.SelectedItem.ToString().Equals("7"))
                    {
                        Cins.Text = dr["Cins7"].ToString();
                        Miktar.Text = dr["Miktar7"].ToString();
                        Fiyat.Text = dr["fiyat7"].ToString();

                    }
                    if (comboBox2.SelectedItem.ToString().Equals("8"))
                    {
                        Cins.Text = dr["Cins8"].ToString();
                        Miktar.Text = dr["Miktar8"].ToString();
                        Fiyat.Text = dr["fiyat8"].ToString();

                    }
                    if (comboBox2.SelectedItem.ToString().Equals("9"))
                    {
                        Cins.Text = dr["Cins9"].ToString();
                        Miktar.Text = dr["Miktar9"].ToString();
                        Fiyat.Text = dr["fiyat9"].ToString();

                    }
                    if (comboBox2.SelectedItem.ToString().Equals("10"))
                    {
                        Cins.Text = dr["Cins10"].ToString();
                        Miktar.Text = dr["Miktar10"].ToString();
                        Fiyat.Text = dr["fiyat10"].ToString();

                    }
                    if (comboBox2.SelectedItem.ToString().Equals("11"))
                    {
                        Cins.Text = dr["Cins11"].ToString();
                        Miktar.Text = dr["Miktar11"].ToString();
                        Fiyat.Text = dr["fiyat11"].ToString();

                    }
                    if (comboBox2.SelectedItem.ToString().Equals("12"))
                    {
                        Cins.Text = dr["Cins12"].ToString();
                        Miktar.Text = dr["Miktar12"].ToString();
                        Fiyat.Text = dr["fiyat12"].ToString();

                    }
                    if (comboBox2.SelectedItem.ToString().Equals("13"))
                    {
                        Cins.Text = dr["Cins13"].ToString();
                        Miktar.Text = dr["Miktar13"].ToString();
                        Fiyat.Text = dr["fiyat13"].ToString();

                    }
                    if (comboBox2.SelectedItem.ToString().Equals("14"))
                    {
                        Cins.Text = dr["Cins14"].ToString();
                        Miktar.Text = dr["Miktar14"].ToString();
                        Fiyat.Text = dr["fiyat14"].ToString();

                    }
                    if (comboBox2.SelectedItem.ToString().Equals("15"))
                    {
                        Cins.Text = dr["Cins15"].ToString();
                        Miktar.Text = dr["Miktar15"].ToString();
                        Fiyat.Text = dr["fiyat15"].ToString();

                    }
                    hes_no.Text = dr["Hesap_no"].ToString();
                    ver_d.Text = dr["Vergi_no"].ToString();
                    Sirk_ad.Text = dr["sirket_adı"].ToString();
                }
                con.Close();

            }
            else
            {
                if (comboBox1.SelectedItem==null)
                {
                    MessageBox.Show("Şirketadı Seç Alanını Doldurunuz");
                }
                if (comboBox2.SelectedItem == null)
                {
                    MessageBox.Show("Tahsilat No Alanını Doldurunuz");
                }
               
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          label8.Text =DateTime.Now.ToLongTimeString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form y = new Fatura_Kayıt();
            y.Close();
            Form x = new Anasayfa();
            x.Show();
            this.Hide();

        }

        private void Miktar_TextChanged(object sender, EventArgs e)
        {
            
        }
     

        private void Fiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fiyat_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else if ((int)e.KeyChar == 44)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else if ((int)e.KeyChar == 46)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }

        private void Miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }
          
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else if ((int)e.KeyChar == 44)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else if ((int)e.KeyChar == 46)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
           
        }

        private void kdv_i_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else if ((int)e.KeyChar == 44)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else if ((int)e.KeyChar == 46)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }

        }

        private void sir_ad_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

 
 dsDovizKur = new DataSet();
    dsDovizKur.ReadXml(@"http://www.tcmb.gov.tr/kurlar/today.xml");
    DataRow dr = dsDovizKur.Tables[1].Rows[0];
    Dolar = Convert.ToDouble(dr[4].ToString().Replace('.', ','));
    dr = dsDovizKur.Tables[1].Rows[3];
    Euro = Convert.ToDouble(dr[4].ToString().Replace('.', ','));
   dl_r.Text = ""+Dolar;
    eu_r.Text = "" +Euro;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

            MessageBox.Show("" + sayı1);
            if (sayı1 == 1)
            {
               
                cins1 = null;
                miktar1 = null;
                fiyat1 = null;
                tutar1 = null;
                mk1 = null;
                pb1 = null;

                toplam = 0;
                toplam1 = "" + toplam;
                toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                MessageBox.Show("Toplam:" + toplam1);
                dataGridView1.Rows.RemoveAt(0);
                dataGridView1.Refresh();
                sayı1--;

            }
            MessageBox.Show("" + sayı1);
            if (sayı1 == 2)
            {
                sayı1--;
                cins2 = null;
                miktar2 = null;
                fiyat2 = null;
                tutar2 = null;
                mk2 = null;
                pb2 = null;
                toplam = Double.Parse(tutar1);
                toplam1 = "" + toplam;
                toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                MessageBox.Show("Toplam:" + toplam1);
                dataGridView1.Rows.RemoveAt(1);
                dataGridView1.Refresh();
               
            }
            if (sayı1 == 3)
            {

                cins3 = null;
                miktar3 = null;
                fiyat3 = null;
                tutar3 = null;
                mk3 = null;
                pb3 = null;
                toplam = Double.Parse(tutar1) + Double.Parse(tutar2);
                toplam1 = "" + toplam;
                toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                MessageBox.Show("Toplam:" + toplam1);
                dataGridView1.Rows.RemoveAt(2);
                dataGridView1.Refresh();
                sayı1--;

            }
            if (sayı1 == 4)
            {

                cins4 = null;
                miktar4 = null;
                fiyat4 = null;
                tutar4 = null;
                mk4 = null;
                pb4 = null;
                toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3);
                toplam1 = "" + toplam;
                toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                MessageBox.Show("Toplam:" + toplam1);
                dataGridView1.Rows.RemoveAt(3);
                dataGridView1.Refresh();
                sayı1--;
            }

            if (sayı1 == 5)
            {

                cins5 = null;
                miktar5 = null;
                fiyat5 = null;
                tutar5 = null;
                mk5 = null;
                pb5 = null;
                toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4);
                toplam1 = "" + toplam;
                toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                MessageBox.Show("Toplam:" + toplam1);
                dataGridView1.Rows.RemoveAt(4);
                dataGridView1.Refresh();
                sayı1--;
            }
            if (sayı1 == 6)
            {

                cins6 = null;
                miktar6 = null;
                fiyat6 = null;
                tutar6 = null;
                mk6 = null;
                pb6 = null;
                toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4) + Double.Parse(tutar5);
                toplam1 = "" + toplam;
                toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                MessageBox.Show("Toplam:" + toplam1);
                dataGridView1.Rows.RemoveAt(5);
                dataGridView1.Refresh();
                sayı1--;
            }
            if (sayı1 == 7)
            {

                cins7 = null;
                miktar7 = null;
                fiyat7 = null;
                tutar7 = null;
                mk7 = null;
                pb7 = null;
                toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4) + Double.Parse(tutar5) + Double.Parse(tutar6);
                toplam1 = "" + toplam;
                toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                MessageBox.Show("Toplam:" + toplam1);
                dataGridView1.Rows.RemoveAt(6);
                dataGridView1.Refresh();
                sayı1--;

            }
            if (sayı1 == 8)
            {

                cins8 = null;
                miktar8 = null;
                fiyat8 = null;
                tutar8 = null;
                mk8 = null;
                pb8= null;
                toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4) + Double.Parse(tutar5) + Double.Parse(tutar6) + Double.Parse(tutar7);
                toplam1 = "" + toplam;
                toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                MessageBox.Show("Toplam:" + toplam1);
                dataGridView1.Rows.RemoveAt(7);
                dataGridView1.Refresh();
                sayı1--;
            }
            if (sayı1 == 9)
            {

                cins9 = null;
                miktar9 = null;
                fiyat9 = null;
                tutar9 = null;
                mk9 = null;
                pb9 = null;
                toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4) + Double.Parse(tutar5) + Double.Parse(tutar6) + Double.Parse(tutar7) + Double.Parse(tutar8);
                toplam1 = "" + toplam;
                toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                MessageBox.Show("Toplam:" + toplam1);
                dataGridView1.Rows.RemoveAt(8);
                dataGridView1.Refresh();
                sayı1--;
            }
            if (sayı1 == 10)
            {

                cins10 = null;
                miktar10 = null;
                fiyat10 = null;
                tutar10 = null;
                mk10 = null;
                pb10 = null;
                toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4) + Double.Parse(tutar5) + Double.Parse(tutar6) + Double.Parse(tutar7) + Double.Parse(tutar8) + Double.Parse(tutar9);
                toplam1 = "" + toplam;
                toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                MessageBox.Show("Toplam:" + toplam1);
                dataGridView1.Rows.RemoveAt(9);
                dataGridView1.Refresh();
                sayı1--;
            }
            if (sayı1 == 11)
            {

                cins11 = null;
                miktar11 = null;
                fiyat11 = null;
                tutar11 = null;
                mk11 = null;
                pb11 = null;
                toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4) + Double.Parse(tutar5) + Double.Parse(tutar6) + Double.Parse(tutar7) + Double.Parse(tutar8) + Double.Parse(tutar9) + Double.Parse(tutar10);
                toplam1 = "" + toplam;
                toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                MessageBox.Show("Toplam:" + toplam1);
                dataGridView1.Rows.RemoveAt(10);
                dataGridView1.Refresh();
                sayı1--;
            }
            if (sayı1 == 12)
            {

                cins12 = null;
                miktar12 = null;
                fiyat12 = null;
                tutar12 = null;
                mk12 = null;
                pb12 = null;

                toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4) + Double.Parse(tutar5) + Double.Parse(tutar6) + Double.Parse(tutar7) + Double.Parse(tutar8) + Double.Parse(tutar9) + Double.Parse(tutar10) + Double.Parse(tutar11);
                toplam1 = "" + toplam;
                toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                MessageBox.Show("Toplam:" + toplam1);
                dataGridView1.Rows.RemoveAt(11);
                dataGridView1.Refresh();
                sayı1--;
            }
            if (sayı1 == 13)
            {

                cins13 = null;
                miktar13 = null;
                fiyat13 = null;
                tutar13 = null;
                mk13 = null;
                pb13 = null;
                toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4) + Double.Parse(tutar5) + Double.Parse(tutar6) + Double.Parse(tutar7) + Double.Parse(tutar8) + Double.Parse(tutar9) + Double.Parse(tutar10) + Double.Parse(tutar11) + Double.Parse(tutar12);
                toplam1 = "" + toplam;
                toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                MessageBox.Show("Toplam:" + toplam1);
                dataGridView1.Rows.RemoveAt(12);
                dataGridView1.Refresh();
                sayı1--;
            }
            if (sayı1 == 14)
            {

                cins14 = null;
                miktar14 = null;
                fiyat14 = null;
                tutar14 = null;
                mk14 = null;
                pb14 = null;
                toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4) + Double.Parse(tutar5) + Double.Parse(tutar6) + Double.Parse(tutar7) + Double.Parse(tutar8) + Double.Parse(tutar9) + Double.Parse(tutar10) + Double.Parse(tutar11) + Double.Parse(tutar12) + Double.Parse(tutar13);
                toplam1 = "" + toplam;
                toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                MessageBox.Show("Toplam:" + toplam1);
                dataGridView1.Rows.RemoveAt(13);
                dataGridView1.Refresh();
                sayı1--;
            }
            if (sayı1 == 15)
            {

                cins15 = null;
                miktar15 = null;
                fiyat15 = null;
                tutar15 = null;
                mk15 = null;
                pb15 = null;
                toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4) + Double.Parse(tutar5) + Double.Parse(tutar6) + Double.Parse(tutar7) + Double.Parse(tutar8) + Double.Parse(tutar9) + Double.Parse(tutar10) + Double.Parse(tutar11) + Double.Parse(tutar12) + Double.Parse(tutar13) + Double.Parse(tutar14);
                toplam1 = "" + toplam;
                toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                MessageBox.Show("Toplam:" + toplam1);
                dataGridView1.Rows.RemoveAt(14);
                dataGridView1.Refresh();
                sayı1--;


            }
        }
        }
}
