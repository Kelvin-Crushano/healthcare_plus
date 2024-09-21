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

namespace HospitalProject
{
    public partial class patiant : Form
    {
        my_connection con = new my_connection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter daat = new MySqlDataAdapter();
        DataTable data = new DataTable();
        MySqlDataReader dare;

        String id;
        public patiant()
        {
            InitializeComponent();
        }

        private void add()
        {


            cmd = new MySqlCommand("INSERT INTO `patient_reg`(`id`, `name`, `nic`, `address`, `phone`) VALUES (?,?,?,?,?)", con.open());
            cmd.Parameters.AddWithValue("@1", textBox1.Text);
            cmd.Parameters.AddWithValue("@2", textBox2.Text);
            cmd.Parameters.AddWithValue("@3", textBox4.Text);
            cmd.Parameters.AddWithValue("@4", textBox3.Text);
            cmd.Parameters.AddWithValue("@5", textBox5.Text);

            int check = Convert.ToInt32(cmd.ExecuteNonQuery());
            con.close();
            if (check > 0)
            {
                MessageBox.Show("Successfully Added");
                _clear();
            }
            else
            {
                MessageBox.Show("Un Successfully Added");
            }


        }
        private void load()
        {
            dataGridView1.Rows.Clear();

            cmd = new MySqlCommand("SELECT * FROM `patient_reg`", con.open());
            dare = cmd.ExecuteReader();
            while (dare.Read())
            {
                dataGridView1.Rows.Add(dare.GetString("id"), dare.GetString("name"), dare.GetString("nic"), dare.GetString("address"), dare.GetString("phone"));

            }

            dare.Close();
            con.close();
        }

        private void _clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        public void set_data()
        {
            cmd = new MySqlCommand("SELECT * FROM `patient_reg` WHERE `id` = ?", con.open());
            cmd.Parameters.AddWithValue("@1", id);
            daat = new MySqlDataAdapter(cmd);
            data = new DataTable();
            daat.Fill(data);

            textBox1.Text = data.Rows[0][1].ToString();
            textBox2.Text = data.Rows[0][2].ToString();
            textBox4.Text = data.Rows[0][3].ToString();
            textBox3.Text = data.Rows[0][4].ToString();
            textBox5.Text = data.Rows[0][5].ToString();

            con.close();

            textBox1.Enabled = false;
        }

        private void upd()
        {


            cmd = new MySqlCommand("UPDATE `patient_reg` SET `name`=?,`nic`=?,`address`=?,`phone`=? WHERE `id`=?", con.open());


            cmd.Parameters.AddWithValue("@1", textBox2.Text);
            cmd.Parameters.AddWithValue("@2", textBox4.Text);
            cmd.Parameters.AddWithValue("@3", textBox3.Text);
            cmd.Parameters.AddWithValue("@4", textBox5.Text);
            cmd.Parameters.AddWithValue("@5", textBox1.Text);

            int check = Convert.ToInt32(cmd.ExecuteNonQuery());
            con.close();
            if (check > 0)
            {
                MessageBox.Show("Successfully Updated");
            }
            else
            {
                MessageBox.Show("This Data Not Have");
            }


        }


        private void dlt()
        {
            if (id == "")
            {
                MessageBox.Show("Please Select ID");
            }
            else
            {
                cmd = new MySqlCommand("DELETE FROM `patient_reg` WHERE `id` = ?", con.open());
                cmd.Parameters.AddWithValue("@1", id);
                int check = Convert.ToInt32(cmd.ExecuteNonQuery());
                MessageBox.Show("Successfully Deleted");
                con.close();
                id = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {

                MessageBox.Show("Enter Data Correctly");

            }
            else
            {
                if(button1.Text == "+ADD")
                {
                    add();
                    load();
                }
                else
                {
                    upd();
                    load();
                    _clear();
                    button1.Text = "+ADD";
                    textBox1.Enabled = true;
                }
               
            }
        }

        private void patiant_Load(object sender, EventArgs e)
        {
            load();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dlt();
            load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            set_data();
            button1.Text = "UPDATE";
            textBox1.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView1.Rows[rowindex];

            id = selectedrow.Cells[0].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _clear();
            button1.Text = "+ADD";
            textBox1.Enabled = true;
        }
    }
}
