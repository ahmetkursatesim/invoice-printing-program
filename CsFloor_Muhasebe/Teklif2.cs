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
    public partial class Teklif2 : Form
    {
        private double Euro = 0.0;
        private double Dolar = 0.0;
        private DataSet dsDovizKur;
        public string üyk;
        public string ayk;
        public string kk;
        public string pö;
        public string yd;
        public string çy;
        public string ek;
        public string py;
        public string ayf;
        public int sayı1;
        string malzeme1, malzeme2, malzeme3, malzeme4;
        string adet1, adet2, adet3, adet4;
        string metraj1, metraj2, metraj3, metraj4;
        string b_fiyat1, b_fiyat2, b_fiyat3, b_fiyat4;
        string tutar1, tutar2, tutar3, tutar4;
        double toplam;
        string toplam1;
        string kdv1;
        string genel_toplam1;

        public Teklif2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Malzeme.Text != "" && adet.Text != "" && metraj.Text != "" && bfiyat.Text != "")
            {
                sayı1++;
                MessageBox.Show("" + sayı1);
               
              

                if (sayı1 == 1)
                {

                    malzeme1 = Malzeme.Text;
                    adet1 = adet.Text;
                    metraj1 = metraj.Text;
                    b_fiyat1 = bfiyat.Text;
                    tutar1 = "" + Double.Parse(metraj.Text) * Double.Parse(bfiyat.Text);
                   tutar1= string.Format("{0:#,##0.00}", double.Parse(tutar1));
                    toplam = Double.Parse(tutar1);
                    toplam1 = "" + toplam;
                    toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                    MessageBox.Show("Toplam:" + toplam1);
                    

            dataGridView1.Rows.Add();
          
            dataGridView1.Rows[0].Cells[0].Value = malzeme1;
            dataGridView1.Rows[0].Cells[1].Value = adet1;
            dataGridView1.Rows[0].Cells[2].Value = metraj1;
            dataGridView1.Rows[0].Cells[3].Value = b_fiyat1;
            dataGridView1.Rows[0].Cells[4].Value = tutar1;
            dataGridView1.Rows[0].Cells[4].Value = toplam1;
                }
                if (sayı1 == 2)
                {

                    malzeme2 = Malzeme.Text;
                    adet2 = adet.Text;
                    metraj2 = metraj.Text;
                    b_fiyat2 = bfiyat.Text;
                    tutar2 = "" + Double.Parse(metraj.Text) * Double.Parse(bfiyat.Text);
                  tutar2 = string.Format("{0:#,##0.00}", double.Parse(tutar2));
                    toplam = Double.Parse(tutar1) + Double.Parse(tutar2);
                    toplam1 = "" + toplam;
                    toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                    MessageBox.Show("Toplam:" + toplam1);
                    dataGridView1.Rows.Add();

                    dataGridView1.Rows[1].Cells[0].Value = malzeme1;
                    dataGridView1.Rows[1].Cells[1].Value = adet1;
                    dataGridView1.Rows[1].Cells[2].Value = metraj1;
                    dataGridView1.Rows[1].Cells[3].Value = b_fiyat1;
                    dataGridView1.Rows[1].Cells[4].Value = tutar1;
                    dataGridView1.Rows[1].Cells[5].Value = toplam1;
                }

                if (sayı1 == 3)
                {

                    malzeme3 = Malzeme.Text;
                    adet3 = adet.Text;
                    metraj3 = metraj.Text;
                    b_fiyat3 = bfiyat.Text;
                    tutar3 = "" + Double.Parse(metraj.Text) * Double.Parse(bfiyat.Text);
                    tutar3 = string.Format("{0:#,##0.00}", double.Parse(tutar3));
                    toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3);
                    toplam1 = "" + toplam;
                    toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                    MessageBox.Show("Toplam:" + toplam1);
                    dataGridView1.Rows.Add();

                    dataGridView1.Rows[2].Cells[0].Value = malzeme1;
                    dataGridView1.Rows[2].Cells[1].Value = adet1;
                    dataGridView1.Rows[2].Cells[2].Value = metraj1;
                    dataGridView1.Rows[2].Cells[3].Value = b_fiyat1;
                    dataGridView1.Rows[2].Cells[4].Value = tutar1;
                    dataGridView1.Rows[2].Cells[5].Value = toplam1;


                }
                if (sayı1 == 4)
                {

                    malzeme4 = Malzeme.Text;
                    adet4 = adet.Text;
                    metraj4 = "--";
                    b_fiyat4 = "--";
                    tutar4= "" + Double.Parse(bfiyat.Text);
                    tutar4 = string.Format("{0:#,##0.00}", double.Parse(tutar4));
                    toplam = Double.Parse(tutar1) + Double.Parse(tutar2) + Double.Parse(tutar3) + Double.Parse(tutar4);
                    toplam1 = "" + toplam;
                    toplam1 = string.Format("{0:#,##0.00}", double.Parse(toplam1));
                    MessageBox.Show("Toplam:" + toplam1);
                    dataGridView1.Rows.Add();

                    dataGridView1.Rows[3].Cells[0].Value = malzeme1;
                    dataGridView1.Rows[3].Cells[1].Value = adet1;
                    dataGridView1.Rows[3].Cells[2].Value = metraj1;
                    dataGridView1.Rows[3].Cells[3].Value = b_fiyat1;
                    dataGridView1.Rows[3].Cells[4].Value = tutar1;
                    dataGridView1.Rows[3].Cells[5].Value = toplam1;
                }
            }
            else
            {
                if (Malzeme.Text == "")
                {

                    MessageBox.Show(" malzeme ilgili alanı doldurunuz");
                }
                if (adet.Text == "")
                {
                    MessageBox.Show("adet ilgili alanı doldurunuz");

                }

                if (metraj.Text == "")
                {
                    MessageBox.Show("metraj ilgili alanı doldurunuz");
                }
                if (bfiyat.Text == "")
                {

                    MessageBox.Show("b.fiyat ilgili alanı doldurunuz");
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection con;
            OleDbDataAdapter da;
            OleDbCommand cmd;
            DataSet ds;
            if (g_ad.Text != "" && g_mail.Text != "" && g_tel.Text != "" && F_ad.Text != "" && yet.Text != "" && tel.Text != ""&& kdv_i.Text!="")
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\\Database\\CsFloor1.accdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                double kdv = toplam * Double.Parse(kdv_i.Text) / 100;
                double Genel_toplam = toplam + kdv;
                kdv1 = "" + kdv;
                genel_toplam1 = ""+Genel_toplam;
               kdv1= string.Format("{0:#,##0.00}", double.Parse(kdv1));
               
               genel_toplam1 = string.Format("{0:#,##0.00}", double.Parse(genel_toplam1));
                MessageBox.Show("" + kdv1);
                MessageBox.Show("" + genel_toplam1);
                MessageBox.Show("" + toplam1);
                cmd.CommandText = "insert into cs_teklif (malzeme1,malzeme2,malzeme3,malzeme4,Adet1,Adet2,Adet3,Adet4,Metraj1,Metraj2,Metraj3,Metraj4,b_fiyat1,b_fiyat2,b_fiyat3,b_fiyat4,tutar1,tutar2,tutar3,tutar4,firma_ad,firma_yetkili,Firma_tel,gönderen,gönderen_tel,gönderen_email,kur,toplam,genel_toplam,kdv,tarih,f_email) values ('" + malzeme1 + "','" + malzeme2 + "','" + malzeme3 + "','" + malzeme4 + "','" + adet1 + "','" + adet2 + "','" + adet3 + "','" + adet4 + "','" + metraj1 + "','" + metraj2 + "','" + metraj3 + "','" + metraj4 + "','" + b_fiyat1 + "','" + b_fiyat2 + "','" + b_fiyat3 + "','" + b_fiyat4 + "','" + tutar1 + "','" + tutar2 + "','" + tutar3 + "','" + tutar4 + "','" + F_ad.Text + "','" + yet.Text + "','" + tel.Text + "','" + g_ad.Text + "','" + g_tel.Text + "','" + g_mail.Text + "','" + eu_r.Text + "','" + toplam1 + "','" +  genel_toplam1 + "','" + kdv1 + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + f_email.Text + "') ";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kayıt Tamamlandı");
            
              

                    sayı1 = 0;
                    dataGridView1.Rows.Clear();
                
            }
            else
            {
                if (F_ad.Text == "")
                {
                    MessageBox.Show(" firma ilgili alanı doldurunuz");

                }
                if (yet.Text == "")
                {
                    MessageBox.Show("yetkili ilgili alanı doldurunuz");

                }
                if (tel.Text == "")
                {
                    MessageBox.Show("tel ilgili alanı doldurunuz");

                }
                if (g_ad.Text == "")
                {
                    MessageBox.Show("gönderen ilgili alanı doldurunuz");

                }
                if (g_tel.Text == "")
                {
                    MessageBox.Show("gönderen tel ilgili alanı doldurunuz");

                }
                if (g_mail.Text == "")
                {
                    MessageBox.Show("gönderen mail ilgili alanı doldurunuz");

                }
                if (kdv_i.Text == "")
                {
                    MessageBox.Show("Kdv alanını doldurunuz");

                }

            }

        }

        private void kdv_i_TextChanged(object sender, EventArgs e)
        {

        }

        private void pyss_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dsDovizKur = new DataSet();
            dsDovizKur.ReadXml(@"http://www.tcmb.gov.tr/kurlar/today.xml");
            DataRow dr = dsDovizKur.Tables[1].Rows[0];
            Dolar = Convert.ToDouble(dr[4].ToString().Replace('.', ','));
            dr = dsDovizKur.Tables[1].Rows[3];
            Euro = Convert.ToDouble(dr[4].ToString().Replace('.', ','));
            dl_r.Text = "" + Dolar;
            eu_r.Text = "" + Euro;
        }

        private void Teklif2_Load(object sender, EventArgs e)
        {

            OleDbConnection con;
            OleDbDataAdapter da;
            OleDbCommand cmd;
            DataSet ds;

            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\\Database\\CsFloor1.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select firma_ad from cs_teklif";
            cmd.ExecuteNonQuery();


            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["firma_ad"].ToString());



            }

            dsDovizKur = new DataSet();
            dsDovizKur.ReadXml(@"http://www.tcmb.gov.tr/kurlar/today.xml");
            DataRow mr = dsDovizKur.Tables[1].Rows[0];
            Dolar = Convert.ToDouble(mr[4].ToString().Replace('.', ','));
            mr = dsDovizKur.Tables[1].Rows[4];
            Euro = Convert.ToDouble(mr[4].ToString().Replace('.', ','));
            dl_r.Text = "" + Dolar;
            eu_r.Text = "" + Euro;
            comboBox2.Items.Add(1);
            comboBox2.Items.Add(2);
            comboBox2.Items.Add(3);
            comboBox2.Items.Add(4);


          

        }

        private void eu_r_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection con;
            OleDbDataAdapter da;
            OleDbCommand cmd;
            DataSet ds;

            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:\\Database\\CsFloor1.accdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select malzeme1,malzeme2,malzeme3,malzeme4,Adet1,Adet2,Adet3,Adet4,Metraj1,Metraj2,Metraj3,Metraj4,b_fiyat1,b_fiyat2,b_fiyat3,b_fiyat4,firma_ad,firma_yetkili,Firma_tel,gönderen,gönderen_tel,gönderen_email from cs_teklif where firma_ad='" + comboBox1.SelectedItem.ToString() + "'";
                cmd.ExecuteNonQuery();

                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (comboBox2.SelectedItem.ToString().Equals("1"))
                    {
                        Malzeme.Text = dr["malzeme1"].ToString();
                        adet.Text = dr["Adet1"].ToString();
                        metraj.Text = dr["Metraj1"].ToString();
                        bfiyat.Text = dr["b_fiyat1"].ToString();
                        F_ad.Text = dr["firma_ad"].ToString();
                        yet.Text = dr["firma_yetkili"].ToString();
                        tel.Text = dr["Firma_tel"].ToString();
                        g_ad.Text = dr["gönderen"].ToString();
                        g_tel.Text = dr["gönderen_tel"].ToString();
                        g_mail.Text = dr["gönderen_email"].ToString();




                    }
                    if (comboBox2.SelectedItem.ToString().Equals("2"))
                    {
                        Malzeme.Text = dr["malzeme2"].ToString();
                        adet.Text = dr["Adet2"].ToString();
                        metraj.Text = dr["Metraj2"].ToString();
                        bfiyat.Text = dr["b_fiyat2"].ToString();
                        F_ad.Text = dr["firma_ad"].ToString();
                        yet.Text = dr["firma_yetkili"].ToString();
                        tel.Text = dr["Firma_tel"].ToString();
                        g_ad.Text = dr["gönderen"].ToString();
                        g_tel.Text = dr["gönderen_tel"].ToString();
                        g_mail.Text = dr["gönderen_email"].ToString();




                    }
                    if (comboBox2.SelectedItem.ToString().Equals("3"))
                    {
                        Malzeme.Text = dr["malzeme3"].ToString();
                        adet.Text = dr["Adet3"].ToString();
                        metraj.Text = dr["Metraj3"].ToString();
                        bfiyat.Text = dr["b_fiyat3"].ToString();
                        F_ad.Text = dr["firma_ad"].ToString();
                        yet.Text = dr["firma_yetkili"].ToString();
                        tel.Text = dr["Firma_tel"].ToString();
                        g_ad.Text = dr["gönderen"].ToString();
                        g_tel.Text = dr["gönderen_tel"].ToString();
                        g_mail.Text = dr["gönderen_email"].ToString();




                    }
                    if (comboBox2.SelectedItem.ToString().Equals("4"))
                    {
                        Malzeme.Text = dr["malzeme4"].ToString();
                        adet.Text = dr["Adet4"].ToString();
                        metraj.Text = dr["Metraj4"].ToString();
                        bfiyat.Text = dr["b_fiyat4"].ToString();
                        F_ad.Text = dr["firma_ad"].ToString();
                        yet.Text = dr["firma_yetkili"].ToString();
                        tel.Text = dr["Firma_tel"].ToString();
                        g_ad.Text = dr["gönderen"].ToString();
                        g_tel.Text = dr["gönderen_tel"].ToString();
                        g_mail.Text = dr["gönderen_email"].ToString();




                    }

                }

            }

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bfiyat_KeyPress(object sender, KeyPressEventArgs e)
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

        private void metraj_KeyPress(object sender, KeyPressEventArgs e)
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

        private void adet_TextChanged(object sender, EventArgs e)
        {

        }

        private void adet_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}