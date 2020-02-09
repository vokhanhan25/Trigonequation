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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        double a, b, c, d;
        Form1 giai = new Form1();
        string ngh1 = "", ngh2 = "", ngh3 = "";
        Boolean kt = false;
        string soa = "", sob = "", soc = "", sod = "";
        string[] kq = new string[5];
        PictureBox[] pt = new PictureBox[20];
        Button button4 = new Button();

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ngh1 = "";
            ngh2 = "";
            ngh3 = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label7.Text = "";
            soa = ""; sob = ""; soc = "";sod = "";
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ bốn số a,b,c,d!");
            else
            {
                Docdulieu doc = new Docdulieu();
                a = doc.chuyen(textBox1.Text);
                b = doc.chuyen(textBox2.Text);
                c = doc.chuyen(textBox3.Text);
                d = doc.chuyen(textBox4.Text);
                if (a == d)
                {
                    ngh1 = "x = π/2 + kπ";
                    kt = true;
                }
                
                giai.radioButton3.Checked = true;
                giai.textBox2.Text = (a - d).ToString();
                giai.textBox3.Text = b.ToString();
                giai.textBox4.Text = (c - d).ToString();
                giai.button1_Click(button1, e);
                ngh2 = giai.ngh1;
                ngh3 = giai.ngh3;

                kq[1] = ngh1;
                kq[2] = ngh2;
                kq[3] = ngh3;

                for (int i = 1; i < 5; i++)
                    for (int j = i + 1; j < 5; j++)
                        if (kq[i] == "" && kq[j] != "")
                        {
                            kq[i] = kq[j];
                            kq[j] = "";
                        }

                if (ngh1 == "" && ngh2 == "" && ngh3 == "")
                    label7.Text = "Phương trình vô nghiệm";
                else
                {
                    label7.Text = "Phương trình có nghiệm:";
                    label8.Text = kq[1];
                    label9.Text = kq[2];
                    label10.Text = kq[3];
                    label11.Text = "(với k là số nguyên)"; 
                }

                Button button2 = new Button();
                button2.Text = "Lời giải chi tiết";
                button2.Font = button1.Font;
                button2.Location = new Point(300, 265);
                button2.AutoSize = true;
                this.Controls.Add(button2);
                button2.Click += Button2_Click;
                this.AcceptButton = button2;

                button4.Text = "Đồ thị";
                button4.Font = button1.Font;
                button4.Location = new Point(300, 305);
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
                int y = (int)Math.Round(30 * (a * x1 * x1 + b * x1 * x2 + c * x2 * x2 - d));
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
                int y = (int)Math.Round(30 * (a * x1 * x1 + b * x1 * x2 + c * x2 * x2 - d));
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
            loigiai.AutoScroll = true;

            Label mau = new Label();
            mau.Font = new Font("VNF-Comic Sans", 12);

            for (int i = 1; i < 20; i++)
            {
                pt[i] = new PictureBox();
                pt[i].Size = new Size(0, 0);
                loigiai.Controls.Add(pt[i]);
            }

            for (int i = 1; i < 20; i++)
            {
                lg[i] = new Label();
                lg[i].Font = mau.Font;
                lg[i].AutoSize = true;
                lg[i].Text = "";
                lg[i].Size = new Size(0, 0);
                loigiai.Controls.Add(lg[i]);
            }

            lg[1].Text = "+) Xét cos(x) = 0 =>"; // sin(x)^1 = 1";
            lg[1].Location = new Point(20, 20);

            pt[1].Image = Properties.Resources.sinb;
            pt[1].Size = new Size(64, 30);
            pt[1].Location = new Point(15 + lg[1].Width, 17);

            lg[1].Text = lg[1].Text + "                 = 1";

            if (a == d)
            {
                lg[2].Text = "Do " + Math.Round(a, 4) + " = " + Math.Round(d, 4) + " => π/2 + kπ là nghiệm của phương trình";
                kt = true;
            }
            else lg[2].Text = "Do " + Math.Round(a, 4) + " ≠ " + Math.Round(d, 4) + " => π/2 + kπ không là nghiệm của phương trình";
            lg[2].Location = new Point(30, 45);

            lg[3].Text = "+) Xét cos(x) ≠ 0, chia cả 2 vế của (*) cho cos(x)^2, ta được: ";
            lg[3].Location = new Point(20, 70);

            if (a >= 0)
                if (Math.Round(a, 3) != 1) soa = Math.Round(a, 3) + "";
            if (a < 0)
                if (Math.Round(a, 3) != -1) soa = "- " + Math.Round(-a, 3);
                else soa = "- ";
            if (b >= 0)
                if (Math.Round(b, 3) != 1) sob = "+ " + Math.Round(b, 3);
                else sob = "+ ";
            if (b < 0)
                if (Math.Round(b, 3) != -1) sob = "- " + Math.Round(-b, 3);
                else sob = "- ";
            if (c >= 0) soc = "+ " + Math.Round(c, 3);
            if (c < 0) soc = "- " + Math.Round(-c, 3);
            if (d >= 0)
                if (Math.Round(d,3) != 1) sod = "" + Math.Round(d, 3);
            if (d < 0)
                if (Math.Round(d, 3) != -1) sod = "- " + Math.Round(-d, 3);
                else sod = "- ";

            lg[4].Text = soa;
            lg[4].Location = new Point(100, 120);
            
            pt[2].Image = Properties.Resources.sinchiacos;
            pt[2].Size = new Size(91, 65);
            pt[2].Location = new Point(95 + lg[4].Width, 100);

            lg[4].Text = lg[4].Text + "                     " + sob;

            pt[3].Image = Properties.Resources.sincoschiacos;
            pt[3].Size = new Size(110, 65);
            pt[3].Location = new Point(95 + lg[4].Width, 100);

            lg[4].Text = lg[4].Text + "                             " + soc;

            pt[4].Image = Properties.Resources.coschiacos;
            pt[4].Size = new Size(91, 68);
            pt[4].Location = new Point(95 + lg[4].Width, 100);

            lg[4].Text = lg[4].Text + "                        = " + sod;

            pt[5].Image = Properties.Resources._1chiacos;
            pt[5].Size = new Size(95, 68);
            pt[5].Location = new Point(95+ lg[4].Width, 100);
        
            if (a - d >= 0)
                if (Math.Round(a - d, 3) != 1) soa = Math.Round(a - d, 3) + "";
            if (a - d < 0)
                if (Math.Round(a - d, 3) != -1) soa = "- " + Math.Round(a - d, 3);
                else soa = "- ";
            if (b >= 0)
                if (Math.Round(b, 3) != 1) sob = "+ " + Math.Round(b, 3) + "tan(x) ";
                else sob = "+ tan(x) ";
            if (b < 0)
                if (Math.Round(b, 3) != -1) sob = "- " + Math.Round(-b, 3) + "tan(x) ";
                else sob = "- tan(x) ";
            if (c >= 0) soc = "+ " + Math.Round(c, 3);
            if (c < 0) soc = "- " + Math.Round(-c, 3);

            lg[5].Text = "<=>   " + soa;// + sob + soc + " = 0  (1)";
            lg[5].Location = new Point(65, 170);

            pt[6].Image = Properties.Resources.tanb;
            pt[6].Size = new Size(64, 30);
            pt[6].Location = new Point(60 + lg[5].Width, 166);

            lg[5].Text = lg[5].Text + "                  " + sob + soc + " = 0  (1)";

            lg[6].Text = "Đặt t = tan(x), giải (1) ta được: ";
            lg[6].Location = new Point(30, 195);

            if (giai.d < 0)
            {
                lg[7].Text = " (1) vô nghiệm";
                lg[7].Location = new Point(60, 220);
            }

            if (giai.d == 0)
            {
                lg[7].Text = "t = " + Math.Round(giai.x) + " => tan(x) = " + Math.Round(giai.x);
                if ((Math.Abs(giai.x - Math.PI / 2) <= 0.000000001))
                    lg[7].Text = lg[7].Text + "  (loại)";
                else lg[7].Text = lg[7].Text + " => " + ngh2;
                lg[7].Location = new Point(60, 220);

            }

            if (giai.d > 0)
            {
                if (giai.kt == 1)
                {
                    lg[7].Location = new Point(60, 220);
                    lg[7].Text = "(1) có vô số nghiệm";

                    lg[8].Location = new Point(60, 245);
                    lg[8].Text = "(vì a,b,c = 0)";

                    lg[9].Location = new Point(60, 270);
                    lg[9].Text = "=> (*) có vô số nghiệm x = arctan(t)  (t ≠ π/2 + kπ)";
                }
                else
                if (giai.kt == 2)
                {
                    lg[7].Location = new Point(60, 220);
                    lg[7].Text = "(1) vô nghiệm";

                    lg[8].Location = new Point(60, 245);
                    lg[8].Text = "(vì a,b = 0, c ≠ 0)";

                    lg[9].Location = new Point(60, 170);
                    lg[9].Text = "=> (*) vô nghiệm";
                }
                else
                {
                    lg[7].Text = "t = " + Math.Round(giai.x1) + "=> tan(x) = " + Math.Round(giai.x1);
                    if ((Math.Abs(giai.x1 - Math.PI / 2) <= 0.000000001))
                        lg[7].Text = lg[7].Text + "  (loại)";
                    else lg[7].Text = lg[7].Text + "=> " + ngh2;
                    lg[7].Location = new Point(60, 220);

                    lg[8].Text = "t = " + Math.Round(giai.x2) + "=> tan(x) = " + Math.Round(giai.x2);
                    if ((Math.Abs(giai.x2 - Math.PI / 2) <= 0.000000001))
                        lg[8].Text = lg[8].Text + "  (loại)";
                    else lg[8].Text = lg[8].Text + "=> " + ngh3;
                    lg[8].Location = new Point(60, 245);
                }
            }

            if (ngh1 == "" && ngh2 == "" && ngh3 == "")
            {
                lg[9].Text = "Vậy phương trình (*) vô nghiệm";
                lg[9].Location = new Point(30, 270);
            }
            else
            {
                lg[9].Text = "Vậy phương trình (*) có nghiệm:";
                lg[9].Location = new Point(30, 270);
                int dong = 270;
                if (ngh1 != " ")
                {
                    dong = dong + 25;
                    lg[10].Text = ngh1;
                    lg[10].Location = new Point(60, dong);
                }

                if (ngh2 != " ")
                {
                    dong = dong + 25;
                    lg[11].Text = ngh2;
                    lg[11].Location = new Point(60, dong);
                }

                if (ngh3 != " ")
                {
                    dong = dong + 25;
                    lg[12].Text = ngh3;
                    lg[12].Location = new Point(60, dong);
                }
            }

            Button button3 = new Button();
            button3.Text = "Hướng dẫn giải tổng quát";
            button3.Font = button1.Font;
            button3.Size = new Size(200, 40);
            button3.Location = new Point(40, 360);
            loigiai.Controls.Add(button3);
            button3.Click += Button3_Click;
            
            loigiai.Size = new Size(650, 450);
            loigiai.AutoSize = true;

            loigiai.ShowDialog();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            HuongDan3 huongdan = new HuongDan3();
            huongdan.ShowDialog();
        }


    }
}
