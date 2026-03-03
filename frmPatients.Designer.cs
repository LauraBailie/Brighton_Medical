namespace _43938442_ExamProject
{
    partial class frmPatients
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
            this.components = new System.ComponentModel.Container();
            this.rbCancelled = new System.Windows.Forms.RadioButton();
            this.rbPending = new System.Windows.Forms.RadioButton();
            this.rbComplete = new System.Windows.Forms.RadioButton();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbUrgent = new System.Windows.Forms.RadioButton();
            this.rbRoutine = new System.Windows.Forms.RadioButton();
            this.rbLab = new System.Windows.Forms.RadioButton();
            this.rbSurgical = new System.Windows.Forms.RadioButton();
            this.rbHendricks = new System.Windows.Forms.RadioButton();
            this.rbVanZyl = new System.Windows.Forms.RadioButton();
            this.groupBoxApptType = new System.Windows.Forms.GroupBox();
            this.groupBoxDoctor = new System.Windows.Forms.GroupBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAllergies = new System.Windows.Forms.TextBox();
            this.lblAllergies = new System.Windows.Forms.Label();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.lblCell = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmergency = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.patientsTableAdapter1 = new _43938442_ExamProject.PatientDataSet1TableAdapters.PatientsTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxStatus.SuspendLayout();
            this.groupBoxApptType.SuspendLayout();
            this.groupBoxDoctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // rbCancelled
            // 
            this.rbCancelled.AutoSize = true;
            this.rbCancelled.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCancelled.Location = new System.Drawing.Point(6, 71);
            this.rbCancelled.Name = "rbCancelled";
            this.rbCancelled.Size = new System.Drawing.Size(88, 20);
            this.rbCancelled.TabIndex = 2;
            this.rbCancelled.TabStop = true;
            this.rbCancelled.Text = "Cancelled";
            this.rbCancelled.UseVisualStyleBackColor = true;
            // 
            // rbPending
            // 
            this.rbPending.AutoSize = true;
            this.rbPending.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPending.Location = new System.Drawing.Point(6, 45);
            this.rbPending.Name = "rbPending";
            this.rbPending.Size = new System.Drawing.Size(77, 20);
            this.rbPending.TabIndex = 1;
            this.rbPending.TabStop = true;
            this.rbPending.Text = "Pending";
            this.rbPending.UseVisualStyleBackColor = true;
            // 
            // rbComplete
            // 
            this.rbComplete.AutoSize = true;
            this.rbComplete.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbComplete.Location = new System.Drawing.Point(6, 19);
            this.rbComplete.Name = "rbComplete";
            this.rbComplete.Size = new System.Drawing.Size(85, 20);
            this.rbComplete.TabIndex = 0;
            this.rbComplete.TabStop = true;
            this.rbComplete.Text = "Complete";
            this.rbComplete.UseVisualStyleBackColor = true;
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.rbCancelled);
            this.groupBoxStatus.Controls.Add(this.rbPending);
            this.groupBoxStatus.Controls.Add(this.rbComplete);
            this.groupBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStatus.Location = new System.Drawing.Point(532, 314);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(184, 98);
            this.groupBoxStatus.TabIndex = 22;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Select a date and time:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 222);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // rbUrgent
            // 
            this.rbUrgent.AutoSize = true;
            this.rbUrgent.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUrgent.Location = new System.Drawing.Point(6, 151);
            this.rbUrgent.Name = "rbUrgent";
            this.rbUrgent.Size = new System.Drawing.Size(185, 20);
            this.rbUrgent.TabIndex = 3;
            this.rbUrgent.TabStop = true;
            this.rbUrgent.Text = "Urgent check-up (R2000)";
            this.rbUrgent.UseVisualStyleBackColor = true;
            // 
            // rbRoutine
            // 
            this.rbRoutine.AutoSize = true;
            this.rbRoutine.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRoutine.Location = new System.Drawing.Point(6, 104);
            this.rbRoutine.Name = "rbRoutine";
            this.rbRoutine.Size = new System.Drawing.Size(184, 20);
            this.rbRoutine.TabIndex = 2;
            this.rbRoutine.TabStop = true;
            this.rbRoutine.Text = "Routine check-up (R500)";
            this.rbRoutine.UseVisualStyleBackColor = true;
            // 
            // rbLab
            // 
            this.rbLab.AutoSize = true;
            this.rbLab.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLab.Location = new System.Drawing.Point(6, 60);
            this.rbLab.Name = "rbLab";
            this.rbLab.Size = new System.Drawing.Size(215, 20);
            this.rbLab.TabIndex = 1;
            this.rbLab.TabStop = true;
            this.rbLab.Text = "Medical result analysis (R360)";
            this.rbLab.UseVisualStyleBackColor = true;
            // 
            // rbSurgical
            // 
            this.rbSurgical.AutoSize = true;
            this.rbSurgical.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSurgical.Location = new System.Drawing.Point(6, 19);
            this.rbSurgical.Name = "rbSurgical";
            this.rbSurgical.Size = new System.Drawing.Size(132, 20);
            this.rbSurgical.TabIndex = 0;
            this.rbSurgical.TabStop = true;
            this.rbSurgical.Text = "Surgical (R1500)";
            this.rbSurgical.UseVisualStyleBackColor = true;
            // 
            // rbHendricks
            // 
            this.rbHendricks.AutoSize = true;
            this.rbHendricks.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHendricks.Location = new System.Drawing.Point(6, 45);
            this.rbHendricks.Name = "rbHendricks";
            this.rbHendricks.Size = new System.Drawing.Size(124, 20);
            this.rbHendricks.TabIndex = 1;
            this.rbHendricks.TabStop = true;
            this.rbHendricks.Text = "Dr C. Hendricks";
            this.rbHendricks.UseVisualStyleBackColor = true;
            // 
            // rbVanZyl
            // 
            this.rbVanZyl.AutoSize = true;
            this.rbVanZyl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVanZyl.Location = new System.Drawing.Point(6, 19);
            this.rbVanZyl.Name = "rbVanZyl";
            this.rbVanZyl.Size = new System.Drawing.Size(118, 20);
            this.rbVanZyl.TabIndex = 0;
            this.rbVanZyl.TabStop = true;
            this.rbVanZyl.Text = "Dr A.H. van Zyl";
            this.rbVanZyl.UseVisualStyleBackColor = true;
            // 
            // groupBoxApptType
            // 
            this.groupBoxApptType.Controls.Add(this.rbUrgent);
            this.groupBoxApptType.Controls.Add(this.rbRoutine);
            this.groupBoxApptType.Controls.Add(this.rbLab);
            this.groupBoxApptType.Controls.Add(this.rbSurgical);
            this.groupBoxApptType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxApptType.Location = new System.Drawing.Point(283, 221);
            this.groupBoxApptType.Name = "groupBoxApptType";
            this.groupBoxApptType.Size = new System.Drawing.Size(243, 192);
            this.groupBoxApptType.TabIndex = 20;
            this.groupBoxApptType.TabStop = false;
            this.groupBoxApptType.Text = "Appointment Type:";
            // 
            // groupBoxDoctor
            // 
            this.groupBoxDoctor.Controls.Add(this.rbHendricks);
            this.groupBoxDoctor.Controls.Add(this.rbVanZyl);
            this.groupBoxDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDoctor.Location = new System.Drawing.Point(532, 221);
            this.groupBoxDoctor.Name = "groupBoxDoctor";
            this.groupBoxDoctor.Size = new System.Drawing.Size(184, 74);
            this.groupBoxDoctor.TabIndex = 19;
            this.groupBoxDoctor.TabStop = false;
            this.groupBoxDoctor.Text = "Doctor:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(447, 67);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(144, 20);
            this.txtSurname.TabIndex = 17;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(152, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(139, 20);
            this.txtName.TabIndex = 15;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(365, 69);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(78, 16);
            this.lblSurname.TabIndex = 14;
            this.lblSurname.Text = "Last Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(9, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 16);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Insert, edit or remove patient details";
            // 
            // txtAllergies
            // 
            this.txtAllergies.Location = new System.Drawing.Point(722, 68);
            this.txtAllergies.Multiline = true;
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.Size = new System.Drawing.Size(164, 88);
            this.txtAllergies.TabIndex = 26;
            this.txtAllergies.TextChanged += new System.EventHandler(this.txtAllergies_TextChanged);
            // 
            // lblAllergies
            // 
            this.lblAllergies.AutoSize = true;
            this.lblAllergies.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllergies.Location = new System.Drawing.Point(651, 68);
            this.lblAllergies.Name = "lblAllergies";
            this.lblAllergies.Size = new System.Drawing.Size(65, 16);
            this.lblAllergies.TabIndex = 25;
            this.lblAllergies.Text = "Allergies:";
            // 
            // txtCell
            // 
            this.txtCell.Location = new System.Drawing.Point(152, 101);
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(139, 20);
            this.txtCell.TabIndex = 28;
            this.txtCell.TextChanged += new System.EventHandler(this.txtCell_TextChanged);
            // 
            // lblCell
            // 
            this.lblCell.AutoSize = true;
            this.lblCell.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCell.Location = new System.Drawing.Point(9, 105);
            this.lblCell.Name = "lblCell";
            this.lblCell.Size = new System.Drawing.Size(35, 16);
            this.lblCell.TabIndex = 27;
            this.lblCell.Text = "Cell:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(447, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(144, 20);
            this.txtEmail.TabIndex = 30;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(365, 101);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 29;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmergency
            // 
            this.txtEmergency.Location = new System.Drawing.Point(152, 136);
            this.txtEmergency.Name = "txtEmergency";
            this.txtEmergency.Size = new System.Drawing.Size(139, 20);
            this.txtEmergency.TabIndex = 32;
            this.txtEmergency.TextChanged += new System.EventHandler(this.txtEmergency_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Emergency Contact:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(447, 136);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(144, 20);
            this.txtPassword.TabIndex = 34;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(365, 137);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(72, 16);
            this.lblPassword.TabIndex = 33;
            this.lblPassword.Text = "Password:";
            // 
            // patientsTableAdapter1
            // 
            this.patientsTableAdapter1.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(877, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "_________________________________________________________________________________" +
    "________________________________________________________________";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.Location = new System.Drawing.Point(722, 333);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 31);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Yellow;
            this.btnEdit.Location = new System.Drawing.Point(722, 281);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(164, 31);
            this.btnEdit.TabIndex = 38;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(722, 382);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 31);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Lime;
            this.btnInsert.Location = new System.Drawing.Point(722, 229);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(164, 31);
            this.btnInsert.TabIndex = 36;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 251);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(152, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(35, 20);
            this.txtID.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "ID:";
            // 
            // frmPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(898, 431);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmergency);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCell);
            this.Controls.Add(this.lblCell);
            this.Controls.Add(this.txtAllergies);
            this.Controls.Add(this.lblAllergies);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBoxApptType);
            this.Controls.Add(this.groupBoxDoctor);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Name = "frmPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients";
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.groupBoxApptType.ResumeLayout(false);
            this.groupBoxApptType.PerformLayout();
            this.groupBoxDoctor.ResumeLayout(false);
            this.groupBoxDoctor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbCancelled;
        private System.Windows.Forms.RadioButton rbPending;
        private System.Windows.Forms.RadioButton rbComplete;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rbUrgent;
        private System.Windows.Forms.RadioButton rbRoutine;
        private System.Windows.Forms.RadioButton rbLab;
        private System.Windows.Forms.RadioButton rbSurgical;
        private System.Windows.Forms.RadioButton rbHendricks;
        private System.Windows.Forms.RadioButton rbVanZyl;
        private System.Windows.Forms.GroupBox groupBoxApptType;
        private System.Windows.Forms.GroupBox groupBoxDoctor;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAllergies;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.Label lblCell;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmergency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private PatientDataSet1TableAdapters.PatientsTableAdapter patientsTableAdapter1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
    }
}