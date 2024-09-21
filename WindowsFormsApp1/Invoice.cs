using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace HospitalProject
{
    public partial class Invoice : Form
    {
        my_connection con = new my_connection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter daat = new MySqlDataAdapter();
        DataTable data = new DataTable();
        MySqlDataReader dare;

        String id;
        double grn_tot = 0;
        public Invoice()
        {
            InitializeComponent();
        }

        private void pr()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintPage);

            // You can set additional print settings here if needed
            // For example, pd.PrinterSettings.PrinterName = "YourPrinterName";

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            printPreviewDialog1.Document = pd;
  


            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            int rw_spc = 300;
            // Your report content drawing logic goes here
            // Use the Graphics object (e.Graphics) to draw text, shapes, images, etc.

            // Example: Draw "Hello, World!" at position (100, 100)
            e.Graphics.DrawString("INVOICE", new Font("Arial", 12), Brushes.Black, new PointF(450, 150));
            e.Graphics.DrawString("---------------", new Font("Arial", 12), Brushes.Black, new PointF(450, 200));
            e.Graphics.DrawString("Item Name", new Font("Arial", 12), Brushes.Black, new PointF(100, 250));
            e.Graphics.DrawString("Item Qty", new Font("Arial", 12), Brushes.Black, new PointF(300, 250));
            e.Graphics.DrawString("Item Amount", new Font("Arial", 12), Brushes.Black, new PointF(500, 250));
            e.Graphics.DrawString("Item Total", new Font("Arial", 12), Brushes.Black, new PointF(700, 250));


            for(int i = 0; i<dataGridView1.RowCount; i++)
            {
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), new Font("Arial", 12), Brushes.Black, new PointF(100, rw_spc));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 12), Brushes.Black, new PointF(300, rw_spc));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 12), Brushes.Black, new PointF(500, rw_spc));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 12), Brushes.Black, new PointF(700, rw_spc));

                rw_spc = rw_spc + 50;
            }

            rw_spc = rw_spc + 50;

            e.Graphics.DrawString("Grand Total : ", new Font("Arial", 12), Brushes.Black, new PointF(500, rw_spc));
            e.Graphics.DrawString(grn_tot.ToString(), new Font("Arial", 12), Brushes.Black, new PointF(700, rw_spc));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pr();
            dataGridView1.Rows.Clear();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

        private void add_datagrid()
        {
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dataGridView1);
            newRow.Cells[0].Value = comboBox1.Text;
            newRow.Cells[1].Value = textBox2.Text;
            newRow.Cells[2].Value = textBox3.Text;
            newRow.Cells[3].Value = label1.Text;
            dataGridView1.Rows.Add(newRow);
        }

        private void calculate()
        {
            double qty;
            double amnt;
            double tot_amount;
            double g_tot;

            qty = double.Parse(textBox2.Text);
            amnt = double.Parse(textBox3.Text);
            tot_amount = qty * amnt;

            label1.Text = tot_amount.ToString();
        }
        private void Invoice_Load(object sender, EventArgs e)
        {
            //get_id("medicine_detailes", "name", comboBox1);
            //get_id("room_with_amt", "name", comboBox1);
            get_id("patient_reg", "id", comboBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "" || comboBox2.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please Enter Data Correectly");
            }
            else
            {
                add_desc();
                add_datagrid();
                _clear();
                cal_grn_tot();
            }
            

        }
        private void _clear()
        {
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label1.Text = "0.00";
        }

        private void add_desc()
        {


            cmd = new MySqlCommand("INSERT INTO `patient_medicin_prescription`(`pat_id`, `medicine_name`, `qty`, `amount`, `tot_amount`, `date`) VALUES (?,?,?,?,?,?)", con.open());
            cmd.Parameters.AddWithValue("@1", comboBox2.Text);
            cmd.Parameters.AddWithValue("@2", comboBox1.Text);
            cmd.Parameters.AddWithValue("@3", textBox2.Text);
            cmd.Parameters.AddWithValue("@4", textBox3.Text);
            cmd.Parameters.AddWithValue("@5", label1.Text);
            cmd.Parameters.AddWithValue("@6", dateTimePicker1.Value);

            int check = Convert.ToInt32(cmd.ExecuteNonQuery());
            con.close();


        }

        void cal_grn_tot()
        {
            
            double get_amt = 0;
            grn_tot = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                get_amt = double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());

                grn_tot = grn_tot + get_amt;
            }

            label7.Text = grn_tot.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void search_item_medicine()
        {
            

            cmd = new MySqlCommand("SELECT * FROM `medicine_detailes` WHERE `name`=?", con.open());
            cmd.Parameters.AddWithValue("@1", comboBox1.Text);
            daat = new MySqlDataAdapter(cmd);
            data.Clear();
            daat.Fill(data);
            con.close();


            if (data.Rows.Count > 0)
            {
                //.Show(data.ToString());
                //textBox3.Text = data["amount"].ToString();
                foreach (DataRow row in data.Rows)
                {
                    textBox3.Text = row["amount"].ToString();
                }
            }
            else
            {
                MessageBox.Show("This Item Havent");
            }

            dare.Close();
            con.close();

        }

        private void search_item_room()
        {


            cmd = new MySqlCommand("SELECT * FROM `room_with_amt` WHERE `room_no`=?", con.open());
            cmd.Parameters.AddWithValue("@1", comboBox1.Text);
            daat = new MySqlDataAdapter(cmd);
            data.Clear();
            daat.Fill(data);
            con.close();


            if (data.Rows.Count > 0)
            {
                //.Show(data.ToString());
                //textBox3.Text = data["amount"].ToString();
                foreach (DataRow row in data.Rows)
                {
                    textBox3.Text = row["amnt"].ToString();
                }
            }
            else
            {
                MessageBox.Show("This Item Havent");
            }

            dare.Close();
            con.close();

        }

        private void comboBox1_ValueMemberChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                search_item_medicine();
            }
            else if(checkBox2.Checked == true)
            {
                search_item_room();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            get_id("medicine_detailes", "name", comboBox1);
            checkBox2.Checked = false;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            get_id("room_with_amt", "room_no", comboBox1);
            checkBox1.Checked = false;


        }
    }
}
