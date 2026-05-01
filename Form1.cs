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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Blood", "Blood Type");
            dataGridView1.Columns.Add("Give", "Give To");
            dataGridView1.Columns.Add("Take", "Take From");
            dataGridView1.Rows.Add("A+", "A+,AB+", "A+.A-");
            dataGridView1.Rows.Add("A-", "A+,A-,AB+,AB-", "A-");
            dataGridView1.Rows.Add("B+", "B+,AB+", "B+,B-");
            dataGridView1.Rows.Add("O-", "All", "O-");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DonorForm f = new DonorForm();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RequestForm f = new RequestForm();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HospitalsForm f = new HospitalsForm();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StoriesForm f = new StoriesForm();
            f.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("Please Sign In First");
            LoginForm f = new LoginForm();
            f.Show();
        }
    }
}
