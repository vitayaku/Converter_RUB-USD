using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Конвертер_рубли_доллары
{
    public partial class Form1 : Form
    {
        decimal rub, usd;

        public Form1()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= '0' && e.KeyChar <= '9' )||(e.KeyChar == (char)Keys.Back))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = true;
            textBox2.Text = String.Empty;
            textBox1.Text = String.Empty;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox1.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           try
           {
                if (radioButton1.Checked)
                {
                    rub = Convert.ToDecimal(int.Parse(textBox2.Text));
                    textBox1.Text = Convert.ToString(rub /  Convert.ToDecimal(66.16));
                }
                else if(radioButton2.Checked)
                {
                    usd = Convert.ToDecimal(int.Parse(textBox1.Text));
                    textBox2.Text = Convert.ToString(usd * Convert.ToDecimal(66.16));
                }
           }
           catch
           {
                MessageBox.Show("Укажите сумму", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
           }
        }
    }
}
