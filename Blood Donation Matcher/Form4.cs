
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Blood_Donation_Matcher.FeedbackForm;

namespace Blood_Donation_Matcher
{
    public partial class FeedbackForm : Form
    {
        public class Basecard : Label
        {
            public Basecard()
            {
                this.ForeColor = Color.White;
                this.Font = new Font("palatino linotype ", 12);
                this.Margin = new Padding(10);
               
            }
        }
        public class Feedbackcard : Basecard
        {
           public Feedbackcard(String name,String bloodType ,String message)
            {
                this.Text = $"Name : {name}({bloodType})\nMessage : {message}";
                this.BackColor = Color.Maroon;
                this.Size = new Size(350,80);
                this.AutoSize = false;
            }
        }
        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            flowLayoutPanel1.Controls.Add(new Feedbackcard("أحمد رأفت", "A+", "التبرع كان سهل جداً والممرضة يدها خفيفة، شكراً لكم"));
            flowLayoutPanel1.Controls.Add(new Feedbackcard("Hany Salem", "O-", "The center was very crowded today and I waited for 2 hours!"));
            flowLayoutPanel1.Controls.Add(new Feedbackcard("Mona Ahmed", "B+", "Great experience, very clean tools and professional staff."));
            flowLayoutPanel1.Controls.Add(new Feedbackcard("ياسين علي", "AB+" ,"   للأسف مكان التبرع بعيد جداً ومفيش مواصلات قريبة منه"));
            flowLayoutPanel1.Controls.Add(new Feedbackcard("Sara Ali", "O+", "Donation done successfully but the juice after was not cold."));
            flowLayoutPanel1.Controls.Add(new Feedbackcard("إياد حسن", "O-", "للأسف مأكلتش كويس قبل ما أروح وحسيت بدوخة شديدة وإغماء بعد التبرع، لازم التوعية بأهمية وجبة الإفطار تكون أكتر من كدة."));
            flowLayoutPanel1.Controls.Add(new Feedbackcard("Mariam Soliman", "A+", "شكراً جداً إنكم رفضتم تخلوني أتبرع بسبب نقص الهيموجلوبين، ده عرفني إني محتاجة أهتم بصحتي الأول، إجراءات فحص ممتازة."));
            flowLayoutPanel1.Controls.Add(new Feedbackcard("كريم محمود", "B+", "اتحركت بسرعة بعد التبرع ومسمعتش نصيحة الممرضة بالراحة لمدة 15 دقيقة، وتعبت جداً في الطريق. يا ريت تنبهوا على الناس متتحركش فوراً."));
            flowLayoutPanel1.Controls.Add(new Feedbackcard("Dina Ali", "AB-", "التجربة كانت آمنة جداً، واهتمامكم بتوفير عصائر ومياه بعد التبرع ساعدني مرجعش البيت دايخة."));
            flowLayoutPanel1.Controls.Add(new Feedbackcard("يوسف خالد", "O+", "كنت فاكر الموضوع بسيط، بس اكتشفت إن ضغطي عالي جداً وقت التبرع. البرنامج لازم يضيف تنبيهات بضرورة قياس الضغط قبل التحرك للمركز."));
            flowLayoutPanel1.Controls.Add(new Feedbackcard("Nada Mansour", "A-", "أهم حاجة طمنتني هي استخدام أدوات جديدة ومعقمة قدام عيني، ده بيشجع أي حد خايف من نقل العدوى إنه يشارك وهو مطمن."));
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          String name = textBox1.Text;
            String blood = comboBox1.Text;
            String message = textBox2.Text;
                        Feedbackcard newCard = new Feedbackcard(name, blood ,message);
            flowLayoutPanel1.Controls.Add(newCard);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
         }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
