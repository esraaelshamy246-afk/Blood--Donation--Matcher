using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Donation_Matcher
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                if(control is Panel || control is FlowLayoutPanel)
                {
                    var property = control.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                    property.SetValue(control, true, null);
                }
            }
        }
        private void LoadForm(Form form)
        {
            maincontentPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            maincontentPanel.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelMenu.Visible =! panelMenu.Visible;
            timerMenu .Start();
        }
        bool isMenuOpen = false;

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (isMenuOpen)
            {
                panelMenu.Width -= 10;
                if (panelMenu.Width <= 60)
                {
                    isMenuOpen = false;
                    timerMenu.Stop();
                }
            }
            else
            {
                panelMenu.Width += 10;
                if (panelMenu.Width >= 150)
                {
                    isMenuOpen = true;
                    timerMenu.Stop();
                }
            }
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            LoadForm(new DonateForm());
        }

        private void btnHospitals_Click(object sender, EventArgs e)
        {
            LoadForm(new HospitalsForm());
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            LoadForm(new FeedbackForm());
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            LoadForm(new RequestForm());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
             LoadForm(new RegisterForm());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
             LoadForm(new HomeContentForm());
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           LoadForm(new HomeContentForm());
        }

        private void maincontentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEligibilitycheck_Click(object sender, EventArgs e)
        {
            LoadForm(new Eligibility_check_form());
        }
    }
}
