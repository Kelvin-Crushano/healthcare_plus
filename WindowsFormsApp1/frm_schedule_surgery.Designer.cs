
namespace WindowsFormsApp1
{
    partial class frm_schedule_surgery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_schedule_surgery));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox_sort_by_patient_id = new System.Windows.Forms.TextBox();
            this.lbl_sort_by_patient_id = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.textBox_surgery_time = new System.Windows.Forms.TextBox();
            this.lbl_surgery_time = new System.Windows.Forms.Label();
            this.dateTimePicker_surgery_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_surgery_date = new System.Windows.Forms.Label();
            this.cmbBox_available_operation_theater = new System.Windows.Forms.ComboBox();
            this.cmbBox_surgery_type = new System.Windows.Forms.ComboBox();
            this.cmbBox_patient_id = new System.Windows.Forms.ComboBox();
            this.lbl_available_operation_theater = new System.Windows.Forms.Label();
            this.lbl_surgery_type = new System.Windows.Forms.Label();
            this.lbl_patient_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.textBox_sort_by_patient_id);
            this.panel2.Controls.Add(this.lbl_sort_by_patient_id);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(229, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 222);
            this.panel2.TabIndex = 132;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(363, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 27);
            this.btn_search.TabIndex = 93;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // textBox_sort_by_patient_id
            // 
            this.textBox_sort_by_patient_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox_sort_by_patient_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sort_by_patient_id.Location = new System.Drawing.Point(190, 20);
            this.textBox_sort_by_patient_id.Name = "textBox_sort_by_patient_id";
            this.textBox_sort_by_patient_id.Size = new System.Drawing.Size(167, 26);
            this.textBox_sort_by_patient_id.TabIndex = 92;
            // 
            // lbl_sort_by_patient_id
            // 
            this.lbl_sort_by_patient_id.AutoSize = true;
            this.lbl_sort_by_patient_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sort_by_patient_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sort_by_patient_id.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_sort_by_patient_id.Location = new System.Drawing.Point(17, 22);
            this.lbl_sort_by_patient_id.Name = "lbl_sort_by_patient_id";
            this.lbl_sort_by_patient_id.Size = new System.Drawing.Size(164, 20);
            this.lbl_sort_by_patient_id.TabIndex = 91;
            this.lbl_sort_by_patient_id.Text = "Sort By:  Patient ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(822, 150);
            this.dataGridView1.TabIndex = 90;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.textBox_surgery_time);
            this.panel1.Controls.Add(this.lbl_surgery_time);
            this.panel1.Controls.Add(this.dateTimePicker_surgery_date);
            this.panel1.Controls.Add(this.lbl_surgery_date);
            this.panel1.Controls.Add(this.cmbBox_available_operation_theater);
            this.panel1.Controls.Add(this.cmbBox_surgery_type);
            this.panel1.Controls.Add(this.cmbBox_patient_id);
            this.panel1.Controls.Add(this.lbl_available_operation_theater);
            this.panel1.Controls.Add(this.lbl_surgery_type);
            this.panel1.Controls.Add(this.lbl_patient_id);
            this.panel1.Location = new System.Drawing.Point(250, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 240);
            this.panel1.TabIndex = 133;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(734, 187);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 27);
            this.btn_save.TabIndex = 144;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(653, 187);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 27);
            this.btn_update.TabIndex = 143;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(572, 187);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 27);
            this.btn_delete.TabIndex = 142;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // textBox_surgery_time
            // 
            this.textBox_surgery_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_surgery_time.Location = new System.Drawing.Point(643, 104);
            this.textBox_surgery_time.Name = "textBox_surgery_time";
            this.textBox_surgery_time.Size = new System.Drawing.Size(163, 26);
            this.textBox_surgery_time.TabIndex = 141;
            // 
            // lbl_surgery_time
            // 
            this.lbl_surgery_time.AutoSize = true;
            this.lbl_surgery_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_surgery_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_surgery_time.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_surgery_time.Location = new System.Drawing.Point(523, 105);
            this.lbl_surgery_time.Name = "lbl_surgery_time";
            this.lbl_surgery_time.Size = new System.Drawing.Size(114, 20);
            this.lbl_surgery_time.TabIndex = 140;
            this.lbl_surgery_time.Text = "Surgery Time";
            // 
            // dateTimePicker_surgery_date
            // 
            this.dateTimePicker_surgery_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_surgery_date.Location = new System.Drawing.Point(242, 99);
            this.dateTimePicker_surgery_date.Name = "dateTimePicker_surgery_date";
            this.dateTimePicker_surgery_date.Size = new System.Drawing.Size(275, 26);
            this.dateTimePicker_surgery_date.TabIndex = 139;
            // 
            // lbl_surgery_date
            // 
            this.lbl_surgery_date.AutoSize = true;
            this.lbl_surgery_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_surgery_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_surgery_date.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_surgery_date.Location = new System.Drawing.Point(121, 104);
            this.lbl_surgery_date.Name = "lbl_surgery_date";
            this.lbl_surgery_date.Size = new System.Drawing.Size(115, 20);
            this.lbl_surgery_date.TabIndex = 138;
            this.lbl_surgery_date.Text = "Surgery Date";
            // 
            // cmbBox_available_operation_theater
            // 
            this.cmbBox_available_operation_theater.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_available_operation_theater.FormattingEnabled = true;
            this.cmbBox_available_operation_theater.Location = new System.Drawing.Point(242, 150);
            this.cmbBox_available_operation_theater.Name = "cmbBox_available_operation_theater";
            this.cmbBox_available_operation_theater.Size = new System.Drawing.Size(120, 28);
            this.cmbBox_available_operation_theater.TabIndex = 135;
            // 
            // cmbBox_surgery_type
            // 
            this.cmbBox_surgery_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_surgery_type.FormattingEnabled = true;
            this.cmbBox_surgery_type.Location = new System.Drawing.Point(643, 41);
            this.cmbBox_surgery_type.Name = "cmbBox_surgery_type";
            this.cmbBox_surgery_type.Size = new System.Drawing.Size(163, 28);
            this.cmbBox_surgery_type.TabIndex = 136;
            // 
            // cmbBox_patient_id
            // 
            this.cmbBox_patient_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_patient_id.FormattingEnabled = true;
            this.cmbBox_patient_id.Location = new System.Drawing.Point(242, 44);
            this.cmbBox_patient_id.Name = "cmbBox_patient_id";
            this.cmbBox_patient_id.Size = new System.Drawing.Size(120, 28);
            this.cmbBox_patient_id.TabIndex = 137;
            // 
            // lbl_available_operation_theater
            // 
            this.lbl_available_operation_theater.AutoSize = true;
            this.lbl_available_operation_theater.BackColor = System.Drawing.Color.Transparent;
            this.lbl_available_operation_theater.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_available_operation_theater.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_available_operation_theater.Location = new System.Drawing.Point(4, 153);
            this.lbl_available_operation_theater.Name = "lbl_available_operation_theater";
            this.lbl_available_operation_theater.Size = new System.Drawing.Size(232, 20);
            this.lbl_available_operation_theater.TabIndex = 132;
            this.lbl_available_operation_theater.Text = "Available Operation Theater";
            // 
            // lbl_surgery_type
            // 
            this.lbl_surgery_type.AutoSize = true;
            this.lbl_surgery_type.BackColor = System.Drawing.Color.Transparent;
            this.lbl_surgery_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_surgery_type.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_surgery_type.Location = new System.Drawing.Point(523, 44);
            this.lbl_surgery_type.Name = "lbl_surgery_type";
            this.lbl_surgery_type.Size = new System.Drawing.Size(114, 20);
            this.lbl_surgery_type.TabIndex = 133;
            this.lbl_surgery_type.Text = "Surgery Type";
            // 
            // lbl_patient_id
            // 
            this.lbl_patient_id.AutoSize = true;
            this.lbl_patient_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_patient_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_id.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_patient_id.Location = new System.Drawing.Point(146, 47);
            this.lbl_patient_id.Name = "lbl_patient_id";
            this.lbl_patient_id.Size = new System.Drawing.Size(90, 20);
            this.lbl_patient_id.TabIndex = 134;
            this.lbl_patient_id.Text = "Patient ID";
            // 
            // frm_schedule_surgery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_schedule_surgery";
            this.Text = "Schedule Surgery";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textBox_sort_by_patient_id;
        private System.Windows.Forms.Label lbl_sort_by_patient_id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox textBox_surgery_time;
        private System.Windows.Forms.Label lbl_surgery_time;
        private System.Windows.Forms.DateTimePicker dateTimePicker_surgery_date;
        private System.Windows.Forms.Label lbl_surgery_date;
        private System.Windows.Forms.ComboBox cmbBox_available_operation_theater;
        private System.Windows.Forms.ComboBox cmbBox_surgery_type;
        private System.Windows.Forms.ComboBox cmbBox_patient_id;
        private System.Windows.Forms.Label lbl_available_operation_theater;
        private System.Windows.Forms.Label lbl_surgery_type;
        private System.Windows.Forms.Label lbl_patient_id;
    }
}