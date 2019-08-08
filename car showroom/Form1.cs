using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using(OdbcConnection myconnection=new OdbcConnection())
//    {
//        myConnection.ConnectionString = myConnectionString;
//        myConnection.Open();
//    }

namespace car_showroom
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 Cars = new Form2();
            Cars.Show();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 Costumer = new Form3();
            Costumer.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form4 Modification = new Form4();
            Modification.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 Order = new Form5();
            Order.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 Payment = new Form6();
            Payment.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Exit;

            Exit = MessageBox.Show("Confirm if you want to Exit", "Car Showroom Manangment",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Exit == DialogResult.Yes)
            {
                Application.Exit();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (username.Text == "abc" && passward.Text == "123")
            {
                btnCars.Enabled = true;
                btnCustoner.Enabled = true;
                btnModification.Enabled = true;
                btnOrder.Enabled = true;
                btnPayment.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please Enter Correct Login Details", "Car Showroom Manangment");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            username.Clear();
            passward.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCars.Enabled = false;
            btnCustoner.Enabled = false;
            btnModification.Enabled = false;
            btnOrder.Enabled = false;
            btnPayment.Enabled = false;
        }
    }
}

//    public void InsertRow(string connectionString , string insertSQL)
//    {
//        using (OleDbConnection connection = new OleDbConnection(connectionString))
//        {
//            OleDbCommand command = new OleDbCommand(insertSQL);
//            command.Connection = connectionString;
//            try
//            {
//                connection.Open();
//                command.ExecuteNonQuery();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//         }
//    }
//}

