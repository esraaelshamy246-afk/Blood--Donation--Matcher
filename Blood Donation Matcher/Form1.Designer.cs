namespace Blood_Donation_Matcher
{
    partial class form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnDonate = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnHospitals = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.btnEligibilitycheck = new System.Windows.Forms.Button();
            this.maincontentPanel = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.Panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.AutoSize = true;
            this.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel1.BackColor = System.Drawing.Color.Black;
            this.Panel1.Controls.Add(this.pictureBoxMenu);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(916, 62);
            this.Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blood Donation Matcher";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.btnRegister);
            this.panelMenu.Controls.Add(this.btnDonate);
            this.panelMenu.Controls.Add(this.btnRequest);
            this.panelMenu.Controls.Add(this.btnHospitals);
            this.panelMenu.Controls.Add(this.btnFeedback);
            this.panelMenu.Controls.Add(this.btnEligibilitycheck);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelMenu.Location = new System.Drawing.Point(0, 62);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(15, 30, 0, 0);
            this.panelMenu.Size = new System.Drawing.Size(185, 462);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Visible = false;
            this.panelMenu.WrapContents = false;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(15, 99);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(170, 39);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Registration";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnDonate
            // 
            this.btnDonate.BackColor = System.Drawing.Color.White;
            this.btnDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonate.ForeColor = System.Drawing.Color.Black;
            this.btnDonate.Location = new System.Drawing.Point(15, 158);
            this.btnDonate.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(170, 39);
            this.btnDonate.TabIndex = 0;
            this.btnDonate.Text = "Donate";
            this.btnDonate.UseVisualStyleBackColor = false;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.White;
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.ForeColor = System.Drawing.Color.Black;
            this.btnRequest.Location = new System.Drawing.Point(15, 217);
            this.btnRequest.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(170, 39);
            this.btnRequest.TabIndex = 3;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnHospitals
            // 
            this.btnHospitals.BackColor = System.Drawing.Color.White;
            this.btnHospitals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHospitals.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHospitals.ForeColor = System.Drawing.Color.Black;
            this.btnHospitals.Location = new System.Drawing.Point(15, 276);
            this.btnHospitals.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnHospitals.Name = "btnHospitals";
            this.btnHospitals.Size = new System.Drawing.Size(170, 39);
            this.btnHospitals.TabIndex = 4;
            this.btnHospitals.Text = "Hospitals";
            this.btnHospitals.UseVisualStyleBackColor = false;
            this.btnHospitals.Click += new System.EventHandler(this.btnHospitals_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.BackColor = System.Drawing.Color.White;
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.ForeColor = System.Drawing.Color.Black;
            this.btnFeedback.Location = new System.Drawing.Point(15, 335);
            this.btnFeedback.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(170, 39);
            this.btnFeedback.TabIndex = 1;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = false;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // timerMenu
            // 
            this.timerMenu.Interval = 35;
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // btnEligibilitycheck
            // 
            this.btnEligibilitycheck.BackColor = System.Drawing.Color.White;
            this.btnEligibilitycheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEligibilitycheck.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEligibilitycheck.ForeColor = System.Drawing.Color.Black;
            this.btnEligibilitycheck.Location = new System.Drawing.Point(15, 394);
            this.btnEligibilitycheck.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnEligibilitycheck.Name = "btnEligibilitycheck";
            this.btnEligibilitycheck.Size = new System.Drawing.Size(170, 39);
            this.btnEligibilitycheck.TabIndex = 6;
            this.btnEligibilitycheck.Text = "Eligibility check";
            this.btnEligibilitycheck.UseVisualStyleBackColor = false;
            this.btnEligibilitycheck.Click += new System.EventHandler(this.btnEligibilitycheck_Click);
            // 
            // maincontentPanel
            // 
            this.maincontentPanel.BackgroundImage = global::Blood_Donation_Matcher.Properties.Resources.WhatsApp_Image_2026_04_25_at_3_45_47_PM;
            this.maincontentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maincontentPanel.Location = new System.Drawing.Point(185, 62);
            this.maincontentPanel.Name = "maincontentPanel";
            this.maincontentPanel.Size = new System.Drawing.Size(731, 462);
            this.maincontentPanel.TabIndex = 2;
            this.maincontentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.maincontentPanel_Paint);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(15, 40);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(170, 39);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMenu.Image")));
            this.pictureBoxMenu.Location = new System.Drawing.Point(12, 4);
            this.pictureBoxMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(64, 56);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMenu.TabIndex = 1;
            this.pictureBoxMenu.TabStop = false;
            this.pictureBoxMenu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(916, 524);
            this.Controls.Add(this.maincontentPanel);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.Panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form1";
            this.Text = " Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.Button btnDonate;
        private System.Windows.Forms.Button btnHospitals;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel maincontentPanel;
        private System.Windows.Forms.Button btnEligibilitycheck;
    }
}

