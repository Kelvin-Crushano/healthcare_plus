using HospitalProject;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class frm_room_scheduling : Form
    {
        my_connection con = new my_connection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter daat = new MySqlDataAdapter();
        DataTable data = new DataTable();
        MySqlDataReader dare;

        String id;
        public frm_room_scheduling()
        {
            InitializeComponent();
        }

        private void add()
        {


            cmd = new MySqlCommand("INSERT INTO `room_schedule`(`pat_id`, `admission_date`, `room_type`, `room_no`, `disarge_date`) VALUES (?,?,?,?,?)", con.open());
            cmd.Parameters.AddWithValue("@1", cmbBox_patient_id.Text);
            cmd.Parameters.AddWithValue("@2", dateTimePicker_admission_date.Value);
            cmd.Parameters.AddWithValue("@3", cmbBox_room_type.Text);
            cmd.Parameters.AddWithValue("@4", cmbBox_room_no.Text);
            cmd.Parameters.AddWithValue("@5", dateTimePicker_discharge_date.Value);

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

        private void _clear()
        {
            cmbBox_patient_id.Text = "";
            cmbBox_room_type.Text = "";
            cmbBox_room_no.Text = "";
        }

        private void load()
        {
            dataGridView1.Rows.Clear();

            cmd = new MySqlCommand("SELECT * FROM `room_schedule`", con.open());
            dare = cmd.ExecuteReader();
            while (dare.Read())
            {
                dataGridView1.Rows.Add(dare.GetString("id"), dare.GetString("pat_id"), dare.GetString("admission_date"), dare.GetString("room_type"), dare.GetString("room_no"), dare.GetString("disarge_date"));

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
                cmd = new MySqlCommand("DELETE FROM `room_schedule` WHERE `id` = ?", con.open());
                cmd.Parameters.AddWithValue("@1", id);
                int check = Convert.ToInt32(cmd.ExecuteNonQuery());
                MessageBox.Show("Successfully Deleted");
                con.close();
                id = "";
            }

        }

        private void search()
        {
            dataGridView1.Rows.Clear();

            cmd = new MySqlCommand("SELECT * FROM `room_schedule` WHERE `room_no`=?", con.open());
            cmd.Parameters.AddWithValue("@1", comboBox1.Text);
            dare = cmd.ExecuteReader();
            while (dare.Read())
            {
                dataGridView1.Rows.Add(dare.GetString("id"), dare.GetString("pat_id"), dare.GetString("admission_date"), dare.GetString("room_type"), dare.GetString("room_no"), dare.GetString("disarge_date"));

            }

            dare.Close();
            con.close();

        }

        private void get_id(String tname, String id, System.Windows.Forms.ComboBox combobox)
        {
            combobox.Items.Clear();

            String Query1 = "SELECT * FROM ";
            String coma = "`";
            String genQuer = Query1 + coma + tname + coma;

            int i = 0;
            cmd = new MySqlCommand(genQuer, con.open());
            dare = cmd.ExecuteReader();
            while (dare.Read())
            {
                combobox.Items.Add(dare.GetString(id));
                i += 1;
            }

            dare.Close();
            con.close();
        }

        private int find_availibility()
        {

            int status_ = 0;
            cmd = new MySqlCommand("SELECT * FROM `room_schedule` WHERE `room_no`=? AND `disarge_date`>=?", con.open());
            cmd.Parameters.AddWithValue("@1", cmbBox_room_no.Text);
            cmd.Parameters.AddWithValue("@2", dateTimePicker_admission_date.Value.Date);
            daat = new MySqlDataAdapter(cmd);
            data.Clear();
            daat.Fill(data);
            con.close();

            if (data.Rows.Count > 0)
            {
                status_ = 1;
            }
            else
            {
                status_ = 0;
            }

            return status_;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cmbBox_patient_id.Text == "" || cmbBox_room_no.Text == "")
            {

                MessageBox.Show("Enter Data Correctly");

            }
            else
            {
                if(find_availibility() == 0)
                {
                    add();
                    load();
                    _clear();
                }
                else
                {
                    MessageBox.Show("Unavailable Shecdule Please make Re-Schedule");
                }
                  

            }
        }

        private void frm_room_scheduling_Load(object sender, EventArgs e)
        {
            get_id("patient_reg", "id", cmbBox_patient_id);
            get_id("room_with_amt", "room_no", cmbBox_room_no);
            load();
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
