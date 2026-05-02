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

    public enum PaymentMethod
    {
        Fawry,
        CreditCard,
        MobileWallet,
        NotSelected // حالة افتراضية لو مفيش حاجة اختارت
    }
    public partial class DonateDetailsForm : Form
    {
        private object rbMobileWallet;

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

            string data = "Name: " + txtName.Text +
                   " | Address: " + txtAddress.Text +
                   " | Phone: " + txtPhone.Text +
                   " | Date: " + dateTimePicker1.Value.ToShortDateString();

            // 1. كود الـ File Handling (الحفظ في ملف نصي)
            // السطر ده وظيفته يفتح الملف (أو ينشئه لو مش موجود) ويضيف السطر الجديد في آخره
            File.AppendAllText("DonorsData.txt", data + Environment.NewLine);

            // 2. إظهار رسالة النجاح (رسالة واحدة احترافية بعد الحفظ)
            MessageBox.Show("Your request has been booked successfully and saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 3. مسح الخانات لتجهيزها لمستخدم جديد
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            // استخدام الـ Enum لتخزين طريقة الدفع، وافتراضياً هي NotSelected
            PaymentMethod selectedMethod = PaymentMethod.NotSelected;

            // تحديد طريقة الدفع بناءً على الـ RadioButton المختارة
            if (rbFawry.Checked)
            {
                selectedMethod = PaymentMethod.Fawry;
            }
            else if (rbCreditCard.Checked) 
            {
                selectedMethod = PaymentMethod.CreditCard;
            }
            else if (rbMobile.Checked) 
            {
                selectedMethod = PaymentMethod.MobileWallet;
            }

            // التحقق من أن المستخدم اختار طريقة دفع
            if (selectedMethod == PaymentMethod.NotSelected)
            {
                // إظهار رسالة تنبيه لو مفيش حاجة اتخارت
                MessageBox.Show("Please select a payment method first.", "Payment Method Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // لو اختار فعلاً، بنكمل العملية

                MessageBox.Show($"Your generous donation has been received", "THANK YOU FOR YOUR DONATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        

    }
    }
    }

