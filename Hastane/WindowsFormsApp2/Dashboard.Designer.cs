namespace WindowsFormsApp2
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnAddDiagnosis = new System.Windows.Forms.Button();
            this.btnFullHistory = new System.Windows.Forms.Button();
            this.btnHospital = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelIndecator1 = new System.Windows.Forms.Label();
            this.labelIndecator2 = new System.Windows.Forms.Label();
            this.labelIndecator3 = new System.Windows.Forms.Label();
            this.labelIndecator4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.txtAny = new System.Windows.Forms.TextBox();
            this.txtBlood = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "CONTROLER";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddPatient.Location = new System.Drawing.Point(39, 97);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(177, 37);
            this.btnAddPatient.TabIndex = 5;
            this.btnAddPatient.Text = "Add New Patient Record";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnAddDiagnosis
            // 
            this.btnAddDiagnosis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddDiagnosis.Location = new System.Drawing.Point(39, 155);
            this.btnAddDiagnosis.Name = "btnAddDiagnosis";
            this.btnAddDiagnosis.Size = new System.Drawing.Size(177, 37);
            this.btnAddDiagnosis.TabIndex = 6;
            this.btnAddDiagnosis.Text = "Add Diagnosis Information";
            this.btnAddDiagnosis.UseVisualStyleBackColor = false;
            this.btnAddDiagnosis.Click += new System.EventHandler(this.btnAddDiagnosis_Click);
            // 
            // btnFullHistory
            // 
            this.btnFullHistory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFullHistory.Location = new System.Drawing.Point(39, 211);
            this.btnFullHistory.Name = "btnFullHistory";
            this.btnFullHistory.Size = new System.Drawing.Size(177, 37);
            this.btnFullHistory.TabIndex = 7;
            this.btnFullHistory.Text = "Full History of Patient";
            this.btnFullHistory.UseVisualStyleBackColor = false;
            this.btnFullHistory.Click += new System.EventHandler(this.btnFullHistory_Click);
            // 
            // btnHospital
            // 
            this.btnHospital.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHospital.Location = new System.Drawing.Point(39, 264);
            this.btnHospital.Name = "btnHospital";
            this.btnHospital.Size = new System.Drawing.Size(177, 37);
            this.btnHospital.TabIndex = 8;
            this.btnHospital.Text = "Hospital Information";
            this.btnHospital.UseVisualStyleBackColor = false;
            this.btnHospital.Click += new System.EventHandler(this.btnHospital_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(222, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 432);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hospital Management System";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Green;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(78, 327);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelIndecator1
            // 
            this.labelIndecator1.AutoSize = true;
            this.labelIndecator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndecator1.Location = new System.Drawing.Point(2, 93);
            this.labelIndecator1.Name = "labelIndecator1";
            this.labelIndecator1.Size = new System.Drawing.Size(31, 33);
            this.labelIndecator1.TabIndex = 14;
            this.labelIndecator1.Text = "»";
            // 
            // labelIndecator2
            // 
            this.labelIndecator2.AutoSize = true;
            this.labelIndecator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndecator2.Location = new System.Drawing.Point(2, 151);
            this.labelIndecator2.Name = "labelIndecator2";
            this.labelIndecator2.Size = new System.Drawing.Size(31, 33);
            this.labelIndecator2.TabIndex = 15;
            this.labelIndecator2.Text = "»";
            // 
            // labelIndecator3
            // 
            this.labelIndecator3.AutoSize = true;
            this.labelIndecator3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndecator3.Location = new System.Drawing.Point(2, 207);
            this.labelIndecator3.Name = "labelIndecator3";
            this.labelIndecator3.Size = new System.Drawing.Size(31, 33);
            this.labelIndecator3.TabIndex = 16;
            this.labelIndecator3.Text = "»";
            // 
            // labelIndecator4
            // 
            this.labelIndecator4.AutoSize = true;
            this.labelIndecator4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndecator4.Location = new System.Drawing.Point(2, 260);
            this.labelIndecator4.Name = "labelIndecator4";
            this.labelIndecator4.Size = new System.Drawing.Size(31, 33);
            this.labelIndecator4.TabIndex = 17;
            this.labelIndecator4.Text = "»";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboGender);
            this.panel1.Controls.Add(this.txtAny);
            this.panel1.Controls.Add(this.txtBlood);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(222, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 430);
            this.panel1.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(282, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Add New Patient Record";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(539, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Any Major Disease Suffered Earlier";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Blood Group";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contact Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // comboGender
            // 
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboGender.Location = new System.Drawing.Point(214, 206);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(348, 21);
            this.comboGender.TabIndex = 7;
            // 
            // txtAny
            // 
            this.txtAny.Location = new System.Drawing.Point(71, 321);
            this.txtAny.Name = "txtAny";
            this.txtAny.Size = new System.Drawing.Size(491, 20);
            this.txtAny.TabIndex = 5;
            // 
            // txtBlood
            // 
            this.txtBlood.Location = new System.Drawing.Point(214, 239);
            this.txtBlood.Name = "txtBlood";
            this.txtBlood.Size = new System.Drawing.Size(348, 20);
            this.txtBlood.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(214, 171);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(348, 20);
            this.txtAge.TabIndex = 3;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(214, 132);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(348, 20);
            this.txtContact.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(214, 97);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(348, 20);
            this.txtAddress.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(214, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(348, 20);
            this.txtName.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 423);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelIndecator4);
            this.Controls.Add(this.labelIndecator3);
            this.Controls.Add(this.labelIndecator2);
            this.Controls.Add(this.labelIndecator1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHospital);
            this.Controls.Add(this.btnFullHistory);
            this.Controls.Add(this.btnAddDiagnosis);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnAddDiagnosis;
        private System.Windows.Forms.Button btnFullHistory;
        private System.Windows.Forms.Button btnHospital;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelIndecator1;
        private System.Windows.Forms.Label labelIndecator2;
        private System.Windows.Forms.Label labelIndecator3;
        private System.Windows.Forms.Label labelIndecator4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.TextBox txtAny;
        private System.Windows.Forms.TextBox txtBlood;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSave;
    }
}