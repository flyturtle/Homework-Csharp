using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace _004
{
    public partial class Form1 : Form
    {
              string connectionString;
        public SqlConnection connection1;

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


        private void POPlistbox1()
        {
           // using (connection = new SqlConnection(connectionString))
           // using (SqlDataAdapter adapter = new SqlDataAdapter("select *from Steelname", connection))
            //{
                //DataTable SteelnameDT = new DataTable();
                steelnameTableAdapter.Fill(_003DataSet.Steelname);
            
                listBox1.DisplayMember = "steelName";
                listBox1.ValueMember = "識別碼";
                listBox1.DataSource = steelnameBindingSource;
                //listBox1.DataSource = SteelnameDT;
            //

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            F1button1.Text = "To Form 2";
            POPlistbox1();
            listBox1.SelectedValue = 1;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.ShowDialog(this);
            
        }

        public void listBox1_DataSourceChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          //  this.Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            
        }

       
        private void popstar()
        {
                      
                
                }
        static void HasRows(SqlConnection connection)
        {
            using (connection)
            {
                SqlCommand command = new SqlCommand("SELECT steelstar FROM Steelname;",connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}",reader.GetInt32(0),reader.GetString(1));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            }
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = listBox1.SelectedIndex.ToString();
                DataTable DT = new DataTable();
                using (connection = new SqlConnection(connectionString)) { textBox2.Text = HasRows(); }
                   
            }
            catch (Exception)
            {

                throw;
            }
          
        }

      
    }
    

}
