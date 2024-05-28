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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void averagegetter_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (radioButton1.Checked == true)
            {
                msg = "Semester: 1";
            }
            else if (radioButton2.Checked == true)
            {
                msg = "Semester: 2";
            }

            MessageBox.Show("Name: " + nametextbox.Text + "\nID: " + IDtextbox.Text + "\nDepartment: " + comboBox1.Text + "\n" + msg);
            Form f9 = new Form9();
            this.Hide();
            f9.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
    }

