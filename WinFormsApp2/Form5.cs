using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, sum;
            n1 = Convert.ToInt32(textBox1.Text);
            n2 = Convert.ToInt32(textBox2.Text);
            n3 = Convert.ToInt32(textBox3.Text);

            sum = n1 + n2;

            if (n3 == sum)
            {
                Form f6 = new Form6(n1, n2);
                this.Hide();
                f6.Show();
            }
            else
            {
                MessageBox.Show("WRONG!");
            }
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            this.Hide(); form1.Show();
        }
    }
}

