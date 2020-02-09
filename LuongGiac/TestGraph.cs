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
    public partial class TestGraph : Form
    {
        public TestGraph()
        {
            InitializeComponent();

            //for (int i = 300; i < 601; i++)
            //{
            //    diem[299] = new Label();
            //    diem[i] = new Label();
            //    double x = i - 300;
            //    x = Math.Tan(x / 30);
            //    int y = (int)Math.Round(30 *x);
            //    diem[i].Size = new Size(3, 3);
            //    diem[i].Location = new Point((int)i - 1, 300 - y - 1);
            //    diem[i].BackColor = Color.Blue;
            //    if (300 - y - 1 < 601) this.Controls.Add(diem[i]);

            //    int y1, y2, tm;
            //    y1 = diem[i].Location.Y;
            //    y2 = diem[i-1].Location.Y;
            //    if (y1 < y2)
            //    {
            //        tm = y2;
            //        y2 = y1;
            //        y1 = tm;
            //    }
            //    if (Math.Abs(y1 - y2) > 3 && i != 300 && y1 < 700 && y2 > -200)
            //    {
            //        Label[] them = new Label[700];
            //        if (y2 < 10) y2 = 10;
            //        if (y1 > 590) y1 = 590;
            //        for (int j = y2; j < y1 ; j++)
            //        {
            //            them[j] = new Label();
            //            them[j].BackColor = Color.Blue;
            //            them[j].Size = new Size(3, 3);
            //            them[j].Location = new Point(i - 1, j);
            //            this.Controls.Add(them[j]);
            //        }
            //    }
            //}

            //for (int i = 300; i > 10; i--)
            //{
            //    diem[i] = new Label();
            //    double x = i - 300;
            //    x = Math.Tan(x / 30);
            //    int y = (int)Math.Round(30*x);
            //    diem[i].Size = new Size(3, 3);
            //    diem[i].Location = new Point((int)i - 1, 300 - y - 1);
            //    diem[i].BackColor = Color.Blue;
            //    if (300 - y - 1 < 601) this.Controls.Add(diem[i]);

            //    int y1, y2, tm;
            //    y1 = diem[i].Location.Y;
            //    y2 = diem[i + 1].Location.Y;
            //    if (y1 < y2)
            //    {
            //        tm = y2;
            //        y2 = y1;
            //        y1 = tm;
            //    }
            //    if (Math.Abs(y1 - y2) > 3 && i != 300 && y1 < 700 && y2 > -200)
            //    {
            //        Label[] them = new Label[700];
            //        if (y2 < 10) y2 = 10;
            //        if (y1 > 590) y1 = 590;
            //        for (int j = y2; j < y1; j++)
            //        {
            //            them[j] = new Label();
            //            them[j].BackColor = Color.Blue;
            //            them[j].Size = new Size(3, 3);
            //            them[j].Location = new Point(i - 1, j);
            //            this.Controls.Add(them[j]);
            //        }
            //    }
            //}

            //vetruc();
        }

        Label[] diem = new Label[1200];

        public void vetruc()
        {
            for (int i = 300; i < 601; i++)
            {
                if ((i) % 30 != 0)
                {
                    Label cot = new Label();
                    cot.BackColor = Color.Black;
                    cot.Size = new Size(1, 1);
                    cot.Location = new Point(i, 300);
                    this.Controls.Add(cot);

                    if (i < 590)
                    {
                        Label dong = new Label();
                        dong.BackColor = Color.Black;
                        dong.Size = new Size(1, 1);
                        dong.Location = new Point(300, i);
                        this.Controls.Add(dong);
                    }
                }
                else
                {
                    Label cot = new Label();
                    cot.BackColor = Color.Black;
                    cot.Size = new Size(2, 2);
                    cot.Location = new Point(i, 300);
                    this.Controls.Add(cot);

                    if (i < 590)
                    {
                        Label dong = new Label();
                        dong.BackColor = Color.Black;
                        dong.Size = new Size(2, 2);
                        dong.Location = new Point(300, i);
                        this.Controls.Add(dong);
                    }
                }
            }

            for (int i = 300; i > 1; i--)
            {
                if ((i) % 30 != 0)
                {
                    if (i > 10)
                    {
                        Label cot = new Label();
                        cot.BackColor = Color.Black;
                        cot.Size = new Size(1, 1);
                        cot.Location = new Point(i, 300);
                        this.Controls.Add(cot);
                    }

                    Label dong = new Label();
                    dong.BackColor = Color.Black;
                    dong.Size = new Size(1, 1);
                    dong.Location = new Point(300, i);
                    this.Controls.Add(dong);
                }
                else
                {
                    if (i > 10)
                    {
                        Label cot = new Label();
                        cot.BackColor = Color.Black;
                        cot.Size = new Size(2, 2);
                        cot.Location = new Point(i, 300);
                        this.Controls.Add(cot);
                    }

                    Label dong = new Label();
                    dong.BackColor = Color.Black;
                    dong.Size = new Size(2, 2);
                    dong.Location = new Point(300, i);
                    this.Controls.Add(dong);
                }
            }

            for (int i = 0; i < 19; i++)
            {
                if (i - 9 != 0)
                {
                    Label cot = new Label();
                    cot.Font = new Font("Comic Sans MS", 8);
                    cot.Text = "" + (i - 9);
                    cot.AutoSize = true;
                    cot.Location = new Point(280, 565 - i * 30);
                    this.Controls.Add(cot);
                }

                Label dong = new Label();
                dong.Font = new Font("Comic Sans MS", 8);
                dong.Text = "" + (i - 9);
                dong.AutoSize = true;
                this.Controls.Add(dong);

                //if (i != 9)
                dong.Location = new Point(i * 30 + 30, 305);
                //else
                //    dong.Location = new Point(i * 30 + 25, 305);
            }

            for (int i = 594; i < 601; i++)
            {
                Label tren = new Label();
                tren.BackColor = Color.Black;
                tren.Size = new Size(1, 1);
                tren.Location = new Point(i, i - 300);
                this.Controls.Add(tren);

                Label duoi = new Label();
                duoi.BackColor = Color.Black;
                duoi.Size = new Size(1, 1);
                duoi.Location = new Point(i, 900 - i);
                this.Controls.Add(duoi);
            }

            for (int i = 1; i < 7; i++)
            {
                Label trai = new Label();
                trai.BackColor = Color.Black;
                trai.Size = new Size(1, 1);
                trai.Location = new Point(300 + i, i);
                this.Controls.Add(trai);

                Label phai = new Label();
                phai.BackColor = Color.Black;
                phai.Size = new Size(1, 1);
                phai.Location = new Point(300 - i, i);
                this.Controls.Add(phai);
            }

            Label chy = new Label();
            chy.Text = "y";
            chy.Font = new Font("Comic Sans MS", 8);
            chy.Location = new Point(310, -2);
            chy.Size = new Size(15, 20);
            this.Controls.Add(chy);

            Label chx = new Label();
            chx.Text = "x";
            chx.Font = new Font("Comic Sans MS", 8);
            chx.Location = new Point(605, 290);
            chx.Size = new Size(15, 15);
            this.Controls.Add(chx);
        }
    }
}
