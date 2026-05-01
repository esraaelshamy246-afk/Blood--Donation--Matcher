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
using static Person;
using static Person.Patient;

namespace Blood_Donation_Matcher
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string name = textBox2.Text;
            string phone = textBox3.Text;
            string age = numericUpDown1.Text;
            string address = textBox5.Text;
            string bloodType = comboBox1.Text;
            string city = comboBox2.Text;
            string userType = "";

           
            if (radioButton1.Checked) { userType = "Donor (متبرع)"; }
            else if (radioButton2.Checked) { userType = "Patient (مريض)"; }

            if (name == "" ||phone == "" || age == "" || bloodType == "" || userType == "")
    {
                MessageBox.Show("من فضلك أكملي جميع البيانات الأساسية!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
    else
            {
                try
                {
                    
                    BloodType bType = (BloodType)comboBox1.SelectedIndex;

                    string record = "";

                    if (radioButton1.Checked) 
                    {
                        
                        Donor d = new Donor(name, phone, int.Parse(age), address, bType, city  );
                        record = "Donor|" + d.Name + "|" + d.Phone + "|" + d.Age + "|" + d.Address + "|" + d.City + "|" + d.bloodType;
                    }
                    else if (radioButton2.Checked) 
                    {
                        Patient p = new Patient(name, phone, int.Parse(age), address, bType, city );
                        record = "Patient|" + p.Name + "|" + p.Phone + "|" + p.Age + "|" + p.Address + "|" + p.City + "|" + p.bloodType;
                    }

                    
                    using (StreamWriter sw = new StreamWriter("UsersData.txt", true))
                    {
                        sw.WriteLine(record);
                    }

                    MessageBox.Show("تم الحفظ والربط بنجاح!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ: " + ex.Message);
                }




            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
   
            textBox2.Text = "";
            numericUpDown1.Text = "";
            textBox3.Text = ""; 
            textBox5.Text = "";
            textBox6.Text = "";
            
            comboBox1.SelectedIndex = -1; 
            comboBox2.SelectedIndex = -1; 

            
            radioButton1.Checked = false; 
            radioButton2.Checked = false; 

            
            textBox5.Text = "No file selected";    

            
            textBox2.Focus();
        
    }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            textBox2.BackColor= Color.LightGray;
        }
        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void numericUpDown1_MouseDown(object sender, MouseEventArgs e)
        {
            numericUpDown1.BackColor = Color.White;
        }

        private void numericUpDown1_MouseClick(object sender, MouseEventArgs e)
        {
            numericUpDown1.BackColor = Color.White;
        }

        private void numericUpDown1_MouseUp(object sender, MouseEventArgs e)
        {
            numericUpDown1.BackColor = Color.White;
        }

        private void textBox4_MouseEnter(object sender, EventArgs e)
        {
            textBox3.BackColor= Color.LightGray;
        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            textBox3.BackColor= Color.White;
        }

        private void comboBox1_MouseEnter(object sender, EventArgs e)
        {
            comboBox1.BackColor= Color.LightGray;
        }

        private void comboBox1_MouseLeave(object sender, EventArgs e)
        {
            comboBox1.BackColor = Color.White;
        }

        private void textBox6_MouseLeave(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.White;
        }

        private void textBox6_MouseEnter(object sender, EventArgs e)
        {
            textBox6.BackColor= Color.LightGray;
        }

        private void comboBox2_MouseEnter(object sender, EventArgs e)
        {
            comboBox2.BackColor = Color.LightGray;
        }

        private void comboBox2_MouseLeave(object sender, EventArgs e)
        {
            comboBox2.BackColor = Color.White;
        }

        private void textBox5_MouseEnter(object sender, EventArgs e)
        {
            textBox5.BackColor= Color.LightGray;
        }

        private void textBox5_MouseLeave(object sender, EventArgs e)
        {
            textBox5.BackColor= Color.White;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void textBox2_MouseLeave_1(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;  
        }
    }
}



public class Person
{
    public string Name;
    public string Phone;
    public int Age;
    public string Address;
    public BloodType bloodType;
    public string City;

    public Person(string name, string phone, int age, string address, BloodType bloodType, string city)
    {
        this.Name = name;
        this.Phone = phone;
        this.Age = age;
        this.Address = address;
        this.bloodType = bloodType;
        this.City = city;
    }




    public class Donor : Person
    {
        public Donor(string name, string phone, int age, string address, BloodType bloodType, string city )
            : base(name, phone, age, address, bloodType, city)
        {

        }

    }

    public class Patient : Person
    {
        public Patient(string name, string phone, int age, string address, BloodType bloodType,string city)
            : base(name, phone, age, address, bloodType, city)
        {

        }


        public enum BloodType
        {
            A_Positive,
            A_Negative,
            B_Positive,
            B_Negative,
            AB_Positive,
            AB_Negative,
            O_Positive,
            O_Negative
        }


        public class PersonManager
        {
            private Person[] people = new Person[100];
            private int count = 0;


            public void AddPerson()
            {
                if (count < 100)
                    count++;
            }

        }
    }
}

        
