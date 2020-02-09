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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        Docdulieu doc = new Docdulieu();
        Form1 giai = new Form1();
        string ngh1 = "", ngh2 = "";
        double x;

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
                MessageBox.Show("Bạn chưa nhập số y");
            else
            {
                x =  doc.chuyen(textBox1.Text);
                if (Math.Abs(Math.Round(x, 3)) <= 1)
                {
                    if (Math.Round(x, 3) == 1)
                        ngh1 = "x =  π/2 + k2π";
                    else
                    if (Math.Round(x, 3) == -1)
                        ngh2 = "x =  -π/2 + k2π";
                    else
                    if (Math.Round(x, 3) == 0)
                        ngh2 = "x =  kπ";
                    else
                    {
                        double y = Math.Asin(x) * 180 / Math.PI;
                        int y1 = new int();

                        if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
                        {
                            if (giai.timthay(y1))
                            {
                                ngh1 = "x =  " + giai.gdb[y1 + 200] + " + k2π";
                                ngh2 = "x =  " + giai.gdb[180 - y1 + 200] + " + k2π";
                            }
                            else
                            {
                                ngh1 = "x =  " + "arcsin(" + Math.Round(x, 3) + ") + k2π";
                                ngh2 = "x =  " + "π - arcsin(" + Math.Round(x, 3) + ") + k2π";
                            }
                        }
                        else
                        {
                            ngh1 = "x =  " + "arcsin(" + Math.Round(x, 3) + ") + k2π";
                            ngh2 = "x =  " + "π - arcsin(" + Math.Round(x, 3) + ") + k2π";
                        }
                    }
                }
                else ngh1 = "       Vô nghiệm";

                label3.Text = ngh1;
                label4.Text = ngh2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                MessageBox.Show("Bạn chưa nhập số y");
            else
            {
                x =  doc.chuyen(textBox2.Text);
                if (Math.Abs(Math.Round(x, 4)) <= 1)
                {
                    if (Math.Round(x, 3) == 1) ngh1 = "x =  k2π";
                    else
                    if (Math.Round(x, 3) == -1) ngh1 = "x =  π + k2π";
                    else
                    if (Math.Round(x, 3) == 0) ngh1 = "x =  π/2 + kπ";
                    else
                    {
                        double y = Math.Acos(x) * 180 / Math.PI;
                        int y1 = new int();
                        if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
                        {
                            if (giai.timthay(y1))
                            {
                                ngh1 = "x =  " + giai.gdb[y1 + 200] + " + k2π";
                                ngh2 = "x =  " + giai.gdb[-y1 + 200] + " + k2π";
                            }
                            else
                            {
                                ngh1 = "x =  " + "arccos(" + Math.Round(x, 3) + ") + k2π";
                                ngh2 = "x =  " + "π - arccos(" + Math.Round(x, 3) + ") + k2π";
                            }
                        }
                        else
                        {
                            ngh1 = "x =  " + "arccos(" + Math.Round(x, 3) + ") + k2π";
                            ngh2 = "x =  " + "π - arccos(" + Math.Round(x, 3) + ") + k2π";
                        }
                    }
                }
                else ngh1 = "       Vô nghiệm";

                label7.Text = ngh1;
                label10.Text = ngh2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
                MessageBox.Show("Bạn chưa nhập số y");
            else
            {
                x =  doc.chuyen(textBox3.Text);
                if (Math.Round(x, 3) == 0) ngh1 = "x =  kπ";
                else
                {
                    double y = Math.Atan(x) * 180 / Math.PI;
                    int y1 = new int();
                    if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
                    {
                        if (giai.timthay(y1))
                        {
                            ngh1 = "x =  " + giai.gdb[y1 + 200] + " + kπ";
                        }
                        else
                        {
                            ngh1 = "x =  " + "arctan(" + Math.Round(x, 3) + ") + kπ";
                        }
                    }
                    else
                    {
                        ngh1 = "x =  " + "arctan(" + Math.Round(x, 3) + ") + kπ";
                    }
                }
            }

            label13.Text = ngh1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
                MessageBox.Show("Bạn chưa nhập số y");
            else
            {
                x =  doc.chuyen(textBox4.Text);
                if (Math.Round(x, 3) == 0) ngh1 = "x =   kπ";
                else
                {
                    double y = Math.Atan(1 / x) * 180 / Math.PI;
                    int y1 = new int();
                    if (int.TryParse(Math.Round(y, 3).ToString(), out y1))
                    {
                        if (giai.timthay(y1))
                        {
                            ngh1 = "x =  " + giai.gdb[y1 + 200] + " + kπ";
                        }
                        else
                        {
                            ngh1 = "x =  " + "arccot(" + Math.Round(x, 3) + ") + kπ";
                        }
                    }
                    else
                    {
                        ngh1 = "x =  " + "arccot(" + Math.Round(x, 3) + ") + kπ";
                    }
                }
            }

            label14.Text = ngh1;
        }

    }
}
