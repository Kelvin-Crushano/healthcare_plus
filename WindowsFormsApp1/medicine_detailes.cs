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
    public partial class medicine_detailes : Form
    {
        my_connection con = new my_connection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter daat = new MySqlDataAdapter();
        DataTable data = new DataTable();
        MySqlDataReader dare;

        String id;
        public medicine_detailes()
        {
            InitializeComponent();
        }

        private void _clear()
        {
            textBox1.Text = "";
            textBox_dos.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }


        private void add()
        {


            cmd = new MySqlCommand("INSERT INTO `medicine_detailes`(`name`, `dosage_formate`, `description`, `amount`) VALUES (?,?,?,?)", con.open());
            cmd.Parameters.AddWithValue("@1", textBox1.Text);
            cmd.Parameters.AddWithValue("@2", textBox_dos.Text);
            cmd.Parameters.AddWithValue("@3", textBox3.Text);
            cmd.Parameters.AddWithValue("@4", textBox4.Text);

            int check = Convert.ToInt32(cmd.ExecuteNonQuery());
            con.close();
            if (check > 0)
            {
                MessageBox.Show("Successfully Added");
                _clear();
            }
            else
            {
                MessageBox.Show("Not Added");
            }


        }



        private void load()
        {
            dataGridView1.Rows.Clear();

            cmd = new MySqlCommand("SELECT * FROM `medicine_detailes`", con.open());
            dare = cmd.ExecuteReader();
            while (dare.Read())
            {
                dataGridView1.Rows.Add(dare.GetString("id"), dare.GetString("name"), dare.GetString("dosage_formate"), dare.GetString("description"), dare.GetString("amount"));

            }

            dare.Close();
            con.close();
        }

        private void search()
        {
            dataGridView1.Rows.Clear();

            cmd = new MySqlCommand("SELECT * FROM `medicine_detailes` WHERE `name`=?", con.open());
            cmd.Parameters.AddWithValue("@1", textBox2.Text);
            dare = cmd.ExecuteReader();
            while (dare.Read())
            {
                dataGridView1.Rows.Add(dare.GetString("id"), dare.GetString("name"), dare.GetString("dosage_formate"), dare.GetString("description"), dare.GetString("amount"));

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
                cmd = new MySqlCommand("DELETE FROM `medicine_detailes` WHERE `id` = ?", con.open());
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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView1.Rows[rowindex];

            id = selectedrow.Cells[0].Value.ToString();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            dlt();
            load();
        }

        private void medicine_detailes_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
