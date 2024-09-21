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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        my_connection con = new my_connection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter daat = new MySqlDataAdapter();
        DataTable data = new DataTable();
        MySqlDataReader dare;
        public Form1()
        {
            InitializeComponent();
        }

        private void login_admin()
        {

            cmd = new MySqlCommand("SELECT * FROM `staff_registration` WHERE `email`=? AND `password`=?", con.open());
            cmd.Parameters.AddWithValue("@1", txtBox_userid.Text);
            cmd.Parameters.AddWithValue("@2", txtBox_password.Text);
            daat = new MySqlDataAdapter(cmd);
            data.Clear();
            daat.Fill(data);
            con.close();

            if (data.Rows.Count > 0)
            {
                frm_admin_dashboard hf = new frm_admin_dashboard();
                hf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("This Username or Password are invalid");
            }



        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login_admin();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_st_registration hf = new frm_st_registration();
            hf.Show();
            this.Hide();
        }
    }
}
