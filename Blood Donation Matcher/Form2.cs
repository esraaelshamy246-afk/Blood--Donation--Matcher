using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            txtName.BackColor = Color.LightGray;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            txtAddress.BackColor = Color.LightGray;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            txtAddress.BackColor = Color.White;
        }

        private void maskedTextBox1_MouseEnter(object sender, EventArgs e)
        {
            txtPhone.BackColor = Color.LightGray;
        }

        private void maskedTextBox1_MouseLeave(object sender, EventArgs e)
        {
            txtPhone.BackColor = Color.White;
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

            // التحقق إذا كانت الحقول فارغة
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                // إظهار رسالة تنبيه للمستخدم
                MessageBox.Show("Please fill in all the fields first.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dateTimePicker1.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Please select a valid future date for blood pickup.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // التوقف عن التنفيذ
            }
                // إذا وصل الكود هنا، يعني أن كل البيانات صحيحة
                MessageBox.Show("Your request has been booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            // التأكد من اختيار طريقة الدفع
            if (!rbFawry.Checked && !rbCreditCard.Checked && !rbCreditCard.Checked)
            {
                // إظهار رسالة تنبيه لو مفيش حاجة اتخارت
                MessageBox.Show("Please select a payment method first.", "Payment Method Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // لو اختار فعلاً، بنكمل العملية
                string selectedMethod = "";

                if (rbFawry.Checked) selectedMethod = "Fawry";
                else if (rbCreditCard.Checked) selectedMethod = "Mobile Wallet";
                else if (rbCreditCard.Checked) selectedMethod = "Credit Card";

                MessageBox.Show($"Your generous donation has been received", "THANK YOY FOR YOUR DONATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
       
        }
    }
    }

