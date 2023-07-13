using AxWMPLib;
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
    public partial class Resimler_Sesler : Form
    {
        public Resimler_Sesler()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\yilma\Desktop\C# COCUK UYG SESLER\koyun.wav";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\yilma\Desktop\C# COCUK UYG SESLER\horoz.wav";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\yilma\Desktop\C# COCUK UYG SESLER\eşşek.wav";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\yilma\Desktop\C# COCUK UYG SESLER\kedi.wav";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\yilma\Desktop\C# COCUK UYG SESLER\ördek.wav";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.URL = @"C:\Users\yilma\Desktop\C# COCUK UYG SESLER\kurbağa.wav";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Resimler_Sesler_Load(object sender, EventArgs e)
        {

        }
    }
}
