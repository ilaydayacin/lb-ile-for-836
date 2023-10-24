using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_2_836
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNotVer_Click(object sender, EventArgs e)
        {
            lbTakdir.Items.Clear();
            lbTesekkur.Items.Clear();
            lbKaldi.Items.Clear();
            lbGecti.Items.Clear();
            lbNotlar.Items.Clear();
            Random rnd =new Random();

            lblGecti.Text = "";
            lblKaldi.Text = "";
            lblTakdir.Text = "";
            lblTesekkur.Text = "";
            btnDurumcuk.Enabled = true;

            for (int i = 0; i < 15; i++)
            {
                int Not = rnd.Next(0,101);
                lbNotlar.Items.Add(Not);
            }

        }

        private void btnDurumcuk_Click(object sender, EventArgs e)
        {
            int kaldi = 0, gecti = 0, takdir = 0, tesekkur = 0;


            for (int i = 0; i < lbNotlar.Items.Count; i++)
            {
                int not = Convert.ToInt32(lbNotlar.Items[i].ToString());

                if (not < 50)
                {
                    lbKaldi.Items.Add(not);
                    lblKaldi.Text = "Kaldı: " + lbKaldi.Items.Count.ToString();
                    kaldi++;

                }
                else if (not >= 50 && not < 70)
                {
                    lbGecti.Items.Add(not);
                    gecti++;
                    lblGecti.Text = "Geçti: " + lbGecti.Items.Count.ToString();
                }
                else if (not >= 70 && not < 85)
                {
                    lbTesekkur.Items.Add(not);
                    tesekkur++;
                    lblTesekkur.Text = "Teşekkür: " + lbTesekkur.Items.Count.ToString();
                }
                else
                {
                    lbTakdir.Items.Add(not);
                    takdir++;
                    lblTakdir.Text = "Takdir: " + lbTakdir.Items.Count.ToString();
                }
                lblSayi.Text = "Öğrenci Sayısı: " + lbNotlar.Items.Count.ToString();
            }
            btnDurumcuk.Enabled = false;
        }
    }
}
