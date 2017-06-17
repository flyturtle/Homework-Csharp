using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace _004
{
    public partial class Form2 : Form
    {
        string[] books = new string[] { "a", "b", "d" };
        string conString;
        private Form1 form1;
        public Form2(Form1 form1)
        {
            this.form1 = form1;
            conString = ConfigurationManager.ConnectionStrings["_004.Properties.Settings._003ConnectionString"].ConnectionString;
            button1.Text = "Add to list";
            button2.Text = "back to form1";

        }
        
        public Form2()
        {
            InitializeComponent(); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            popdate();
            //string[] books = new string[] { "a", "b", "d" };
            //checkedListBox1.Items.AddRange(books);
            //button1.Text = "Add to list";
            //button2.Text = "back to form1";
        }
        private void POPatt()
        {
            DataTable AllTable = new DataTable();
            steelnameTableAdapter1.Fill(_003DataSet1.Steelname);
            checkedListBox1.DisplayMember = "steelName";
            checkedListBox1.ValueMember = "識別碼";
        //    checkedListBox1.SelectedIndex = steelnameBindingSource
                }
        public void POP()
        {
            checkedListBox2.GetItemText(textBox1.Text);
        }

        private void popdate()
        {
            string[] books = new string[] { textBox2.Text };
            checkedListBox1.Items.AddRange(books);
        }
              

        private void button1_Click(object sender, EventArgs e)
        {            
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox2.Items.Add(checkedListBox1.Items[i]);
                checkedListBox1.Items.RemoveAt(i);            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            popdate();
        }
    }
}
