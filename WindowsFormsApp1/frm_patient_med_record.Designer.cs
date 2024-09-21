
namespace WindowsFormsApp1
{
    partial class frm_patient_med_record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_patient_med_record));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.cmbBox_treatment_plan_id = new System.Windows.Forms.ComboBox();
            this.cmbBox_surgery_id = new System.Windows.Forms.ComboBox();
            this.cmbBox_patient_injury_id = new System.Windows.Forms.ComboBox();
            this.cmbBox_patient_illness_id = new System.Windows.Forms.ComboBox();
            this.cmbBox_lipid_pro_test_report_id = new System.Windows.Forms.ComboBox();
            this.cmbBox_ct_scan_report_id = new System.Windows.Forms.ComboBox();
            this.cmbBox_x_ray_test_report_id = new System.Windows.Forms.ComboBox();
            this.cmbBox_thyrox_test_report_id = new System.Windows.Forms.ComboBox();
            this.lbl_lipid_pro_test_report_id = new System.Windows.Forms.Label();
            this.lbl_ct_scan_report_id = new System.Windows.Forms.Label();
            this.lbl_x_ray_test_report_id = new System.Windows.Forms.Label();
            this.lbl_thyrox_test_report_id = new System.Windows.Forms.Label();
            this.cmbBox_fbs_test_report_id = new System.Windows.Forms.ComboBox();
            this.lbl_fbs_test_report_id = new System.Windows.Forms.Label();
            this.richTextBox_health_issue = new System.Windows.Forms.RichTextBox();
            this.textBox_weight = new System.Windows.Forms.TextBox();
            this.lbl_health_issue = new System.Windows.Forms.Label();
            this.lbl_surgery_id = new System.Windows.Forms.Label();
            this.lbl_patient_illness_id = new System.Windows.Forms.Label();
            this.lbl_treatment_plan_id = new System.Windows.Forms.Label();
            this.lbl_patient_injury_id = new System.Windows.Forms.Label();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.cmbBox_patient_id = new System.Windows.Forms.ComboBox();
            this.lbl_patient_id = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox_sort_by_patient_Id = new System.Windows.Forms.TextBox();
            this.lbl_sort_by_patient_id = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pictureBox1.Location = new System.Drawing.Point(-2, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.cmbBox_treatment_plan_id);
            this.panel1.Controls.Add(this.cmbBox_surgery_id);
            this.panel1.Controls.Add(this.cmbBox_patient_injury_id);
            this.panel1.Controls.Add(this.cmbBox_patient_illness_id);
            this.panel1.Controls.Add(this.cmbBox_lipid_pro_test_report_id);
            this.panel1.Controls.Add(this.cmbBox_ct_scan_report_id);
            this.panel1.Controls.Add(this.cmbBox_x_ray_test_report_id);
            this.panel1.Controls.Add(this.cmbBox_thyrox_test_report_id);
            this.panel1.Controls.Add(this.lbl_lipid_pro_test_report_id);
            this.panel1.Controls.Add(this.lbl_ct_scan_report_id);
            this.panel1.Controls.Add(this.lbl_x_ray_test_report_id);
            this.panel1.Controls.Add(this.lbl_thyrox_test_report_id);
            this.panel1.Controls.Add(this.cmbBox_fbs_test_report_id);
            this.panel1.Controls.Add(this.lbl_fbs_test_report_id);
            this.panel1.Controls.Add(this.richTextBox_health_issue);
            this.panel1.Controls.Add(this.textBox_weight);
            this.panel1.Controls.Add(this.lbl_health_issue);
            this.panel1.Controls.Add(this.lbl_surgery_id);
            this.panel1.Controls.Add(this.lbl_patient_illness_id);
            this.panel1.Controls.Add(this.lbl_treatment_plan_id);
            this.panel1.Controls.Add(this.lbl_patient_injury_id);
            this.panel1.Controls.Add(this.lbl_weight);
            this.panel1.Controls.Add(this.cmbBox_patient_id);
            this.panel1.Controls.Add(this.lbl_patient_id);
            this.panel1.Location = new System.Drawing.Point(242, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 460);
            this.panel1.TabIndex = 139;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(737, 407);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 27);
            this.btn_update.TabIndex = 162;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // cmbBox_treatment_plan_id
            // 
            this.cmbBox_treatment_plan_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_treatment_plan_id.FormattingEnabled = true;
            this.cmbBox_treatment_plan_id.Location = new System.Drawing.Point(665, 351);
            this.cmbBox_treatment_plan_id.Name = "cmbBox_treatment_plan_id";
            this.cmbBox_treatment_plan_id.Size = new System.Drawing.Size(147, 28);
            this.cmbBox_treatment_plan_id.TabIndex = 160;
            // 
            // cmbBox_surgery_id
            // 
            this.cmbBox_surgery_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_surgery_id.FormattingEnabled = true;
            this.cmbBox_surgery_id.Location = new System.Drawing.Point(240, 348);
            this.cmbBox_surgery_id.Name = "cmbBox_surgery_id";
            this.cmbBox_surgery_id.Size = new System.Drawing.Size(180, 28);
            this.cmbBox_surgery_id.TabIndex = 159;
            // 
            // cmbBox_patient_injury_id
            // 
            this.cmbBox_patient_injury_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_patient_injury_id.FormattingEnabled = true;
            this.cmbBox_patient_injury_id.Location = new System.Drawing.Point(665, 305);
            this.cmbBox_patient_injury_id.Name = "cmbBox_patient_injury_id";
            this.cmbBox_patient_injury_id.Size = new System.Drawing.Size(147, 28);
            this.cmbBox_patient_injury_id.TabIndex = 158;
            // 
            // cmbBox_patient_illness_id
            // 
            this.cmbBox_patient_illness_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_patient_illness_id.FormattingEnabled = true;
            this.cmbBox_patient_illness_id.Location = new System.Drawing.Point(240, 302);
            this.cmbBox_patient_illness_id.Name = "cmbBox_patient_illness_id";
            this.cmbBox_patient_illness_id.Size = new System.Drawing.Size(180, 28);
            this.cmbBox_patient_illness_id.TabIndex = 157;
            // 
            // cmbBox_lipid_pro_test_report_id
            // 
            this.cmbBox_lipid_pro_test_report_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_lipid_pro_test_report_id.FormattingEnabled = true;
            this.cmbBox_lipid_pro_test_report_id.Location = new System.Drawing.Point(665, 205);
            this.cmbBox_lipid_pro_test_report_id.Name = "cmbBox_lipid_pro_test_report_id";
            this.cmbBox_lipid_pro_test_report_id.Size = new System.Drawing.Size(147, 28);
            this.cmbBox_lipid_pro_test_report_id.TabIndex = 156;
            // 
            // cmbBox_ct_scan_report_id
            // 
            this.cmbBox_ct_scan_report_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_ct_scan_report_id.FormattingEnabled = true;
            this.cmbBox_ct_scan_report_id.Location = new System.Drawing.Point(665, 257);
            this.cmbBox_ct_scan_report_id.Name = "cmbBox_ct_scan_report_id";
            this.cmbBox_ct_scan_report_id.Size = new System.Drawing.Size(147, 28);
            this.cmbBox_ct_scan_report_id.TabIndex = 155;
            // 
            // cmbBox_x_ray_test_report_id
            // 
            this.cmbBox_x_ray_test_report_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_x_ray_test_report_id.FormattingEnabled = true;
            this.cmbBox_x_ray_test_report_id.Location = new System.Drawing.Point(240, 252);
            this.cmbBox_x_ray_test_report_id.Name = "cmbBox_x_ray_test_report_id";
            this.cmbBox_x_ray_test_report_id.Size = new System.Drawing.Size(180, 28);
            this.cmbBox_x_ray_test_report_id.TabIndex = 154;
            // 
            // cmbBox_thyrox_test_report_id
            // 
            this.cmbBox_thyrox_test_report_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_thyrox_test_report_id.FormattingEnabled = true;
            this.cmbBox_thyrox_test_report_id.Location = new System.Drawing.Point(240, 205);
            this.cmbBox_thyrox_test_report_id.Name = "cmbBox_thyrox_test_report_id";
            this.cmbBox_thyrox_test_report_id.Size = new System.Drawing.Size(180, 28);
            this.cmbBox_thyrox_test_report_id.TabIndex = 153;
            // 
            // lbl_lipid_pro_test_report_id
            // 
            this.lbl_lipid_pro_test_report_id.AutoSize = true;
            this.lbl_lipid_pro_test_report_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lipid_pro_test_report_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lipid_pro_test_report_id.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_lipid_pro_test_report_id.Location = new System.Drawing.Point(456, 208);
            this.lbl_lipid_pro_test_report_id.Name = "lbl_lipid_pro_test_report_id";
            this.lbl_lipid_pro_test_report_id.Size = new System.Drawing.Size(203, 20);
            this.lbl_lipid_pro_test_report_id.TabIndex = 151;
            this.lbl_lipid_pro_test_report_id.Text = "Lipid Pro Test Report ID";
            // 
            // lbl_ct_scan_report_id
            // 
            this.lbl_ct_scan_report_id.AutoSize = true;
            this.lbl_ct_scan_report_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ct_scan_report_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ct_scan_report_id.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_ct_scan_report_id.Location = new System.Drawing.Point(498, 260);
            this.lbl_ct_scan_report_id.Name = "lbl_ct_scan_report_id";
            this.lbl_ct_scan_report_id.Size = new System.Drawing.Size(161, 20);
            this.lbl_ct_scan_report_id.TabIndex = 152;
            this.lbl_ct_scan_report_id.Text = "CT Scan Report ID";
            // 
            // lbl_x_ray_test_report_id
            // 
            this.lbl_x_ray_test_report_id.AutoSize = true;
            this.lbl_x_ray_test_report_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_x_ray_test_report_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_x_ray_test_report_id.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_x_ray_test_report_id.Location = new System.Drawing.Point(59, 255);
            this.lbl_x_ray_test_report_id.Name = "lbl_x_ray_test_report_id";
            this.lbl_x_ray_test_report_id.Size = new System.Drawing.Size(175, 20);
            this.lbl_x_ray_test_report_id.TabIndex = 150;
            this.lbl_x_ray_test_report_id.Text = "X-ray Test Report ID";
            // 
            // lbl_thyrox_test_report_id
            // 
            this.lbl_thyrox_test_report_id.AutoSize = true;
            this.lbl_thyrox_test_report_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_thyrox_test_report_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thyrox_test_report_id.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_thyrox_test_report_id.Location = new System.Drawing.Point(49, 208);
            this.lbl_thyrox_test_report_id.Name = "lbl_thyrox_test_report_id";
            this.lbl_thyrox_test_report_id.Size = new System.Drawing.Size(185, 20);
            this.lbl_thyrox_test_report_id.TabIndex = 149;
            this.lbl_thyrox_test_report_id.Text = "Thyrox Test Report ID";
            // 
            // cmbBox_fbs_test_report_id
            // 
            this.cmbBox_fbs_test_report_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_fbs_test_report_id.FormattingEnabled = true;
            this.cmbBox_fbs_test_report_id.Location = new System.Drawing.Point(665, 71);
            this.cmbBox_fbs_test_report_id.Name = "cmbBox_fbs_test_report_id";
            this.cmbBox_fbs_test_report_id.Size = new System.Drawing.Size(147, 28);
            this.cmbBox_fbs_test_report_id.TabIndex = 148;
            // 
            // lbl_fbs_test_report_id
            // 
            this.lbl_fbs_test_report_id.AutoSize = true;
            this.lbl_fbs_test_report_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fbs_test_report_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fbs_test_report_id.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_fbs_test_report_id.Location = new System.Drawing.Point(491, 74);
            this.lbl_fbs_test_report_id.Name = "lbl_fbs_test_report_id";
            this.lbl_fbs_test_report_id.Size = new System.Drawing.Size(168, 20);
            this.lbl_fbs_test_report_id.TabIndex = 147;
            this.lbl_fbs_test_report_id.Text = "FBS Test Report ID";
            // 
            // richTextBox_health_issue
            // 
            this.richTextBox_health_issue.Location = new System.Drawing.Point(240, 79);
            this.richTextBox_health_issue.Name = "richTextBox_health_issue";
            this.richTextBox_health_issue.Size = new System.Drawing.Size(231, 96);
            this.richTextBox_health_issue.TabIndex = 146;
            this.richTextBox_health_issue.Text = "";
            // 
            // textBox_weight
            // 
            this.textBox_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_weight.Location = new System.Drawing.Point(665, 29);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(85, 26);
            this.textBox_weight.TabIndex = 145;
            // 
            // lbl_health_issue
            // 
            this.lbl_health_issue.AutoSize = true;
            this.lbl_health_issue.BackColor = System.Drawing.Color.Transparent;
            this.lbl_health_issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_health_issue.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_health_issue.Location = new System.Drawing.Point(123, 77);
            this.lbl_health_issue.Name = "lbl_health_issue";
            this.lbl_health_issue.Size = new System.Drawing.Size(111, 20);
            this.lbl_health_issue.TabIndex = 144;
            this.lbl_health_issue.Text = "Health Issue";
            // 
            // lbl_surgery_id
            // 
            this.lbl_surgery_id.AutoSize = true;
            this.lbl_surgery_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_surgery_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_surgery_id.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_surgery_id.Location = new System.Drawing.Point(139, 351);
            this.lbl_surgery_id.Name = "lbl_surgery_id";
            this.lbl_surgery_id.Size = new System.Drawing.Size(95, 20);
            this.lbl_surgery_id.TabIndex = 143;
            this.lbl_surgery_id.Text = "Surgery ID";
            // 
            // lbl_patient_illness_id
            // 
            this.lbl_patient_illness_id.AutoSize = true;
            this.lbl_patient_illness_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_patient_illness_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_illness_id.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_patient_illness_id.Location = new System.Drawing.Point(87, 305);
            this.lbl_patient_illness_id.Name = "lbl_patient_illness_id";
            this.lbl_patient_illness_id.Size = new System.Drawing.Size(147, 20);
            this.lbl_patient_illness_id.TabIndex = 142;
            this.lbl_patient_illness_id.Text = "Patient Illness ID";
            // 
            // lbl_treatment_plan_id
            // 
            this.lbl_treatment_plan_id.AutoSize = true;
            this.lbl_treatment_plan_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_treatment_plan_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_treatment_plan_id.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_treatment_plan_id.Location = new System.Drawing.Point(504, 356);
            this.lbl_treatment_plan_id.Name = "lbl_treatment_plan_id";
            this.lbl_treatment_plan_id.Size = new System.Drawing.Size(155, 20);
            this.lbl_treatment_plan_id.TabIndex = 141;
            this.lbl_treatment_plan_id.Text = "Treatment Plan ID";
            // 
            // lbl_patient_injury_id
            // 
            this.lbl_patient_injury_id.AutoSize = true;
            this.lbl_patient_injury_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_patient_injury_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_injury_id.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_patient_injury_id.Location = new System.Drawing.Point(520, 308);
            this.lbl_patient_injury_id.Name = "lbl_patient_injury_id";
            this.lbl_patient_injury_id.Size = new System.Drawing.Size(139, 20);
            this.lbl_patient_injury_id.TabIndex = 140;
            this.lbl_patient_injury_id.Text = "Patient Injury ID";
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.BackColor = System.Drawing.Color.Transparent;
            this.lbl_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_weight.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_weight.Location = new System.Drawing.Point(594, 32);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(65, 20);
            this.lbl_weight.TabIndex = 139;
            this.lbl_weight.Text = "Weight";
            // 
            // cmbBox_patient_id
            // 
            this.cmbBox_patient_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_patient_id.FormattingEnabled = true;
            this.cmbBox_patient_id.Location = new System.Drawing.Point(240, 27);
            this.cmbBox_patient_id.Name = "cmbBox_patient_id";
            this.cmbBox_patient_id.Size = new System.Drawing.Size(107, 28);
            this.cmbBox_patient_id.TabIndex = 138;
            // 
            // lbl_patient_id
            // 
            this.lbl_patient_id.AutoSize = true;
            this.lbl_patient_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_patient_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_id.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_patient_id.Location = new System.Drawing.Point(144, 35);
            this.lbl_patient_id.Name = "lbl_patient_id";
            this.lbl_patient_id.Size = new System.Drawing.Size(90, 20);
            this.lbl_patient_id.TabIndex = 137;
            this.lbl_patient_id.Text = "Patient ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.textBox_sort_by_patient_Id);
            this.panel2.Controls.Add(this.lbl_sort_by_patient_id);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(242, 533);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 176);
            this.panel2.TabIndex = 140;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(378, 17);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(73, 27);
            this.btn_search.TabIndex = 147;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // textBox_sort_by_patient_Id
            // 
            this.textBox_sort_by_patient_Id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox_sort_by_patient_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sort_by_patient_Id.Location = new System.Drawing.Point(205, 18);
            this.textBox_sort_by_patient_Id.Name = "textBox_sort_by_patient_Id";
            this.textBox_sort_by_patient_Id.Size = new System.Drawing.Size(165, 26);
            this.textBox_sort_by_patient_Id.TabIndex = 146;
            // 
            // lbl_sort_by_patient_id
            // 
            this.lbl_sort_by_patient_id.AutoSize = true;
            this.lbl_sort_by_patient_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sort_by_patient_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sort_by_patient_id.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_sort_by_patient_id.Location = new System.Drawing.Point(15, 21);
            this.lbl_sort_by_patient_id.Name = "lbl_sort_by_patient_id";
            this.lbl_sort_by_patient_id.Size = new System.Drawing.Size(164, 20);
            this.lbl_sort_by_patient_id.TabIndex = 145;
            this.lbl_sort_by_patient_id.Text = "Sort By:  Patient ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(833, 107);
            this.dataGridView1.TabIndex = 144;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(707, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 163;
            this.label1.Text = "LAB RESULTS";
            // 
            // frm_patient_med_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 721);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_patient_med_record";
            this.Text = "Patient Medical Record";
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
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ComboBox cmbBox_treatment_plan_id;
        private System.Windows.Forms.ComboBox cmbBox_surgery_id;
        private System.Windows.Forms.ComboBox cmbBox_patient_injury_id;
        private System.Windows.Forms.ComboBox cmbBox_patient_illness_id;
        private System.Windows.Forms.ComboBox cmbBox_lipid_pro_test_report_id;
        private System.Windows.Forms.ComboBox cmbBox_ct_scan_report_id;
        private System.Windows.Forms.ComboBox cmbBox_x_ray_test_report_id;
        private System.Windows.Forms.ComboBox cmbBox_thyrox_test_report_id;
        private System.Windows.Forms.Label lbl_lipid_pro_test_report_id;
        private System.Windows.Forms.Label lbl_ct_scan_report_id;
        private System.Windows.Forms.Label lbl_x_ray_test_report_id;
        private System.Windows.Forms.Label lbl_thyrox_test_report_id;
        private System.Windows.Forms.ComboBox cmbBox_fbs_test_report_id;
        private System.Windows.Forms.Label lbl_fbs_test_report_id;
        private System.Windows.Forms.RichTextBox richTextBox_health_issue;
        private System.Windows.Forms.TextBox textBox_weight;
        private System.Windows.Forms.Label lbl_health_issue;
        private System.Windows.Forms.Label lbl_surgery_id;
        private System.Windows.Forms.Label lbl_patient_illness_id;
        private System.Windows.Forms.Label lbl_treatment_plan_id;
        private System.Windows.Forms.Label lbl_patient_injury_id;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.ComboBox cmbBox_patient_id;
        private System.Windows.Forms.Label lbl_patient_id;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textBox_sort_by_patient_Id;
        private System.Windows.Forms.Label lbl_sort_by_patient_id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}