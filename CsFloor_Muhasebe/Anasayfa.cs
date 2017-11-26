using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsFloor_Muhasebe
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void faturaKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form y = new Anasayfa();
            y.Close();
            Form x = new Fatura_Kayıt();
            x.Show();
            this.Hide();

        }

        private void faturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void faturaListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void teklifKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form y = new Anasayfa();
            y.Close();
            Form x = new Teklif2();
            x.Show();
            this.Hide();
        }
    }
}
