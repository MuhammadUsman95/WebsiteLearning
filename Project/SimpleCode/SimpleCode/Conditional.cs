using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCode
{
    public partial class Conditional : Form
    {
        public Conditional()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            bool button1;

            if (a > 10)
                button1 = true;
            else
                button1 = false;

            if (button1)
                MessageBox.Show("sucess");
            else
                MessageBox.Show("try again");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int gender = 1;

            comboBox1.Text = (gender == 1) ? "Male" : "Female";

        }

        private void Conditional_Load(object sender, EventArgs e)
        {
            int gender = 1;

            comboBox1.Text = (gender == 3) ? "Male" : "Female";
        }
    }
}
