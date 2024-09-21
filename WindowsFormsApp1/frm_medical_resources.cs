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
    public partial class frm_medical_resources : Form
    {
        my_connection con = new my_connection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter daat = new MySqlDataAdapter();
        DataTable data = new DataTable();
        MySqlDataReader dare;

        String id;

        public frm_medical_resources()
        {
            InitializeComponent();
        }

        private void lbl_room_type_Click(object sender, EventArgs e)
        {

        }

        private void availableSurgeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void add()
        {


            cmd = new MySqlCommand("INSERT INTO `medical_resource`(`equipment_type`, `model`, `menufectrurer`, `serial_number`) VALUES (?,?,?,?)", con.open());
            cmd.Parameters.AddWithValue("@1", textBox_equipment_type.Text);
            cmd.Parameters.AddWithValue("@2", textBox_model.Text);
            cmd.Parameters.AddWithValue("@3", textBox_manufacturer.Text);
            cmd.Parameters.AddWithValue("@4", textBox_serial_no.Text);


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

            cmd = new MySqlCommand("SELECT * FROM `medical_resource`", con.open());
            dare = cmd.ExecuteReader();
            while (dare.Read())
            {
                dataGridView1.Rows.Add(dare.GetString("id"), dare.GetString("equipment_type"), dare.GetString("model"), dare.GetString("menufectrurer"), dare.GetString("serial_number"));

            }

            dare.Close();
            con.close();
        }

        private void search()
        {
            dataGridView1.Rows.Clear();

            cmd = new MySqlCommand("SELECT * FROM `medical_resource` WHERE `equipment_type`=?", con.open());
            cmd.Parameters.AddWithValue("@1", textBox_sort_by_equipment_type.Text);
            dare = cmd.ExecuteReader();
            while (dare.Read())
            {
                dataGridView1.Rows.Add(dare.GetString("id"), dare.GetString("equipment_type"), dare.GetString("model"), dare.GetString("menufectrurer"), dare.GetString("serial_number"));

            }

            dare.Close();
            con.close();
        }
        private void _clear()
        {
            textBox_equipment_type.Clear();
            textBox_model.Clear();
            textBox_manufacturer.Clear();
            textBox_serial_no.Clear();
        }

        private void dlt()
        {
            if (id == "")
            {
                MessageBox.Show("Please Select Item");
            }
            else
            {
                cmd = new MySqlCommand("DELETE FROM `medical_resource` WHERE `id` = ?", con.open());
                cmd.Parameters.AddWithValue("@1", id);
                int check = Convert.ToInt32(cmd.ExecuteNonQuery());
                MessageBox.Show("Successfully Deleted");
                con.close();
                id = "";
            }

        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (textBox_equipment_type.Text == "" || textBox_model.Text == "")
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

        private void frm_medical_resources_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }
    }
}
