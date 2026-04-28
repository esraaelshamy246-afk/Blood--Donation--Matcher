using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Blood_Donation_Matcher
{
    public partial class DonateDetailsForm : Form
    {
        public DonateDetailsForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 1. التحقق من أن المستخدم قد اختار محافظة (اختياري ولكن مهم)
            if (comboBoxGovernorates.SelectedIndex == -1 || comboBoxGovernorates.Text == "-- Select a Governorate --")
            {
                MessageBox.Show("Please select a governorate first.");
                return; // الخروج من الدالة إذا لم يتم الاختيار
            }

            // 2. إنشاء كائن (Object) من الفورم الثانية
            HospitalsForm secondForm = new HospitalsForm();

           // إظهار الفورم الثانية الآن
            secondForm.Show();

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightGray;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor= Color.White;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightGray;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.LightGray;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void maskedTextBox1_MouseEnter(object sender, EventArgs e)
        {
            maskedTextBox1.BackColor = Color.LightGray;
        }

        private void maskedTextBox1_MouseLeave(object sender, EventArgs e)
        {
            maskedTextBox1.BackColor = Color.White;
        }

        private void dateTimePicker1_MouseEnter(object sender, EventArgs e)
        {
            dateTimePicker1.BackColor = Color.LightGray;
        }

        private void dateTimePicker1_MouseLeave(object sender, EventArgs e)
        {
            dateTimePicker1.BackColor = Color.LightGray;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGray;   
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Your request has been submitted successfully!", // نص الرسالة الرئيسي
                    "THANK YOU FOR YOUR DONATION"); // عنوان الرسالة العلوي
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Your generous donation has been received","THANK YOY FOR YOUR DONATION");
        }
    }
    }

