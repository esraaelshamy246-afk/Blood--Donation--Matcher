using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodDonatoinMatcher
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username != "" && password != "")
            {
              MessageBox.Show ("Login successful!");
                HomeForm f = new HomeForm();
                f.Show();
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
        }
    }
}
