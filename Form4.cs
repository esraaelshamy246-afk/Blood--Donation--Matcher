using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BloodDonatoinMatcher
{
    public partial class HospitalsForm : Form
    {
        public HospitalsForm()
        {
             InitializeComponent();

           DataTable dtHospitala = new DataTable();

            ShowDataInGrid();
          

        }

        private void HospitalsForm_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Empty;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.BackColor = Color.White;
                }
                ShowDataInGrid();
                RefreashNames();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text)
                || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text)
                || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text)
                || string.IsNullOrWhiteSpace(textBox7.Text) || string.IsNullOrWhiteSpace(textBox8.Text))
            {
                MessageBox.Show("! You Have to Full All Data First ");
                return;
            }
            


            string filePath = "MyHospitals.txt";
           

            try
            {
                string lines = $"{textBox1.Text},{textBox2.Text},{textBox3.Text},{textBox4.Text}," +
                         $"{textBox5.Text},{textBox6.Text},{textBox7.Text},{textBox8.Text},";


               

                File.AppendAllLines(filePath, new[] { lines });


                MessageBox.Show("Record Inserted Successfully");
                 ShowDataInGrid();
              
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();

                comboBox1.Items.Clear();
                if (File.Exists(filePath))
                {
                    string[] allNames = File.ReadAllLines(filePath);

                    string[] allLines = File.ReadAllLines("MyHospitals.txt");
                    foreach (string line in allLines) 
                    {
                        if (!string.IsNullOrWhiteSpace(line)) 
                        {
                            string[] parts = line.Split(',');
                            if (parts.Length > 1) 
                            {
                                
                                comboBox1.Items.Add(parts[1].Trim());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            ShowDataInGrid();
            RefreashNames();
 
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //string idToUpdate = "";

            string filePath = "MyHospitals.txt";

            if ( !File.Exists(filePath))
            {
                return;
            }
                try
                {
                    List<string> lines = File.ReadAllLines(filePath).ToList();
                     bool isUpdated = true;
                
                
                for (int i = 0; i < lines.Count; i++)
                   {
                       string[] data = lines[i].Split(',');
                     
                      if (data.Length > 0 && data[0].Trim() == textBox1.Text.Trim())
                      {

                        lines[i] = $"{textBox1.Text},{textBox2.Text},{textBox3.Text},{textBox4.Text}," +
                                 $"{textBox5.Text},{textBox6.Text},{textBox7.Text},{textBox8.Text},";

                        isUpdated = true;
                        break;


                      }
                   }


                if (isUpdated)

                {

                    File.WriteAllLines(filePath, lines);

                    MessageBox.Show("Updated done ");
                    ShowDataInGrid();
                    ClearTextBxes();
                }
                else 
                {
                    MessageBox.Show("does not work please try again");
                }
                }
                catch (Exception ex)
            { MessageBox.Show("Problem"+ ex.Message); }

            

        }
        public void ShowDataInGrid(string searchTerm = "")
        {
            string filePath = "MyHospitals.txt";
            try
            {
                if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath)) return;

                DataTable dt = new DataTable();

                
                
               
                      dt.Columns.Add("ID");
                      dt.Columns.Add("Name");
                      dt.Columns.Add("Adress");
                      dt.Columns.Add("Email");
                      dt.Columns.Add("Phone");
                      dt.Columns.Add("Governorate");
                      dt.Columns.Add("Blood Type");
                      dt.Columns.Add("Statue");

                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] row = line.Split (',');
                      if (row.Length >= 8)
                      {
                        if (!string.IsNullOrWhiteSpace(searchTerm) && row[1].ToLower()
                        .IndexOf(searchTerm.ToLower())  == -1) continue;

                        dt.Rows.Add(row[0].Trim(), row[1].Trim(), row[2].Trim(), row[3].Trim(),
                                      row[4].Trim(), row[5].Trim(), row[6].Trim(), row[7].Trim());
                      }

                }
                   dataGridView1.DataSource = dt;


              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          // dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var allLines = File.ReadAllLines("MyHospitals.txt");

            var remainingLines = allLines.Where(line => !line.StartsWith(textBox1.Text));
            File.WriteAllLines("MyHospitals.txt", remainingLines);

            MessageBox.Show("done ");
            ShowDataInGrid();
            ClearTextBxes();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
                textBox6.Text = row.Cells[5].Value.ToString();
                textBox7.Text = row.Cells[6].Value.ToString();
                textBox8.Text = row.Cells[7].Value.ToString();
            }

            
        }

        private void Hospital_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                string filePath = "MyHospitals.txt";

                if (!File.Exists(filePath)) return;

                DataTable dt = new DataTable();

                string[] colums = { "ID", "Name", "Adress", "Email", "Phone"
                        , "Governorate", "BloodType", "Status" };
                foreach (var col in colums) dt.Columns.Add(col); 
                
                    string[] lines = File.ReadAllLines(filePath);
                    string word = comboBox1.Text.ToLower().Trim();
                    foreach (string line in lines) 
                    {
                        if (line.ToLower().Contains(word) )
                        {
                            string[] row = line.Split('.');
                            if (row.Length >= 8)
                            {
                                dt.Rows.Add(row[0].Trim(), row[1].Trim(), row[2].Trim(), row[3].Trim(),
                                            row[4].Trim(), row[5].Trim(), row[6].Trim(), row[7].Trim());
                            }

                        }
                    }

                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ClearTextBxes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
            comboBox1.Text = "";
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ShowDataInGrid(comboBox1.Text.Trim());
                ClearTextBxes();
            }

            
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {

        }

        public void RefreashNames()
        {

            string filePath = "MyHospitals.txt";
            if (File.Exists(filePath))
            {
                var allNames = File.ReadAllLines(filePath)
                    .Where(l => !string.IsNullOrWhiteSpace(l))
                    .Select(l => l.Split(',')[1].Trim()).ToArray();


                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(allNames);

                comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;


            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        public void ClearAllFields() 
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";


            comboBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            ShowDataInGrid();
            textBox1.Focus();
        }
                  
    }
}
