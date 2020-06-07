using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onMouseEnter(object sender, EventArgs e)
        {
            //Button button=sender as Button;

            //button.Text = "Changed";
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            //Button button = sender as Button;

            //button.Text = "button1";
        }

        private void onClick(object sender, EventArgs e)
        {
            Button button = sender as Button;

            //if (button.BackColor == Color.Red)
            //{
            //    button.BackColor = Color.Green;
            //}
            //else
            //{
            //    button.BackColor = Color.Red;
            //}

           
        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Surname");
            listView1.Columns.Add("Gender");
            listView1.Columns.Add("Age");
            listView1.Columns.Add("isStudent");
         
        }
        List<User> users = new List<User>();
        private void button1_Click(object sender, EventArgs e)
        {
           
            User user = new User()
            {
                Name = textBox1.Text,
                Surname = textBox2.Text,
                Age = numericUpDown1.Value,
                Gender = comboBox1.Text
               
            };
            if (user.Name == "" || user.Name==" ")
            {
                MessageBox.Show("Name or surname cannot be empty");
                return;
            }
            if (checkBox1.Checked)
            {
                user.isStudent = "Student";
            }
            else
            {
                user.isStudent = "Not student";
            }
            string[] data = new string[] { user.Name, user.Surname, user.Gender, user.Age.ToString(),user.isStudent };
            
           ListViewItem item = new ListViewItem(data);
            listView1.Items.Add(item);
            users.Add(user);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = users;
            
         
          
        }
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }
    }

    class User
    {
      
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public decimal Age { get; set; }
        public string isStudent { get; set; }
    }
}
