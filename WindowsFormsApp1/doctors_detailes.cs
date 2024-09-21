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

namespace HospitalProject
{
    public partial class doctors_detailes : Form
    {
        my_connection con = new my_connection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter daat = new MySqlDataAdapter();
        DataTable data = new DataTable();
        MySqlDataReader dare;

        String id;
        public doctors_detailes()
        {
            InitializeComponent();
        }
        private void _clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }


        private void add()
        {


            cmd = new MySqlCommand("INSERT INTO `doctor`(`id`, `name`, `address`, `phone`, `gmail`, `specialization`, `qualifications`, `expertise`) VALUES (?,?,?,?,?,?,?,?)", con.open());
            cmd.Parameters.AddWithValue("@1", textBox1.Text);
            cmd.Parameters.AddWithValue("@2", textBox2.Text);
            cmd.Parameters.AddWithValue("@3", textBox3.Text);
            cmd.Parameters.AddWithValue("@4", textBox5.Text);
            cmd.Parameters.AddWithValue("@5", textBox4.Text);
            cmd.Parameters.AddWithValue("@6", textBox6.Text);
            cmd.Parameters.AddWithValue("@7", textBox7.Text);
            cmd.Parameters.AddWithValue("@8", textBox8.Text);

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

        private void upd()
        {


            cmd = new MySqlCommand("UPDATE `doctor` SET `name`=?,`address`=?,`phone`=?,`gmail`=?,`specialization`=?,`qualifications`=?,`expertise`=? WHERE `id`=?", con.open());

            cmd.Parameters.AddWithValue("@1", textBox2.Text);
            cmd.Parameters.AddWithValue("@2", textBox3.Text);
            cmd.Parameters.AddWithValue("@3", textBox5.Text);
            cmd.Parameters.AddWithValue("@4", textBox4.Text);
            cmd.Parameters.AddWithValue("@5", textBox6.Text);
            cmd.Parameters.AddWithValue("@6", textBox7.Text);
            cmd.Parameters.AddWithValue("@7", textBox8.Text);
            cmd.Parameters.AddWithValue("@8", textBox1.Text);

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

        public void set_data()
        {
            cmd = new MySqlCommand("SELECT * FROM `doctor` WHERE `id` = ?", con.open());
            cmd.Parameters.AddWithValue("@1", id);
            daat = new MySqlDataAdapter(cmd);
            data = new DataTable();
            daat.Fill(data);

            textBox1.Text = data.Rows[0][1].ToString();
            textBox2.Text = data.Rows[0][2].ToString();
            textBox3.Text = data.Rows[0][3].ToString(); 
            textBox5.Text = data.Rows[0][4].ToString();
            textBox4.Text = data.Rows[0][5].ToString();
            textBox6.Text = data.Rows[0][6].ToString();
            textBox7.Text = data.Rows[0][7].ToString();
            textBox8.Text = data.Rows[0][8].ToString();

            con.close();

            textBox1.Enabled = false;
        }
        private void load()
        {
            dataGridView1.Rows.Clear();

            cmd = new MySqlCommand("SELECT * FROM `doctor`", con.open());
            dare = cmd.ExecuteReader();
            while (dare.Read())
            {
                dataGridView1.Rows.Add(dare.GetString("id"), dare.GetString("name"), dare.GetString("phone"), dare.GetString("gmail"), dare.GetString("address"), dare.GetString("specialization"), dare.GetString("qualifications"), dare.GetString("expertise"));

            }

            dare.Close();
            con.close();
        }

        private void dlt()
        {
            if (id == "")
            {
                MessageBox.Show("Please Select Doctor");
            }
            else
            {
                cmd = new MySqlCommand("DELETE FROM `doctor` WHERE `id` = ?", con.open());
                cmd.Parameters.AddWithValue("@1", id);
                int check = Convert.ToInt32(cmd.ExecuteNonQuery());
                MessageBox.Show("Successfully Deleted");
                con.close();
                id = "";
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            _clear();
            button1.Text = "+ADD";
            textBox1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {

                MessageBox.Show("Enter Data Correctly");

            }
            else
            {
                MessageBox.Show("add");
                if (button1.Text == "+ADD")
                {
                    MessageBox.Show("ad func");
                    add();
                    load();
                    _clear();
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

        

        private void doctors_detailes_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView1.Rows[rowindex];

            id = selectedrow.Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            set_data();
            button1.Text = "UPDATE";
            textBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dlt();
            load();
        }
    }
}
