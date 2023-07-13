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
    public partial class Matematik : Form
    {
        public Matematik()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int yanit = 0;
        int skor = 0;

        private void Matematik_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            label10.Visible = false;
            button1. Visible = false;
            button2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            textBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            label10.Visible = false;
            button2.Text = "Pes";
           
            button1.Enabled = true;
            int a = rastgele.Next(1, 11);
            int b = rastgele.Next(1, 11);
            int c = rastgele.Next(1,5);

            label3.Text = a.ToString();
            label4.Text = b.ToString();
            if (c == 1)
            {
                label5.Text = "+";  
            }
            else if (c == 2)
            {
                label5.Text = "-"; 
            }
            else if (c == 3)
            {
                label5.Text = "*"; 
            }
            else if (c == 4)
            {
                label5.Text = "/"; 
            }
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* label10.Visible = false;*/
            button2.Text = "Sonraki";
            if (label5.Text == "+")
            {
                yanit = Convert.ToInt32(label3.Text) + Convert.ToInt32(label4.Text);
                label7.Text = yanit.ToString();
            }
            else if (label5.Text == "-")
            {
                yanit = Convert.ToInt32(label3.Text) - Convert.ToInt32(label4.Text);
                label7.Text = yanit.ToString();
            }
            else if (label5.Text == "*")
            {
                yanit = Convert.ToInt32(label3.Text) * Convert.ToInt32(label4.Text);
                label7.Text = yanit.ToString();
            }
            else if (label5.Text == "/")
            {
                yanit = Convert.ToInt32(label3.Text) / Convert.ToInt32(label4.Text);
                label7.Text = yanit.ToString();
            }
            if (textBox1.Text == label7.Text)
            {
                skor += 10;
                label8.Text = skor.ToString();
                label10.Visible = true;
                label10.Text = "TEBRİKLER";
                label10.ForeColor = Color.Black ;
                this.BackColor = Color.Green ;
            }
            else 
            {
                skor -= 5;
                label8.Text = skor.ToString();
                label10.Visible = true;
                label10.Text = "YANLIŞ CEVAP";
                label10.ForeColor  = Color.Black;
                this.BackColor = Color.Red;
            }
            button1.Enabled = false;
            textBox1.Clear();
            label3.Text = "00";
            label4.Text = "00";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true ;
            label4.Visible = true  ;
            label5.Visible = true ;
            label6.Visible = true ;
            label7.Visible = true ;
            label8.Visible = true ;
            label9.Visible = true ;
            textBox1.Visible = true ;
            int a = rastgele.Next(1, 11);
            int b = rastgele.Next(1, 11);
            int c = rastgele.Next(1, 5);

            label3.Text = a.ToString();
            label4.Text = b.ToString();
            if (c == 1)
            {
                label5.Text = "+"; 
            }
            else if (c == 2)
            {
                label5.Text = "-"; 
            }
            else if (c == 3)
            {
                label5.Text = "*"; 
            }
            else if (c == 4)
            {
                label5.Text = "/"; 
            }
            button3.Visible  = false;
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
