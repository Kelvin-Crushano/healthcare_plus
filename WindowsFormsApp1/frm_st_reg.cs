using HospitalProject;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class frm_st_registration : Form
    {
        my_connection con = new my_connection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter daat = new MySqlDataAdapter();
        DataTable data = new DataTable();
        public frm_st_registration()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            MessageBox.Show(this.ClientSize.Width.ToString());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void staffRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frm_st_registration_Load(object sender, EventArgs e)
        {

        }

        private void add()
        {


            cmd = new MySqlCommand("INSERT INTO `staff_registration`(`first_name`, `last_name`, `email`, `phone`, `role`, `password`) VALUES (?,?,?,?,?,?)", con.open());
            cmd.Parameters.AddWithValue("@1", txtbox_LastName.Text);
            cmd.Parameters.AddWithValue("@2", txtbox_FirstName.Text);
            cmd.Parameters.AddWithValue("@3", txtBox_email.Text);
            cmd.Parameters.AddWithValue("@4", textBox1.Text);
            cmd.Parameters.AddWithValue("@5", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@6", textBox2.Text);

            int check = Convert.ToInt32(cmd.ExecuteNonQuery());
            con.close();
            if (check > 0)
            {
                MessageBox.Show("Successfully Added");
                _clear();
            }
            else
            {
                MessageBox.Show("Adding unsuccessful");
            }


        }

        private void _clear()
        {
            txtbox_LastName.Clear();
            txtbox_FirstName.Clear();
            txtBox_email.Clear();
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBox_email.Text == "")
            {

                MessageBox.Show("Enter Data Correctly");

            }
            else
            {
                add();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 hf = new Form1();
            hf.Show();
            this.Hide();
        }
    }
}
