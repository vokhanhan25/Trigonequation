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
    public partial class Docdulieu : Form
    {
        public Docdulieu()
        {
            //InitializeComponent();

            //chuyen("(62/27+38)(7-4)");
        }

        string st;
        string[] t, s;
        int top,sl;
        int[] p;
        double[] stack;
        bool dautru = false;

        void tinh()
        {

            int i, j;
            string tm1 = " ";
            string tm2 = " ";
            double tm;

            i = 0;
            if (s[i] != "pi")
            {
                while (s[i] == " " || s[i] == null) i++;
                tm1 = s[i].ToString();
                while ((int)s[i + 1][0] >= 48 && (int)s[i + 1][0] <= 57 && i + 1 <= sl)
                {
                    tm1 = tm1 + s[i + 1];
                    i++;
                }
            }
            else tm1 = "pi";
            j = i + 1;
            if (s[j] != "pi")
            {
                while (s[j] == " " && s[j] != null && j < st.Length) j++;
                if (s[j] != null) tm2 = s[j].ToString();
                if (s[j] != null)
                {
                    while ((int)s[j + 1][0] >= 48 && (int)s[j + 1][0] <= 57 && j + 1 <= sl && s[j + 1] != null)
                    {
                        tm2 = tm2 + s[j + 1];
                        j++;
                    }
                }
            }
            else
            {
                tm2 = "pi";
                j++;
            }
            if (tm1 != "pi") stack[1] = Convert.ToDouble(tm1);
            else stack[1] = Math.PI;
            if (tm2 != "pi")
            {
                if (tm2[0] != 's' && tm2 != " " && tm2[0] != 'c' && tm2[0] != 't' && tm2[0] != 'p'
                    && tm2 != "+" && tm2 != "-" && tm2 != "*" && tm2 != "/" && tm2 != "")
                {
                    stack[2] = Convert.ToDouble(tm2);
                    top = 2;
                    i = j + 1;
                }
                else
                {
                    top = 1;
                    i++;
                }
            }
            else
            {
                stack[2] = Math.PI;
                top = 2;
                i = j + 1;
            }
            while (i <= sl)
            {
                if (s[i] == "+")
                {
                    tm = stack[top] + stack[top - 1];
                    stack[top - 1] = tm;
                    top--;
                    i++;
                }
                else
                {
                    if (s[i] == "-")
                    {
                        tm = stack[top - 1] - stack[top];
                        stack[top - 1] = tm;
                        top--;
                        i++;
                    }
                    else
                    {
                        if (s[i] == "*")
                        {
                            tm = stack[top] * stack[top - 1];
                            stack[top - 1] = tm;
                            top--;
                            i++;
                        }
                        else
                        {
                            if (s[i] == "/")
                            {
                                tm = stack[top - 1] / stack[top];
                                stack[top - 1] = tm;
                                top--;
                                i++;
                            }
                            else
                            {
                                if (s[i] == "sqrt")
                                {
                                    tm = Math.Sqrt(stack[top]);
                                    stack[top] = tm;
                                    i++;
                                }
                                else
                                {
                                    if (s[i] == "sin")
                                    {
                                        tm = Math.Sin(stack[top]);
                                        stack[top] = tm;
                                        i++;
                                    }
                                    else
                                    {
                                        if (s[i] == "cos")
                                        {
                                            tm = Math.Cos(stack[top]);
                                            stack[top] = tm;
                                            i = i + 3;
                                        }
                                        else
                                        {
                                            if (s[i] == "tan")
                                            {
                                                tm = Math.Tan(stack[top]);
                                                stack[top] = tm;
                                                i++;
                                            }
                                            else
                                            {
                                                if (s[i] == "cot")
                                                {
                                                    tm = Math.Tan(1 / stack[top]);
                                                    stack[top] = tm;
                                                    i++;
                                                }
                                                else
                                                {
                                                    if (s[i] == "^")
                                                    {
                                                        double coso = stack[top - 1];
                                                        double somu = stack[top];
                                                        tm = coso;
                                                        for (int k = 2; k <= somu; k++)
                                                            tm = tm * somu;
                                                        stack[top - 1] = tm;
                                                        i++;
                                                    }
                                                    else
                                                    {
                                                        if (s[i] != " ")
                                                        {
                                                            top++;
                                                            j = i;
                                                            if (s[i] != "pi")
                                                            {
                                                                tm1 = s[i].ToString();
                                                                while ((int)s[j + 1][0] >= 48 && (int)s[j + 1][0] <= 57 && j + 1 < s.Length - 1)
                                                                {
                                                                    tm1 = tm1 + s[j + 1].ToString();
                                                                    j++;
                                                                }
                                                                i = j + 1;
                                                                stack[top] = Convert.ToDouble(tm1);
                                                            }
                                                            else stack[top] = Math.PI;
                                                        }
                                                        else if (s[i] == " ") i++;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        void chuyen1()
        {
            int i = 0;
            string x = "";
            char ch;

            top = 0;
            while (i <= st.Length-1)
            {
                ch = st[i];
                if (ch == '(')
                {
                    top++;
                    t[top] = st[i].ToString();
                }
                else
                if (ch == ')')
                {
                    do
                    {
                        x = t[top].ToString();
                        top--;
                        if (x != "(")
                        {
                            sl++;
                            s[sl] = x;
                        }
                    }
                    while (x != "(");
                }
                else
                if (ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == 's' || ch == 'c' || ch == 't' || ch == '^')
                {
  
                    while (top > 0  &&  (p[st[i]]  <= p[t[top][0]]))
                    {
                        sl++;
                        s[sl] = t[top];
                        top--;
                    }
                    top++;
                    if ((int)st[i] >= 42 && (int)st[i] <= 47 || st[i] == '^')
                    {
                        t[top] = st[i].ToString();
                    }
                    else
                    {
                        while ((int) st[i] >= 97)
                        {
                            t[top] = t[top] + st[i].ToString();
                            i++;
                        }
                    }
                }
                else
                {
                    sl++;
                    while ((int)st[i] <= 57 && st[i] != ' ')
                    {
                        s[sl] = s[sl] + st[i].ToString();
                        i++;
                    }
                    if (st[i] == 'p' && st[i + 1] == 'i')
                        s[sl] = "pi";
                }
                i++;
            }

            while (top > 0)
            {
                sl++;
                s[sl] = t[top];
                top--;
            }

            sl++;
            s[sl] = " ";
        }

        void themdaucach()
        {
            int i;
            i = 0;
            while (i < st.Length - 1)
            {
                if (((((int)st[i] >= 48 && (int)st[i + 1] < 48) ||
                    ((int)st[i] < 48 && (int)st[i + 1] >= 48)) ||
                    (((int)st[i] >= 58 && (int)st[i + 1] < 58) ||
                    ((int)st[i] < 58 && (int)st[i + 1] >= 58))) &&
                    (st[i] != '.') && st[i+1] != '.')
                {
                    st = st.Insert(i+1, " ");
                    i++;
                }
                i++;
            }
            st = st + " ";
        }

        void themdaunhan()
        {
            int i;
            i = 0;
            while (i < st.Length - 1)
            {
                if ((((int)st[i] >= 49 && (int)st[i] <= 57) || st[i] == ')') &&
                    ((int) st[i+1] >= 97 || st[i+1] == '('))
                    st = st.Insert(i + 1, "*");
                i++;   
            }
        }

        public double chuyen(string de)
        {
            st = de;
            sl = 0;
            top = 0;
            t = new string[100];
            s = new string[100];
            for (int i = 1; i <= 99; i++)
                s[i] = " ";
            p = new int['z'];
            stack = new double[100];
            p['('] = 0;
            p['*'] = 2;
            p['/'] = 2;
            p['+'] = 1;
            p['-'] = 1;
            p['s'] = 3;
            p['c'] = 3;
            p['t'] = 3;
            p['p'] = 3;
            p['^'] = 3;
            int j = 0;
            while (j < st.Length && st[j] == ' ') j++;
            if (st[j] == '-')
            {
                string stn = "";
                for (int i = j; i < st.Length; i++)
                    stn = stn + st[i].ToString();
                st = stn;
                dautru = true;
            }
            else dautru = false;
            themdaunhan();
            themdaucach();
            chuyen1();
            tinh();
            double d = stack[1];
            if (dautru) d = -d;
            return d;
        }
    }
}
