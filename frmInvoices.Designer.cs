namespace _43938442_ExamProject
{
    partial class frmInvoices
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
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.patientsTableAdapter1 = new _43938442_ExamProject.PatientDataSet1TableAdapters.PatientsTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rbCancelled = new System.Windows.Forms.RadioButton();
            this.rbPending = new System.Windows.Forms.RadioButton();
            this.rbComplete = new System.Windows.Forms.RadioButton();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbUrgent = new System.Windows.Forms.RadioButton();
            this.rbRoutine = new System.Windows.Forms.RadioButton();
            this.groupBoxApptType = new System.Windows.Forms.GroupBox();
            this.rbLab = new System.Windows.Forms.RadioButton();
            this.rbSurgical = new System.Windows.Forms.RadioButton();
            this.groupBoxDoctor = new System.Windows.Forms.GroupBox();
            this.rbHendricks = new System.Windows.Forms.RadioButton();
            this.rbVanZyl = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lstInvoice = new System.Windows.Forms.ListBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBoxStatus.SuspendLayout();
            this.groupBoxApptType.SuspendLayout();
            this.groupBoxDoctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // patientsTableAdapter1
            // 
            this.patientsTableAdapter1.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(427, 424);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 36);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Lime;
            this.btnSubmit.Location = new System.Drawing.Point(12, 424);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(164, 36);
            this.btnSubmit.TabIndex = 47;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rbCancelled
            // 
            this.rbCancelled.AutoSize = true;
            this.rbCancelled.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCancelled.Location = new System.Drawing.Point(217, 20);
            this.rbCancelled.Name = "rbCancelled";
            this.rbCancelled.Size = new System.Drawing.Size(88, 20);
            this.rbCancelled.TabIndex = 2;
            this.rbCancelled.TabStop = true;
            this.rbCancelled.Text = "Cancelled";
            this.rbCancelled.UseVisualStyleBackColor = true;
            this.rbCancelled.CheckedChanged += new System.EventHandler(this.rbCancelled_CheckedChanged_1);
            // 
            // rbPending
            // 
            this.rbPending.AutoSize = true;
            this.rbPending.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPending.Location = new System.Drawing.Point(111, 20);
            this.rbPending.Name = "rbPending";
            this.rbPending.Size = new System.Drawing.Size(77, 20);
            this.rbPending.TabIndex = 1;
            this.rbPending.TabStop = true;
            this.rbPending.Text = "Pending";
            this.rbPending.UseVisualStyleBackColor = true;
            this.rbPending.CheckedChanged += new System.EventHandler(this.rbPending_CheckedChanged_1);
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
            this.rbComplete.CheckedChanged += new System.EventHandler(this.rbComplete_CheckedChanged_1);
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.rbCancelled);
            this.groupBoxStatus.Controls.Add(this.rbPending);
            this.groupBoxStatus.Controls.Add(this.rbComplete);
            this.groupBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStatus.Location = new System.Drawing.Point(274, 319);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(317, 53);
            this.groupBoxStatus.TabIndex = 46;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Select the date and time of the appropriate appointment:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(281, 148);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(310, 22);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // rbUrgent
            // 
            this.rbUrgent.AutoSize = true;
            this.rbUrgent.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUrgent.Location = new System.Drawing.Point(6, 97);
            this.rbUrgent.Name = "rbUrgent";
            this.rbUrgent.Size = new System.Drawing.Size(185, 20);
            this.rbUrgent.TabIndex = 3;
            this.rbUrgent.TabStop = true;
            this.rbUrgent.Text = "Urgent check-up (R2000)";
            this.rbUrgent.UseVisualStyleBackColor = true;
            this.rbUrgent.CheckedChanged += new System.EventHandler(this.rbUrgent_CheckedChanged_1);
            // 
            // rbRoutine
            // 
            this.rbRoutine.AutoSize = true;
            this.rbRoutine.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRoutine.Location = new System.Drawing.Point(6, 71);
            this.rbRoutine.Name = "rbRoutine";
            this.rbRoutine.Size = new System.Drawing.Size(184, 20);
            this.rbRoutine.TabIndex = 2;
            this.rbRoutine.TabStop = true;
            this.rbRoutine.Text = "Routine check-up (R500)";
            this.rbRoutine.UseVisualStyleBackColor = true;
            this.rbRoutine.CheckedChanged += new System.EventHandler(this.rbRoutine_CheckedChanged_1);
            // 
            // groupBoxApptType
            // 
            this.groupBoxApptType.Controls.Add(this.rbUrgent);
            this.groupBoxApptType.Controls.Add(this.rbRoutine);
            this.groupBoxApptType.Controls.Add(this.rbLab);
            this.groupBoxApptType.Controls.Add(this.rbSurgical);
            this.groupBoxApptType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxApptType.Location = new System.Drawing.Point(281, 176);
            this.groupBoxApptType.Name = "groupBoxApptType";
            this.groupBoxApptType.Size = new System.Drawing.Size(310, 131);
            this.groupBoxApptType.TabIndex = 44;
            this.groupBoxApptType.TabStop = false;
            this.groupBoxApptType.Text = "Appointment Type:";
            // 
            // rbLab
            // 
            this.rbLab.AutoSize = true;
            this.rbLab.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLab.Location = new System.Drawing.Point(6, 45);
            this.rbLab.Name = "rbLab";
            this.rbLab.Size = new System.Drawing.Size(215, 20);
            this.rbLab.TabIndex = 1;
            this.rbLab.TabStop = true;
            this.rbLab.Text = "Medical result analysis (R360)";
            this.rbLab.UseVisualStyleBackColor = true;
            this.rbLab.CheckedChanged += new System.EventHandler(this.rbLab_CheckedChanged_1);
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
            this.rbSurgical.CheckedChanged += new System.EventHandler(this.rbSurgical_CheckedChanged_1);
            // 
            // groupBoxDoctor
            // 
            this.groupBoxDoctor.Controls.Add(this.rbHendricks);
            this.groupBoxDoctor.Controls.Add(this.rbVanZyl);
            this.groupBoxDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDoctor.Location = new System.Drawing.Point(12, 319);
            this.groupBoxDoctor.Name = "groupBoxDoctor";
            this.groupBoxDoctor.Size = new System.Drawing.Size(184, 74);
            this.groupBoxDoctor.TabIndex = 43;
            this.groupBoxDoctor.TabStop = false;
            this.groupBoxDoctor.Text = "Doctor:";
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
            this.rbHendricks.CheckedChanged += new System.EventHandler(this.rbHendricks_CheckedChanged_1);
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
            this.rbVanZyl.CheckedChanged += new System.EventHandler(this.rbVanZyl_CheckedChanged_1);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(199, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(139, 20);
            this.txtName.TabIndex = 39;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(363, 91);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(78, 16);
            this.lblSurname.TabIndex = 38;
            this.lblSurname.Text = "Last Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(114, 91);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 16);
            this.lblName.TabIndex = 37;
            this.lblName.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Create invoices";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(534, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "(*please ensure that the patient is registered first and that their appointment s" +
    "tatus is Complete.)";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(447, 89);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(144, 20);
            this.txtSurname.TabIndex = 41;
            // 
            // lstInvoice
            // 
            this.lstInvoice.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInvoice.FormattingEnabled = true;
            this.lstInvoice.ItemHeight = 15;
            this.lstInvoice.Location = new System.Drawing.Point(5, 494);
            this.lstInvoice.Name = "lstInvoice";
            this.lstInvoice.Size = new System.Drawing.Size(586, 169);
            this.lstInvoice.TabIndex = 60;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 145);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(39, 89);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(34, 20);
            this.txtID.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 62;
            this.label4.Text = "ID:";
            // 
            // frmInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 673);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lstInvoice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBoxApptType);
            this.Controls.Add(this.groupBoxDoctor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSurname);
            this.Name = "frmInvoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoices";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.groupBoxApptType.ResumeLayout(false);
            this.groupBoxApptType.PerformLayout();
            this.groupBoxDoctor.ResumeLayout(false);
            this.groupBoxDoctor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.RadioButton rbCancelled;
        private System.Windows.Forms.RadioButton rbPending;
        private System.Windows.Forms.RadioButton rbComplete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBoxApptType;
        private System.Windows.Forms.RadioButton rbUrgent;
        private System.Windows.Forms.RadioButton rbRoutine;
        private System.Windows.Forms.RadioButton rbLab;
        private System.Windows.Forms.RadioButton rbSurgical;
        private System.Windows.Forms.GroupBox groupBoxDoctor;
        private System.Windows.Forms.RadioButton rbHendricks;
        private System.Windows.Forms.RadioButton rbVanZyl;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurname;
        private PatientDataSet1TableAdapters.PatientsTableAdapter patientsTableAdapter1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox lstInvoice;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
    }
}