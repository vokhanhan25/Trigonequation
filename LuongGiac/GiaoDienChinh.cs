using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuongGiac
{
    public partial class GiaoDienChinh : Form
    {
        public GiaoDienChinh()
        {
            InitializeComponent();

            goc[1] = button1.Text;
            goc[2] = button2.Text;
            goc[3] = button3.Text;
            goc[4] = button4.Text;
            goc[5] = button5.Text;
            goc[6] = button6.Text;
            goc[7] = button7.Text;
            goc[10] = button10.Text;
            goc[11] = button11.Text;
        }

        string[] goc = new string[12];

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 giai1 = new Form1();
            giai1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 giai2 = new Form2();
            giai2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 giai3 = new Form3();
            giai3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 giai4 = new Form4();
            giai4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 giai5 = new Form5();
            giai5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 giai6 = new Form6();
            giai6.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 giai7 = new Form7();
            giai7.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TaiLieu1 tailieu = new TaiLieu1();
            tailieu.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TaiLieu2 tailieu = new TaiLieu2();
            tailieu.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form8 giai = new Form8();
            giai.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form9 giai = new Form9();
            giai.ShowDialog();
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.Text = goc[7];
            button7.Image = Properties.Resources.none;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Text = goc[3];
            button3.Image = Properties.Resources.none;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.Text = goc[6];
            button6.Image = Properties.Resources.none;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Text = goc[2];
            button2.Image = Properties.Resources.none;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Text = goc[4];
            button4.Image = Properties.Resources.none;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = goc[1];
            button1.Image = Properties.Resources.none;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Text = goc[5];
            button5.Image = Properties.Resources.none;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.Text = goc[11];
            button11.Image = Properties.Resources.none;
        }  

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.Text = goc[10];
            button10.Image = Properties.Resources.none;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.Text = button7.Text + "\r\n" + "\r\n" + "\r\n";
            button7.Image = Properties.Resources.vd5;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Text = button3.Text + "\r\n" + "\r\n" + "\r\n";
            button3.Image = Properties.Resources.vd4;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.Text = button6.Text + "\r\n" + "\r\n" + "\r\n";
            button6.Image = Properties.Resources.vd9;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Text = button2.Text + "\r\n" + "\r\n" + "\r\n";
            button2.Image = Properties.Resources.vd3;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.Text = button4.Text + "\r\n" + "\r\n" + "\r\n";
            button4.Image = Properties.Resources.vd2;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Text = button1.Text + "\r\n" + "\r\n" + "\r\n";
            button1.Image = Properties.Resources.vd1;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.Text = button5.Text + "\r\n" + "\r\n" + "\r\n";
            button5.Image = Properties.Resources.vd6;
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.Text = button11.Text + "\r\n" + "\r\n" + "\r\n";
            button11.Image = Properties.Resources.vd8;
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.Text = button10.Text + "\r\n" + "\r\n" + "\r\n";
            button10.Image = Properties.Resources.vd7;
        }
    }
}
