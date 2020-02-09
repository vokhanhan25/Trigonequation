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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        Docdulieu doc = new Docdulieu();
        Form1 giai = new Form1();
        Label[] lg = new Label[30];
        PictureBox[] pt = new PictureBox[30];
        string soa = "", sob = "", soc = "", som = "", somb = "", son = "", sonb = ""
            ,sonc = "",soamn = "",somn = "",socamn = "",sot1 = "",sot2 = "";
        string[] kq = new string[5];
        string ngh1 = "", ngh2 = "", ngh3 = "", ngh4 = "";
        double a, b, c, m, n, x1, x2, x3, x4, d, d1, d2, t1, t2;
        Button button4 = new Button();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ 5 số a,b,c,m,n!");
            else
            {
                soa = ""; sob = ""; soc = ""; som = ""; somb = ""; son = ""; sonb = "";
                sonc = ""; soamn = ""; somn = ""; socamn = ""; sot1 = ""; sot2 = "";
                ngh1 = "";
                ngh2 = "";
                ngh3 = "";
                ngh4 = "";
                label9.Text = "";
                label10.Text = "";
                label11.Text = "";
                label12.Text = "";
                label13.Text = "";

                a = doc.chuyen(textBox1.Text);
                b = doc.chuyen(textBox2.Text);
                c = doc.chuyen(textBox3.Text);
                m = doc.chuyen(textBox4.Text);
                n = doc.chuyen(textBox5.Text);

                if (a > 0)
                    if (Math.Round(a, 3) != 1) soa = Math.Round(a, 3) + "";
                if (a < 0)
                    if (Math.Round(a, 3) != -1) soa = "-" + Math.Round(-a, 3);
                if (b > 0)
                    if (Math.Round(b, 3) != 1) sob = " + " + Math.Round(b, 3) + "t ";
                    else sob = "+ t ";
                if (b < 0)
                    if (Math.Round(b, 3) != -1) sob = "- " + Math.Round(-b, 3) + "t ";
                    else sob = "- t ";
                if (c > 0) soc = "+ " + Math.Round(c, 3);
                if (c < 0) soc = "- " + Math.Round(-c, 3);
                if (m > 0)
                    if (Math.Round(m,3) != 1) som = Math.Round(m, 3) + "";
                if (m < 0)
                    if (Math.Round(m, 3) != -1) som = "-" + Math.Round(-m, 3);
                    else som = "-";
                if (n > 0)
                {
                    son = "+ " + Math.Round(n, 3);
                    if (Math.Round(n, 3) != 1) sonc = "+ " + Math.Round(n, 3);
                    else sonc = "+ ";
                }
                if (n < 0)
                {
                    son = "- " + Math.Round(-n, 3);
                    if (Math.Round(n, 3) != -1) sonc = "- " + Math.Round(-n, 3);
                    else sonc = "- ";
                }
                if (Math.Round(m, 3) != 1 && Math.Round(m, 3) != -1) somb = Math.Round(m * m, 3) + "";
                if (Math.Round(n, 3) != 1 && Math.Round(n, 3) != -1) sonb = "+ " + Math.Round(n * n, 3) + "";
                    else sonb = "+ ";
                if (2 * a * m * n > 0) soamn = "- " + Math.Round(2 * a * m * n, 3);
                if (2 * a * m * n < 0) soamn = "+ " + Math.Round(-2 * a * m * n, 3);
                if (2 * m * n > 0) somn = "- " + Math.Round(2 * m * n, 3);
                if (2 * m * n < 0) somn = "+ " + Math.Round(-2 * m * n, 3);
                if (c - 2 * a * m * n > 0) socamn = "+ " + Math.Round(c - 2 * a * m * n, 3);
                if (c - 2 * a * m * n < 0) socamn = "- " + Math.Round(-c + 2 * a * m * n, 3);

                giai.radioButton1.Checked = true;
                giai.textBox2.Text = a.ToString();
                giai.textBox3.Text = b.ToString();
                giai.textBox4.Text = (c - 2 * a * m * n).ToString();
                giai.button1_Click(button1, e);

                d = giai.d;
                if (d == 0)
                    t1 = giai.x;
                if (d > 0)
                {
                    t1 = giai.x1;
                    t2 = giai.x2;
                }

                if (t1 > 0)
                    if (Math.Round(t1, 3) != 1) sot1 = "- " + Math.Round(t1, 3) + "tan(x)";
                    else sot1 = "- tan(x)";
                if (t1 < 0)
                    if (Math.Round(t1, 3) != -1) sot1 = "+ " + Math.Round(-t1, 3) + "tan(x)";
                    else sot1 = "+ tan(x)";
                if (t2 > 0)
                    if (Math.Round(t2, 3) != 1) sot2 = "- " + Math.Round(t2, 3) + "tan(x)";
                    else sot2 = "- tan(x)";
                if (t2 < 0)
                    if (Math.Round(t2, 3) != -1) sot2 = "+ " + Math.Round(-t2, 3) + "tan(x)";
                    else sot2 = "+ tan(x)";

                if (d >= 0)
                {
                    giai.radioButton3.Checked = true;
                    giai.textBox2.Text = m.ToString();
                    giai.textBox3.Text = (-t1).ToString();
                    giai.textBox4.Text = n.ToString();
                    giai.button1_Click(button1, e);

                    d1 = giai.d;
                    if (d1 == 0)
                    {
                        x1 = giai.x;
                        ngh1 = giai.ngh1;
                    }
                    if (d1 > 0)
                    {
                        x1 = giai.x1;
                        x2 = giai.x2;
                        ngh1 = giai.ngh1;
                        ngh2 = giai.ngh3;
                    }
                }

                if (d > 0)
                {
                    giai.radioButton3.Checked = true;
                    giai.textBox2.Text = m.ToString();
                    giai.textBox3.Text = (-t2).ToString();
                    giai.textBox4.Text = n.ToString();
                    giai.button1_Click(button1, e);

                    d2 = giai.d;
                    if (d2 == 0)
                    {
                        x3 = giai.x;
                        ngh3 = giai.ngh1;
                    }
                    if (d2 > 0)
                    {
                        x3 = giai.x1;
                        x4 = giai.x2;
                        ngh3 = giai.ngh1;
                        ngh4 = giai.ngh3;
                    }
                }

                kq[1] = ngh1;
                kq[2] = ngh2;
                kq[3] = ngh3;
                kq[4] = ngh4;

                for (
                    int i = 1; i < 5; i++)
                    for (int j = i + 1; j < 5; j++)
                        if (kq[i] == "" && kq[j] != "")
                        {
                            kq[i] = kq[j];
                            kq[j] = "";
                        }

                if (ngh1 == "" && ngh2 == "" && ngh3 == "" && ngh4 == "")
                    label9.Text = "Phương trình vô nghiệm";
                else
                {
                    label9.Text = "Phương trình có nghiệm:";
                    label10.Text = kq[1];
                    label11.Text = kq[2];
                    label12.Text = kq[3];
                    label13.Text = kq[4];
                    label17.Text = "(với k là số nguyên)";
                }

                Button button2 = new Button();
                button2.Text = "Lời giải chi tiết";
                button2.Font = button1.Font;
                button2.Location = new Point(360, 220);
                button2.AutoSize = true;
                this.Controls.Add(button2);
                button2.Click += Button2_Click;
                this.AcceptButton = button2;

                button4.Text = "Đồ thị";
                button4.Font = button1.Font;
                button4.Location = new Point(360, 260);
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
                double x1 = Math.Tan(x / 30);
                double x2 = 1/Math.Tan(x / 30);
                int y = (int)Math.Round(30 * (a*(m*m*x1*x1 + n*n*x2*x2) + b*(m*x1 + n*x2) + c));
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
                double x1 = Math.Tan(x / 30);
                double x2 = 1 / Math.Tan(x / 30);
                int y = (int)Math.Round(30 * (a * (m * m * x1 * x1 + n * n * x2 * x2) + b * (m * x1 + n * x2) + c));
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

            for (int i =1; i < 30; i++)
            {
                lg[i] = new Label();
                lg[i].Font = new Font("VNF-Comic Sans", 12);
                lg[i].AutoSize = true;
                lg[i].Size = new Size(0, 0);

                pt[i] = new PictureBox();
                pt[i].Size = new Size(0, 0);
            }
            
            for (int i = 1; i < 30; i++)
                loigiai.Controls.Add(pt[i]);
            for (int i = 1; i < 30; i++)
                loigiai.Controls.Add(lg[i]);

            lg[1].Text = "Đặt t = " + som + "tan(x)  " + sonc + "cot(x) ";
            lg[1].Location = new Point(30, 30);

            lg[2].Text = "=> " + somb;
            lg[2].Location = new Point(30, 60);

            pt[1].Image = Properties.Resources.tanx;
            pt[1].Location = new Point(25 + lg[2].Width, 62);
            pt[1].Size = new Size(63,24);

            lg[2].Text = lg[2].Text + "                  " + sonb ;

            pt[2].Image = Properties.Resources.cotx;
            pt[2].Location = new Point(25 + lg[2].Width, 62);
            pt[2].Size = new Size(63, 24);

            lg[2].Text = lg[2].Text + "                   = "; 

            pt[3].Image = Properties.Resources.tbinh;
            pt[3].Location = new Point(lg[2].Width + 25,54);
            pt[3].Size = new Size(27, 25);
            pt[3].SizeMode = PictureBoxSizeMode.StretchImage;

            lg[2].Text = lg[2].Text + "         " + somn;

            lg[3].Text = "=> (*)  <=>  " + soa + "(";
            lg[3].Location = new Point(30, 90);

            pt[4].Image = Properties.Resources.tbinh;
            pt[4].Location = new Point(lg[3].Width + 25, 84);
            pt[4].Size = new Size(27, 25);

            lg[3].Text = lg[3].Text + "       " + somn + ") " + sob + soc + " = 0";

            lg[4].Text = "<=>  " + soa; 
            lg[4].Location = new Point(75, 120);

            pt[5].Image = Properties.Resources.tbinh;
            pt[5].Size = new Size(27, 25);
            pt[5].Location = new Point(lg[4].Width + 70,114);

            lg[4].Text += "       " + sob + socamn + " = 0";

            if (d < 0)
            {
                lg[4].Text = lg[4].Text + "   (vô nghiệm)";
            }
            if (d == 0)
            {
                lg[5].Text = "<=>  t = " + Math.Round(t1, 3);
                lg[5].Location = new Point(75,150);

                lg[6].Text = " => " + som + "tan(x)  " + sonc + "cot(x) = " + Math.Round(t1, 3);
                lg[6].Location = new Point(75, 180);

                lg[7].Text = "<=>  " + som; 
                lg[7].Location = new Point(75, 210);

                pt[6].Image = Properties.Resources.tanx;
                pt[6].Size = new Size(63,24);
                pt[6].Location = new Point(lg[7].Width + 25, 212);

                lg[7].Text += "                 " + sot1 + son;
            }
            if (d > 0)
            {
                lg[5].Text = "<=>";
                lg[5].Location = new Point(75, 165);

                pt[6].Image = Properties.Resources.daungoac;
                pt[6].Size = new Size(27, 58);
                pt[6].Location = new Point(100, 150);

                lg[6].Text = "t = " + Math.Round(t1, 3);
                lg[6].Location = new Point(130, 150);

                lg[7].Text = "t = " + Math.Round(t2, 3);
                lg[7].Location = new Point(130, 180);

                //t1
                lg[8].Text = "Với t = " + Math.Round(t1, 3) + " => " + som + "tan(x) " + son + "cot(x) = " + Math.Round(t1,3) + " => " + som;
                if (d1 <= 0) lg[8].Location = new Point(30, 210);
                else lg[8].Location = new Point(30, 225);

                pt[7].Image = Properties.Resources.tanx;
                pt[7].Size = new Size(63, 24);
                if (d1 <= 0) pt[7].Location = new Point(lg[8].Size.Width + 25, 212);
                else pt[7].Location = new Point(lg[8].Size.Width + 25, 227);

                lg[8].Text = lg[8].Text + "                 " + sot1 + son + " = 0"; 

                if (d1 < 0) lg[8].Text = lg[8].Text + "  (vô nghiệm)";
                if (d1 == 0) lg[8].Text = lg[8].Text + " => tan(x) = " + Math.Round(x1, 3);
                if (d1 > 0)
                {
                    lg[8].Text = lg[8].Text + " => ";

                    pt[8].Image = Properties.Resources.daungoac;
                    pt[8].Size = new Size(27, 58);
                    pt[8].Location = new Point(lg[8].Width + 30 , 210);

                    lg[9].Text = "tan(x) = " + Math.Round(x1, 3);
                    lg[9].Location = new Point(lg[8].Width + 60, 210);

                    lg[10].Text = "tan(x) = " + Math.Round(x2, 3);
                    lg[10].Location = new Point(lg[8].Width + 60, 240);
                }

                //t2
                lg[11].Text = "Với t = " + Math.Round(t2, 3) + " => " + som + "tan(x) " + son + "cot(x) = " + Math.Round(t2, 3) + " => " + som;
                if (d2 <= 0) lg[11].Location = new Point(30, 270);
                else lg[11].Location = new Point(30, 285);

                pt[9].Image = Properties.Resources.tanx;
                pt[9].Size = new Size(63, 24);
                if (d2 <= 0) pt[9].Location = new Point(lg[11].Width + 25, 272);
                else pt[9].Location = new Point(lg[11].Width + 25, 287);

                lg[11].Text += "                 " + sot2 + son + " = 0";

                if (d2 < 0) lg[11].Text += " (vô nghiệm)";
                if (d2 == 0) lg[11].Text += " => tan(x) = " + Math.Round(x3, 3);
                if (d2 > 0)
                {
                    lg[11].Text += " => ";

                    pt[10].Image = Properties.Resources.daungoac;
                    pt[10].Size = new Size(27, 58);
                    pt[10].Location = new Point(lg[11].Width + 30, 270);

                    lg[12].Text = "tan(x) = " + Math.Round(x3, 3);
                    lg[12].Location = new Point(lg[11].Width + 60, 270);

                    lg[13].Text = "tan(x) = " + Math.Round(x4, 3);
                    lg[13].Location = new Point(lg[11].Width + 60, 300);
                }
            }

            lg[14].Text = "Phương trình có nghiệm: ";
            lg[14].Location = new Point(30, 330);

            lg[15].Text = kq[1];
            lg[15].Location = new Point(40, 360);

            lg[16].Text = kq[2];
            lg[16].Location = new Point(40, 390);

            lg[17].Text = kq[3];
            lg[17].Location = new Point(40, 420);

            lg[18].Text = kq[4];
            lg[18].Location = new Point(40, 450);

            Button button3 = new Button();
            button3.Text = "Hướng dẫn giải tổng quát";
            button3.Font = button1.Font;
            button3.Size = new Size(200, 40);
            button3.Location = new Point(40, 480);
            loigiai.Controls.Add(button3);
            button3.Click += Button3_Click;

            loigiai.Size = new Size(800, 600);
            loigiai.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
