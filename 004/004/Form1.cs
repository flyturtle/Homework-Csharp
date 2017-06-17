using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;


namespace _004
{
    public partial class Form1 : Form
    {
        //SqlConnection connection;
        string connectionString;
        public Form1(Form2 f2)
        {
            InitializeComponent();
            //f2 = fm2;
            connectionString = ConfigurationManager.ConnectionStrings["_004.Properties.Settings._003ConnectionString"].ConnectionString;
        }

        public Form1()
        {
            InitializeComponent();
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            //string form1text = F1textBox1.Text;
            //F1listBox1.Items.Add(F1textBox1);
            fm2.ShowDialog(this);
            
        }
        private void POPatt()
        {
            DataTable AllTable = new DataTable();
            steelnameTableAdapter.Fill(_003DataSet.Steelname);
            listBox1.DisplayMember = "steelName";
            listBox1.ValueMember = "識別碼";
            listBox1.DataSource = steelnameBindingSource;            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            F1button1.Text = "To Form 2";
            POPatt();
        }
        
        public void listBox1_DataSourceChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
    

}
