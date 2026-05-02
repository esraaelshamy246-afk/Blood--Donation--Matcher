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
    public partial class form5 : Form
    {
        public form5()
        {
            InitializeComponent();
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
       
  

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text)
                || string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox3.Text) ||
                string.IsNullOrWhiteSpace(numericUpDown1.Text) || string.IsNullOrWhiteSpace(numericUpDown2.Text))
            {
                MessageBox.Show("Please enter the patient name");
                return;
            }

            string name = textBox1.Text;
            string bloodType = comboBox1.Text;
            string age = numericUpDown1.Value.ToString();
            string phone = textBox2.Text;
            string bags = numericUpDown2.Text;
            string date = dateTimePicker1.Text;
            string isUrgent = checkBox3.Checked ? "Emergency Case" : "Normal Case";
            string gender = checkBox1.Checked ? "Male" : "Female";

            string message = $@"Request Registered Successfully:

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
