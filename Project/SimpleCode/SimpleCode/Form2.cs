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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtno1.Clear();
            txtno2.Clear();
            txttotal.Clear();

            RdbAdd.Checked = true;
            txtno1.Focus();

        }

        private void btnCalcu_Click(object sender, EventArgs e)
        {
            int no1 = Convert.ToInt32(txtno1.Text);
            int no2 = Convert.ToInt32(txtno2.Text);

            int result = 0;
            if (RdbAdd.Checked == true)
            {
                result = no1 + no2;
            }

            if (RdbSub.Checked == true)
            {
                result = no1 - no2;
            }
            txttotal.Text = result.ToString();

            if (result > 100)
            {
                MessageBox.Show("usman");
            }
        }
    }
}
