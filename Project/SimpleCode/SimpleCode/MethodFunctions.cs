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
    public partial class MethodFunctions : Form
    {
        public MethodFunctions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usman","Message Box" , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Message("sdfsdf  ");
        }
        public void Message(string languageName)
        {
            String Message = "Muhammad Usman" + languageName;

      
            MessageBox.Show(languageName +"Second", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
