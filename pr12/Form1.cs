using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !((c >= 'а' && c <= 'я') || c == 'ё' || c == 8 || c == 32);
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxName.Text.Length > 0) && (textBoxPrice.Text.Length > 0) && (Convert.ToInt32(numericUpDownCount.Text) > 0) && (textBoxSale.Text.Length > 0))
            {
                buttonAdd.Enabled = true;
                buttonDelete.Enabled = true;
            }
            else
            {
                buttonAdd.Enabled = false;
                buttonDelete.Enabled = false;
            }
                
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
