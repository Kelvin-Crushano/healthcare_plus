
namespace WindowsFormsApp1
{
    partial class frm_medical_resources
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_medical_resources));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox_sort_by_equipment_type = new System.Windows.Forms.TextBox();
            this.lbl_sort_by_equipment_type = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.textBox_serial_no = new System.Windows.Forms.TextBox();
            this.textBox_model = new System.Windows.Forms.TextBox();
            this.textBox_manufacturer = new System.Windows.Forms.TextBox();
            this.lbl_serial_no = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.textBox_equipment_type = new System.Windows.Forms.TextBox();
            this.lbl_maufacturer = new System.Windows.Forms.Label();
            this.lbl_equipment_type = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.textBox_sort_by_equipment_type);
            this.panel2.Controls.Add(this.lbl_sort_by_equipment_type);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(256, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 237);
            this.panel2.TabIndex = 185;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(403, 18);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 27);
            this.btn_search.TabIndex = 93;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // textBox_sort_by_equipment_type
            // 
            this.textBox_sort_by_equipment_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox_sort_by_equipment_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sort_by_equipment_type.Location = new System.Drawing.Point(230, 19);
            this.textBox_sort_by_equipment_type.Name = "textBox_sort_by_equipment_type";
            this.textBox_sort_by_equipment_type.Size = new System.Drawing.Size(167, 26);
            this.textBox_sort_by_equipment_type.TabIndex = 92;
            // 
            // lbl_sort_by_equipment_type
            // 
            this.lbl_sort_by_equipment_type.AutoSize = true;
            this.lbl_sort_by_equipment_type.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sort_by_equipment_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sort_by_equipment_type.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_sort_by_equipment_type.Location = new System.Drawing.Point(17, 22);
            this.lbl_sort_by_equipment_type.Name = "lbl_sort_by_equipment_type";
            this.lbl_sort_by_equipment_type.Size = new System.Drawing.Size(207, 20);
            this.lbl_sort_by_equipment_type.TabIndex = 91;
            this.lbl_sort_by_equipment_type.Text = "Sort By: Equipment Type";
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
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(21, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(822, 180);
            this.dataGridView1.TabIndex = 90;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.textBox_serial_no);
            this.panel1.Controls.Add(this.textBox_model);
            this.panel1.Controls.Add(this.textBox_manufacturer);
            this.panel1.Controls.Add(this.lbl_serial_no);
            this.panel1.Controls.Add(this.lbl_model);
            this.panel1.Controls.Add(this.textBox_equipment_type);
            this.panel1.Controls.Add(this.lbl_maufacturer);
            this.panel1.Controls.Add(this.lbl_equipment_type);
            this.panel1.Location = new System.Drawing.Point(291, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 243);
            this.panel1.TabIndex = 186;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(676, 160);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 27);
            this.btn_save.TabIndex = 193;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(768, 21);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 27);
            this.btn_delete.TabIndex = 191;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // textBox_serial_no
            // 
            this.textBox_serial_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_serial_no.Location = new System.Drawing.Point(541, 114);
            this.textBox_serial_no.Name = "textBox_serial_no";
            this.textBox_serial_no.Size = new System.Drawing.Size(200, 26);
            this.textBox_serial_no.TabIndex = 188;
            // 
            // textBox_model
            // 
            this.textBox_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_model.Location = new System.Drawing.Point(186, 114);
            this.textBox_model.Name = "textBox_model";
            this.textBox_model.Size = new System.Drawing.Size(200, 26);
            this.textBox_model.TabIndex = 188;
            // 
            // textBox_manufacturer
            // 
            this.textBox_manufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_manufacturer.Location = new System.Drawing.Point(541, 56);
            this.textBox_manufacturer.Name = "textBox_manufacturer";
            this.textBox_manufacturer.Size = new System.Drawing.Size(200, 26);
            this.textBox_manufacturer.TabIndex = 189;
            // 
            // lbl_serial_no
            // 
            this.lbl_serial_no.AutoSize = true;
            this.lbl_serial_no.BackColor = System.Drawing.Color.Transparent;
            this.lbl_serial_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_serial_no.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_serial_no.Location = new System.Drawing.Point(412, 117);
            this.lbl_serial_no.Name = "lbl_serial_no";
            this.lbl_serial_no.Size = new System.Drawing.Size(122, 20);
            this.lbl_serial_no.TabIndex = 185;
            this.lbl_serial_no.Text = "Serial Number";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.BackColor = System.Drawing.Color.Transparent;
            this.lbl_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_model.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_model.Location = new System.Drawing.Point(123, 117);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(57, 20);
            this.lbl_model.TabIndex = 185;
            this.lbl_model.Text = "Model";
            // 
            // textBox_equipment_type
            // 
            this.textBox_equipment_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_equipment_type.Location = new System.Drawing.Point(186, 56);
            this.textBox_equipment_type.Name = "textBox_equipment_type";
            this.textBox_equipment_type.Size = new System.Drawing.Size(200, 26);
            this.textBox_equipment_type.TabIndex = 190;
            // 
            // lbl_maufacturer
            // 
            this.lbl_maufacturer.AutoSize = true;
            this.lbl_maufacturer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_maufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maufacturer.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_maufacturer.Location = new System.Drawing.Point(418, 59);
            this.lbl_maufacturer.Name = "lbl_maufacturer";
            this.lbl_maufacturer.Size = new System.Drawing.Size(116, 20);
            this.lbl_maufacturer.TabIndex = 186;
            this.lbl_maufacturer.Text = "Manufacturer";
            // 
            // lbl_equipment_type
            // 
            this.lbl_equipment_type.AutoSize = true;
            this.lbl_equipment_type.BackColor = System.Drawing.Color.Transparent;
            this.lbl_equipment_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_equipment_type.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_equipment_type.Location = new System.Drawing.Point(42, 59);
            this.lbl_equipment_type.Name = "lbl_equipment_type";
            this.lbl_equipment_type.Size = new System.Drawing.Size(138, 20);
            this.lbl_equipment_type.TabIndex = 187;
            this.lbl_equipment_type.Text = "Equipment Type";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.HeaderText = "EQUIPMENT TYPE";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 116;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "MODEL";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "MENUFECTURER";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "SERIAL NUMBER";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // frm_medical_resources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_medical_resources";
            this.Text = "Medical Resource";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_medical_resources_Load);
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
        private System.Windows.Forms.TextBox textBox_sort_by_equipment_type;
        private System.Windows.Forms.Label lbl_sort_by_equipment_type;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox textBox_model;
        private System.Windows.Forms.TextBox textBox_manufacturer;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.TextBox textBox_equipment_type;
        private System.Windows.Forms.Label lbl_maufacturer;
        private System.Windows.Forms.Label lbl_equipment_type;
        private System.Windows.Forms.TextBox textBox_serial_no;
        private System.Windows.Forms.Label lbl_serial_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}