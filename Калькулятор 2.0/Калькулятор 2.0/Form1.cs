using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Калькулятор_2._0
{
    public partial class Form1 : Form
    {
        static public  bool Lock = false;
        public Form1()
        {
            
            InitializeComponent();
            Panel1.Hide();
            this.Width = 236;            
            {
                MemClearb.Click += new EventHandler(b_mem_click);
                MemSaveb.Click += new EventHandler(b_mem_click);
                MemPlusb.Click += new EventHandler(b_mem_click);
                MemMinusb.Click += new EventHandler(b_mem_click);
                MemReadb.Click += new EventHandler(b_mem_click);
                b0.Click += new EventHandler(b_num_click);
                b1.Click += new EventHandler(b_num_click);
                b2.Click += new EventHandler(b_num_click);
                b3.Click += new EventHandler(b_num_click);
                b4.Click += new EventHandler(b_num_click);
                b5.Click += new EventHandler(b_num_click);
                b6.Click += new EventHandler(b_num_click);
                b7.Click += new EventHandler(b_num_click);
                b8.Click += new EventHandler(b_num_click);
                b9.Click += new EventHandler(b_num_click);
                bend.Click += new EventHandler(b_end_click);
                bplus.Click += new EventHandler(b_click);
                sqrtb.Click += new EventHandler(b_click);
                bminus.Click += new EventHandler(b_click);
                bmult.Click += new EventHandler(b_click);
                bdel.Click += new EventHandler(b_click);
                bprocent.Click += new EventHandler(b_click);               
                berase.Click += new EventHandler(b_erase_click);
                brect.Click += new EventHandler(b_click);
                bdot.Click += new EventHandler(b_click);
                SetPMb.Click += new EventHandler(pm_switch);
                drob.Click += new EventHandler(drob_Click);
                Dateb.Click += new EventHandler(Date_Kalk);
            }
            bclear.Click += new EventHandler(b_clear_click);
        }

        public void Date_Kalk(object sender, EventArgs e)
        {
            TimeSpan date;
            DateTime d1 = DateStart.Value;
            DateTime d2 = DateFin.Value;
            if (d1 < d2)
            {
                 date = d2 - d1;
            }
            else
            {
                 date = d1 - d2;
            }        
            DateBox.Text = String.Format("{0:d} дней",date.Days+1);
        }

        internal static void NullExc()
        {
            Lock = true;           
        }

        private void drob_Click(object sender, EventArgs e)
        {
            if (!CheckLock())
            {
                if (textbox.Text != "")
                {
                    bool check = true;
                    string newText = "";
                    char[] src = textbox.Text.ToCharArray();
                    int pos = src.Length - 1;
                    int i = -1;
                    for (; pos >= 0; pos--)
                    {
                        if (check)
                        {
                            if (!Char.IsDigit(src[pos]) && !RPN.IsSpecSymb(src[pos]))
                            {
                                check = false;
                                i = pos; break;
                            }
                            if (pos == 0)
                            {
                                check = false;
                                i = -1;
                            }
                        }
                    }
                    for (int j = 0; j < src.Length; j++)
                    {
                        if (j == 0 && i == -1) { newText += "1/" + src[j]; }
                        else
                        {
                            if (j == i)
                            {
                                newText += "1/" + src[j];
                            }
                            else
                            {
                                newText += src[j];
                            }
                        }
                    }
                    textbox.Text = newText; 
                }
                else
                { textbox.Text = "1/"; }
            }
        }

        private void pm_switch(object sender, EventArgs e)
        {
            if (!CheckLock())
            {
                if (textbox.Text != "")
                {
                    bool check = true;
                    string newText = "";
                    char[] src = textbox.Text.ToCharArray();
                    int pos = src.Length - 1;
                    int i = -1;
                    for (; pos >= 0; pos--)
                    {
                        if (check)
                        {
                            if (!Char.IsDigit(src[pos]))
                            {
                                check = false;
                                i = pos; break;
                            }
                            if (pos == 0)
                            {
                                check = false;
                                i = -1;
                            }
                        }
                    }
                    for (int j = 0; j < src.Length; j++)
                    {
                        if (j == 0 && i == -1) { newText += "-" + src[0]; }
                        else
                        {
                            if (j == i)
                            {
                                switch (src[j])
                                {

                                    case '+': { newText += "-"; } break;
                                    case '-': { if (j != 0 && !RPN.IsOperand(src[j - 1])) newText += "+"; } break;
                                    default: { newText += src[j] + "-"; } break;
                                }
                            }
                            else
                            {
                                newText += src[j];
                            }
                        }
                    }
                    textbox.Text = newText;
                }
                else
                { textbox.Text = "-"; }
            }
        }

        private void b_mem_click(object sender, EventArgs e)
        {
            if (!CheckLock())
            {
                double b = 0;
                switch ((sender as Button).Tag.ToString())
                {
                    case "C":
                        { MemLabel.Text = ""; }
                        break;
                    case "R":
                        { textbox.Text = MemLabel.Text; }
                        break;
                    case "S":
                        { if (double.TryParse(textbox.Text, out b)) { MemLabel.Text = textbox.Text; } }
                        break;
                    case "+":
                        { MemRewrite('+'); }
                        break;
                    case "-":
                        { MemRewrite('-'); }
                        break;
                }
            }
        }
        private void MemRewrite(char a)
        {
            if (!CheckLock())
            {
                double b;
                if (double.TryParse(textbox.Text, out b) && double.TryParse(MemLabel.Text, out b))
                {
                    double op1 = double.Parse(MemLabel.Text);
                    double op2 = double.Parse(textbox.Text);

                    switch (a)
                    {
                        case '+':
                            {
                                MemLabel.Text = (op1 + op2).ToString();
                            }
                            break;
                        case '-':
                            {
                                MemLabel.Text = (op1 - op2).ToString();
                            }
                            break;
                    }
                }
            }
        }
        private void b_num_click(object sender, EventArgs e)
        {
            if (!CheckLock())
            {
                if (Check_LastSymb(sender))
                { textbox.Text += (sender as Button).Tag; }
            }

        }
        private void b_end_click(object sender, EventArgs e)
        {
            if (!CheckLock())
            {
                string str = textbox.Text;
                string str2 = RPN.Interpritate(str);
                str = RPN.Kalculate(str2);
                textbox.Text = string.Format("{0}", Convert.ToDouble(str));
            }
        }
        private void b_erase_click(object sender, EventArgs e)
        {
            if (!CheckLock())
            {
                if (textbox.Text != "")
                {
                    string str = textbox.Text;
                    char[] strmas = str.ToCharArray();
                    char[] strmaserase = new char[strmas.Length - 1];
                    for (int i = 0; i < strmas.Length - 1; i++)
                    {
                        strmaserase[i] = strmas[i];
                    }
                    textbox.Text = "";
                    for (int i = 0; i < strmas.Length - 1; i++)
                    {
                        textbox.Text += strmaserase[i];
                    }
                }
                else textbox.Text = "";
            }
        }
        private void b_clear_click(object sender, EventArgs e)
        {
            textbox.Text = ""; Lock = false;
        }
        private void b_click(object sender, EventArgs e)
        {
            if (!CheckLock())
            {
                if (Check_LastSymb(sender))
                { textbox.Text += (sender as Button).Tag; }
            }

        }
        private void TSMenu_Click(object sender, EventArgs e)
        {
            if (!CheckLock())
            {
                string mess = "Кунгурцев Александр 19-ИДБо-3б";
                string cap = "Калькулятор";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(mess, cap, button);
            }
        }
        private void DateMode_CheckedChanged(object sender, EventArgs e)
        {
            if (TimeStrip.Checked)
            {
                this.Width = 436;
                Panel1.Show();
            }
            else
            {
                this.Width = 236;
                Panel1.Hide();
            }
        }

        private void form_keydown(object sender, KeyEventArgs e)
        {
            if (!CheckLock())
            {
                if (e.KeyCode == Keys.Enter)
                {
                    bend.PerformClick();
                }
            }
        }
        private bool Check_LastSymb(object sender)
        {
            
            char ch = char.Parse( (sender as Button).Tag.ToString());
            if (RPN.IsOperand(ch) || RPN.IsSpecSymb(ch) || Char.IsDigit(ch))
            {
                if (textbox.Text != "")
                {
                    char[] txt = textbox.Text.ToCharArray();
                    if (!RPN.IsOperand(txt[txt.Length - 1]))
                    {
                        return true;
                    }
                    if (RPN.IsSpecSymb(ch) || Char.IsDigit(ch))
                    {
                        return true;
                    }
                }
                else
                { if (Char.IsDigit(ch)) { return true; } }
            }
            return false;
        }
        private void Check_LastSymb(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            e.Handled = true;
            if (RPN.IsOperand(number) || RPN.IsSpecSymb(number) || Char.IsDigit(number) || number == 8)
            {
                if (textbox.Text != "")
                {
                    char[] txt = textbox.Text.ToCharArray();
                    if (!RPN.IsOperand(txt[txt.Length - 1]))
                    {
                        e.Handled = false;
                    }
                    if (RPN.IsSpecSymb(number) || Char.IsDigit(number))
                    {
                        e.Handled = false;
                    }
                    if (number == 8)
                    { e.Handled = false; }
                }
                else
                { if (Char.IsDigit(number)) { e.Handled = false; } }
            }
        }
        private bool CheckLock()
        {
            return Lock;
        }
    }
}
