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
                MessageBox.Show("من فضلك ادخلي اسم المريض");
                return;
            }

            string name = textBox1.Text;
            string bloodType = comboBox1.Text;
            string age = numericUpDown1.Value.ToString();
            string phone = textBox2.Text;
            string bags = comboBox2.Text;
            string date = dateTimePicker1.Text;
            string isUrgent = checkBox1.Checked ? "عاجلة" : "عادية";
            string gender = radioButton1.Checked ? "ذكر" : "أنثى";

            string message = $"تم تسجيل الطلب:\n" +
                             $"المريض: {name}\n" +
                             $"الفصيلة: {bloodType}\n" +
                             $"السن: {age}\n" +
                             $"النوع: {gender}\n" +
                             $"الهاتف: {phone}\n" +
                             $"عدد الأكياس: {bags}\n" +
                             $"الحالة: {isUrgent}\n" +
                             $"التاريخ: {date}";

            MessageBox.Show(message, "نجاح العملية");

        }
    }
}
