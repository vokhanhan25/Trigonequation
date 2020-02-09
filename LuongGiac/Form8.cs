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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        string[] ngh = new string[20];
        string[] kq = new string[20];
        Docdulieu doc = new Docdulieu();
        Form1 giai = new Form1();
        double a, b, c, k,t1,t2,x1,x2,x3,x4,d1,d2,d;
        Label[] lg = new Label[30];
        PictureBox[] pt = new PictureBox[30];
        string soa = "", sob = "", soc = "", so2k = "", soc_2k = "",sot1 = "",sot2 = "", sok = "";
        string ham = "";
        Button button4 = new Button();

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 30; i++)
            {
                lg[i] = new Label();
                pt[i] = new PictureBox();
            }

            for (int i = 1;i < 30;i++)
            {
                lg[i].Size = new Size(0, 0);
                pt[i].Size = new Size(0, 0);
            }
            for (int i = 1; i < 9; i++)
                ngh[i] = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            soa = ""; sob = ""; soc = ""; so2k = ""; soc_2k = "";
            if ((!radioButton1.Checked && !radioButton2.Checked) || 
                (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == ""))
            {
                if (!radioButton1.Checked && !radioButton2.Checked)
                    MessageBox.Show("Bạn chưa chọn dạng của f(x)!");
                else
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                    MessageBox.Show("Bạn chưa nhập đủ 4 số a,b,c,k!");
            }
            else
            {
                a = doc.chuyen(textBox1.Text);
                b = doc.chuyen(textBox2.Text);
                c = doc.chuyen(textBox3.Text);
                k = doc.chuyen(textBox4.Text);

                if (radioButton1.Checked) ham = "sin(x)";
                else ham = "cos(x)";

                if (a > 0)
                    if (Math.Round(a, 3) != 1) soa = Math.Round(a, 3) + "";
                if (a < 0)
                    if (Math.Round(a, 3) != -1) soa = "-" + Math.Round(-a, 3);
                if (b > 0)
                    if (Math.Round(b, 3) != 1) sob = " + " + Math.Round(b, 3) + "t ";
                    else sob = " + t ";
                if (b < 0)
                    if (Math.Round(b, 3) != -1) sob = "- " + Math.Round(-b, 3) + "t ";
                    else sob = " - t ";
                if (c > 0) soc = "+ " + Math.Round(c, 3);
                if (c < 0) soc = "- " + Math.Round(-c, 3);
                if (-2 * k > 0) so2k = "+ " + Math.Round((-2 * k), 3);
                if (-2 * k < 0) so2k = "- " + Math.Round(-(-2 * k), 3);
                if (c - 2 * k > 0) soc_2k = "+ " + Math.Round((c - 2 * a * k), 3);
                if (c - 2 * k < 0) soc_2k = "- " + Math.Round(-(c - 2 * a * k), 3);
                if (k > 0) sok = "+ " + Math.Round(k, 3);
                if (k < 0) sok = "- " + Math.Round(-k, 3);

                giai.radioButton1.Checked = true;
                giai.textBox2.Text = textBox1.Text;
                giai.textBox3.Text = textBox2.Text;
                giai.textBox4.Text = (c - 2 * a * k).ToString();
                giai.button1_Click(button1, e);

                d = giai.d;
                if (giai.d == 0)
                    t1 = giai.x;
                if (giai.d > 0)
                {
                    t1 = giai.x1;
                    t2 = giai.x2;
                }

                if (d >= 0)
                {
                    if (radioButton1.Checked) giai.radioButton1.Checked = true;
                    else giai.radioButton2.Checked = true;
                    giai.textBox2.Text = "1";
                    giai.textBox3.Text = (-t1).ToString();
                    giai.textBox4.Text = textBox4.Text;
                    giai.button1_Click(button1, e);

                    d1 = giai.d;
                    if (giai.d == 0)
                    {
                        x1 = giai.x;
                        ngh[1] = giai.ngh1;
                        ngh[2] = giai.ngh2;
                    }
                    if (giai.d > 0)
                    {
                        x1 = giai.x1;
                        x2 = giai.x2;
                        ngh[1] = giai.ngh1;
                        ngh[2] = giai.ngh2;
                        ngh[3] = giai.ngh3;
                        ngh[4] = giai.ngh4;
                    }
                }

                if (d > 0)
                {
                    if (radioButton1.Checked) giai.radioButton1.Checked = true;
                    else giai.radioButton2.Checked = true;
                    giai.radioButton1.Checked = true;
                    giai.textBox2.Text = "1";
                    giai.textBox3.Text = (-t2).ToString();
                    giai.textBox4.Text = textBox4.Text;
                    giai.button1_Click(button1, e);

                    d2 = giai.d;
                    if (giai.d == 0)
                    {
                        x3 = giai.x;
                        ngh[5] = giai.ngh1;
                        ngh[6] = giai.ngh2;
                    }
                    if (giai.d > 0)
                    {
                        x3 = giai.x1;
                        x4 = giai.x2;
                        ngh[5] = giai.ngh1;
                        ngh[6] = giai.ngh2;
                        ngh[7] = giai.ngh3;
                        ngh[8] = giai.ngh4;
                    }
                }

                for (int i = 1; i < 9; i++)
                    kq[i] = ngh[i];

                for (int i = 1;i<9;i++)
                    for (int j = i+1; j < 9; j++)
                        if (kq[i] == "" && kq[j] != "")
                        {
                            kq[i] = ngh[j];
                            kq[j] = "";
                        }

                if (ngh[1] == "" && ngh[2] == "" && ngh[3] == "" && ngh[4] == "" && ngh[5] == "" && ngh[6] == "" && ngh[7] == "" && ngh[8] == "")
                    label7.Text = "Phương trình vô nghiệm";
                else
                {
                    label7.Text = "Phương trình có nghiệm";
                    label8.Text = kq[1]; 
                    label9.Text = kq[2]; 
                    label10.Text = kq[3];
                    label11.Text = kq[4];
                    label12.Text = kq[5];
                    label13.Text = kq[6];
                    label14.Text = kq[7];
                    label15.Text = kq[8];
                    label19.Text = "(với k là số nguyên)";
                }

                Button button2 = new Button();
                button2.Text = "Lời giải chi tiết";
                button2.Font = button1.Font;
                button2.Location = new Point(380, 350);
                button2.AutoSize = true;
                this.Controls.Add(button2);
                button2.Click += Button2_Click;

                button4.Text = "Đồ thị";
                button4.Font = button1.Font;
                button4.Location = new Point(380, 390);
                button4.Size = new Size(128, 36);
                this.Controls.Add(button4);
                button4.Click += Button4_Click;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            TestGraph dothi = new TestGraph();
            Label[] diem = new Label[700];

            if (a > 0)
                if (Math.Round(a, 3) != 1) soa = Math.Round(a, 3) + "";
            if (a < 0)
                if (Math.Round(a, 3) != -1) soa = "-" + Math.Round(-a, 3) + "";
                else soa = "- ";
            if (b > 0)
                if (Math.Round(b, 3) != 1) sob = " + " + Math.Round(b, 3);
                else sob = "+ ";
            if (b < 0)
                if (Math.Round(b, 3) != -1) sob = "- " + Math.Round(-b, 3);
                else sob = "- ";
            if (c > 0) soc = "+ " + Math.Round(c, 3);
            if (c < 0) soc = "- " + Math.Round(-c, 3);

            for (int i = 300; i < 601; i++)
            {
                diem[i] = new Label();
                double x = i - 300;
                if (radioButton1.Checked) x = Math.Sin(x / 30);
                if (radioButton2.Checked) x = Math.Cos(x / 30);
                int y = (int)Math.Round(30 * (a * (x*x + (k * k)/(x*x)) + b*(x+k/x) + c));
                diem[i].Size = new Size(3, 3);
                diem[i].Location = new Point((int)i - 1, 300 - y - 1);
                diem[i].BackColor = Color.Blue;
                if (300 - y - 1 < 601) dothi.Controls.Add(diem[i]);

                diem[299] = new Label();
                int y1, y2, tm;
                y1 = diem[i].Location.Y;
                y2 = diem[i - 1].Location.Y;
                if (y1 < y2)
                {
                    tm = y2;
                    y2 = y1;
                    y1 = tm;
                }
                if (Math.Abs(y1 - y2) > 3 && i != 300 && y1 < 700 && y2 > -200)
                {
                    Label[] them = new Label[700];
                    if (y2 < 10) y2 = 10;
                    if (y1 > 590) y1 = 590;
                    for (int j = y2; j < y1; j++)
                    {
                        them[j] = new Label();
                        them[j].BackColor = Color.Blue;
                        them[j].Size = new Size(3, 3);
                        them[j].Location = new Point(i - 1, j - 1);
                        dothi.Controls.Add(them[j]);
                    }
                }
            }

            for (int i = 300; i > 10; i--)
            {
                diem[i] = new Label();
                double x = i - 300;
                if (radioButton1.Checked) x = Math.Sin(x / 30);
                if (radioButton2.Checked) x = Math.Cos(x / 30);
                int y = (int)Math.Round(30 * (a * (x * x + (k * k) / (x * x)) + b * (x + k / x) + c));
                diem[i].Size = new Size(3, 3);
                diem[i].Location = new Point((int)i - 1, 300 - y - 1);
                diem[i].BackColor = Color.Blue;
                if (300 - y - 1 < 601) dothi.Controls.Add(diem[i]);

                int y1, y2, tm;
                y1 = diem[i].Location.Y;
                y2 = diem[i + 1].Location.Y;
                if (y1 < y2)
                {
                    tm = y2;
                    y2 = y1;
                    y1 = tm;
                }
                if (Math.Abs(y1 - y2) > 3 && i != 300 && y1 < 700 && y2 > -200)
                {
                    Label[] them = new Label[700];
                    if (y2 < 10) y2 = 10;
                    if (y1 > 590) y1 = 590;
                    for (int j = y2; j < y1; j++)
                    {
                        them[j] = new Label();
                        them[j].BackColor = Color.Blue;
                        them[j].Size = new Size(3, 3);
                        them[j].Location = new Point(i - 1, j - 1);
                        dothi.Controls.Add(them[j]);
                    }
                }
            }

            dothi.vetruc();

            dothi.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.AcceptButton = button4;
            LoiGiai loigiai = new LoiGiai();
   
            for (int i = 1; i < 20; i++)
            {
                lg[i].Font = new Font("VNF-Comic Sans", 12);
                lg[i].AutoSize = true;
            }

            lg[1].Text = "Đặt t =                               =>                                   = ";
            lg[1].Location = new Point(30, 40);

            pt[1].Image = Properties.Resources.kchiafx;
            pt[1].Size = new Size(118,64);
            pt[1].Location = new Point(90,20);

            pt[2].Image = Properties.Resources.kchiafx2;
            pt[2].Size = new Size(130, 64);
            pt[2].Location = new Point(235, 16);

            pt[3].Image = Properties.Resources.ttru2k;
            pt[3].Size = new Size(69,27);
            pt[3].Location = new Point(380,40);

            lg[2].Text = "=> (*)  <=>  " + soa;
            if (k != 0)
                lg[2].Text = lg[2].Text + "(";
            lg[2].Location = new Point(30,85);
            
            pt[4].Image = Properties.Resources.tbinh;
            pt[4].Size = new Size(27,25);
            if (k != 0)
            pt[4].Location = new Point(110 + (soa.Length+1)*7 , 81);
            else
                pt[4].Location = new Point(110 + soa.Length * 7, 81);
            pt[4].SizeMode = PictureBoxSizeMode.StretchImage;

            if (k != 0)
                lg[3].Text = so2k + ")" + sob + soc + " = 0";
            else lg[3].Text = sob + soc;
            lg[3].Location = new Point(pt[4].Location.X + 25,85);

            lg[4].Text = "<=>  " + soa;
            lg[4].Location = new Point(76, 115);

            pt[5].Image = Properties.Resources.tbinh;
            pt[5].Size = new Size(27, 25);
            pt[5].Location = new Point(110 + soa.Length * 7, 111);
            pt[5].SizeMode = PictureBoxSizeMode.StretchImage;

            lg[5].Text = sob + soc_2k + " = 0  (1)";
            lg[5].Location = new Point(pt[5].Location.X + 25, 115);

            lg[6].Text = "Giải (1) ta được";
            lg[6].Location = new Point(30,145);

            if (d < 0)
            {
                lg[7].Text = "(1) vô nghiệm";
                lg[7].Location = new Point(30,175);
            }
            if (d == 0)
            {
                if (t1 > 0)
                    if (Math.Round(t1, 3) != 1) sot1 = "+ " + Math.Round(t1, 3) + "f(x) ";
                    else sot1 = "+ f(x) ";
                if (t1 < 0)
                    if (Math.Round(t1, 3) != 1) sot1 = "- " + Math.Round(-t1, 3) + "f(x) ";
                    else sot1 = "- f(x) ";

                lg[7].Text = "t = " + Math.Round(t1, 3);
                lg[7].Location = new Point(40, 175);

                lg[8].Text = "=>                               = " + Math.Round(t1, 3) + "  =>               " + sot1 + sok + " = 0";
                lg[8].Location = new Point(30, 215);

                pt[6].Image = Properties.Resources.kchiafx;
                pt[6].Location = new Point(50,205);
                pt[6].Size = new Size(118,64);

                pt[8].Image = Properties.Resources.fxbinh;
                pt[8].Location = new Point((("=>                               = " + Math.Round(t1, 3) + "  =>               " + sot1 + sok + " = 0").Length - 16) * 8 + 10, 199);
                pt[8].Size = new Size(47, 37);

                if (d1 < 0)
                    lg[8].Text = lg[8].Text + " (vô nghiệm)";
                if (d1 == 0)
                    lg[8].Text = lg[8].Text + "=> f(x) = " + Math.Round(x1, 3);
                if (d1 > 0)
                {
                    lg[8].Text = lg[8].Text + " => ";

                    pt[7].Image = Properties.Resources.daungoac;
                    pt[7].Location = new Point(50 + lg[7].Text.Length * 5, 200);
                    pt[7].Size = new Size(27, 58);

                    lg[9].Text = "f(x) = " + Math.Round(x1, 3);
                    lg[9].Location = new Point(85 + lg[8].Text.Length * 5, 200);

                    lg[10].Text = "f(x) = " + Math.Round(x2, 3);
                    lg[10].Location = new Point(85 + lg[8].Text.Length * 5, 230);
                }

            }

            if (d > 0)
            {
                if (t1 > 0)
                    if (Math.Round(t1, 3) != 1) sot1 = "- " + Math.Round(t1, 3) + "f(x) ";
                    else sot1 = "- f(x) ";
                if (t1 < 0)
                    if (Math.Round(t1, 3) != -1) sot1 = "+ " + Math.Round(-t1, 3) + "f(x) ";
                    else sot1 = "+ f(x) ";

                if (t2 > 0)
                    if (Math.Round(t2, 3) != 1) sot2 = "- " + Math.Round(t2, 3) + "f(x) ";
                    else sot2 = "- f(x) ";
                if (t2 < 0)
                    if (Math.Round(t2, 3) != -1) sot2 = "+ " + Math.Round(-t2, 3) + "f(x) ";
                    else sot2 = "+ f(x) ";

                //t1
                pt[6].Image = Properties.Resources.daungoac;
                pt[6].Location = new Point(40, 175);
                pt[6].Size = new Size(27,58);

                lg[7].Text = "t = " + Math.Round(t1, 3);
                lg[7].Location = new Point(70, 175);

                lg[8].Text = "t = " + Math.Round(t2, 3);
                lg[8].Location = new Point(70, 205);

                lg[9].Text = "Với " + lg[7].Text + " =>                               = " + Math.Round(t1, 3) + "  =>               " + sot1 + sok + " = 0";
                lg[9].Location = new Point(30,255);

                pt[7].Image = Properties.Resources.kchiafx;
                pt[7].Location = new Point(110 + (lg[7].Text.Length-4)*7, 235);
                pt[7].Size = new Size(118, 64);

                pt[8].Image = Properties.Resources.fxbinh;
                pt[8].Location = new Point((("Với " + lg[7].Text + " =>                               = " + Math.Round(t1, 3) + "  =>").Length-16)*8 + 10,249);
                pt[8].Size = new Size(47, 37);

                if (d1 < 0)
                    lg[9].Text = lg[9].Text + " (vô nghiệm)";
                if (d1 == 0)
                    lg[9].Text = lg[9].Text + "=> f(x) = " + Math.Round(x1, 3);
                if (d1 > 0)
                {
                    lg[9].Text = lg[9].Text + " => ";

                    pt[9].Image = Properties.Resources.daungoac;
                    pt[9].Location = new Point(50 + lg[9].Text.Length*5,240);
                    pt[9].Size = new Size(27, 58);

                    lg[10].Text = "f(x) = " + Math.Round(x1, 3);
                    lg[10].Location = new Point(85 + lg[9].Text.Length * 5,240);

                    lg[11].Text = "f(x) = " + Math.Round(x2, 3);
                    lg[11].Location = new Point(85 + lg[9].Text.Length * 5, 270);
                }

                //t2
                lg[14].Text = "Với " + lg[8].Text + " =>                               = " + Math.Round(t2, 3) + "  =>               " + sot2 + sok + " = 0";
                lg[14].Location = new Point(30, 320);

                pt[12].Image = Properties.Resources.kchiafx;
                pt[12].Location = new Point(110 + (lg[8].Text.Length - 4) * 7, 300);
                pt[12].Size = new Size(118, 64);

                pt[13].Image = Properties.Resources.fxbinh;
                pt[13].Location = new Point((("Với " + lg[8].Text + " =>                               = " + Math.Round(t2, 3) + "  =>").Length - 16) * 8 + 10, 314);
                pt[13].Size = new Size(47, 37);

                if (d2 < 0)
                    lg[14].Text = lg[14].Text + " (vô nghiệm)";
                if (d2 == 0)
                    lg[14].Text = lg[14].Text + "=> f(x) = " + Math.Round(x3, 3);
                if (d2 > 0)
                {
                    lg[14].Text = lg[14].Text + " => ";

                    pt[10].Image = Properties.Resources.daungoac;
                    pt[10].Location = new Point(50 + lg[9].Text.Length * 5, 305);
                    pt[10].Size = new Size(27, 58);

                    lg[15].Text = "f(x) = " + Math.Round(x3, 3);
                    lg[15].Location = new Point(85 + lg[9].Text.Length * 5, 305);

                    lg[16].Text = "f(x) = " + Math.Round(x4, 3);
                    lg[16].Location = new Point(85 + lg[9].Text.Length * 5, 335);
                }
            }

            lg[17].Text = "Do f(x) = " + ham;
            lg[17].Location = new Point(30,365);

            lg[18].Text = kq[1];
            lg[18].Location = new Point(40, 395);

            lg[19].Text = kq[2];
            lg[19].Location = new Point(40, 425);

            lg[20].Text = kq[3];
            lg[20].Location = new Point(40, 455);

            lg[21].Text = kq[4];
            lg[21].Location = new Point(40, 485);

            lg[22].Text = kq[5];
            lg[22].Location = new Point(300, 395);

            lg[23].Text = kq[6];
            lg[23].Location = new Point(300, 425);

            lg[24].Text = kq[7];
            lg[24].Location = new Point(300, 455);

            lg[25].Text = kq[8];
            lg[25].Location = new Point(300, 485);

            for (int i = 1; i < 20; i++)
                loigiai.Controls.Add(pt[i]);

            for (int i = 1; i < 30; i++)
                loigiai.Controls.Add(lg[i]);

            loigiai.Size = new Size(800, 600);
            loigiai.ShowDialog();
        }
    }
}
