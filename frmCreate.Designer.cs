namespace _43938442_ExamProject
{
    partial class frmAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointment));
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDoctor = new System.Windows.Forms.GroupBox();
            this.rbHendricks = new System.Windows.Forms.RadioButton();
            this.rbVanZyl = new System.Windows.Forms.RadioButton();
            this.groupBoxApptType = new System.Windows.Forms.GroupBox();
            this.rbUrgent = new System.Windows.Forms.RadioButton();
            this.rbRoutine = new System.Windows.Forms.RadioButton();
            this.rbLab = new System.Windows.Forms.RadioButton();
            this.rbSurgical = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.rbCancelled = new System.Windows.Forms.RadioButton();
            this.rbPending = new System.Windows.Forms.RadioButton();
            this.rbComplete = new System.Windows.Forms.RadioButton();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxDoctor.SuspendLayout();
            this.groupBoxApptType.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert, edit or delete an appointment";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 154);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "First Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(13, 180);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(78, 16);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Last Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 153);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(98, 179);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(164, 20);
            this.txtSurname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "(*please ensure that the patient is registered first.)";
            // 
            // groupBoxDoctor
            // 
            this.groupBoxDoctor.Controls.Add(this.rbHendricks);
            this.groupBoxDoctor.Controls.Add(this.rbVanZyl);
            this.groupBoxDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDoctor.Location = new System.Drawing.Point(354, 290);
            this.groupBoxDoctor.Name = "groupBoxDoctor";
            this.groupBoxDoctor.Size = new System.Drawing.Size(184, 74);
            this.groupBoxDoctor.TabIndex = 6;
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
            this.rbHendricks.CheckedChanged += new System.EventHandler(this.rbHendricks_CheckedChanged);
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
            this.rbVanZyl.CheckedChanged += new System.EventHandler(this.rbVanZyl_CheckedChanged);
            // 
            // groupBoxApptType
            // 
            this.groupBoxApptType.Controls.Add(this.rbUrgent);
            this.groupBoxApptType.Controls.Add(this.rbRoutine);
            this.groupBoxApptType.Controls.Add(this.rbLab);
            this.groupBoxApptType.Controls.Add(this.rbSurgical);
            this.groupBoxApptType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxApptType.Location = new System.Drawing.Point(354, 144);
            this.groupBoxApptType.Name = "groupBoxApptType";
            this.groupBoxApptType.Size = new System.Drawing.Size(184, 131);
            this.groupBoxApptType.TabIndex = 7;
            this.groupBoxApptType.TabStop = false;
            this.groupBoxApptType.Text = "Appointment Type:";
            // 
            // rbUrgent
            // 
            this.rbUrgent.AutoSize = true;
            this.rbUrgent.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUrgent.Location = new System.Drawing.Point(6, 97);
            this.rbUrgent.Name = "rbUrgent";
            this.rbUrgent.Size = new System.Drawing.Size(129, 20);
            this.rbUrgent.TabIndex = 3;
            this.rbUrgent.TabStop = true;
            this.rbUrgent.Text = "Urgent check-up";
            this.rbUrgent.UseVisualStyleBackColor = true;
            this.rbUrgent.CheckedChanged += new System.EventHandler(this.rbUrgent_CheckedChanged);
            // 
            // rbRoutine
            // 
            this.rbRoutine.AutoSize = true;
            this.rbRoutine.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRoutine.Location = new System.Drawing.Point(6, 71);
            this.rbRoutine.Name = "rbRoutine";
            this.rbRoutine.Size = new System.Drawing.Size(136, 20);
            this.rbRoutine.TabIndex = 2;
            this.rbRoutine.TabStop = true;
            this.rbRoutine.Text = "Routine check-up";
            this.rbRoutine.UseVisualStyleBackColor = true;
            this.rbRoutine.CheckedChanged += new System.EventHandler(this.rbRoutine_CheckedChanged);
            // 
            // rbLab
            // 
            this.rbLab.AutoSize = true;
            this.rbLab.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLab.Location = new System.Drawing.Point(6, 45);
            this.rbLab.Name = "rbLab";
            this.rbLab.Size = new System.Drawing.Size(167, 20);
            this.rbLab.TabIndex = 1;
            this.rbLab.TabStop = true;
            this.rbLab.Text = "Medical result analysis";
            this.rbLab.UseVisualStyleBackColor = true;
            this.rbLab.CheckedChanged += new System.EventHandler(this.rbLab_CheckedChanged);
            // 
            // rbSurgical
            // 
            this.rbSurgical.AutoSize = true;
            this.rbSurgical.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSurgical.Location = new System.Drawing.Point(6, 19);
            this.rbSurgical.Name = "rbSurgical";
            this.rbSurgical.Size = new System.Drawing.Size(76, 20);
            this.rbSurgical.TabIndex = 0;
            this.rbSurgical.TabStop = true;
            this.rbSurgical.Text = "Surgical";
            this.rbSurgical.UseVisualStyleBackColor = true;
            this.rbSurgical.CheckedChanged += new System.EventHandler(this.rbSurgical_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 419);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select a date and time:";
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.rbCancelled);
            this.groupBoxStatus.Controls.Add(this.rbPending);
            this.groupBoxStatus.Controls.Add(this.rbComplete);
            this.groupBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStatus.Location = new System.Drawing.Point(354, 391);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(184, 98);
            this.groupBoxStatus.TabIndex = 9;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status:";
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
            this.rbCancelled.CheckedChanged += new System.EventHandler(this.rbCancelled_CheckedChanged);
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
            this.rbPending.CheckedChanged += new System.EventHandler(this.rbPending_CheckedChanged);
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
            this.rbComplete.CheckedChanged += new System.EventHandler(this.rbComplete_CheckedChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Lime;
            this.btnInsert.Location = new System.Drawing.Point(13, 459);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 31);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(256, 458);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Yellow;
            this.btnEdit.Location = new System.Drawing.Point(94, 458);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 31);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.Location = new System.Drawing.Point(175, 458);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(13, 241);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(98, 127);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(35, 20);
            this.txtID.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(564, 75);
            this.label5.TabIndex = 16;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // frmAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(580, 513);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBoxApptType);
            this.Controls.Add(this.groupBoxDoctor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Name = "frmAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointments";
            this.groupBoxDoctor.ResumeLayout(false);
            this.groupBoxDoctor.PerformLayout();
            this.groupBoxApptType.ResumeLayout(false);
            this.groupBoxApptType.PerformLayout();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxDoctor;
        private System.Windows.Forms.RadioButton rbHendricks;
        private System.Windows.Forms.RadioButton rbVanZyl;
        private System.Windows.Forms.GroupBox groupBoxApptType;
        private System.Windows.Forms.RadioButton rbLab;
        private System.Windows.Forms.RadioButton rbSurgical;
        private System.Windows.Forms.RadioButton rbUrgent;
        private System.Windows.Forms.RadioButton rbRoutine;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.RadioButton rbPending;
        private System.Windows.Forms.RadioButton rbComplete;
        private System.Windows.Forms.RadioButton rbCancelled;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
    }
}