using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildEducationApplication
{
    public partial class Eslestırme : Form
    {
        public Eslestırme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         label1.Text = button1.Text ;
            button1. BackColor = Color.Yellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = button2.Text;
            button2. BackColor = Color.Yellow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = button3.Text;
            button3. BackColor = Color.Yellow;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = button4.Text;
            button4. BackColor = Color.Yellow;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = button5.Text;
            button5. BackColor = Color.Yellow;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            label1.Text = button6.Text;
          button6.  BackColor = Color.Yellow;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            label1.Text = button7.Text;
            button7. BackColor = Color.Yellow;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = button8.Text;
            button8.BackColor = Color.Yellow;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text = button9.Text;
            button9. BackColor = Color.Yellow;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label2.Text = button10.Text;
            button10. BackColor = Color.Yellow;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label2.Text = button11.Text;
            button11. BackColor = Color.Yellow;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label2.Text = button12.Text;
            button12. BackColor = Color.Yellow;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label2.Text = button13.Text;
            button13. BackColor = Color.Yellow;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label2.Text = button14.Text;
            button14. BackColor = Color.Yellow;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label2.Text = button15.Text;
            button15.BackColor = Color.Yellow;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label2.Text = button16.Text;
            button16.BackColor = Color.Yellow;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label1.Text == "SU" && label2.Text == "WATER")
            {
                button1.Enabled = false;
                button14.Enabled = false;
                button14.BackColor = Color.Green;
                button1.BackColor = Color.Green;
                label1.Text = "CEVAP";
                label2.Text = "CEVAP";
            }
            if (label1.Text == "TELEFON" && label2.Text == "TELEPHONE")
            {
                button2.Enabled = false;
                button16.Enabled = false;
                button16.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                label1.Text = "CEVAP";
                label2.Text = "CEVAP";
            }
            if (label1.Text == "MASA" && label2.Text == "TABLE")
            {
                button3.Enabled = false;
                button12.Enabled = false;
                button12.BackColor = Color.Green;
                button3.BackColor = Color.Green;
                label1.Text = "CEVAP";
                label2.Text = "CEVAP";
            }
            if (label1.Text == "İNEK" && label2.Text == "COW")
            {
                button4.Enabled = false;
                button9.Enabled = false;
                button9.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                label1.Text = "CEVAP";
                label2.Text = "CEVAP";
            }
            if (label1.Text == "PARFÜM" && label2.Text == "PARFUME")
            {
                button5.Enabled = false;
                button15.Enabled = false;
                button15.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                label1.Text = "CEVAP";
                label2.Text = "CEVAP";
            }
            if (label1.Text == "PERDE" && label2.Text == "CURTAIN")
            {
                button6.Enabled = false;
                button11.Enabled = false;
                button11.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                label1.Text = "CEVAP";
                label2.Text = "CEVAP";
            }
            if (label1.Text == "YATAK" && label2.Text == "BED")
            {
                button7.Enabled = false;
                button10.Enabled = false;
                button10.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                label1.Text = "CEVAP";
                label2.Text = "CEVAP";
            }
            if (label1.Text == "TİŞÖRT" && label2.Text == "T-SHIRT")
            {
                button8.Enabled = false;
                button13.Enabled = false;
                button13.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                label1.Text = "CEVAP";
                label2.Text = "CEVAP";
            }
        }

        private void Eslestırme_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
