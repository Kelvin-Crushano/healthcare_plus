
namespace WindowsFormsApp1
{
    partial class frm_theater_availability
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_theater_availability));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.dateTimePicker_discharge_date = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_admission_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_discharge_date = new System.Windows.Forms.Label();
            this.lbl_admission_date = new System.Windows.Forms.Label();
            this.cmbBox_room_no = new System.Windows.Forms.ComboBox();
            this.cmbBox_room_type = new System.Windows.Forms.ComboBox();
            this.cmbBox_patient_id = new System.Windows.Forms.ComboBox();
            this.lbl_room_no = new System.Windows.Forms.Label();
            this.lbl_room_type = new System.Windows.Forms.Label();
            this.lbl_patient_id = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_sort_by_patient_id = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "NO : 01",
            "NO : 02",
            "NO : 03",
            "NO : 04",
            "NO : 05",
            "NO : 06"});
            this.comboBox1.Location = new System.Drawing.Point(202, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 28);
            this.comboBox1.TabIndex = 161;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(687, 190);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 27);
            this.btn_save.TabIndex = 160;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // dateTimePicker_discharge_date
            // 
            this.dateTimePicker_discharge_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_discharge_date.Location = new System.Drawing.Point(192, 135);
            this.dateTimePicker_discharge_date.Name = "dateTimePicker_discharge_date";
            this.dateTimePicker_discharge_date.Size = new System.Drawing.Size(275, 26);
            this.dateTimePicker_discharge_date.TabIndex = 156;
            // 
            // dateTimePicker_admission_date
            // 
            this.dateTimePicker_admission_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_admission_date.Location = new System.Drawing.Point(507, 37);
            this.dateTimePicker_admission_date.Name = "dateTimePicker_admission_date";
            this.dateTimePicker_admission_date.Size = new System.Drawing.Size(260, 26);
            this.dateTimePicker_admission_date.TabIndex = 157;
            // 
            // lbl_discharge_date
            // 
            this.lbl_discharge_date.AutoSize = true;
            this.lbl_discharge_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_discharge_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discharge_date.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_discharge_date.Location = new System.Drawing.Point(51, 140);
            this.lbl_discharge_date.Name = "lbl_discharge_date";
            this.lbl_discharge_date.Size = new System.Drawing.Size(134, 20);
            this.lbl_discharge_date.TabIndex = 154;
            this.lbl_discharge_date.Text = "Discharge Date";
            // 
            // lbl_admission_date
            // 
            this.lbl_admission_date.AutoSize = true;
            this.lbl_admission_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_admission_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admission_date.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_admission_date.Location = new System.Drawing.Point(351, 42);
            this.lbl_admission_date.Name = "lbl_admission_date";
            this.lbl_admission_date.Size = new System.Drawing.Size(135, 20);
            this.lbl_admission_date.TabIndex = 155;
            this.lbl_admission_date.Text = "Admission Date";
            // 
            // cmbBox_room_no
            // 
            this.cmbBox_room_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_room_no.FormattingEnabled = true;
            this.cmbBox_room_no.Items.AddRange(new object[] {
            "NO : 01",
            "NO : 02",
            "NO : 03",
            "NO : 04",
            "NO : 05",
            "NO : 06"});
            this.cmbBox_room_no.Location = new System.Drawing.Point(507, 86);
            this.cmbBox_room_no.Name = "cmbBox_room_no";
            this.cmbBox_room_no.Size = new System.Drawing.Size(260, 28);
            this.cmbBox_room_no.TabIndex = 151;
            // 
            // cmbBox_room_type
            // 
            this.cmbBox_room_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_room_type.FormattingEnabled = true;
            this.cmbBox_room_type.Items.AddRange(new object[] {
            "NORMAL",
            "INDERMEDIATE",
            "ADVANCE"});
            this.cmbBox_room_type.Location = new System.Drawing.Point(192, 86);
            this.cmbBox_room_type.Name = "cmbBox_room_type";
            this.cmbBox_room_type.Size = new System.Drawing.Size(130, 28);
            this.cmbBox_room_type.TabIndex = 152;
            // 
            // cmbBox_patient_id
            // 
            this.cmbBox_patient_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_patient_id.FormattingEnabled = true;
            this.cmbBox_patient_id.Location = new System.Drawing.Point(192, 34);
            this.cmbBox_patient_id.Name = "cmbBox_patient_id";
            this.cmbBox_patient_id.Size = new System.Drawing.Size(130, 28);
            this.cmbBox_patient_id.TabIndex = 153;
            // 
            // lbl_room_no
            // 
            this.lbl_room_no.AutoSize = true;
            this.lbl_room_no.BackColor = System.Drawing.Color.Transparent;
            this.lbl_room_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_no.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_room_no.Location = new System.Drawing.Point(363, 89);
            this.lbl_room_no.Name = "lbl_room_no";
            this.lbl_room_no.Size = new System.Drawing.Size(138, 20);
            this.lbl_room_no.TabIndex = 148;
            this.lbl_room_no.Text = "Theater Number";
            // 
            // lbl_room_type
            // 
            this.lbl_room_type.AutoSize = true;
            this.lbl_room_type.BackColor = System.Drawing.Color.Transparent;
            this.lbl_room_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_type.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_room_type.Location = new System.Drawing.Point(87, 89);
            this.lbl_room_type.Name = "lbl_room_type";
            this.lbl_room_type.Size = new System.Drawing.Size(47, 20);
            this.lbl_room_type.TabIndex = 149;
            this.lbl_room_type.Text = "Type";
            // 
            // lbl_patient_id
            // 
            this.lbl_patient_id.AutoSize = true;
            this.lbl_patient_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_patient_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_id.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_patient_id.Location = new System.Drawing.Point(96, 37);
            this.lbl_patient_id.Name = "lbl_patient_id";
            this.lbl_patient_id.Size = new System.Drawing.Size(90, 20);
            this.lbl_patient_id.TabIndex = 150;
            this.lbl_patient_id.Text = "Patient ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.dateTimePicker_discharge_date);
            this.panel1.Controls.Add(this.dateTimePicker_admission_date);
            this.panel1.Controls.Add(this.lbl_discharge_date);
            this.panel1.Controls.Add(this.lbl_admission_date);
            this.panel1.Controls.Add(this.cmbBox_room_no);
            this.panel1.Controls.Add(this.cmbBox_room_type);
            this.panel1.Controls.Add(this.cmbBox_patient_id);
            this.panel1.Controls.Add(this.lbl_room_no);
            this.panel1.Controls.Add(this.lbl_room_type);
            this.panel1.Controls.Add(this.lbl_patient_id);
            this.panel1.Location = new System.Drawing.Point(337, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 251);
            this.panel1.TabIndex = 152;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(376, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 27);
            this.btn_search.TabIndex = 93;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_sort_by_patient_id
            // 
            this.lbl_sort_by_patient_id.AutoSize = true;
            this.lbl_sort_by_patient_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sort_by_patient_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sort_by_patient_id.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_sort_by_patient_id.Location = new System.Drawing.Point(17, 22);
            this.lbl_sort_by_patient_id.Name = "lbl_sort_by_patient_id";
            this.lbl_sort_by_patient_id.Size = new System.Drawing.Size(172, 20);
            this.lbl_sort_by_patient_id.TabIndex = 91;
            this.lbl_sort_by_patient_id.Text = "Sort By:  Theater No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(21, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(822, 150);
            this.dataGridView1.TabIndex = 90;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "PATIENT ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "ADMISSION DATE";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "TYPE";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "THEATER NO";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "DISCHARGE DATE";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.lbl_sort_by_patient_id);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(316, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 264);
            this.panel2.TabIndex = 151;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(768, 219);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 27);
            this.btn_delete.TabIndex = 158;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 150;
            this.pictureBox1.TabStop = false;
            // 
            // frm_theater_availability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_theater_availability";
            this.Text = "Theater Availability";
            this.Load += new System.EventHandler(this.frm_theater_availability_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DateTimePicker dateTimePicker_discharge_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_admission_date;
        private System.Windows.Forms.Label lbl_discharge_date;
        private System.Windows.Forms.Label lbl_admission_date;
        private System.Windows.Forms.ComboBox cmbBox_room_no;
        private System.Windows.Forms.ComboBox cmbBox_room_type;
        private System.Windows.Forms.ComboBox cmbBox_patient_id;
        private System.Windows.Forms.Label lbl_room_no;
        private System.Windows.Forms.Label lbl_room_type;
        private System.Windows.Forms.Label lbl_patient_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_sort_by_patient_id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}