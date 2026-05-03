using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Blood_Donation_Matcher
{
    public partial class form5 : Form
    {
        List<BloodRequest> allRequests = new List<BloodRequest>();

        public form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter the patient name");
                return;
            }

           

            allRequests.Add(newRequest);
            MessageBox.Show(newRequest.GetFullMessage(), "Success");
            try
            {
                System.IO.File.AppendAllText("requests.txt", newRequest.GetFullMessage() + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving to file: " + ex.Message);
            }
        }
        private void RequestForm_Load(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void groupBox1_Click(object sender, EventArgs e) { }
    }
}