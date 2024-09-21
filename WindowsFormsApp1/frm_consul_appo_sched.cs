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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsApp1
{
    public partial class frm_consul_appo_sched : Form
    {

        my_connection con = new my_connection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter daat = new MySqlDataAdapter();
        DataTable data = new DataTable();
        MySqlDataReader dare;

        String id;
        String selected_person;

        DateTime today = DateTime.Today;
        public frm_consul_appo_sched()
        {
            InitializeComponent();
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

        private void add()
        {


            cmd = new MySqlCommand("INSERT INTO `doctor_with_patient_appointment_schedule`(`doc_id`, `pat_id`, `date`, `time_slot`) VALUES (?,?,?,?)", con.open());
            cmd.Parameters.AddWithValue("@1", cmbBox_doc_id.Text);
            cmd.Parameters.AddWithValue("@2", cmbBox_patient_id.Text);
            cmd.Parameters.AddWithValue("@3", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@4", comboBox1.Text);


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


            cmd = new MySqlCommand("UPDATE `doctor_with_patient_appointment_schedule` SET `doc_id`=?,`pat_id`=?,`date`=?,`time_slot`=? WHERE `id`=?", con.open());


            cmd.Parameters.AddWithValue("@1", cmbBox_doc_id.Text);
            cmd.Parameters.AddWithValue("@2", cmbBox_patient_id.Text);
            cmd.Parameters.AddWithValue("@3", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@4", comboBox1.Text);
            cmd.Parameters.AddWithValue("@5", lbl_id.Text);

            int check = Convert.ToInt32(cmd.ExecuteNonQuery());
            con.close();
            if (check > 0)
            {
                MessageBox.Show("Successfully Updated");
            }
            else
            {
                MessageBox.Show("This Student Not Have");
            }


        }

        private void _clear()
        {
            comboBox1.Text = "";
            cmbBox_doc_id.Text = "";
            cmbBox_patient_id.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_consul_appo_sched_Load(object sender, EventArgs e)
        {

            get_id("patient_reg", "id", cmbBox_patient_id);
            get_id("doctor", "id", cmbBox_doc_id);
            load_with_person_based_all("*", "doc_id and pat_id");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || cmbBox_doc_id.Text == "" || cmbBox_patient_id.Text == "")
            {

                MessageBox.Show("Enter Data Correctly");

            }
            else
            {
                if (btn_save.Text == "SCHEDULE")
                {
                    add();
                    _clear();
                    load_with_person_based_all("*", "all doc_id and pat_id");
                }
                else
                {
                    upd();
                    _clear();
                    load_with_person_based_all("*", "all doc_id and pat_id");
                    btn_save.Text = "SCHEDULE";
                    lbl_id.Text = "ID";
                }

            }
        }

        public void set_data()
        {
            cmd = new MySqlCommand("SELECT * FROM `doctor_with_patient_appointment_schedule` WHERE `id` = ?", con.open());
            cmd.Parameters.AddWithValue("@1", id);
            daat = new MySqlDataAdapter(cmd);
            data = new DataTable();
            daat.Fill(data);


            lbl_id.Text = data.Rows[0][0].ToString();
            cmbBox_doc_id.Text = data.Rows[0][1].ToString();
            cmbBox_patient_id.Text = data.Rows[0][2].ToString();
            comboBox1.Text = data.Rows[0][4].ToString();
            

            con.close();

        }

        private void load_with_person_based_all(String person, String person_id)
        {
            dataGridView1.Rows.Clear();
            String Sel = "SELECT * FROM `doctor_with_patient_appointment_schedule` WHERE ";
            String equ = "=";
            String and_date = " AND `date`>=?";
            String coma = "`";

            String date_onyl = "`date`>=?";
            String genQuer;


            genQuer = Sel+ coma+ person+ coma+ equ+ coma+ person_id+coma+ and_date;


            if (person == "*")
            {
                genQuer = Sel  + date_onyl;
            }
            else
            {
                genQuer = Sel + coma + person + coma + equ + person_id + and_date;
            }


            cmd = new MySqlCommand(genQuer, con.open());
            cmd.Parameters.AddWithValue("@1", today);
            dare = cmd.ExecuteReader();
            while (dare.Read())
            {
                dataGridView1.Rows.Add(dare.GetString("id"), dare.GetString("doc_id"), dare.GetString("pat_id"), dare.GetString("date"), dare.GetString("time_slot"));

            }

            dare.Close();
            con.close();
        }

        private void dlt()
        {
            if (id == "")
            {
                MessageBox.Show("Please Select Appointment");
            }
            else
            {
                cmd = new MySqlCommand("DELETE FROM `doctor_with_patient_appointment_schedule` WHERE `id` = ?", con.open());
                cmd.Parameters.AddWithValue("@1", id);
                int check = Convert.ToInt32(cmd.ExecuteNonQuery());
                MessageBox.Show("Successfully Deleted");
                con.close();
                id = "";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            set_data();
            btn_save.Text = "RE-SCHEDULE";
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView1.Rows[rowindex];

            id = selectedrow.Cells[0].Value.ToString();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "Select Doctor ID";
            get_id("doctor", "id", comboBox2);
            selected_person = "doc_id";
            checkBox2.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "Select Patient ID";
            get_id("patient_reg", "id", comboBox2);
            selected_person = "pat_id";
            checkBox1.Checked = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked.Equals(false) && checkBox2.Checked.Equals(false))
            {
                MessageBox.Show("Select Person in Check Box");
            }
            else
            {
                if (comboBox2.Text == "Select Doctor ID")
                {
                    MessageBox.Show("Select Doctor ID");
                }
                else if(comboBox2.Text == "Select Patient ID")
                {
                    MessageBox.Show("Select Patient ID");
                }
                else
                {
                    if (checkBox1.Checked.Equals(true))
                    {
                        load_with_person_based_all("doc_id", comboBox2.Text);
                    }
                    else if (checkBox2.Checked.Equals(true))
                    {
                        load_with_person_based_all("pat_id", comboBox2.Text);
                    }
                }
            }

            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _clear();
            load_with_person_based_all("*", "all doc_id and pat_id");
            btn_save.Text = "SCHEDULE";
            lbl_id.Text = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dlt();
            load_with_person_based_all("*", "all doc_id and pat_id");
            btn_save.Text = "SCHEDULE";
            lbl_id.Text = "ID";
        }
    }
}
