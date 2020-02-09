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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        double a, b, c, m,n,beta,canab,t1,t2,t;
        string sbeta,st1 = "",st2 = "" ,st;
        string ngh1 = "", ngh2 = "";
        Form1 giai = new Form1();
        Docdulieu doc = new Docdulieu();
        Label[] lg = new Label[20];
        string[] kq = new string[5];
        Button button4 = new Button();
        string soa = "", sob = "", soc = "",som = "",son = "";

        public void timst(double x)
        {
            st = x.ToString();
            double y = x * 180 / Math.PI;
            int y1 = 0;
            if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
            {
                if (giai.timthay(y1)) st = giai.gdb[y1 + 200];
                else st = x.ToString();
            }
        }

        public void timst1(double x)
        {
            st1 = x.ToString();
            double y = x * 180 / Math.PI;
            int y1 = 0;
            if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
            {
                if (giai.timthay(y1)) st1 = giai.gdb[y1 + 200];
                else st1 = x.ToString();
            }
        }

        public void timst2(double x)
        {
            st2 = x.ToString();
            double y = x * 180 / Math.PI;
            int y1 = 0;
            if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
            {
                if (giai.timthay(y1)) st2 = giai.gdb[y1 + 200];
                else st2 = x.ToString();
            }
        }

        public string arcsinc()
        {
            double x = c / canab;
            string kq = "";
            double y = x * 180 / Math.PI;
            int y1 = 0;
            if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
            {
                if (giai.timthay(y1)) kq = giai.gdb[y1 + 200];
                else kq = Math.Round(Math.Asin(c / canab), 3).ToString();
            }
            else kq = Math.Round(Math.Asin(c / canab), 3).ToString();
            return kq;
        }

        public string arcsinc1()
        {
            double x = c / canab;
            string kq = "";
            double y = Math.Asin(x) * 180 / Math.PI;
            int y1 = 0;
            if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
            {
                if (giai.timthay(y1)) kq = giai.gdb[y1 + 200];
                else kq = "arcsin(" + Math.Round(x, 3) + ")";
            }
            else kq = "arcsin(" + Math.Round(x, 3) + ")";
            return kq;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label12.Text = "";
            label13.Text = "";
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ ba số a,b,c!");
            else
            if (textBox4.Text == "" || textBox5.Text == "")
               MessageBox.Show("Bạn chưa nhập đủ 2 số m,n!");
            else
            {
                a = doc.chuyen(textBox1.Text);
                b = doc.chuyen(textBox2.Text);
                c = doc.chuyen(textBox3.Text);
                m = doc.chuyen(textBox4.Text);
                n = doc.chuyen(textBox5.Text);
                sbeta = ""; st1 = ""; st2 = ""; st = "";
                string som = "", son = "";
                string maum = "";
                if (n > 0) son = " - " + Math.Round(n, 3).ToString();
                if (n < 0) son = " + " + Math.Round(-n, 3).ToString();

                if (m != 1) som = "/" + Math.Round(m, 3).ToString();

                if (a * a + b * b >= Math.Round(c*c,3))
                {
                    double kt1 = Math.Round(Math.Acos(a / Math.Sqrt(a * a + b * b)), 5);
                    double kt2 = Math.Round(Math.Asin(b / Math.Sqrt(a * a + b * b)), 5);
                    if (kt1 == kt2) beta = kt1;
                    if (-kt1 == kt2) beta = -kt1;
                    if (kt1 == Math.PI - kt2) beta = kt1;
                    if (-kt1 == Math.PI - kt2) beta = kt1;
                    canab = Math.Sqrt(a * a + b * b);
                    if (Math.Round(c / canab, 5) == 1 || Math.Round(c / canab, 5) == -1 || Math.Round(c, 5) == 0)
                    {
                        if (Math.Round(c / canab, 5) == 1)
                            t = Math.PI / 2 - beta;
                        else
                        if (Math.Round(c / canab, 5) == -1)
                            t = -Math.PI / 2 - beta;
                        else
                        if (Math.Round(c, 5) == 0)
                            t = -beta;
                        timst(t + beta);
                        string sot = "";
                        if (Math.Round(t,3) != 0) sot = Math.Round(t, 3).ToString() ;
                        double y = t * 180 / Math.PI;
                        int y1 = 0;
                        if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
                        {
                            if (giai.timthay(y1))
                            {
                                double mau = m * giai.mau[y1 + 200];
                                if (mau != 1) maum = "/" + Math.Round(mau, 3).ToString();
                                ngh1 = "x = " + giai.tu[y1 + 200] + maum + son + som + "+ k2π" + som;
                            }
                            else ngh1 = "x = " + sot + som + son + som + "+ k2π" + som;
                        }
                        else ngh1 = "x = " + sot + som + son + som + "+ k2π" + som;
                    } 
                    else
                    {
                        t1 = Math.Asin(c / canab) - beta;
                        t2 = Math.PI - Math.Asin(c / canab) - beta;
                        timst1(t1 + beta);
                        timst2(t2 + beta);
                        string sot1 = "";
                        if (Math.Round(t1,3) != 0) sot1 = Math.Round(t1, 3) + "";
                        string sot2 = "";
                        if (Math.Round(t2,3) != 0) sot2 = Math.Round(t2, 3) + "";
                        double y = t1 * 180 / Math.PI;
                        int y1 = 0;
                        if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
                        {
                            if (giai.timthay(y1))
                            {
                                double mau = m * giai.mau[y1 + 200];
                                if (mau != 1) maum = "/" + Math.Round(mau, 3).ToString();
                                ngh1 = "x = " + giai.tu[y1 + 200] + maum + son + som + "+ k2π" + som;
                            }
                            else ngh1 = "x = " + sot1 + som + son + som + "+ k2π" + som;

                        }
                        else ngh1 = "x = " + sot1 + som + son + som + "+ k2π" + som;

                        y = t2 * 180 / Math.PI;
                        y1 = 0;
                        if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
                        {
                            if (giai.timthay(y1))
                            {
                                double mau = m * giai.mau[y1 + 200];
                                if (mau != 1) maum = "/" + Math.Round(mau, 3).ToString();
                                ngh2 = "x = " + giai.tu[y1 + 200] + maum + son + som + "+ k2π" + som;
                            }
                            else ngh2 = "x = " + sot2 + som + son + som + "+ k2π" + som;
                        }
                        else ngh2 = "x = " + sot2 + som + son + som + "+ k2π" + som;
                    }

                    kq[1] = ngh1;
                    kq[2] = ngh2;

                    for (int i = 1; i < 3; i++)
                        for (int j = i + 1; j < 3; j++)
                            if (kq[i] == "" && kq[j] != "")
                            {
                                kq[i] = kq[j];
                                kq[j] = "";
                            }

                    label11.Text = "Phương trình có nghiệm:";
                    label12.Text = kq[1];
                    label13.Text = kq[2];
                    label14.Text = "(với k là số nguyên)";
                }
                else label11.Text = "Phương trình vô nghiệm";
                Button button2 = new Button();
                button2.Font = button1.Font;
                button2.Text = "Lời giải chi tiết";
                button2.AutoSize = true;
                this.Controls.Add(button2);
                button2.Location = new Point(502,140);
                button2.Click += Button2_Click;
                this.AcceptButton = button2;

                button4.Text = "Đồ thị";
                button4.Font = button1.Font;
                button4.Location = new Point(502, 180);
                button4.Size = new Size(128, 36);
                this.Controls.Add(button4);
                button4.Click += Button4_Click;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            TestGraph dothi = new TestGraph();
            Label[] diem = new Label[700];

            if (Math.Round(a, 3) == 1) soa = ""; else soa = Math.Round(a, 3).ToString();
            if (b > 0)
                if (Math.Round(b, 3) == 1) sob = "+ "; else sob = "+ " + Math.Round(b, 3).ToString();
            if (b < 0)
                if (Math.Round(b, 3) == -1) sob = "- "; else sob = "- " + Math.Round(-b, 3) + "";
            if (Math.Round(m, 3) == 1) som = ""; else som = Math.Round(m, 3).ToString();
            if (n > 0) son = "+ " + Math.Round(n, 3);
            if (n < 0) son = "- " + Math.Round(-n, 3);
            soc = Math.Round(c, 3) + "";

            for (int i = 300; i < 601; i++)
            {
                diem[i] = new Label();
                double x = i - 300;
                diem[i].Size = new Size(3, 3);
                int y = (int)Math.Round( 30 * (a * Math.Sin(m * (x / 30) + n) + b * Math.Cos(m * (x / 30) + n) - c));
                diem[i].Location = new Point(i -1 , 299 - y);
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
                        them[j].Location = new Point(i - 1, j-1);
                        dothi.Controls.Add(them[j]);
                    }
                }
            }

            for (int i = 300; i > 10; i--)
            {
                diem[i] = new Label();
                double x = i - 300;
                diem[i].Size = new Size(3, 3);
                int y = (int)Math.Round(30 * (a * Math.Sin(m * (x / 30) + n) + b * Math.Cos(m * (x / 30) + n) - c));
                diem[i].Location = new Point(i - 1, 299 - y);
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
                        them[j].Location = new Point(i - 1, j-1);
                        dothi.Controls.Add(them[j]);
                    }
                }
            }
            for (int i = 1; i < 20; i++)
            {
                lg[i] = new Label();
                lg[i].Text = "";
                lg[i].Font = new Font("VNF-Comic Sans", 12);
                lg[i].AutoSize = true;
            }

            dothi.vetruc();

            lg[1].Text = "Đồ thị hàm số y = " + soa + "sin( " + som + "x " + son + " ) " + sob + "cos( " + som + "x" + son + " ) = " + soc;   ;
            lg[1].Location = new Point(30, 610);

            for (int i = 1; i < 20; i++)
                dothi.Controls.Add(lg[i]);

            dothi.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            sbeta = "";
            LoiGiai loigiai = new LoiGiai();
            for (int i = 1; i <= 19; i++)
                lg[i] = new Label();
            for (int i =1;i <= 19; i++)
            {
                lg[i].Font = new Font("VNF-Comic Sans",12);
                lg[i].AutoSize = true;
            }
            if (a * a + b * b <Math.Round( c * c,3))
            {
                lg[1].Text = "Phương trình vô nghiệm vì";
                lg[1].Location = new Point(30, 30);

                PictureBox ptb = new PictureBox();
                ptb.BackgroundImage = Properties.Resources.abc;
                ptb.Location = new Point(220, 28);
                ptb.Size = new Size(110, 28);
                loigiai.Controls.Add(ptb);
            }
            else
            {
                if (Math.Round(a, 3) == 1) soa = ""; else soa = Math.Round(a, 3).ToString();
                if (b > 0)
                    if (Math.Round(b, 3) == 1) sob = "+ "; else sob = "+ " +Math.Round(b, 3).ToString();
                if (b < 0)
                    if (Math.Round(b, 3) == -1) sob = "- "; else sob = "- " + Math.Round(-b, 3) + "";
                if (Math.Round(m, 3) == 1) som = ""; else som = Math.Round(m, 3).ToString();
                if (n > 0) son = "+ " + Math.Round(n, 3);
                if (n < 0) son = "- " + Math.Round(-n, 3);
                soc = Math.Round(c, 3) + "";

                lg[3].Text = soa + "sin(" + som + "x " + son + ") " +
                             sob + "cos(" + som + "x " + son + ") = " +
                             soc + "  (*)";
                lg[3].Location = new Point(20,20);

                lg[1].Text = "Vì";

                PictureBox ptb1 = new PictureBox();
                ptb1.Image = Properties.Resources.ab;
                ptb1.Size = new Size(69,28);
                loigiai.Controls.Add(ptb1);

                lg[2].Text = " = " + a*a + " + " + b * b + " = " +Math.Round(a * a + b * b,5) + " ≠ 0";

                lg[1].Location = new Point(30,50);
                ptb1.Location = new Point(50,50);
                lg[2].Location = new Point(115,50);

                loigiai.Controls.Add(ptb1);

                lg[4].Text = "(*) <=>  " + Math.Round(a/canab,3) + "sin(" + som + "x " + son + ") + " +
                            Math.Round(b/canab,3) + "cos(" + som + "x " + son + ") = " +
                            Math.Round(c/canab, 3);
                lg[4].Location = new Point(30,80);

                double y = beta * 180 / Math.PI;
                int y1;
                if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
                {
                    if (giai.timthay(y1)) sbeta = "" + giai.gdb[y1];
                    else if (giai.timthay(-y1)) sbeta = "" + giai.gdb[-y1];
                    else sbeta = Math.Round(beta, 3).ToString();
                }
                else sbeta = Math.Round(beta, 3).ToString();

                lg[5].Text = "<=>  cos(" + sbeta + ")sin(" + som + "x " + son + ") + " +
                                "sin(" + sbeta + ")cos(" + som + "x " + son +
                                ") = " + Math.Round(c / canab, 3);

                lg[6].Text = "<=>  sin(" + som + "x " + son +" + " + sbeta + ") = " + Math.Round(c / canab, 3);

                //lg[7].Text = "<=>  sin(" + som + "x " + son + " + " + sbeta + ") = sin(" + arcsinc() + ")";

                lg[5].Location = new Point(55,110);
                lg[6].Location = new Point(55,140);
                //lg[7].Location = new Point(55, 170);

                if (Math.Round(c / canab, 5) == 1 || Math.Round(c / canab, 5) == -1 || Math.Round(c, 5) == 0)
                {
                    lg[8].Text = "<=> " + som +"x " + son + " + " + sbeta + " = " + arcsinc1() + " + k2π";
                    lg[8].Location = new Point(55, 170);

                    lg[9].Text = "<=> " +ngh1;
                    lg[9].Location = new Point(55, 200);
                }
                else
                {
                    lg[8].Text = "<=>";
                    PictureBox ptb2 = new PictureBox();
                    ptb2.Image = Properties.Resources.daungoac;
                    ptb2.Size = new Size(27, 58);
                    loigiai.Controls.Add(ptb2);

                    lg[8].Location = new Point(55, 185);
                    ptb2.Location = new Point(90, 170);

                    lg[9].Text = som + "x " + son + " + " + sbeta + " = " + arcsinc1() + "+ k2π";
                    lg[10].Text = som + "x " + son + " + " + sbeta + " = π - " + arcsinc1() + "+ k2π";

                    lg[9].Location = new Point(120,170);
                    lg[10].Location = new Point(120, 200);

                    lg[11].Text = kq[1];
                    lg[12].Text = kq[2];

                    lg[13] .Text= "<=>";

                    PictureBox ptb3 = new PictureBox();
                    ptb3.Image = Properties.Resources.daungoac;
                    ptb3.Size = new Size(27,58);
                    ptb3.Location = new Point(90, 230);
                    loigiai.Controls.Add(ptb3);

                    lg[13].Location = new Point(55,245);
                   
                    lg[11].Location = new Point(120, 230);
                    lg[12].Location = new Point(120, 260);
                }
            }

            Button button3 = new Button();
            button3.Text = "Hướng dẫn giải tổng quát";
            button3.Font = button1.Font;
            button3.Size = new Size(200, 40);
            button3.Location = new Point(40, 300);
            loigiai.Controls.Add(button3);
            button3.Click += Button3_Click;

            for (int i = 1; i <= 19; i++)
                loigiai.Controls.Add(lg[i]);
            loigiai.Size = new Size(800, 400);
            loigiai.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            HuongDan2 huongdan = new HuongDan2();
            huongdan.ShowDialog();
        }
    }
}
