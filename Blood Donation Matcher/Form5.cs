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

namespace Blood_Donation_Matcher
{
    public partial class س : Form
    {
        public س()
        {
            InitializeComponent();
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter the patient name");
                return;
            }

            string name = textBox1.Text;
            string bloodType = comboBox1.Text;
            string age = numericUpDown1.Value.ToString();
            string phone = textBox2.Text;
            string bags = comboBox2.Text;
            string date = dateTimePicker1.Text;
            string isUrgent = checkBox1.Checked ? "Urgent" : "Normal";
            string gender = radioButton1.Checked ? "Male" : "Female";

            string message = $@"Request Registered Successfully:
----------------------------------
Patient: {name}
Blood Type: {bloodType}
Age: {age}
Gender: {gender}
Phone: {phone}
Required Units: {bags}
Status: {isUrgent}
Date: {date}";

            MessageBox.Show(message, "Success");
        }
    }

        }
