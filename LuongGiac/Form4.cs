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
    public partial class Form4 : Form
    {
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        public Form4()
        {
            InitializeComponent();
        }

        string sin0()
        {
            string kq = "kπ - π/4";
            return kq;
        }

        string sin1()
        {
            string kq = "π/4 + k2π";
            return kq;
        }

        string sin_1()
        {
            string kq = "-3π/4 + k2π";
            return kq;
        }

        string sinpi41()
        {
            string kq = "k2π";
            return kq;
        }

        string sinpi42()
        {
            string kq = "π/2 + k2π";
            return kq;
        }
           

        double a, b, c,x,x1,x2;
        Label[] lg = new Label[20];
        string ngh1 = "", ngh2 = "", ngh3 = "", ngh4 = "";
        Form1 giai = new Form1();
        Docdulieu doc = new Docdulieu();
        string soa = "", sob1 = "",sob2 = "", soc = "";
        string[] kq = new string[5];
        Button button4 = new Button();

        private void button1_Click(object sender, EventArgs e)
        {
            ngh1 = "";
            ngh2 = "";
            ngh3 = "";
            ngh4 = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            soa = ""; sob1 = ""; sob2 = ""; soc = "";
            if ((radioButton1.Checked == false && radioButton2.Checked == false)
                || (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == ""))
            {
                if (radioButton1.Checked == false && radioButton2.Checked == false)
                    MessageBox.Show("Bạn chưa chọn dạng phương trình!");
                else
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    MessageBox.Show("Bạn chưa nhập đủ ba số a,b,c");
            }
            else
            {
                a = doc.chuyen(textBox1.Text);
                b = doc.chuyen(textBox2.Text);
                c = doc.chuyen(textBox3.Text);

                if (radioButton1.Checked == true)
                {
                    giai.textBox2.Text = b.ToString();
                    giai.textBox3.Text = (2 * a).ToString();
                    giai.textBox4.Text = (-2 * c - b).ToString();
                    giai.radioButton1.Checked = true;
                    giai.button1_Click(button1, e);
                }
                else
                if (radioButton2.Checked)
                {
                    giai.textBox2.Text = (-b).ToString();
                    giai.textBox3.Text = (-2 * a).ToString();
                    giai.textBox4.Text = (-2 * c + b).ToString();
                    giai.radioButton1.Checked = true;
                    giai.button1_Click(button1, e);
                }

                if (giai.d < 0)
                {
                    label9.Text = "Phương trình vô nghiệm";
                }

                if (giai.d == 0)
                {
                    if (Math.Abs(Math.Round(x,3)) <= Math.Round(Math.Sqrt(2),3))
                    {
                        x = giai.x;
                        if (Math.Round(x,3) == 0) ngh1 = "x = " + sin0();
                        else
                        if (Math.Round(x,3) == Math.Round(Math.Sqrt(2),3)) ngh1 = "x = " + sin1();
                        else
                        if (Math.Round(x,3) == -Math.Round(Math.Sqrt(2),3)) ngh1 = "x = " + sin_1();
                        else
                        {
                            if (radioButton1.Checked == true)
                            {
                                if (Math.Round(x,3) == 1)
                                {
                                    ngh1 = "x = " + sinpi41();
                                    ngh2 = "x = " + sinpi42();
                                }
                                else
                                {
                                    double y = Math.Asin(x /Math.Sqrt(2)) * 180 / Math.PI;
                                    int y1 = 0;

                                    if (int.TryParse(Math.Round(y,5).ToString(), out y1))
                                    {
                                        if (giai.timthay(y1))
                                        {
                                            double k = 180 / y1;
                                            ngh1 = "x = " + giai.gdb[y1 + 200 - 45] + " + k2π";
                                            ngh2 = "x = " + giai.gdb[180 - y1 + 200 - 45] + " + k2π";
                                        }
                                        else
                                        {
                                            ngh1 = "x = " + "arcsin(" + Math.Round(x, 3) + ") - π/4+ k2π";
                                            ngh2 = "x = " + "π - arcsin(" + Math.Round(x, 3) + ") - π/4 + k2π";
                                        }
                                    }
                                    else
                                    {
                                        ngh1 = "x = " + "arcsin(" + Math.Round(x, 3) + ") - π/4+ k2π";
                                        ngh2 = "x = " + "π - arcsin(" + Math.Round(x, 3) + ") - π/4 + k2π";
                                    }
                                }
                            }

                            if (radioButton2.Checked == true)
                            {
                                if (Math.Round(x,3) == -1)
                                {
                                    ngh1 = "x = -π/2 + k2π";
                                    ngh2 = "x = k2π";
                                }
                                else
                                {
                                    double y = Math.Asin(x /Math.Sqrt(2)) * 180 / Math.PI;
                                    int y1 = 0;
                                    if (int.TryParse(Math.Round(y,5).ToString(), out y1))
                                    {

                                        if (giai.timthay(y1))
                                        {
                                            double k = 180 / y1;
                                            ngh1 = "x = " + giai.gdb[y1 + 200 - 45] + " + k2π";
                                            ngh2 = "x = " + giai.gdb[180 - y1 + 200 - 45]+ " + k2π";
                                        }
                                        else
                                        {
                                            ngh1 = "x = " + "arccos(" + Math.Round(x, 3) + ") + π/4+ k2π";
                                            ngh2 = "x = " + "π - arccos(" + Math.Round(x, 3) + ") + π/4 + k2π";
                                        }
                                    }
                                    else
                                    {
                                        ngh1 = "x = " + "arccos(" + Math.Round(x, 3) + ") + π/4+ k2π";
                                        ngh2 = "x = " + "π - arccos(" + Math.Round(x, 3) + ") + π/4 + k2π";
                                    }
                                }
                            }
                        }
                    }
                }

                if (giai.d > 0)
                {
                    x1 = giai.x1;
                    x2 = giai.x2;
                    if (Math.Abs(Math.Round(x1, 3)) <= Math.Round(Math.Sqrt(2),3))
                    {
                        x1 = giai.x1;
                        if (Math.Round(x1, 3)== 0) ngh1 = "x = " + sin0();
                        else
                        if (Math.Round(x1, 3)== Math.Round(Math.Sqrt(2),3)) ngh1 = "x = " + sin1();
                        else
                        if (Math.Round(x1, 3)== -Math.Round(Math.Sqrt(2),3)) ngh1 = "x = " + sin_1();
                        else
                        {
                            if (radioButton1.Checked == true)
                            {
                                if (Math.Round(x1, 3)== 1)
                                {
                                    ngh1 = "x = " + sinpi41();
                                    ngh2 = "x = " + sinpi42();
                                }
                                else
                                {
                                    double y = Math.Asin(x1/Math.Sqrt(2)) * 180 / Math.PI;
                                    int y1 = 0;
                                    if (int.TryParse(Math.Round(y,5).ToString(), out y1))
                                    {
                                        if (giai.timthay(y1))
                                        {
                                            double k = 180 / y1;
                                            ngh1 = "x = " + giai.gdb[y1 + 200 - 45] + " + k2π";
                                            ngh2 = "x = " + giai.gdb[180 - y1 + 200 - 45] + " + k2π";
                                        }
                                        else
                                        {
                                            ngh1 = "x = " + "arcsin(" + Math.Round(x1, 3) + ") - π/4+ k2π";
                                            ngh2 = "x = " + "π - arcsin(" + Math.Round(x1, 3) + ") - π/4 + k2π";
                                        }
                                    }
                                    else
                                    {
                                        ngh1 = "x = " + "arcsin(" + Math.Round(x1, 3) + ") - π/4+ k2π";
                                        ngh2 = "x = " + "π - arcsin(" + Math.Round(x1, 3) + ") - π/4 + k2π";
                                    }
                                }
                            }

                            if (radioButton2.Checked == true)
                            {
                                if (Math.Round(x1, 3)== -1)
                                {
                                    ngh1 = "x = -π/2 + k2π";
                                    ngh2 = "x = k2π";
                                }
                                else
                                {
                                    double y = Math.Asin(x1/Math.Sqrt(2)) * 180 / Math.PI;
                                    int y1 = 0;
                                    if (int.TryParse(Math.Round(y,5).ToString(), out y1))
                                    {
                                        if (giai.timthay(y1))
                                        {
                                            double k = 180 / y1;
                                            ngh1 = "x = " + giai.gdb[y1 + 200 - 45] + " + k2π";
                                            ngh2 = "x = " + giai.gdb[180 - y1 + 200 - 45]+ " + k2π";
                                        }
                                        else
                                        {
                                            ngh1 = "x = " + "arccos(" + Math.Round(x1, 3) + ") + π/4+ k2π";
                                            ngh2 = "x = " + "π - arccos(" + Math.Round(x1, 3) + ") + π/4 + k2π";
                                        }
                                    }
                                    else
                                    {
                                        ngh1 = "x = " + "arccos(" + Math.Round(x1, 3) + ") + π/4+ k2π";
                                        ngh2 = "x = " + "π - arccos(" + Math.Round(x1, 3) + ") + π/4 + k2π";
                                    }
                                }
                            }
                        }
                    }

                    if (Math.Abs(Math.Round(x2,5)) <= Math.Round(Math.Sqrt(2),3))
                    {
                        x2 = giai.x2;
                        if (Math.Round(x2, 3)== 0) ngh1 = "x = " + sin0();
                        else
                        if (Math.Round(x2, 3)== Math.Round(Math.Sqrt(2),3)) ngh3 = "x = " + sin1();
                        else
                        if (Math.Round(x2, 3)== -Math.Round(Math.Sqrt(2),3)) ngh3 = "x = " + sin_1();
                        else
                        {
                            if (radioButton1.Checked == true)
                            {
                                if (Math.Round(x2, 3)== 1)
                                {
                                    ngh3 = "x = " + sinpi41();
                                    ngh3 = "x = " + sinpi42();
                                }
                                else
                                {
                                    double y = Math.Asin(x2 / Math.Sqrt(2))* 180 / Math.PI;
                                    int y1 = 0;
                                    if (int.TryParse(Math.Round(y,5).ToString(), out y1))
                                    {
                                        if (giai.timthay(y1))
                                        {
                                            double k = 180 / y1;
                                            ngh3 = "x = " + giai.gdb[y1 + 200 - 45] + " + k2π";
                                            ngh4 = "x = " + giai.gdb[180 - y1 + 200 - 45] + " + k2π";
                                        }
                                        else
                                        {
                                            ngh3 = "x = " + "arcsin(" + Math.Round(x2, 3) + ") - π/4+ k2π";
                                            ngh4 = "x = " + "π - arcsin(" + Math.Round(x2, 3) + ") - π/4 + k2π";
                                        }
                                    }
                                    else
                                    {
                                        ngh3 = "x = " + "arcsin(" + Math.Round(x2, 3) + ") - π/4+ k2π";
                                        ngh4 = "x = " + "π - arcsin(" + Math.Round(x2, 3) + ") - π/4 + k2π";
                                    }
                                }
                            }

                            if (radioButton2.Checked == true)
                            {
                                if (Math.Round(x2, 3)== -1)
                                {
                                    ngh3 = "x = -π/2 + k2π";
                                    ngh4 = "x = k2π";
                                }
                                else
                                {
                                    double y = Math.Asin(x2 /Math.Sqrt(2)) * 180 / Math.PI;
                                    int y1 = 0;
                                    if (int.TryParse(Math.Round(y,5).ToString(), out y1))
                                    {
                                        if (giai.timthay(y1))
                                        {
                                            double k = 180 / y1;
                                            ngh3 = "x = " + giai.gdb[y1 + 200 - 45] + " + k2π";
                                            ngh4 = "x = " + giai.gdb[180 - y1 + 200 - 45]+ " + k2π";
                                        }
                                        else
                                        {
                                            ngh3 = "x = " + "arccos(" + Math.Round(x2, 3) + ") + π/4+ k2π";
                                            ngh4 = "x = " + "π - arccos(" + Math.Round(x2, 3) + ") + π/4 + k2π";
                                        }
                                    }
                                    else
                                    {
                                        ngh3 = "x = " + "arccos(" + Math.Round(x2, 3) + ") + π/4+ k2π";
                                        ngh4 = "x = " + "π - arc(" + Math.Round(x2, 3) + ") + π/4 + k2π";
                                    }
                                }
                            }
                        }
                    }
                }

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

                if (ngh1 == "" && ngh2 == "" && ngh3 == "" && ngh4 == "")
                {
                    label9.Text = "Phương trình vô nghiệm";
                }
                else
                {
                    label9.Text = "Phương trình có nghiệm:";
                    label10.Text = kq[1];
                    label11.Text = kq[2];
                    label12.Text = kq[3];
                    label13.Text = kq[4];
                    label5.Text = "(với k là số nguyên)";
                }
                Button button2 = new Button();
                button2.Text = "Lời giải chi tiết";
                button2.Font = button1.Font;
                button2.Location = new Point(410, 160);
                button2.AutoSize = true;
                this.Controls.Add(button2);
                button2.Click += Button2_Click;
                this.AcceptButton = button2;

                button4.Text = "Đồ thị";
                button4.Font = button1.Font;
                button4.Location = new Point(410, 200);
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
            //if (b > 0)
            //    if (Math.Round(b, 3) != 1) sob = " + " + Math.Round(b, 3);
            //    else sob = "+ ";
            //if (b < 0)
            //    if (Math.Round(b, 3) != -1) sob = "- " + Math.Round(-b, 3);
            //    else sob = "- ";
            if (c > 0) soc = "+ " + Math.Round(c, 3);
            if (c < 0) soc = "- " + Math.Round(-c, 3);

            for (int i = 300; i < 601; i++)
            {
                diem[i] = new Label();
                double x = i - 300;
                double x1 = Math.Sin(x / 30);
                double x2 = Math.Cos(x / 30);
                int y = 0;
                if (radioButton1.Checked)
                    y = (int)Math.Round(30 * (a * (x1 + x2) + b * x1 * x2 - c));
                if (radioButton2.Checked)
                    y = (int)Math.Round(30 * (a * (x1 - x2) + b * x1 * x2 - c));
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
                int y = 0;
                if (radioButton1.Checked)
                    y = (int)Math.Round(30 * (a * (x1 + x2) + b * x1 * x2 - c));
                if (radioButton2.Checked)
                    y = (int)Math.Round(30 * (a * (x1 - x2) + b * x1 * x2 - c));
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

            PictureBox ptb1 = new PictureBox();
            loigiai.Controls.Add(ptb1);

            PictureBox pt = new PictureBox();
            loigiai.Controls.Add(pt);

            Label mau = new Label();
            mau.Font = new Font("VNF-Comic Sans", 12);
            for (int i = 1; i < 20; i++)
            {
                lg[i] = new Label();
                lg[i].Font = mau.Font;
                lg[i].AutoSize = true;
                lg[i].Text = "";
                loigiai.Controls.Add(lg[i]);
            }

            if (radioButton1.Checked == true) lg[1].Text = "Đặt t = sin(x) + cos(x)  => sin(x)cos(x) =";
            else lg[1].Text = "Đặt t = cos(x) - sin(x)  => sin(x)cos(x) =";
            lg[1].Location = new Point(30, 40);

            if (radioButton1.Checked == true) ptb1.BackgroundImage = Properties.Resources.t_1chia2;
            else ptb1.BackgroundImage = Properties.Resources._1_tchia2;
            ptb1.Location = new Point();
            ptb1.Size = new Size(71, 68);
            ptb1.Location = new Point(325, 20);
            
            lg[2].Text = "(|t| <= sqrt(2)), ta được:";
            lg[2].Location = new Point(400, 40);

            if (b >= 0)
                if (Math.Round(b, 3) != 1) soa = Math.Round(b, 3) + "";
            if (b < 0)
                if (Math.Round(b, 3) != -1) soa = "-" + Math.Round(-b, 3);
                else soa = "- ";
            if (a > 0)
                if (Math.Round(a, 3) != 1)
                {
                    sob1 = "+ " + 2 * Math.Round(a, 3) + "t ";
                    sob2 = "- " + 2 * Math.Round(a, 3) + "t ";
                }
                else
                {
                    sob1 = "+ t ";
                    sob2 = "- t ";
                }
            if (a < 0)
                if (Math.Round(b, 3) != -1)
                {
                    sob1 = "- " + 2 * Math.Round(-a, 3) + "t ";
                    sob2 = "+ " + 2 * Math.Round(-a, 3) + "t ";
                }
                else
                {
                    sob1 = "- t ";
                    sob2 = "+ t ";
                }
            if (b + 2 * c > 0)
                soc = "= " + Math.Round(b + 2 * c, 3);
            if (b + 2 * c < 0)
                soc = "= -" + Math.Round(-(b + 2 * c), 3);

            lg[3].Text = soa;
            
            pt.Image = Properties.Resources.tbinh;
            pt.Size = new Size(23, 23);
            pt.Location = new Point(95 + lg[3].Width, 80);
            
            if (radioButton1.Checked)
                lg[3].Text = lg[3].Text + "       " + sob1 + soc;
            else
                lg[3].Text = lg[3].Text + "       " + sob2 + soc;
            lg[3].Location = new Point(100, 80);

            lg[4].Text = "Giải (1) ta được:";
            lg[4].Location = new Point(40, 105);

            if (giai.d < 0)
                lg[5].Text = "(1) vô nghiệm";
            if (giai.d == 0)
            {
                lg[5].Text = "t = " + Math.Round(x, 4);
                if (Math.Abs(x) > Math.Sqrt(2)) lg[5].Text = lg[5].Text + "  => loại";
            }
            if (giai.d > 0)
            {
                lg[5].Text = "t = " + Math.Round(x1, 4);
                if (Math.Abs(x1) > Math.Sqrt(2)) lg[5].Text = lg[5].Text + "  => loại";
                lg[6].Text = "t = " + Math.Round(x2, 4);
                if (Math.Abs(x2) > Math.Sqrt(2)) lg[6].Text = lg[6].Text + "  => loại";
            }

            lg[5].Location = new Point(60, 130);
            lg[6].Location = new Point(60, 155);

            if (giai.d < 0)
                lg[7].Text = "Vậy phương trình vô nghiệm";
            else
            {
                lg[7].Text = "Vậy phương trình có nghiệm:";
                lg[8].Text = kq[1];
                lg[9].Text = kq[2];
                lg[10].Text = kq[3];
                lg[11].Text = kq[4];

                lg[7].Location = new Point(40, 180);
                lg[8].Location = new Point(60, 205);
                lg[9].Location = new Point(60, 230);
                lg[10].Location = new Point(60, 255);
                lg[11].Location = new Point(60, 280);
            }

            Button button3 = new Button();
            button3.Text = "Hướng dẫn giải tổng quát";
            button3.Font = button1.Font;
            button3.Size = new Size(200, 40);
            button3.Location = new Point(40, 320);
            loigiai.Controls.Add(button3);
            button3.Click += Button3_Click;

            loigiai.Size = new Size(800, 450);
            loigiai.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            HuongDan4 huongdan = new HuongDan4();
            huongdan.ShowDialog();
        }
    }
}
