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
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            taogocdacbiet();
            textBox1.Text = "a*sin(x)^2 + b*sin(x) + c = 0";
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked == true) textBox1.Text = "a*sin(x)^2 + b*sin(x) + c = 0";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked == true) textBox1.Text = "a*cos(x)^2 + b*cos(x) + c = 0";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked == true) textBox1.Text = "a*tan(x)^2 + b*tan(x) + c = 0";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked == true) textBox1.Text = "a*cot(x)^2 + b*cot(x) + c = 0";
        }

        void vonghiem()
        {
            label5.Text = "Phương trình vô nghiệm";
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
            string kq = "π/2 + kπ";
            return kq;
        }

        public int[] db = new int[] { -15,-30, -45, -60,-75, -90,-105, -120,-135, -150,-165, -180, 15,30, 45, 60, 75,90,105, 120,135, 150,165, 180 };
        public string[] gdb = new string[600];
        public string[] tu = new string[600];
        public int[] mau = new int[600];
        public string[] kq = new string[5];
        Label[] lg = new Label[20];
        Button button4 = new Button();

        public void taogocdacbiet()
        {
            gdb[15 + 200] = "π/12";
            gdb[30 + 200] = "π/6";
            gdb[45 + 200] = "π/4";
            gdb[60 + 200] = "π/3";
            gdb[75 + 200] = "5π/12";
            gdb[90 + 200] = "π/2";
            gdb[105 + 200] = "7π/12";
            gdb[120 + 200] = "2π/3";
            gdb[135 + 200] = "3π/4";
            gdb[150 + 200] = "5π/6";
            gdb[165 + 200] = "11π/12";
            gdb[180 + 200] = "π";

            gdb[195 + 200] = "13π/12";
            gdb[210 + 200] = "7π/6";
            gdb[225 + 200] = "5π/4";
            gdb[240 + 200] = "4π/3";
            gdb[255 + 200] = "17π/12";
            gdb[270 + 200] = "3π/2";
            gdb[285 + 200] = "19π/12";
            gdb[300 + 200] = "5π/3";
            gdb[315 + 200] = "7π/4";
            gdb[330 + 200] = "11π/6";
            gdb[345 + 200] = "23π/12";
            gdb[360 + 200] = "2π";

            gdb[200 - 15] = "-π/12";
            gdb[200 - 30] = "-π/6";
            gdb[200 - 45] = "-π/4";
            gdb[200 - 60] = "-π/3";
            gdb[200 - 75] = "-5π/12";
            gdb[200 - 90] = "-π/2";
            gdb[200 - 105] = "-7π/12";
            gdb[200 - 120] = "-2π/3";
            gdb[200 - 135] = "-3π/4";
            gdb[200 - 150] = "-5π/6";
            gdb[200 - 165] = "-11π/12";
            gdb[200 - 180] = "-π";

            tu[15 + 200] = "π";
            tu[30 + 200] = "π";
            tu[45 + 200] = "π";
            tu[60 + 200] = "π";
            tu[75 + 200] = "5π";
            tu[90 + 200] = "π";
            tu[105 + 200] = "7π";
            tu[120 + 200] = "2π";
            tu[135 + 200] = "3π";
            tu[150 + 200] = "5π";
            tu[165 + 200] = "11π";
            tu[180 + 200] = "π";

            tu[195 + 200] = "13π";
            tu[210 + 200] = "7π";
            tu[225 + 200] = "5π";
            tu[240 + 200] = "4π";
            tu[255 + 200] = "17π";
            tu[270 + 200] = "3π";
            tu[285 + 200] = "19π";
            tu[300 + 200] = "5π";
            tu[315 + 200] = "7π";
            tu[330 + 200] = "11π";
            tu[345 + 200] = "23π";
            tu[360 + 200] = "2π";

            tu[-15 + 200] = "-π";
            tu[-30 + 200] = "-π";
            tu[-45 + 200] = "-π";
            tu[-60 + 200] = "-π";
            tu[-75 + 200] = "-5π";
            tu[-90 + 200] = "-π";
            tu[-105 + 200] = "-7π";
            tu[-120 + 200] = "-2π";
            tu[-135 + 200] = "-3π";
            tu[-150 + 200] = "-5π";
            tu[-165 + 200] = "-11π";
            tu[-180 + 200] = "-π";

            mau[15 + 200] = 12;
            mau[30 + 200] = 6;
            mau[45 + 200] = 4;
            mau[60 + 200] = 3;
            mau[75 + 200] = 12;
            mau[90 + 200] = 2;
            mau[105 + 200] = 12;
            mau[120 + 200] = 3;
            mau[135 + 200] = 4;
            mau[150 + 200] = 6;
            mau[165 + 200] = 12;
            mau[180 + 200] = 1;

            mau[-15 + 200] = 12;
            mau[-30 + 200] = 6;
            mau[-45 + 200] = 4;
            mau[-60 + 200] = 3;
            mau[-75 + 200] = 12;
            mau[-90 + 200] = 2;
            mau[-105 + 200] = 12;
            mau[-120 + 200] = 3;
            mau[-135 + 200] = 4;
            mau[-150 + 200] = 6;
            mau[-165 + 200] = 12;
            mau[-180 + 200] = 1;

            mau[195 + 200] = 12;
            mau[210 + 200] = 6;
            mau[225 + 200] = 4;
            mau[240 + 200] = 3;
            mau[255 + 200] = 12;
            mau[270 + 200] = 2;
            mau[285 + 200] = 12;
            mau[300 + 200] = 3;
            mau[315 + 200] = 4;
            mau[330 + 200] = 6;
            mau[345 + 200] = 12;
            mau[360 + 200] = 1;

        }

        public Boolean timthay(int x)
        {
            for (int i =0; i < 24; i++)
                if (x == db[i])
                {
                    return true;
                }
            return false;
        }

        public double a, b, c, d,x,x1,x2;
        Docdulieu doc = new Docdulieu();
        public String ngh1 = "", ngh2 = "", ngh3 = "", ngh4 = "";

        string soa = "", sob = "", soc = "";

        public int songhiem,songhiem1,songhiem2;
        public int kt =0;
       

        public void button1_Click(object sender, EventArgs e)
        {
            ngh1 = "";
            ngh2 = "";
            ngh3 = "";
            ngh4 = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label5.Text = "";
            songhiem = 0;
            songhiem1 = 0;
            songhiem2 = 0;
            soa = ""; sob = ""; soc = "";
            if ((textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "") ||
                (radioButton1.Checked == false && radioButton2.Checked == false &&
                radioButton3.Checked == false && radioButton4.Checked == false))
            {
                if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                    MessageBox.Show("Bạn chưa nhập đủ ba số a,b,c!");
                if (radioButton1.Checked == false && radioButton2.Checked == false &&
                    radioButton3.Checked == false && radioButton4.Checked == false)
                    MessageBox.Show("Bạn chưa chọn dạng phương trình!");
            }
            else
            {
                a = doc.chuyen(textBox2.Text);
                b = doc.chuyen(textBox3.Text);
                c = doc.chuyen(textBox4.Text);

                if (radioButton1.Checked == true) ham = "sin";
                if (radioButton2.Checked == true) ham = "cos";
                if (radioButton3.Checked == true) ham = "tan";
                if (radioButton4.Checked == true) ham = "cot";

                if (a == 0)
                {
                    if (b== 0)
                    {
                        if (c == 0)
                        {
                            label5.Text = "Phương trình có vô số nghiệm";
                            kt = 1;
                            d = 1;
                        }
                        else
                        {
                            label5.Text = "Phương trình vô nghiệm";
                            kt = 2;
                            d = 1;
                        }
                    }
                    else
                    {
                        d = 0;
                        x = -c / b;
                        songhiem = 1;
                        if (!((Math.Abs(x) > 1) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                            || ((Math.Abs(x) - Math.PI / 2 <= 0.000000001) && (radioButton3.Checked == true))
                            || ((Math.Abs(x) <= 0.000000001) && (radioButton4.Checked == true)))
                        {
                            songhiem++;
                            if (radioButton1.Checked == true)
                            {

                                if (Math.Round(x,3)  == 1) ngh1 = "x = " + sin1();
                                else
                                if (Math.Round(x,3)  == -1) ngh1 = "x = " + sin_1();
                                else
                                if (Math.Round(x,3)  == 0) ngh1 = "x = " + sin0();
                                else
                                {
                                    songhiem++;
                                    double y = Math.Asin(x) * 180 / Math.PI;
                                    int y1 = new int();

                                    if (int.TryParse(Math.Round(y,3).ToString(), out y1))
                                    {
                                        if (timthay(y1))
                                        {
                                            ngh1 = "x = " + gdb[y1 + 200]+ " + k2π";
                                            ngh2 = "x = " + gdb[180 - y1 + 200] + " + k2π";
                                        }
                                        else
                                        {
                                            ngh1 = "x = " + "arcsin(" + Math.Round(x, 3) + ") + k2π";
                                            ngh2 = "x = " + "π - arcsin(" + Math.Round(x, 3) + ") + k2π";
                                        }
                                    }
                                    else
                                    {
                                        ngh1 = "x = " + "arcsin(" + Math.Round(x, 3) + ") + k2π";
                                        ngh2 = "x = " + "π - arcsin(" + Math.Round(x, 3) + ") + k2π";
                                    }
                                }
                            }

                            if (radioButton2.Checked == true)
                            {
                                if (Math.Round(x,3)  == 1) ngh1 = "x = " + cos1();
                                else
                                if (Math.Round(x,3)  == -1) ngh1 = "x = " + cos_1();
                                else
                                if (Math.Round(x,3)  == 0) ngh1 = "x = " + cos0();
                                else
                                {
                                    songhiem++;
                                    double y = Math.Acos(x) * 180 / Math.PI;
                                    int y1 = new int();
                                    if (int.TryParse(Math.Round(y,3).ToString(), out y1))
                                    {
                                        if (timthay(y1))
                                        {
                                            ngh1 = "x = " + gdb[y1 + 200]+ " + k2π";
                                            ngh2 = "x = " + gdb[ - y1 + 200] + " + k2π";
                                        }
                                        else
                                        {
                                            ngh1 = "x = " + "arccos(" + Math.Round(x, 3) + ") + k2π";
                                            ngh2 = "x = " + "π - arccos(" + Math.Round(x, 3) + ") + k2π";
                                        }
                                    }
                                    else
                                    {
                                        ngh1 = "x = " + "arccos(" + Math.Round(x, 3) + ") + k2π";
                                        ngh2 = "x = " + "π - arccos(" + Math.Round(x, 3) + ") + k2π";
                                    }
                                }
                            }

                            if (radioButton3.Checked == true)
                            {
                                if (Math.Round(x,3)  == 0) ngh1 = "x = " + sin0();
                                else
                                {
                                    double y = Math.Atan(x) * 180 / Math.PI;
                                    int y1 = new int();
                                    if (int.TryParse(Math.Round(y,3).ToString(), out y1))
                                    {
                                        if (timthay(y1))
                                        {
                                            ngh1 = "x = " + gdb[y1 + 200]+ " + kπ";
                                        }
                                        else
                                        {
                                            ngh1 = "x = " + "arctan(" + Math.Round(x, 3) + ") + kπ";
                                        }
                                    }
                                    else
                                    {
                                        ngh1 = "x = " + "arctan(" + Math.Round(x, 3) + ") + kπ";
                                    }
                                }
                            }

                            if (radioButton4.Checked == true)
                            {
                                if (Math.Round(x,3)  == 0) ngh1 = "x = " + cos0();
                                else
                                {
                                    double y = Math.Atan(1/x) * 180 / Math.PI;
                                    int y1 = new int();
                                    if (int.TryParse(Math.Round(y,3).ToString(), out y1))
                                    {
                                        if (timthay(y1))
                                        {
                                            ngh1 = "x = " + gdb[y1 + 200]+ " + kπ";
                                        }
                                        else
                                        {
                                            ngh1 = "x = " + "arccot(" + Math.Round(x, 3) + ") + kπ";
                                        }
                                    }
                                    else
                                    {
                                        ngh1 = "x = " + "arccot(" + Math.Round(x, 3) + ") + kπ";
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    d = b * b - 4 * a * c;
                    if (d < 0)
                    {
                        vonghiem();
                        songhiem = 0;
                    }
                    else
                    if (d == 0)
                    {
                        x = -b / (2 * a);
                        songhiem = 1;
                        if (!((Math.Abs(x) > 1) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                            || ((Math.Abs(x) - Math.PI / 2 <= 0.000000001) && (radioButton3.Checked == true))
                            || ((Math.Abs(x) <= 0.000000001) && (radioButton4.Checked == true)))
                        {
                            songhiem++;
                            if (radioButton1.Checked == true)
                            {

                                if (Math.Round(x,3)  == 1) ngh1 = "x = " + sin1();
                                else
                                if (Math.Round(x,3)  == -1) ngh1 = "x = " + sin_1();
                                else
                                if (Math.Round(x,3)  == 0) ngh1 = "x = " + sin0();
                                else
                                {
                                    songhiem++;
                                    double y = Math.Asin(x) * 180 / Math.PI;
                                    int y1 = new int();

                                    if (int.TryParse(Math.Round(y,3).ToString(), out y1))
                                    {
                                        if (timthay(y1))
                                        {
                                            ngh1 = "x = " + gdb[y1 + 200]+ " + k2π";
                                            ngh2 = "x = " + gdb[180 - y1 + 200] + " + k2π";
                                        }
                                        else
                                        {
                                            ngh1 = "x = " + "arcsin(" + Math.Round(x, 3) + ") + k2π";
                                            ngh2 = "x = " + "π - arcsin(" + Math.Round(x, 3) + ") + k2π";
                                        }
                                    }
                                    else
                                    {
                                        ngh1 = "x = " + "arcsin(" + Math.Round(x, 3) + ") + k2π";
                                        ngh2 = "x = " + "π - arcsin(" + Math.Round(x, 3) + ") + k2π";
                                    }
                                }
                            }

                            if (radioButton2.Checked == true)
                            {
                                if (Math.Round(x,3)  == 1) ngh1 = "x = " + cos1();
                                else
                                if (Math.Round(x,3)  == -1) ngh1 = "x = " + cos_1();
                                else
                                if (Math.Round(x,3)  == 0) ngh1 = "x = " + cos0();
                                else
                                {
                                    songhiem++;
                                    double y = Math.Acos(x) * 180 / Math.PI;
                                    int y1 = new int();
                                    if (int.TryParse(Math.Round(y,3).ToString(), out y1))
                                    {
                                        if (timthay(y1))
                                        {
                                            ngh1 = "x = " + gdb[y1 + 200]+ " + k2π";
                                            ngh2 = "x = " + gdb[ - y1 + 200] + " + k2π";
                                        }
                                        else
                                        {
                                            ngh1 = "x = " + "arccos(" + Math.Round(x, 3) + ") + k2π";
                                            ngh2 = "x = " + "π - arccos(" + Math.Round(x, 3) + ") + k2π";
                                        }
                                    }
                                    else
                                    {
                                        ngh1 = "x = " + "arccos(" + Math.Round(x, 3) + ") + k2π";
                                        ngh2 = "x = " + "π - arccos(" + Math.Round(x, 3) + ") + k2π";
                                    }
                                }
                            }

                            if (radioButton3.Checked == true)
                            {
                                if (Math.Round(x,3)  == 0) ngh1 = "x = " + sin0();
                                else
                                {
                                    double y = Math.Atan(x) * 180 / Math.PI;
                                    int y1 = new int();
                                    if (int.TryParse(Math.Round(y,3).ToString(), out y1))
                                    {
                                        if (timthay(y1))
                                        {
                                            ngh1 = "x = " + gdb[y1 + 200]+ " + kπ";
                                        }
                                        else
                                        {
                                            ngh1 = "x = " + "arctan(" + Math.Round(x, 3) + ") + kπ";
                                        }
                                    }
                                    else
                                    {
                                        ngh1 = "x = " + "arctan(" + Math.Round(x, 3) + ") + kπ";
                                    }
                                }
                            }

                            if (radioButton4.Checked == true)
                            {
                                if (Math.Round(x,3)  == 0) ngh1 = "x = " + cos0();
                                else
                                {
                                    double y = Math.Atan(1/x) * 180 / Math.PI;
                                    int y1 = new int();
                                    if (int.TryParse(Math.Round(y,3).ToString(), out y1))
                                    {
                                        if (timthay(y1))
                                        {
                                            ngh1 = "x = " + gdb[y1 + 200]+ " + kπ";
                                        }
                                        else
                                        {
                                            ngh1 = "x = " + "arccot(" + Math.Round(x, 3) + ") + kπ";
                                        }
                                    }
                                    else
                                    {
                                        ngh1 = "x = " + "arccot(" + Math.Round(x, 3) + ") + kπ";
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        x1 = (-b + Math.Sqrt(d)) / (2 * a);
                        x2 = (-b - Math.Sqrt(d)) / (2 * a);
                        if (!((Math.Abs(x1) > 1) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                            || ((Math.Abs(x1) - Math.PI / 2 <= 0.000000001) && (radioButton3.Checked == true))
                            || ((Math.Abs(x1) <= 0.000000001) && (radioButton4.Checked == true)))
                        {
                            songhiem1++;

                            if (radioButton1.Checked == true)
                            {
                                if (Math.Round(x1,3) ==  1) ngh1 = "x = " + sin1();
                                else
                                if (Math.Round(x1,3) ==  -1) ngh1 = "x = " + sin_1();
                                else
                                if (Math.Round(x1,3) ==  0) ngh1 = "x = " + sin0();
                                else
                                {
                                    songhiem1++;

                                    double y = Math.Asin(x1) * 180 / Math.PI;
                                    int y1 = new int();
                                    if (int.TryParse(Math.Round(y,3).ToString(), out y1))
                                    {
                                        if (timthay(y1))
                                        {
                                            ngh1 = "x = " + gdb[y1 + 200]+ " + k2π";
                                            ngh2 = "x = " + gdb[180 - y1 + 200] + " + k2π";
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
                                if (Math.Round(x1,3) ==  1) ngh1 = "x = " + cos1();
                                else
                                if (Math.Round(x1,3) ==  -1) ngh1 = "x = " + cos_1();
                                else
                                if (Math.Round(x1,3) ==  0) ngh1 = "x = " + cos0();
                                else
                                {
                                    songhiem1++;

                                    double y = Math.Acos(x1) * 180 / Math.PI;
                                    int y1 = new int();
                                    if (int.TryParse(Math.Round(y,3).ToString(), out y1))
                                    {
                                        if (timthay(y1))
                                        {
                                            ngh1 = "x = " + gdb[y1 + 200]+ " + k2π";
                                            ngh2 = "x = " + gdb[ - y1 + 200] + " + k2π";
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
                                if (Math.Round(x1,3) ==  0) ngh1 = "x = " + sin0();
                                else
                                {
                                    double y = Math.Atan(x1) * 180 / Math.PI;
                                    int y1 = new int();
                                    if (int.TryParse(Math.Round(y,3).ToString(), out y1))
                                    {
                                        if (timthay(y1))
                                        {
                                            ngh1 = "x = " + gdb[y1 + 200]+ " + kπ";
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
                                if (Math.Round(x1,3) ==  0) ngh1 = "x = " + cos0();
                                else
                                {
                                    double y = Math.Atan(1/x1) * 180 / Math.PI;
                                    int y1 = new int();
                                    if (int.TryParse(Math.Round(y,3).ToString(), out y1))
                                    {
                                        if (timthay(y1))
                                        {
                                            ngh1 = "x = " + gdb[y1 + 200]+ " + kπ";
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
                        if (!((Math.Abs(x2) > 1) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                            || ((Math.Abs(x2) - Math.PI / 2 <= 0.000000001) && (radioButton3.Checked == true))
                            || ((Math.Abs(x2) <= 0.000000001) && (radioButton4.Checked == true)))
                        {
                            if (radioButton1.Checked == true)
                            {
                                songhiem2++;
                                if (Math.Round(x2,3) ==  1) ngh3 = "x = " + sin1();
                                else
                                if (Math.Round(x2,3) ==  -1) ngh3 = "x = " + sin_1();
                                else
                                if (Math.Round(x2,3) ==  0) ngh3 = "x = " + sin0();
                                else
                                {
                                    songhiem2++;
                                    double y = Math.Asin(x2) * 180 / Math.PI;
                                    int y1 = new int();
                                    if (int.TryParse(Math.Round(y,3).ToString(), out y1))
                                    {
                                        if (timthay(y1))
                                        {
                                            ngh3 = "x = " + gdb[y1 + 200]+ " + k2π";
                                            ngh4 = "x = " + gdb[180 - y1 + 200] + " + k2π";
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
                                if (Math.Round(x2,3) ==  1) ngh3 = "x = " + cos1();
                                else
                                if (Math.Round(x2,3) ==  -1) ngh3 = "x = " + cos_1();
                                else
                                if (Math.Round(x2,3) ==  0) ngh3 = "x = " + cos0();
                                else
                                {
                                    songhiem2++;
                                    double y = Math.Acos(x2) * 180 / Math.PI;
                                    int y1 = new int();
                                    if (int.TryParse(Math.Round(y,3).ToString(), out y1))
                                    {
                                        if (timthay(y1))
                                        {
                                            ngh3 = "x = " + gdb[y1 + 200]+ " + k2π";
                                            ngh4 = "x = " + gdb[ - y1 + 200] + " + k2π";
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
                                if (Math.Round(x2,3) ==  0) ngh3 = "x = " + sin0();
                                else
                                {
                                    double y = Math.Atan(x2) * 180 / Math.PI;
                                    int y1 = new int();
                                    if (int.TryParse(Math.Round(y,3).ToString(), out y1))
                                    {
                                        if (timthay(y1))
                                        {
                                            ngh3 = "x = " + gdb[y1 + 200]+ " + kπ";
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
                                if (Math.Round(x2,3) ==  0) ngh3 = "x = " + cos0();
                                else
                                {
                                    double y = Math.Atan(1/x2) * 180 / Math.PI;
                                    int y1 = new int();
                                    if (int.TryParse(Math.Round(y,3).ToString(), out y1))
                                    {
                                        if (timthay(y1))
                                        {
                                            ngh3 = "x = " + gdb[y1 + 200]+ " + kπ";
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
                    }
                }

                kq[1] = ngh1;
                kq[2] = ngh2;
                kq[3] = ngh3;
                kq[4] = ngh4;

                for (int i = 1; i<5;i++)
                    for (int j = i+1;j<5;j++)
                        if (kq[i] == "" && kq[j] != "")
                        {
                            kq[i] = kq[j];
                            kq[j] = "";
                        }

                if (ngh1 == "" && ngh2 == "" && ngh3 == "" && ngh4 == "")
                    vonghiem();
                else
                {
                    if (ngh1 != "" || ngh2 != "" || ngh3 != "" || ngh4 != "")
                        label5.Text = "Phương trình có nghiệm:";
                    label6.Text = kq[1];
                    label7.Text = kq[2];
                    label8.Text = kq[3];
                    label9.Text = kq[4];
                    label10.Text = "(với k là số nguyên)";
                }
                if (label5.Text != "Vui lòng nhập các số a,b,c"
                    && label5.Text != "Vui lòng chọn loại phương trình")
                {
                    Button button2 = new Button();
                    button2.Text = "Lời giải chi tiết";
                    button2.Font = button1.Font;
                    button2.Location = new Point(415, 180);
                    button2.AutoSize = true;
                    this.Controls.Add(button2);
                    button2.Click += Button2_Click;
                    this.AcceptButton = button2;

                    button4.Text = "Đồ thị";
                    button4.Font = button1.Font;
                    button4.Location = new Point(415, 220);
                    button4.Size = new Size(128,36);
                    this.Controls.Add(button4);
                    button4.Click += Button4_Click;
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            TestGraph dothi = new TestGraph();
            Label[] diem = new Label[700];

            if (a >= 0)
                if (Math.Round(a, 3) != 1) soa = Math.Round(a, 3) + "";
            if (a <= 0)
                if (Math.Round(a, 3) != -1) soa = "-" + Math.Round(-a, 3) + "";
                else soa = "- ";
            if (b >= 0)
                if (Math.Round(b, 3) != 1) sob = " + " + Math.Round(b, 3);
                else sob = "+ ";
            if (b <= 0)
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
                int y = (int)Math.Round(30 * (a * x * x + b * x + c));
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
                        them[j].Location = new Point(i - 1, j-1);
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
                int y = (int)Math.Round(30 * (a*x * x + b * x + c));
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

            lg[1].Text = " Đồ thị hàm số y = " + soa;
            lg[1].Location = new Point(30, 610);

            PictureBox pt = new PictureBox();
            if (radioButton1.Checked) pt.Image = Properties.Resources.sinb;
            if (radioButton2.Checked) pt.Image = Properties.Resources.cosb;
            if (radioButton3.Checked) pt.Image = Properties.Resources.tanb;
            if (radioButton4.Checked) pt.Image = Properties.Resources.cotb;
            pt.Size = new Size(62, 25);
            pt.Location = new Point(70 + lg[1].Size.Width, 607);
            dothi.Controls.Add(pt);

            lg[2].Text = sob + ham + soc;
            lg[2].Location = new Point(70 + lg[1].Width + pt.Width,610);

            lg[3].Text = "Tập xác định D = ";
            lg[3].Location = new Point(40, 640);

            lg[4].Text = "R";
            lg[4].Font = new Font("Euclid Math Two", 12, FontStyle.Bold);
            lg[4].Location = new Point(65 + lg[3].Width,637);

            if (radioButton3.Checked)
            {
                lg[6].Text = "\\ { π/2 + kπ | k ∈       }";
                lg[6].Location = new Point(85 + lg[3].Width , 640);

                lg[5].Text = "Z";
                lg[5].Font = new Font("Euclid Math Two",12, FontStyle.Bold);
                lg[5].Location = new Point(115 + lg[3].Width + lg[6].Width,637);
            }
            
            if (! radioButton4.Checked)
            {
                lg[7].Text = "Điểm cắt trục tung: (0, ";
                lg[7].Location = new Point(40, 670);

                if (radioButton1.Checked)
                    lg[7].Text += Math.Round(c,3) + " )";
                if (radioButton2.Checked)
                    lg[7].Text += Math.Round(a + b + c).ToString() + " )";
                if (radioButton3.Checked)
                    lg[7].Text += Math.Round(c,3) + " )";
            }

            for (int i = 1; i < 20; i++)
                dothi.Controls.Add(lg[i]);

            dothi.vetruc();
            dothi.Size = new Size(60,740);
            dothi.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            taoForm();
        }

        public string ham;

        void taoForm()
        {
            LoiGiai loigiai = new LoiGiai();
            loigiai.AutoSize = true;

            Label mau = new Label();
            mau.Font = new Font("VNF-Comic Sans", 12);

            if (a >= 0)
                if (Math.Round(a, 3) != 1) soa = Math.Round(a, 3) + "";
            if (a < 0)
                if (Math.Round(a, 3) != -1) soa = "-" + Math.Round(-a, 3) + "";
                else soa = "- ";
            if (b >= 0)
                if (Math.Round(b, 3) != 1) sob = " + " + Math.Round(b, 3) + "t ";
                else sob = "+ t ";
            if (b < 0)
                if (Math.Round(b, 3) != -1) sob = "- " + Math.Round(-b, 3) + "t ";
                else sob = "- t ";
            if (c > 0) soc = "+ " + Math.Round(c, 3);
            if (c < 0) soc = "- " + Math.Round(-c, 3);

            PictureBox pt = new PictureBox();
            loigiai.Controls.Add(pt);

            for (int i =1;i<11;i++)
            {
                lg[i] = new Label();
                lg[i].Font = mau.Font;
                lg[i].AutoSize = true;
                loigiai.Controls.Add(lg[i]);
            }
           
            lg[1].Text = "Đặt t = " + ham + "(x)";
            lg[1].Location = new Point(20, 20);
            if (ham == "sin" || ham == "cos") lg[1].Text = lg[1].Text + "  (|t| <= 1), ta được:";
            else lg[1].Text = lg[1].Text + ",ta được: ";

            lg[2].Text = soa;// + sob + soc + " = 0  (1)";
            lg[2].Location = new Point(30, 45);

            pt.Image = Properties.Resources.tbinh;
            pt.Size = new Size(23,23);
            pt.Location = new Point(25 + lg[2].Width, 43);

            lg[2].Text = lg[2].Text + "    " + sob + soc + " = 0";
                
            lg[3].Text = "Giải (1) ta được:";
            lg[3].Location = new Point(20, 70);

            if (d < 0)
            {
                lg[4].Text = "Phương trình (1) vô nghiệm => (*) vô nghiệm";
                lg[4].Location = new Point(30, 95);
            }
            else
            if (d == 0)
            {
                lg[4].Location = new Point(30, 95);
                lg[4].Text = "t = " + Math.Round(x,4) + " => " + ham + "(x) = " + Math.Round(x, 4);

                if (((Math.Abs(x) > 1) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                      || ((Math.Abs(x) - Math.PI / 2 <= 0.000000001) && (radioButton3.Checked == true))
                      || ((Math.Abs(x) <= 0.000000001) && (radioButton4.Checked == true)))
                {
                    lg[4].Text = lg[4].Text + "  (loại) ";
                    lg[10].Location = new Point(20, 120);
                    lg[10].Text = "=> (*) vô nghiệm";
                }
                else
                {
                    lg[10].Location = new Point(20, 120);
                    lg[10].Text = "=> Nghiệm của (*) là: ";
                }

                lg[6].Location = new Point(30, 145);
                lg[6].Text = ngh1;

                

                if (songhiem >= 2)
                {
                    lg[7].Location = new Point(30, 170);
                    lg[7].Text = ngh2;
                }
            }
            else
            if (d >0)
            {
                if (kt==1)
                {
                    lg[4].Location = new Point(30, 95);
                    lg[4].Text = "(1) có vô số nghiệm";

                    lg[5].Location = new Point(30, 120);
                    lg[5].Text = "(vì a,b,c = 0)";

                    lg[10].Location = new Point(20, 145);
                    lg[10].Text = "=> (*) có vô số nghiệm x = arc" + ham + "(t)";
                    if (ham == "sin" || ham == "cos") lg[10].Text = lg[10].Text + "  (|t| <= 1)";
                }
                else
                if (kt==2)
                {
                    lg[4].Location = new Point(30, 95);
                    lg[4].Text = "(1) vô nghiệm";

                    lg[5].Location = new Point(30, 120);
                    lg[5].Text = "(vì a,b = 0, c ≠ 0)";

                    lg[10].Location = new Point(20, 145);
                    lg[10].Text = "=> (*) vô nghiệm";
                }
                else
                {
                    lg[4].Location = new Point(30, 95);
                    lg[4].Text = "t1 = " + Math.Round(x1, 4) + " => " + ham + "(x) = " + Math.Round(x1, 4);

                    if (((Math.Abs(x1) > 1) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                        || (Math.Abs(x1) - Math.PI / 2 <= 0.000000001) && (radioButton3.Checked == true)
                          || ((Math.Abs(x1) <= 0.000000001) && (radioButton4.Checked == true)))
                        lg[4].Text = lg[4].Text + "  (loại) ";

                    lg[5].Location = new Point(30, 120);
                    lg[5].Text = "t2 = " + Math.Round(x2, 4) + " => " + ham + "(x) = " + Math.Round(x2, 4);

                    if (((Math.Abs(x2) > 1) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                          || ((Math.Abs(x2) - Math.PI / 2 <= 0.000000001) && (radioButton3.Checked == true))
                          || ((Math.Abs(x2) <= 0.000000001) && (radioButton4.Checked == true)))
                        lg[5].Text = lg[5].Text + "  (loại) ";

                    if ((((Math.Abs(x1) > 1) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                        || (Math.Abs(x1) - Math.PI / 2 <= 0.000000001) && (radioButton3.Checked == true)
                          || ((Math.Abs(x1) <= 0.000000001) && (radioButton4.Checked == true))) &&
                          (((Math.Abs(x2) > 1) && ((radioButton1.Checked == true) || (radioButton2.Checked == true)))
                          || ((Math.Abs(x2) - Math.PI / 2 <= 0.000000001) && (radioButton3.Checked == true))
                          || ((Math.Abs(x2) <= 0.000000001) && (radioButton4.Checked == true))))
                    {
                        lg[10].Location = new Point(20, 145);
                        lg[10].Text = "=> (*) vô nghiệm";
                    }
                    else
                    {
                        lg[10].Location = new Point(20, 145);
                        lg[10].Text = "=> Nghiệm của (*) là: ";
                    }

                    lg[6].Location = new Point(30, 170);
                    lg[6].Text = kq[1];

                    if (songhiem1 >= 2)
                    {
                        lg[7].Location = new Point(30, 195);
                        lg[7].Text = kq[2];
                    }

                    lg[8].AutoSize = true;
                    lg[8].Location = new Point(30, 220);
                    lg[8].Text = kq[3];
                
                    if (songhiem2 >= 2)
                    {
                        lg[9].Location = new Point(30, 245);
                        lg[9].Text = kq[4];
                    }
                }
            }

            Button button3 = new Button();
            button3.Text = "Hướng dẫn giải tổng quát";
            button3.Font = button1.Font;
            button3.Size = new Size(200,40);
            button3.Location = new Point(40,280);
            loigiai.Controls.Add(button3);
            button3.Click += Button3_Click;

            loigiai.Size = new Size(350, 404);
            loigiai.AutoSize = true;
            loigiai.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
             HuongDan1 huongdan = new HuongDan1();
            huongdan.ShowDialog();
        }
    }
}
