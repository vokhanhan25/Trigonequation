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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        double a, b, c, d,g,f;
        string ngh1 = "", ngh2 = "", ngh3 = "",ngh4 ="";
        Boolean kt = false;
        string soa = "", sob = "", soc = "",sod = "",soe = "",sof = "";
        Docdulieu doc = new Docdulieu();
        Form5 giai = new Form5();
        string[] kq = new string[5];
        PictureBox[] pt = new PictureBox[30];
        Button button4 = new Button();

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            soa = ""; sob = ""; soc = ""; sod = "";soe = "";sof = "";
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ 4 số a,b,c,d");
            else
            {
                a = doc.chuyen(textBox1.Text);
                b = doc.chuyen(textBox2.Text);
                c = doc.chuyen(textBox3.Text);
                d = doc.chuyen(textBox4.Text);
                g = doc.chuyen(textBox5.Text);
                f = doc.chuyen(textBox6.Text);
                if (a + g >= 0)
                    if (Math.Round(a + g, 3) != 1) soa = Math.Round(a + g, 3) + "";
                if (a + g < 0)
                    if (Math.Round(a + g, 3) != -1) soa = "-" + Math.Round(-a - g, 3);
                if (b + f >= 0)
                    if (Math.Round(b + f, 3) != 1) sob = " + " + Math.Round(b + f, 3);
                    else sob = "+ ";
                if (b + f < 0)
                    if (Math.Round(b + f, 3) != -1) sob = "- " + Math.Round(-b - f, 3);
                    else sob = "- ";
                if (c + g > 0)
                    if (Math.Round(c + g, 3) != 1) soc = "+ " + Math.Round(c + g, 3) + "tan(x) ";
                if (c + g < 0)
                    if (Math.Round(c + g, 3) != -1) soc = "- " + Math.Round(-c - g, 3) + "tan(x) ";
                if (d + f > 0) sod = "+ " + Math.Round(d + f, 3);
                if (d + f < 0) sod = "- " + Math.Round(-d - f, 3);

                giai.radioButton3.Checked = true;
                giai.textBox2.Text = (a + g).ToString();
                giai.textBox3.Text = (b + f).ToString();
                giai.textBox4.Text = (g + c).ToString();
                giai.textBox5.Text = (d + f).ToString();
                giai.button1_Click(button1, e);
                ngh1 = giai.ngh1;
                ngh2 = giai.ngh3;
                ngh3 = giai.ngh5;
                if (a == 0) ngh4 = "π/2 + k2π";

                kq[1] = ngh1;
                kq[2] = ngh2;
                kq[3] = ngh3;
                kq[4] = ngh4;

                for (int i = 1; i < 5; i++)
                    for (int j = i + 1; j < 5; j++)
                        if (kq[i] == "" && kq[j] != "")
                        {
                            kq[i] = kq[j];
                            kq[j] = "";
                        }

                if (ngh1 == "" && ngh2 == "" && ngh3 == "" & ngh4 == "")
                    label8.Text = "Phương trình vô nghiệm";
                else
                {
                    label8.Text = "Phương trình có nghiệm:";
                    label9.Text = kq[1];
                    label10.Text =kq[2];
                    label11.Text =kq[3];
                    label12.Text = kq[4];
                    label14.Text = "(với k là số nguyên)";
                }

                Button button2 = new Button();
                button2.Text = "Lời giải chi tiết";
                button2.Font = button1.Font;
                button2.Location = new Point(370, 190);
                button2.AutoSize = true;
                this.Controls.Add(button2);
                button2.Click += Button2_Click;
                this.AcceptButton = button2;

                button4.Text = "Đồ thị";
                button4.Font = button1.Font;
                button4.Location = new Point(370, 230);
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
                double x1 = Math.Sin(x / 30);
                double x2 = Math.Cos(x / 30);
                int y = (int)Math.Round(30 * (a * x1 * x1 * x1+ b * x1 * x1 * x2 + c * x1 * x2 * x2 + d * x2 *x2 *x2 + g*x1 + f*x2));
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
                double x1 = Math.Sin(x / 30);
                double x2 = Math.Cos(x / 30);
                int y = (int)Math.Round(30 * (a * x1 * x1 * x1 + b * x1 * x1 * x2 + c * x1 * x2 * x2 + d * x2 * x2 * x2 + g * x1 + f * x2));
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

            Label[] lg = new Label[20];
            LoiGiai loigiai = new LoiGiai();

            for (int i = 1; i < 20; i++)
            {
                pt[i] = new PictureBox();
                pt[i].Size = new Size(0, 0);
                loigiai.Controls.Add(pt[i]);
            }

            for (int i = 1; i < 20; i++)
                lg[i] = new Label();
            for (int i = 1; i < 20; i++)
            {
                lg[i].Font = new Font("VNF-Comic Sans", 12);
                lg[i].AutoSize = true;
                lg[i].Text = "";
                lg[i].Size = new Size(0, 0);
            }

            for (int i = 1; i < 20; i++)
                loigiai.Controls.Add(lg[i]);

            lg[1].Text = "+) Xét cos(x) = 0 => ";
            lg[1].Location = new Point(20, 30);

            pt[1].Image = Properties.Resources.sinb;
            pt[1].Size = new Size(60, 31);
            pt[1].Location = new Point(15 + lg[1].Width, 25);

            lg[1].Text = lg[1].Text + "                = 1"; 

            if (a == 0)
            {
                lg[2].Text = "Do " + Math.Round(a, 4) + " = " + 0 + " => π/2 + kπ là nghiệm của phương trình";
                kt = true;
            }
            else lg[2].Text = "Do " + Math.Round(a, 4) + " ≠ " + 0 + " => π/2 + kπ không là nghiệm của phương trình";
            lg[2].Location = new Point(30, 60);

            lg[3].Text = "+) Xét cos(x) ≠ 0, chia cả 2 vế của (*) cho";
            lg[3].Location = new Point(30, 90);

            pt[2].Image = Properties.Resources.cosmu3;
            pt[2].Size = new Size(64, 30);
            pt[2].Location = new Point(lg[3].Width + 25, 88);

            lg[3].Text = lg[3].Text + "                , ta được:";

            lg[4].Text = "(*)  <=>  " + soa;// + sob + soc + sod + " = 0";
            lg[4].Location = new Point(30, 120);

            pt[3].Image = Properties.Resources.tanmu3;
            pt[3].Size = new Size(64, 30);
            pt[3].Location = new Point(25 + lg[4].Width, 117);

            lg[4].Text = lg[4].Text + "                 " + sob;

            pt[4].Image = Properties.Resources.tanx;
            pt[4].Size = new Size(60, 30);
            pt[4].Location = new Point(25 + lg[4].Width, 122);

            lg[4].Text = lg[4].Text + "                " + soc + sod + " = 0";

            if (a + g >= 0)
                if (Math.Round(a + g, 3) != 1) soa = Math.Round(a + g, 3) + "";
            if (a + g < 0)
                if (Math.Round(a + g, 3) != -1) soa = "-" + Math.Round(-a - g, 3);
            if (b + f >= 0)
                if (Math.Round(b + f, 3) != 1) sob = " + " + Math.Round(b + f, 3);
                else sob = "+ ";
            if (b + f < 0)
                if (Math.Round(b + f, 3) != -1) sob = "- " + Math.Round(-b - f, 3);
                else sob = "- ";
            if (c + g > 0)
                if (Math.Round(c + g, 3) != 1) soc = "+ " + Math.Round(c + g, 3) + "t ";
            if (c + g < 0)
                if (Math.Round(c + g, 3) != -1) soc = "- " + Math.Round(-c - g, 3) + "t ";
            if (d + f > 0) sod = "+ " + Math.Round(d + f, 3);
            if (d + f < 0) sod = "- " + Math.Round(-d - f, 3);

            lg[5].Text = "Đặt t = tan(x), ta được";
            lg[5].Location = new Point(30, 150);

            lg[6].Text = "          " + soa;// + sob + soc + sod + " = 0   (1)";
            lg[6].Location = new Point(30, 180);

            pt[5].Image = Properties.Resources.tmu3;
            pt[5].Size = new Size(23,23);
            pt[5].Location = new Point(25 + lg[6].Width, 178);

            lg[6].Text = lg[6].Text + "      " + sob;

            pt[6].Image = Properties.Resources.tbinh;
            pt[6].Size = new Size(23, 23);
            pt[6].Location = new Point(25 + lg[6].Width, 180);

            lg[6].Text = lg[6].Text + "      " + soc + sod + " = 0";

            lg[7].Text = "Giải (1) ta được:";
            lg[7].Location = new Point(30, 210);

            int dong = 210;

            if (a == 0)
            {
                lg[8].Text = "t = 0 => tan(x) = 0";
                lg[8].Location = new Point(30, dong + 30);
                dong = dong + 30;
            }

            if (giai.conghiem1)
            {
                lg[9].Text = "t = " + Math.Round(giai.x1, 3) + " => tan(x) = " + Math.Round(giai.x1, 3);
                lg[9].Location = new Point(30, dong + 30);
                dong = dong + 30;
            }

            if (giai.conghiem2)
            {
                lg[10].Text = "t = " + Math.Round(giai.x2, 3) + " => tan(x) = " + Math.Round(giai.x2, 3);
                lg[10].Location = new Point(30, dong + 30);
                dong = dong + 30;
            }

            if (giai.conghiem3)
            {
                lg[11].Text = "t = " + Math.Round(giai.x3, 3) + " => tan(x) = " + Math.Round(giai.x3, 3);
                lg[11].Location = new Point(30, dong + 30);
                dong = dong + 30;
            }

            if (ngh1 == "" && ngh2 == "" && ngh3 == "" && ngh4 == "")
            {
                lg[12].Text = "=> (*) vô nghiệm:";
                lg[12].Location = new Point(20, dong + 30);
            }
            else
            {
                lg[12].Text = "=> (*) có nghiệm:";
                lg[12].Location = new Point(20, dong + 30);
                dong = dong + 30;

                if (ngh1 != "")
                {
                    lg[13].Text = ngh1;
                    lg[13].Location = new Point(30, dong + 30);
                    dong = dong + 30;
                }

                if (ngh2 != "")
                {
                    lg[14].Text = ngh2;
                    lg[14].Location = new Point(30, dong + 30);
                    dong = dong + 30;
                }

                if (ngh3 != "")
                {
                    lg[15].Text = ngh3;
                    lg[15].Location = new Point(30, dong + 30);
                    dong = dong + 30;
                }

                if (ngh4 != "")
                {
                    lg[16].Text = ngh4;
                    lg[16].Location = new Point(30, dong + 30);
                    dong = dong + 30;
                }
            }

            Button button3 = new Button();
            button3.Text = "Hướng dẫn giải tổng quát";
            button3.Font = button1.Font;
            button3.Size = new Size(200, 40);
            button3.Location = new Point(40, 480);
            loigiai.Controls.Add(button3);
            button3.Click += Button3_Click;

            for (int i = 1; i < 20; i++)
                loigiai.Controls.Add(lg[i]);
            loigiai.AutoSize = true;
            loigiai.Size = new Size(550, 620);
            loigiai.Controls.Add(button3);
            loigiai.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            HuongDan6 giai6 = new HuongDan6();
            giai6.ShowDialog();
        }
    }
}
