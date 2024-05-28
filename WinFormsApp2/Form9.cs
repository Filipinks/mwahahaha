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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Getthataverage_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, n4, ave;

            n1 = int.Parse(nstpcombobox.SelectedItem.ToString());
            n2 = int.Parse(artappcombobox.SelectedItem.ToString());
            n3 = int.Parse(valuecombobox.SelectedItem.ToString());
            n4 = int.Parse(pecombobox.SelectedItem.ToString());

            ave = (n1 + n2 + n3 + n4) / 4;

            label7.Text = ave.ToString();

            if (ave >= 75)
            {
                MessageBox.Show("Average: " + label7.Text + "\nPASSED");
            }
            else
            {
                MessageBox.Show("Average: " + label7.Text + "\nFAILED");
            }
        }

        private void getmeout_Click(object sender, EventArgs e)
        {
            Form f7 = new Form7();
            this.Hide();
            f7.Show();
        }
    }
}

