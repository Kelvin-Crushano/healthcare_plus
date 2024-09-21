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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WindowsFormsApp1
{
    public partial class frm_custom_treatment_plan : Form
    {
        my_connection con = new my_connection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter daat = new MySqlDataAdapter();
        DataTable data = new DataTable();
        MySqlDataReader dare;

        String id;
        public frm_custom_treatment_plan()
        {
            InitializeComponent();
        }

        private void patientInjuriesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void _clear()
        {
            cmbBox_patient_id.Text = "";
            cmbBox_medicine_type.Text = "";
            textBox1.Text = "";
            textBox_duration.Text = "";
        }


        private void add()
        {


            cmd = new MySqlCommand("INSERT INTO `patient_medication_schedule`(`pat_id`, `medicine_name`, `dosage`, `duration`) VALUES (?,?,?,?)", con.open());
            cmd.Parameters.AddWithValue("@1", cmbBox_patient_id.Text);
            cmd.Parameters.AddWithValue("@2", cmbBox_medicine_type.Text);
            cmd.Parameters.AddWithValue("@3", textBox1.Text);
            cmd.Parameters.AddWithValue("@4", textBox_duration.Text);

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


            cmd = new MySqlCommand("UPDATE `patient_medication_schedule` SET `pat_id`=?,`medicine_name`=?,`dosage`=?,`duration`=? WHERE `id`=?", con.open());

            cmd.Parameters.AddWithValue("@1", cmbBox_patient_id.Text);
            cmd.Parameters.AddWithValue("@2", cmbBox_medicine_type.Text);
            cmd.Parameters.AddWithValue("@3", textBox1.Text);
            cmd.Parameters.AddWithValue("@4", textBox_duration.Text);
            cmd.Parameters.AddWithValue("@5", id);

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
            cmd = new MySqlCommand("SELECT * FROM `patient_medication_schedule` WHERE `id` = ?", con.open());
            cmd.Parameters.AddWithValue("@1", id);
            daat = new MySqlDataAdapter(cmd);
            data = new DataTable();
            daat.Fill(data);

            cmbBox_patient_id.Text = data.Rows[0][1].ToString();
            cmbBox_medicine_type.Text = data.Rows[0][2].ToString();
            textBox1.Text = data.Rows[0][3].ToString();
            textBox_duration.Text = data.Rows[0][4].ToString();

            con.close();
        }
        private void load()
        {
            dataGridView1.Rows.Clear();

            cmd = new MySqlCommand("SELECT * FROM `patient_medication_schedule`", con.open());
            dare = cmd.ExecuteReader();
            while (dare.Read())
            {
                dataGridView1.Rows.Add(dare.GetString("id"), dare.GetString("pat_id"), dare.GetString("medicine_name"), dare.GetString("dosage"), dare.GetString("duration"));

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
                cmd = new MySqlCommand("DELETE FROM `patient_medication_schedule` WHERE `id` = ?", con.open());
                cmd.Parameters.AddWithValue("@1", id);
                int check = Convert.ToInt32(cmd.ExecuteNonQuery());
                MessageBox.Show("Successfully Deleted");
                con.close();
                id = "";
            }

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

        private void search()
        {
            dataGridView1.Rows.Clear();

            cmd = new MySqlCommand("SELECT * FROM `patient_medication_schedule` WHERE `pat_id`=?", con.open());
            cmd.Parameters.AddWithValue("@1", comboBox1.Text);
            dare = cmd.ExecuteReader();
            while (dare.Read())
            {
                dataGridView1.Rows.Add(dare.GetString("id"), dare.GetString("pat_id"), dare.GetString("medicine_name"), dare.GetString("dosage"), dare.GetString("duration"));

            }

            dare.Close();
            con.close();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cmbBox_patient_id.Text == "" || cmbBox_medicine_type.Text == "")
            {

                MessageBox.Show("Enter Data Correctly");

            }
            else
            {
                if (btn_save.Text == "+ADD")
                {
                    add();
                    load();
                }
                else
                {
                    upd();
                    load();
                    _clear();
                    btn_save.Text = "+ADD";
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _clear();
            btn_save.Text = "+ADD";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            dlt();
            load();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            set_data();
            btn_save.Text = "UPDATE";
        }

        private void frm_custom_treatment_plan_Load(object sender, EventArgs e)
        {
            get_id("patient_reg", "id", cmbBox_patient_id);
            get_id("medicine_detailes", "name", cmbBox_medicine_type);
            get_id("patient_reg", "id", comboBox1);
            load();
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
    }
}
