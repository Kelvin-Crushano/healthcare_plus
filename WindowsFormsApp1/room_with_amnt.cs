using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HospitalProject
{
    public partial class room_with_amnt : Form
    {
        my_connection con = new my_connection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter daat = new MySqlDataAdapter();
        DataTable data = new DataTable();
        MySqlDataReader dare;

        String id;

        public room_with_amnt()
        {
            InitializeComponent();
        }

        private void _clear()
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void add()
        {


            cmd = new MySqlCommand("INSERT INTO `room_with_amt`(`room_no`, `descr`, `amnt`) VALUES (?,?,?)", con.open());
            cmd.Parameters.AddWithValue("@1", textBox1.Text);
            cmd.Parameters.AddWithValue("@2", textBox3.Text);
            cmd.Parameters.AddWithValue("@3", textBox4.Text);

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

            cmd = new MySqlCommand("SELECT * FROM `room_with_amt`", con.open());
            dare = cmd.ExecuteReader();
            while (dare.Read())
            {
                dataGridView1.Rows.Add(dare.GetString("room_no"), dare.GetString("descr"), dare.GetString("amnt"));

            }

            dare.Close();
            con.close();
        }

        private void dlt()
        {
            if (id == "")
            {
                MessageBox.Show("Please Select ID");
            }
            else
            {
                cmd = new MySqlCommand("DELETE FROM `room_with_amt` WHERE `room_no` = ?", con.open());
                cmd.Parameters.AddWithValue("@1", id);
                int check = Convert.ToInt32(cmd.ExecuteNonQuery());
                MessageBox.Show("Successfully Deleted");
                con.close();
                id = "";
            }

        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

                MessageBox.Show("Enter Data Correctly");

            }
            else
            {
                add();
                load();
                _clear();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView1.Rows[rowindex];

            id = selectedrow.Cells[0].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            dlt();
            load();
        }

        private void room_with_amnt_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
