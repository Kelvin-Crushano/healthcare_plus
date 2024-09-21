
namespace WindowsFormsApp1
{
    partial class frm_patient_profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_patient_profile));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.textBox_patient_dob = new System.Windows.Forms.TextBox();
            this.textBox_patient_age = new System.Windows.Forms.TextBox();
            this.textBox_patient_email = new System.Windows.Forms.TextBox();
            this.textBox_patient_mob = new System.Windows.Forms.TextBox();
            this.textBox_patient_nic = new System.Windows.Forms.TextBox();
            this.textBox_patient_addr = new System.Windows.Forms.TextBox();
            this.textBox_patient_name = new System.Windows.Forms.TextBox();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.lbl_patient_dob = new System.Windows.Forms.Label();
            this.lbl_patient_gender = new System.Windows.Forms.Label();
            this.lbl_patient_age = new System.Windows.Forms.Label();
            this.lbl_patient_email = new System.Windows.Forms.Label();
            this.lbl_patient_mob = new System.Windows.Forms.Label();
            this.lbl_patient_nic = new System.Windows.Forms.Label();
            this.lbl_patient_address = new System.Windows.Forms.Label();
            this.lbl_patient_name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox_sort_by_patient_nic = new System.Windows.Forms.TextBox();
            this.lbl_sort_by_patient_nic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.textBox_patient_dob);
            this.panel1.Controls.Add(this.textBox_patient_age);
            this.panel1.Controls.Add(this.textBox_patient_email);
            this.panel1.Controls.Add(this.textBox_patient_mob);
            this.panel1.Controls.Add(this.textBox_patient_nic);
            this.panel1.Controls.Add(this.textBox_patient_addr);
            this.panel1.Controls.Add(this.textBox_patient_name);
            this.panel1.Controls.Add(this.radioButton_female);
            this.panel1.Controls.Add(this.radioButton_male);
            this.panel1.Controls.Add(this.lbl_patient_dob);
            this.panel1.Controls.Add(this.lbl_patient_gender);
            this.panel1.Controls.Add(this.lbl_patient_age);
            this.panel1.Controls.Add(this.lbl_patient_email);
            this.panel1.Controls.Add(this.lbl_patient_mob);
            this.panel1.Controls.Add(this.lbl_patient_nic);
            this.panel1.Controls.Add(this.lbl_patient_address);
            this.panel1.Controls.Add(this.lbl_patient_name);
            this.panel1.Location = new System.Drawing.Point(280, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 231);
            this.panel1.TabIndex = 7;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(698, 193);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 27);
            this.btn_save.TabIndex = 25;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(573, 193);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 27);
            this.btn_update.TabIndex = 24;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(455, 193);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 27);
            this.btn_delete.TabIndex = 23;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // textBox_patient_dob
            // 
            this.textBox_patient_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_patient_dob.Location = new System.Drawing.Point(192, 145);
            this.textBox_patient_dob.Name = "textBox_patient_dob";
            this.textBox_patient_dob.Size = new System.Drawing.Size(200, 26);
            this.textBox_patient_dob.TabIndex = 21;
            // 
            // textBox_patient_age
            // 
            this.textBox_patient_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_patient_age.Location = new System.Drawing.Point(192, 58);
            this.textBox_patient_age.Name = "textBox_patient_age";
            this.textBox_patient_age.Size = new System.Drawing.Size(200, 26);
            this.textBox_patient_age.TabIndex = 20;
            // 
            // textBox_patient_email
            // 
            this.textBox_patient_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_patient_email.Location = new System.Drawing.Point(573, 145);
            this.textBox_patient_email.Name = "textBox_patient_email";
            this.textBox_patient_email.Size = new System.Drawing.Size(200, 26);
            this.textBox_patient_email.TabIndex = 19;
            // 
            // textBox_patient_mob
            // 
            this.textBox_patient_mob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_patient_mob.Location = new System.Drawing.Point(573, 104);
            this.textBox_patient_mob.Name = "textBox_patient_mob";
            this.textBox_patient_mob.Size = new System.Drawing.Size(200, 26);
            this.textBox_patient_mob.TabIndex = 18;
            // 
            // textBox_patient_nic
            // 
            this.textBox_patient_nic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_patient_nic.Location = new System.Drawing.Point(573, 61);
            this.textBox_patient_nic.Name = "textBox_patient_nic";
            this.textBox_patient_nic.Size = new System.Drawing.Size(200, 26);
            this.textBox_patient_nic.TabIndex = 17;
            // 
            // textBox_patient_addr
            // 
            this.textBox_patient_addr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_patient_addr.Location = new System.Drawing.Point(573, 14);
            this.textBox_patient_addr.Name = "textBox_patient_addr";
            this.textBox_patient_addr.Size = new System.Drawing.Size(200, 26);
            this.textBox_patient_addr.TabIndex = 22;
            // 
            // textBox_patient_name
            // 
            this.textBox_patient_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_patient_name.Location = new System.Drawing.Point(192, 16);
            this.textBox_patient_name.Name = "textBox_patient_name";
            this.textBox_patient_name.Size = new System.Drawing.Size(200, 26);
            this.textBox_patient_name.TabIndex = 16;
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_female.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.radioButton_female.Location = new System.Drawing.Point(261, 107);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(80, 24);
            this.radioButton_female.TabIndex = 15;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = false;
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_male.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.radioButton_male.Location = new System.Drawing.Point(192, 107);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(61, 24);
            this.radioButton_male.TabIndex = 14;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = false;
            // 
            // lbl_patient_dob
            // 
            this.lbl_patient_dob.AutoSize = true;
            this.lbl_patient_dob.BackColor = System.Drawing.Color.Transparent;
            this.lbl_patient_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_dob.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_patient_dob.Location = new System.Drawing.Point(55, 148);
            this.lbl_patient_dob.Name = "lbl_patient_dob";
            this.lbl_patient_dob.Size = new System.Drawing.Size(115, 20);
            this.lbl_patient_dob.TabIndex = 12;
            this.lbl_patient_dob.Text = "Date Of Birth";
            // 
            // lbl_patient_gender
            // 
            this.lbl_patient_gender.AutoSize = true;
            this.lbl_patient_gender.BackColor = System.Drawing.Color.Transparent;
            this.lbl_patient_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_gender.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_patient_gender.Location = new System.Drawing.Point(39, 107);
            this.lbl_patient_gender.Name = "lbl_patient_gender";
            this.lbl_patient_gender.Size = new System.Drawing.Size(131, 20);
            this.lbl_patient_gender.TabIndex = 11;
            this.lbl_patient_gender.Text = "Patient Gender";
            // 
            // lbl_patient_age
            // 
            this.lbl_patient_age.AutoSize = true;
            this.lbl_patient_age.BackColor = System.Drawing.Color.Transparent;
            this.lbl_patient_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_age.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_patient_age.Location = new System.Drawing.Point(67, 61);
            this.lbl_patient_age.Name = "lbl_patient_age";
            this.lbl_patient_age.Size = new System.Drawing.Size(103, 20);
            this.lbl_patient_age.TabIndex = 10;
            this.lbl_patient_age.Text = "Patient Age";
            // 
            // lbl_patient_email
            // 
            this.lbl_patient_email.AutoSize = true;
            this.lbl_patient_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_patient_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_email.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_patient_email.Location = new System.Drawing.Point(415, 148);
            this.lbl_patient_email.Name = "lbl_patient_email";
            this.lbl_patient_email.Size = new System.Drawing.Size(115, 20);
            this.lbl_patient_email.TabIndex = 9;
            this.lbl_patient_email.Text = "Patient Email";
            // 
            // lbl_patient_mob
            // 
            this.lbl_patient_mob.AutoSize = true;
            this.lbl_patient_mob.BackColor = System.Drawing.Color.Transparent;
            this.lbl_patient_mob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_mob.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_patient_mob.Location = new System.Drawing.Point(415, 107);
            this.lbl_patient_mob.Name = "lbl_patient_mob";
            this.lbl_patient_mob.Size = new System.Drawing.Size(123, 20);
            this.lbl_patient_mob.TabIndex = 8;
            this.lbl_patient_mob.Text = "Patient Mobile";
            // 
            // lbl_patient_nic
            // 
            this.lbl_patient_nic.AutoSize = true;
            this.lbl_patient_nic.BackColor = System.Drawing.Color.Transparent;
            this.lbl_patient_nic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_nic.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_patient_nic.Location = new System.Drawing.Point(415, 61);
            this.lbl_patient_nic.Name = "lbl_patient_nic";
            this.lbl_patient_nic.Size = new System.Drawing.Size(101, 20);
            this.lbl_patient_nic.TabIndex = 7;
            this.lbl_patient_nic.Text = "Patient NIC";
            // 
            // lbl_patient_address
            // 
            this.lbl_patient_address.AutoSize = true;
            this.lbl_patient_address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_patient_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_address.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_patient_address.Location = new System.Drawing.Point(415, 17);
            this.lbl_patient_address.Name = "lbl_patient_address";
            this.lbl_patient_address.Size = new System.Drawing.Size(137, 20);
            this.lbl_patient_address.TabIndex = 13;
            this.lbl_patient_address.Text = "Patient Address";
            // 
            // lbl_patient_name
            // 
            this.lbl_patient_name.AutoSize = true;
            this.lbl_patient_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_patient_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_name.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_patient_name.Location = new System.Drawing.Point(53, 17);
            this.lbl_patient_name.Name = "lbl_patient_name";
            this.lbl_patient_name.Size = new System.Drawing.Size(117, 20);
            this.lbl_patient_name.TabIndex = 6;
            this.lbl_patient_name.Text = "Patient Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.textBox_sort_by_patient_nic);
            this.panel2.Controls.Add(this.lbl_sort_by_patient_nic);
            this.panel2.Location = new System.Drawing.Point(280, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 162);
            this.panel2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(716, 109);
            this.dataGridView1.TabIndex = 10;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(445, 8);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 27);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // textBox_sort_by_patient_nic
            // 
            this.textBox_sort_by_patient_nic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sort_by_patient_nic.Location = new System.Drawing.Point(218, 9);
            this.textBox_sort_by_patient_nic.Name = "textBox_sort_by_patient_nic";
            this.textBox_sort_by_patient_nic.Size = new System.Drawing.Size(200, 26);
            this.textBox_sort_by_patient_nic.TabIndex = 8;
            // 
            // lbl_sort_by_patient_nic
            // 
            this.lbl_sort_by_patient_nic.AutoSize = true;
            this.lbl_sort_by_patient_nic.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sort_by_patient_nic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sort_by_patient_nic.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_sort_by_patient_nic.Location = new System.Drawing.Point(28, 12);
            this.lbl_sort_by_patient_nic.Name = "lbl_sort_by_patient_nic";
            this.lbl_sort_by_patient_nic.Size = new System.Drawing.Size(170, 20);
            this.lbl_sort_by_patient_nic.TabIndex = 7;
            this.lbl_sort_by_patient_nic.Text = "Sort By: Patient NIC";
            // 
            // frm_patient_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 458);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_patient_profile";
            this.Text = "Patient Profile";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox textBox_patient_dob;
        private System.Windows.Forms.TextBox textBox_patient_age;
        private System.Windows.Forms.TextBox textBox_patient_email;
        private System.Windows.Forms.TextBox textBox_patient_mob;
        private System.Windows.Forms.TextBox textBox_patient_nic;
        private System.Windows.Forms.TextBox textBox_patient_addr;
        private System.Windows.Forms.TextBox textBox_patient_name;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.Label lbl_patient_dob;
        private System.Windows.Forms.Label lbl_patient_gender;
        private System.Windows.Forms.Label lbl_patient_age;
        private System.Windows.Forms.Label lbl_patient_email;
        private System.Windows.Forms.Label lbl_patient_mob;
        private System.Windows.Forms.Label lbl_patient_nic;
        private System.Windows.Forms.Label lbl_patient_address;
        private System.Windows.Forms.Label lbl_patient_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textBox_sort_by_patient_nic;
        private System.Windows.Forms.Label lbl_sort_by_patient_nic;
    }
}