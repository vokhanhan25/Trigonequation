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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked == true) textBox1.Text = "a*sin(x)^3 + b*sin(x)^2 + c*sin(x) + d = 0";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked == true) textBox1.Text = "a*tan(x)^3 + b*tan(x)^2 + c*tan(x) + d = 0";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked == true) textBox1.Text = "a*cos(x)^3 + b*cos(x)^2 + c*cos(x) + d = 0";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked == true) textBox1.Text = "a*cot(x)^3 + b*cot(x)^2 + c*cot(x) + d = 0";
        }

        public double can3(double x)
        {
            double kq = 0;
            if (x > 0)
                kq = Math.Pow(x, (float)(0.33333333333333333));
            else
                kq = -Math.Pow(-x, (float)(0.3333333333333333));
            return kq;
        }


        public string sin1()
        {
            string kq = "π/2 + k2π";
            return kq;
        }

        public string sin_1()
        {
            string kq = "-π/2 + k2π";
            return kq;
        }

        public string sin0()
        {
            string kq = "kπ";
            return kq;
        }

        string cos1()
        {
            string kq = "k2π";
            return kq;
        }

        string cos_1()
        {
            string kq = "π + k2π";
            return kq;
        }

        string cos0()
        {
            string kq = "π/2 + k*π";
            return kq;
        }

        public double a, b, c, d,denta,k, x, x1, x2,x3;
        Docdulieu doc = new Docdulieu();
        Form1 giai = new Form1();
        public String ngh1 = " ", ngh2 = " ", ngh3 = " ", ngh4 = " ",ngh5 = "",ngh6 = "";
        string soa = "", sob = "", soc = "", sod = "";
        public int songhiem = 1;
        Label[] lg = new Label[20];
        PictureBox[] pt = new PictureBox[30];
        public Boolean conghiem2 = false, conghiem3 = false, conghiem1 = false;
        string[] kq = new string[7];
        Button button4 = new Button();

        public void button1_Click(object sender, EventArgs e)
        {
            ngh1 = ""; ngh2 = ""; ngh3 = ""; ngh4 = ""; ngh5 = ""; ngh6 = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label14.Text = "";
            label15.Text = "";
            conghiem2 = false;
            conghiem3 = false;
            soa = ""; sob = ""; soc = ""; sod = "";
            if ((textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "") ||
                (radioButton1.Checked == false && radioButton2.Checked == false &&
                radioButton3.Checked == false && radioButton4.Checked == false))
            {
                if (radioButton1.Checked == false && radioButton2.Checked == false &&
                    radioButton3.Checked == false && radioButton4.Checked == false)
                    MessageBox.Show("Bạn chưa chọn dạng phương trình!");
                else
                if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                    MessageBox.Show("Bạn chưa nhập đủ bốn số a,b,c,d!");
            }
            else
            {
                a = doc.chuyen(textBox2.Text);
                b = doc.chuyen(textBox3.Text);
                c = doc.chuyen(textBox4.Text);
                d = doc.chuyen(textBox5.Text);
                if (a >= 0)
                    if (Math.Round(a, 3) != 1) soa = Math.Round(a, 3) + "";
                if (a < 0)
                    if (Math.Round(a, 3) != -1) soa = "-" + Math.Round(-a, 3);
                    else soa = "- ";
                if (b >= 0)
                    if (Math.Round(b, 3) != 1) sob = " + " + Math.Round(b, 3);
                    else sob = "+ ";
                if (b < 0)
                    if (Math.Round(b, 3) != -1) sob = "- " + Math.Round(-b, 3);
                    else sob = "- ";
                if (c >= 0)
                    if (Math.Round(c, 3) != 1) soc = "+ " + Math.Round(c, 3) + "tan(x) ";
                if (c < 0)
                    if (Math.Round(c, 3) != -1) soc = "- " + Math.Round(-c, 3) + "tan(x) ";
                if (d >= 0) sod = "+ " + Math.Round(d, 3);
                if (d < 0) sod = "- " + Math.Round(-d, 3);

                if (a == 0)
                {
                    if (radioButton1.Checked == true) giai.radioButton1.Checked = true;
                    if (radioButton2.Checked == true) giai.radioButton2.Checked = true;
                    if (radioButton3.Checked == true) giai.radioButton3.Checked = true;
                    if (radioButton4.Checked == true) giai.radioButton4.Checked = true;
                    giai.textBox2.Text = textBox3.Text;
                    giai.textBox3.Text = textBox4.Text;
                    giai.textBox4.Text = textBox5.Text;
                    giai.button1_Click(button1, e);
                    x1 = giai.x;
                    if (giai.d > 0)
                        x1 = giai.x1;
                    x2 = giai.x2;
                    ngh1 = giai.ngh1;
                    ngh2 = giai.ngh2;
                    ngh3 = giai.ngh3;
                    ngh4 = giai.ngh4;
                    if (ngh3 != "")
                    {
                        conghiem2 = true;
                        conghiem1 = true;
                    }
                    else
                    if (ngh1 != "")
                        conghiem1 = true;

                }
                else
                {
                    denta = b * b - 3 * a * c;
                    k = (9 * a * b * c - 2 * b * b * b - 27 * a * a * d) / (2 * Math.Sqrt(Math.Abs(denta * denta * denta)));
                    if (denta > 0)
                    {

                        if (Math.Abs(k) < 1)
                        {
                            x1 = (2 * Math.Sqrt(denta) * Math.Cos(Math.Acos(k) / 3) - b) / (3 * a);
                            x2 = (2 * Math.Sqrt(denta) * Math.Cos(Math.Acos(k) / 3 - 2 * Math.PI / 3) - b) / (3 * a);
                            x3 = (2 * Math.Sqrt(denta) * Math.Cos(Math.Acos(k) / 3 + 2 * Math.PI / 3) - b) / (3 * a);
                            conghiem2 = true;
                            conghiem3 = true;
                            conghiem1 = true;
                            songhiem = 3;
                        }
                        if (Math.Abs(k) >= 1)
                        {
                            x1 = (Math.Sqrt(denta) * Math.Abs(k)) / (3 * a * k) * (can3(Math.Abs(k) + Math.Sqrt(k * k - 1)) +
                                can3(Math.Abs(k) - Math.Sqrt(k * k - 1))) - b / (3 * a);
                            conghiem1 = true;
                        }
                    }
                    else if (denta == 0)
                    {
                        x1 = -b / (3 * a);
                        conghiem1 = true;
                    }
                    else if (denta < 0)
                    {
                        x1 = Math.Sqrt(Math.Abs(denta)) / (3 * a) * (can3(k + Math.Sqrt(k * k + 1)) +
                            can3(k - Math.Sqrt(k * k + 1))) - b / (3 * a);
                        conghiem1 = true;
                    }
                    if (!((Math.Round(Math.Round(Math.Abs(x1), 4), 4) > 1) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                                || ((Math.Round(Math.Round(Math.Abs(x1), 4), 4) - Math.PI / 2 <= 0.000000001) && (radioButton3.Checked == true))
                                || ((Math.Round(Math.Round(Math.Abs(x1), 4), 4) <= 0.000000001) && (radioButton4.Checked == true)))
                    {
                        if (radioButton1.Checked == true)
                        {
                            if (Math.Round(x1, 3) == 1) ngh1 = "x = " + sin1();
                            else
                            if (Math.Round(x1, 3) == -1) ngh1 = "x = " + sin_1();
                            else
                            if (Math.Round(x1, 3) == 0) ngh1 = "x = " + sin0();
                            else
                            {
                                double y = Math.Asin(x1) * 180 / Math.PI;
                                int y1 = new int();

                                if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
                                {
                                    if (giai.timthay(y1))
                                    {
                                        ngh1 = "x = " + giai.gdb[y1 + 200] + " + k2π";
                                        ngh2 = "x = " + giai.gdb[180 - y1 + 200] + " + k2π";
                                    }
                                    else
                                    {
                                        ngh1 = "x = " + "arcsin(" + Math.Round(x1, 3) + ") + k2π";
                                        ngh2 = "x = " + "π - arcsin(" + Math.Round(x1, 3) + ") + k2π";
                                    }
                                }
                                else
                                {
                                    ngh1 = "x = " + "arcsin(" + Math.Round(x1, 3) + ") + k2π";
                                    ngh2 = "x = " + "π - arcsin(" + Math.Round(x1, 3) + ") + k2π";
                                }
                            }
                        }

                        if (radioButton2.Checked == true)
                        {
                            if (Math.Round(x1, 3) == 1) ngh1 = "x = " + cos1();
                            else
                            if (Math.Round(x1, 3) == -1) ngh1 = "x = " + cos_1();
                            else
                            if (Math.Round(x1, 3) == 0) ngh1 = "x = " + cos0();
                            else
                            {
                                double y = Math.Acos(x1) * 180 / Math.PI;
                                int y1 = new int();
                                if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
                                {
                                    if (giai.timthay(y1))
                                    {
                                        ngh1 = "x = " + giai.gdb[y1 + 200] + " + k2π";
                                        ngh2 = "x = " + giai.gdb[-y1 + 200] + " + k2π";
                                    }
                                    else
                                    {
                                        ngh1 = "x = " + "arccos(" + Math.Round(x1, 3) + ") + k2π";
                                        ngh2 = "x = " + "π - arccos(" + Math.Round(x1, 3) + ") + k2π";
                                    }
                                }
                                else
                                {
                                    ngh1 = "x = " + "arccos(" + Math.Round(x1, 3) + ") + k2π";
                                    ngh2 = "x = " + "π - arccos(" + Math.Round(x1, 3) + ") + k2π";
                                }
                            }
                        }

                        if (radioButton3.Checked == true)
                        {
                            if (Math.Round(x1, 3) == 0) ngh1 = "x = " + sin0();
                            else
                            {
                                double y = Math.Atan(x) * 180 / Math.PI;
                                int y1 = new int();
                                if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
                                {
                                    if (giai.timthay(y1))
                                    {
                                        ngh1 = "x = " + giai.gdb[y1 + 200] + " + kπ";
                                    }
                                    else
                                    {
                                        ngh1 = "x = " + "arctan(" + Math.Round(x1, 3) + ") + kπ";
                                    }
                                }
                                else
                                {
                                    ngh1 = "x = " + "arctan(" + Math.Round(x1, 3) + ") + kπ";
                                }
                            }
                        }

                        if (radioButton4.Checked == true)
                        {
                            if (Math.Round(x1, 3) == 0) ngh1 = "x = " + cos0();
                            else
                            {
                                double y = Math.Atan(1 / x1) * 180 / Math.PI;
                                int y1 = new int();
                                if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
                                {
                                    if (giai.timthay(y1))
                                    {
                                        ngh1 = "x = " + giai.gdb[y1 + 200] + " + kπ";
                                    }
                                    else
                                    {
                                        ngh1 = "x = " + "arccot(" + Math.Round(x1, 3) + ") + kπ";
                                    }
                                }
                                else
                                {
                                    ngh1 = "x = " + "arccot(" + Math.Round(x1, 3) + ") + kπ";
                                }
                            }
                        }
                    }

                    if (denta > 0 && Math.Abs(k) < 1)
                    {
                        if (!((Math.Round(Math.Abs(x2), 4) > 1) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                                || ((Math.Round(Math.Abs(x2), 4) - Math.PI / 2 <= 0.000000001) && (radioButton3.Checked == true))
                                || ((Math.Round(Math.Abs(x2), 4) <= 0.000000001) && (radioButton4.Checked == true)))
                        {
                            if (radioButton1.Checked == true)
                            {
                                if (Math.Round(x2, 3) == 1) ngh3 = "x = " + sin1();
                                else
                                if (Math.Round(x2, 3) == -1) ngh3 = "x = " + sin_1();
                                else
                                if (Math.Round(x2, 3) == 0) ngh3 = "x = " + sin0();
                                else
                                {
                                    double y = Math.Asin(x2) * 180 / Math.PI;
                                    int y1 = new int();
                                    if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
                                    {
                                        if (giai.timthay(y1))
                                        {
                                            ngh3 = "x = " + giai.gdb[y1 + 200] + " + k2π";
                                            ngh4 = "x = " + giai.gdb[180 - y1 + 200] + " + k2π";
                                        }
                                        else
                                        {
                                            ngh3 = "x = " + "arcsin(" + Math.Round(x2, 3) + ") + k2π";
                                            ngh4 = "x = " + "π - arcsin(" + Math.Round(x2, 3) + ") + k2π";
                                        }
                                    }
                                    else
                                    {
                                        ngh3 = "x = " + "arcsin(" + Math.Round(x2, 3) + ") + k2π";
                                        ngh4 = "x = " + "π - arcsin(" + Math.Round(x2, 3) + ") + k2π";
                                    }
                                }
                            }

                            if (radioButton2.Checked == true)
                            {
                                if (Math.Round(x2, 3) == 1) ngh3 = "x = " + cos1();
                                else
                                if (Math.Round(x2, 3) == -1) ngh3 = "x = " + cos_1();
                                else
                                if (Math.Round(x2, 3) == 0) ngh3 = "x = " + cos0();
                                else
                                {
                                    double y = Math.Acos(x2) * 180 / Math.PI;
                                    int y1 = new int();
                                    if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
                                    {
                                        if (giai.timthay(y1))
                                        {
                                            ngh3 = "x = " + giai.gdb[y1 + 200] + " + k2π";
                                            ngh4 = "x = " + giai.gdb[-y1 + 200] + " + k2π";
                                        }
                                        else
                                        {
                                            ngh3 = "x = " + "arccos(" + Math.Round(x2, 3) + ") + k2π";
                                            ngh4 = "x = " + "π - arccos(" + Math.Round(x2, 3) + ") + k2π";
                                        }
                                    }
                                    else
                                    {
                                        ngh3 = "x = " + "arccos(" + Math.Round(x2, 3) + ") + k2π";
                                        ngh4 = "x = " + "π - arccos(" + Math.Round(x2, 3) + ") + k2π";
                                    }
                                }
                            }

                            if (radioButton3.Checked == true)
                            {
                                if (Math.Round(x2, 3) == 0) ngh3 = "x = " + sin0();
                                else
                                {
                                    double y = Math.Atan(x2) * 180 / Math.PI;
                                    int y1 = new int();
                                    if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
                                    {
                                        if (giai.timthay(y1))
                                        {
                                            ngh3 = "x = " + giai.gdb[y1 + 200] + " + kπ";
                                        }
                                        else
                                        {
                                            ngh3 = "x = " + "arctan(" + Math.Round(x2, 3) + ") + kπ";
                                        }
                                    }
                                    else
                                    {
                                        ngh3 = "x = " + "arctan(" + Math.Round(x2, 3) + ") + kπ";
                                    }
                                }
                            }

                            if (radioButton4.Checked == true)
                            {
                                if (Math.Round(x2, 3) == 0) ngh3 = "x = " + cos0();
                                else
                                {
                                    double y = Math.Atan(1 / x2) * 180 / Math.PI;
                                    int y1 = new int();
                                    if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
                                    {
                                        if (giai.timthay(y1))
                                        {
                                            ngh3 = "x = " + giai.gdb[y1 + 200] + " + kπ";
                                        }
                                        else
                                        {
                                            ngh3 = "x = " + "arccot(" + Math.Round(x2, 3) + ") + kπ";
                                        }
                                    }
                                    else
                                    {
                                        ngh3 = "x = " + "arccot(" + Math.Round(x2, 3) + ") + kπ";
                                    }
                                }
                            }
                        }

                        if (!((Math.Abs(x3) > 1) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                                || ((Math.Abs(x3) - Math.PI / 2 <= 0.000000001) && (radioButton3.Checked == true))
                                || ((Math.Abs(x3) <= 0.000000001) && (radioButton4.Checked == true)))
                        {
                            if (radioButton1.Checked == true)
                            {
                                if (Math.Round(x3, 3) == 1) ngh5 = "x = " + sin1();
                                else
                                if (Math.Round(x3, 3) == -1) ngh5 = "x = " + sin_1();
                                else
                                if (Math.Round(x3, 3) == 0) ngh5 = "x = " + sin0();
                                else
                                {
                                    double y = Math.Asin(x3) * 180 / Math.PI;
                                    int y1 = new int();
                                    if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
                                    {
                                        if (giai.timthay(y1))
                                        {
                                            ngh5 = "x = " + giai.gdb[y1 + 200] + " + k2π";
                                            ngh6 = "x = " + giai.gdb[180 - y1 + 200] + " + k2π";
                                        }
                                        else
                                        {
                                            ngh5 = "x = " + "arcsin(" + Math.Round(x3, 3) + ") + k2π";
                                            ngh6 = "x = " + "π - arcsin(" + Math.Round(x3, 3) + ") + k2π";
                                        }
                                    }
                                    else
                                    {
                                        ngh5 = "x = " + "arcsin(" + Math.Round(x3, 3) + ") + k2π";
                                        ngh6 = "x = " + "π - arcsin(" + Math.Round(x3, 3) + ") + k2π";
                                    }
                                }
                            }

                            if (radioButton2.Checked == true)
                            {
                                if (Math.Round(x3, 3) == 1) ngh5 = "x = " + cos1();
                                else
                                if (Math.Round(x3, 3) == -1) ngh5 = "x = " + cos_1();
                                else
                                if (Math.Round(x3, 3) == 0) ngh5 = "x = " + cos0();
                                else
                                {
                                    double y = Math.Acos(x3) * 180 / Math.PI;
                                    int y1 = new int();
                                    if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
                                    {
                                        if (giai.timthay(y1))
                                        {
                                            ngh5 = "x = " + giai.gdb[y1 + 200] + " + k2π";
                                            ngh6 = "x = " + giai.gdb[-y1 + 200] + " + k2π";
                                        }
                                        else
                                        {
                                            ngh5 = "x = " + "arccos(" + Math.Round(x3, 3) + ") + k2π";
                                            ngh6 = "x = " + "π - arccos(" + Math.Round(x3, 3) + ") + k2π";
                                        }
                                    }
                                    else
                                    {
                                        ngh5 = "x = " + "arccos(" + Math.Round(x3, 3) + ") + k2π";
                                        ngh6 = "x = " + "π - arccos(" + Math.Round(x3, 3) + ") + k2π";
                                    }
                                }
                            }

                            if (radioButton3.Checked == true)
                            {
                                if (Math.Round(x3, 3) == 0) ngh5 = "x = " + sin0();
                                else
                                {
                                    double y = Math.Atan(x3) * 180 / Math.PI;
                                    int y1 = new int();
                                    if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
                                    {
                                        if (giai.timthay(y1))
                                        {
                                            ngh5 = "x = " + giai.gdb[y1 + 200] + " + kπ";
                                        }
                                        else
                                        {
                                            ngh5 = "x = " + "arctan(" + Math.Round(x3, 3) + ") + kπ";
                                        }
                                    }
                                    else
                                    {
                                        ngh5 = "x = " + "arctan(" + Math.Round(x3, 3) + ") + kπ";
                                    }
                                }
                            }

                            if (radioButton4.Checked == true)
                            {
                                if (Math.Round(x3, 3) == 0) ngh5 = "x = " + cos0();
                                else
                                {
                                    double y = Math.Atan(1 / x3) * 180 / Math.PI;
                                    int y1 = new int();
                                    if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
                                    {
                                        if (giai.timthay(y1))
                                        {
                                            ngh5 = "x = " + giai.gdb[y1 + 200] + " + kπ";
                                        }
                                        else
                                        {
                                            ngh5 = "x = " + "arccot(" + Math.Round(x3, 3) + ") + kπ";
                                        }
                                    }
                                    else
                                    {
                                        ngh5 = "x = " + "arccot(" + Math.Round(x3, 3) + ") + kπ";
                                    }
                                }
                            }
                        }
                    }

                    kq[1] = ngh1;
                    kq[2] = ngh2;
                    kq[3] = ngh3;
                    kq[4] = ngh4;
                    kq[5] = ngh5;
                    kq[6] = ngh6;

                    for (int i = 1; i < 7; i++)
                        for (int j = i + 1; j < 7; j++)
                            if (kq[i] == "" && kq[j] != "")
                            {
                                kq[i] = kq[j];
                                kq[j] = "";
                            }

                    if (ngh1 == "" && ngh2 == "" && ngh3 == "" && ngh4 == "" && ngh5 == "" && ngh6 == "")
                        label5.Text = "Phương trình vô nghiệm";
                    else
                    {
                        label5.Text = "Phương trình có nghiệm:";
                        label6.Text = kq[1];
                        label7.Text = kq[2];
                        label8.Text = kq[3];
                        label9.Text = kq[4];
                        label14.Text = kq[5];
                        label15.Text = kq[6];
                        label16.Text = "(với k là số nguyên)";
                    }

                    Button button2 = new Button();
                    button2.Text = "Lời giải chi tiết";
                    button2.Font = button1.Font;
                    button2.Location = new Point(437, 230);
                    button2.AutoSize = true;
                    this.Controls.Add(button2);
                    button2.Click += Button2_Click;
                    this.AcceptButton = button2;

                    button4.Text = "Đồ thị";
                    button4.Font = button1.Font;
                    button4.Location = new Point(437, 270);
                    button4.Size = new Size(128, 36);
                    this.Controls.Add(button4);
                    button4.Click += Button4_Click;
                }
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
                if (radioButton3.Checked) x = Math.Tan(x / 30);
                if (radioButton4.Checked) x = 1 / Math.Tan(x / 30);
                int y = (int)Math.Round(30 * (a * x * x * x + b * x * x + c * x + d));
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
                if (radioButton3.Checked) x = Math.Tan(x / 30);
                if (radioButton4.Checked) x = 1 / Math.Tan(x / 30);
                int y = (int)Math.Round(30 * (a * x * x * x + b * x * x + c * x + d));
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
                pt[i] = new PictureBox();
                pt[i].Size = new Size(0, 0);
                loigiai.Controls.Add(pt[i]);
            }

            for (int i = 1; i < 20; i++)
            { 
                lg[i] = new Label();
                lg[i].Font = new Font("VNF-Comic Sans", 12);
                lg[i].AutoSize = true;
                lg[i].Size = new Size(0, 0);
                loigiai.Controls.Add(lg[i]);
            }

            string ham = "";
            if (radioButton1.Checked) ham = "sin(x)";
            if (radioButton2.Checked) ham = "cos(x)";
            if (radioButton3.Checked) ham = "tan(x)";
            if (radioButton4.Checked) ham = "cot(x)";

            Image mu3 = Properties.Resources.ab;

            if (ham == "sin(x)") mu3 = Properties.Resources.sinmu3;
            if (ham == "cos(x)") mu3 = Properties.Resources.cosmu3;
            if (ham == "tan(x)") mu3 = Properties.Resources.tanmu3;
            if (ham == "cot(x)") mu3 = Properties.Resources.cotmu3;

            Image mu2 = Properties.Resources.ab;

            if (ham == "sin(x)") mu2 = Properties.Resources.sinb;
            if (ham == "cos(x)") mu2 = Properties.Resources.cosb;
            if (ham == "tan(x)") mu2 = Properties.Resources.tanb;
            if (ham == "cot(x)") mu2 = Properties.Resources.cotb;

            lg[1].Text = soa;
            lg[1].Location = new Point(30, 20);

            pt[1].Image = mu3;
            pt[1].Size = new Size(64, 30);
            pt[1].Location = new Point(25 + lg[1].Width, 17);

            lg[1].Text = lg[1].Text + "                  " + sob;

            pt[2].Image = mu2;
            pt[2].Size = new Size(64, 30);
            pt[2].Location = new Point(25 + lg[1].Width, 17);

            lg[1].Text = lg[1].Text + "                   " + soc + sod + " = 0";

            if (c >= 0)
                if (Math.Round(c, 3) != 1) soc = "+ " + Math.Round(c, 3) + "t ";
            if (c < 0)
                if (Math.Round(c, 3) != -1) soc = "- " + Math.Round(-c, 3) + "t ";

            lg[2].Text = "Đặt t = " + ham;
            if (ham == "sin(x)" || ham == "cos(x)") lg[2].Text = lg[2].Text + "  (|t| <= 1), ta được:";
            else lg[2].Text = lg[2].Text + ", ta được: ";
            lg[2].Location = new Point(30, 50);

            lg[3].Text = soa;// + sob + soc +sod + " = 0    (1)";
            lg[3].Location = new Point(30, 80);

            pt[3].Image = Properties.Resources.tmu3;
            pt[3].Size = new Size(23,23);
            pt[3].Location = new Point(25 + lg[3].Width, 78);

            lg[3].Text = lg[3].Text + "    " + sob;

            pt[4].Image = Properties.Resources.tbinh;
            pt[4].Size = new Size(23, 23);
            pt[4].Location = new Point(25 + lg[3].Width, 80);

            lg[3].Text = lg[3].Text + "      " + soc + sod + " = 0    (1)";

            lg[4].Text = "Giải (1) ta được: ";
            lg[4].Location = new Point(30, 110);

            if (a == 0)
            {
                if (giai.d < 0)
                {
                    lg[5].Text = "(1) vô nghiệm";
                    lg[5].Location = new Point(30, 140);

                    lg[6].Text = "=>  (*) vô nghiệm";
                    lg[6].Location = new Point(30, 170);
                }
                if (giai.d == 0)
                {
                    lg[5].Location = new Point(30, 140);
                    lg[5].Text = "t = " + Math.Round(giai.x, 4) + " => " + ham + " = " + Math.Round(giai.x, 4);

                    if (((Math.Round(Math.Abs(giai.x), 4) > 1) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                          || ((Math.Round(Math.Abs(giai.x), 4) - Math.PI / 2 <= 0.000000001) && (radioButton3.Checked == true))
                          || ((Math.Round(Math.Abs(giai.x), 4) <= 0.000000001) && (radioButton4.Checked == true)))
                    {
                        lg[5].Text = lg[5].Text + "  (loại) ";
                        lg[6].Location = new Point(20, 170);
                        lg[6].Text = "=> (*) vô nghiệm";
                    }
                    else
                    {
                        lg[6].Location = new Point(20, 170);
                        lg[6].Text = "=> Nghiệm của (*) là: ";
                    }

                    lg[7].Location = new Point(30, 200);
                    lg[7].Text = ngh1;



                    if (giai.songhiem >= 2)
                    {
                        lg[8].Location = new Point(30, 230);
                        lg[8].Text = ngh2;
                    }
                }
                else
                if (giai.d > 0)
                {
                    if (giai.kt == 1)
                    {
                        lg[5].Location = new Point(30, 140);
                        lg[5].Text = "(1) có vô số nghiệm";

                        lg[6].Location = new Point(30, 170);
                        lg[6].Text = "(vì a,b,c,d = 0)";

                        lg[7].Location = new Point(20, 200);
                        lg[7].Text = "=> (*) có vô số nghiệm x = arc" + ham + "(t) ";

                        if (ham == "sin(x)" || ham == "cos(x)") lg[7].Text = lg[7].Text + " (|t| <= 1)";
                    }
                    else
                    if (giai.kt == 2)
                    {
                        lg[5].Location = new Point(30, 140);
                        lg[5].Text = "(1) vô nghiệm";

                        lg[6].Location = new Point(30, 170);
                        lg[6].Text = "(vì a,b,c = 0, d ≠ 0)";

                        lg[7].Location = new Point(20, 200);
                        lg[7].Text = "=> (*) vô nghiệm";
                    }
                    else
                    {
                        lg[5].Location = new Point(30, 140);
                        lg[5].Text = "t = " + Math.Round(giai.x1, 4) + " => " + ham + " = " + Math.Round(giai.x1, 4);

                        if (((Math.Round(Math.Abs(giai.x1), 4) > 1) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                            || (Math.Round(Math.Abs(giai.x1), 4) - Math.PI / 2 <= 0.000000001) && (radioButton3.Checked == true)
                              || ((Math.Round(Math.Abs(giai.x1), 4) <= 0.000000001) && (radioButton4.Checked == true)))
                            lg[5].Text = lg[5].Text + "  (loại) ";

                        lg[6].Location = new Point(30, 170);
                        lg[6].Text = "t = " + Math.Round(giai.x2, 4) + " => " + ham + " = " + Math.Round(giai.x2, 4);

                        if (((Math.Round(Math.Abs(giai.x2), 4) > 1) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                              || ((Math.Round(Math.Abs(giai.x2), 4) - Math.PI / 2 <= 0.000000001) && (radioButton3.Checked == true))
                              || ((Math.Round(Math.Abs(giai.x2), 4) <= 0.000000001) && (radioButton4.Checked == true)))
                            lg[6].Text = lg[6].Text + "  (loại) ";

                        if ((((Math.Round(Math.Abs(giai.x1), 4) > 1) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                            || (Math.Round(Math.Abs(giai.x1), 4) - Math.PI / 2 <= 0.000000001) && (radioButton3.Checked == true)
                              || ((Math.Round(Math.Abs(giai.x1), 4) <= 0.000000001) && (radioButton4.Checked == true))) &&
                              (((Math.Round(Math.Abs(giai.x2), 4) > 1) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                              || ((Math.Round(Math.Abs(giai.x2), 4) - Math.PI / 2 <= 0.000000001) && (radioButton3.Checked == true))
                              || ((Math.Round(Math.Abs(giai.x2), 4) <= 0.000000001) && (radioButton4.Checked == true))))
                        {
                            lg[7].Location = new Point(20, 200);
                            lg[7].Text = "=> (*) vô nghiệm";
                        }
                        else
                        {
                            lg[7].Location = new Point(20, 200);
                            lg[7].Text = "=> Nghiệm của (*) là: ";
                        }

                        lg[8].Location = new Point(30, 230);
                        lg[8].Text = ngh1;

                        if (giai.songhiem1 >= 2)
                        {
                            lg[9].Location = new Point(30, 260);
                            lg[9].Text = ngh2;
                        }

                        lg[10].AutoSize = true;
                        lg[10].Location = new Point(30, 290);
                        lg[10].Text = ngh3;

                        if (giai.songhiem2 >= 2)
                        {
                            lg[11].Location = new Point(30, 310);
                            lg[11].Text = ngh4;
                        }
                    }
                }
            }
            else
            {
                lg[5].Text = "t = " + Math.Round(x1, 3) + " => " + ham + " = " + Math.Round(x1,3);
                if (((Math.Round(Math.Abs(x1), 4) > 1) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                            || ((Math.Round(Math.Abs(x1), 4) - Math.PI / 2 <= 0.000000001) && (radioButton3.Checked == true))
                            || ((Math.Round(Math.Abs(x1), 4) <= 0.000000001) && (radioButton4.Checked == true)))
                    lg[5].Text = lg[5].Text + " (loại)";
                lg[5].Location = new Point(30, 140);

                int dong = 140;

                if (conghiem2)
                {
                    lg[6].Text = "t = " + Math.Round(x2, 3) + " => " + ham + " = " + Math.Round(x2, 3);
                    if (((Math.Round(Math.Abs(x2), 4) > 1) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                            || ((Math.Round(Math.Abs(x2), 4) - Math.PI / 2 <= 0.000000001) && (radioButton3.Checked == true))
                            || ((Math.Round(Math.Abs(x2), 4) <= 0.000000001) && (radioButton4.Checked == true)))
                        lg[6].Text = lg[6].Text + " (loại)";
                    lg[6].Location = new Point(30, dong + 30);
                    dong = dong + 30;
                }

                if (conghiem3)
                {
                    lg[7].Text = "t3 = " + Math.Round(x3, 3) + " => " + ham + " = " + Math.Round(x3, 3);
                    if (((Math.Abs(x3) > 1) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                            || ((Math.Abs(x3) - Math.PI / 2 <= 0.000000001) && (radioButton3.Checked == true))
                            || ((Math.Abs(x3) <= 0.000000001) && (radioButton4.Checked == true)))
                        lg[7].Text = lg[7].Text + " (loại)";
                    lg[7].Location = new Point(30, dong + 30);
                    dong = dong + 30;
                }

                if ((((Math.Round(Math.Abs(x1), 4) > 1) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                            || ((Math.Round(Math.Abs(x1), 4) - Math.PI / 2 <= 0.000000001) && (radioButton3.Checked == true))
                            || ((Math.Round(Math.Abs(x1), 4) <= 0.000000001) && (radioButton4.Checked == true))) &&
                            (((Math.Round(Math.Abs(x2), 4) > 1) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                            || ((Math.Round(Math.Abs(x2), 4) - Math.PI / 2 <= 0.000000001) && (radioButton3.Checked == true))
                            || ((Math.Round(Math.Abs(x2), 4) <= 0.000000001) && (radioButton4.Checked == true))) &&
                            (((Math.Abs(x3) > 1) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                            || ((Math.Abs(x3) - Math.PI / 2 <= 0.000000001) && (radioButton3.Checked == true))
                            || ((Math.Abs(x3) <= 0.000000001) && (radioButton4.Checked == true))))
                {
                    lg[8].Text = "=> (*) vô nghiệm";
                    lg[8].Location = new Point(20, dong + 30);
                }
                else
                {
                    lg[8].Text = "=> (*) có nghiệm:";
                    lg[8].Location = new Point(20, dong + 30);
                    dong = dong + 30;
                    
                    if (ngh1 != "")
                    {
                        lg[9].Text = ngh1;
                        lg[9].Location = new Point(30, dong + 30);
                        dong = dong + 30;
                    }
                    if (ngh2 != "")
                    {
                        lg[10].Text = ngh2;
                        lg[10].Location = new Point(30, dong + 30);
                        dong = dong + 30;
                    }
                    if (ngh3 != "")
                    {
                        lg[11].Text = ngh3;
                        lg[11].Location = new Point(30, dong + 30);
                        dong = dong + 30;
                    }
                    if (ngh4 != "")
                    {
                        lg[12].Text = ngh4;
                        lg[12].Location = new Point(30, dong + 30);
                        dong = dong + 30;
                    }
                    if (ngh5 != "")
                    {
                        lg[13].Text = ngh5;
                        lg[13].Location = new Point(30, dong + 30);
                        dong = dong + 30;
                    }
                    if (ngh6 != "")
                    {
                        lg[14].Text = ngh6;
                        lg[14].Location = new Point(30, dong + 30);
                        dong = dong + 30;
                    }
                }
            }

            Button button3 = new Button();
            button3.Text = "Hướng dẫn giải tổng quát";
            button3.Font = button1.Font;
            button3.Size = new Size(200, 40);
            button3.Location = new Point(40, 440);
            loigiai.Controls.Add(button3);
            button3.Click += Button3_Click;

            loigiai.Size = new Size(400, 550);
            loigiai.Controls.Add(button3);
            loigiai.ShowDialog();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            HuongDan5 giai5 = new HuongDan5();
            giai5.ShowDialog();
        }
    }
}
