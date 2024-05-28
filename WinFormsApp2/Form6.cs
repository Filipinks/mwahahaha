using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class Form6 : Form
    {
        private int num1;
        private int num2;
        public Form6(int n1, int n2)
        {
            InitializeComponent();
            num1 = n1;
            num2 = n2;
        }

        private void calc_Click(object sender, EventArgs e)
        {
            int num3 = Convert.ToInt32(txtbox.Text);
            int prod = num1 * num2;

            if (num3 == prod)
            {
                Form f1 = new Form1();
                this.Hide();
                f1.Show();
            }
            else
            {
                Form f5 = new Form5();
                this.Hide();
                f5.Show();
            }
        }
    }
}


