namespace _43938442_ExamProject
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleDataSet = new _43938442_ExamProject.ScheduleDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allergiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencyContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientDataSet3 = new _43938442_ExamProject.PatientDataSet3();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientsTableAdapter = new _43938442_ExamProject.PatientDataSet3TableAdapters.PatientsTableAdapter();
            this.scheduleTableAdapter = new _43938442_ExamProject.ScheduleDataSetTableAdapters.ScheduleTableAdapter();
            this.groupBoxAppt = new System.Windows.Forms.GroupBox();
            this.linkCancel = new System.Windows.Forms.LinkLabel();
            this.linkEdit = new System.Windows.Forms.LinkLabel();
            this.linkCreate = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.linkDeletePt = new System.Windows.Forms.LinkLabel();
            this.linkEditPt = new System.Windows.Forms.LinkLabel();
            this.linkNewPt = new System.Windows.Forms.LinkLabel();
            this.groupBoxInvoice = new System.Windows.Forms.GroupBox();
            this.linkNewInvoice = new System.Windows.Forms.LinkLabel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxAppt.SuspendLayout();
            this.groupBoxPatient.SuspendLayout();
            this.groupBoxInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Gabriola", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(2, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(190, 55);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Admin!";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial Nova", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1136, 360);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Font = new System.Drawing.Font("Arial Nova Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1128, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Daily Schedule";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 21);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.doctorDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn1,
            this.timeDataGridViewTextBoxColumn1,
            this.appointmentTypeDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn1});
            this.dataGridView3.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.scheduleBindingSource, "Id", true));
            this.dataGridView3.DataSource = this.scheduleBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(239, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(883, 338);
            this.dataGridView3.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 41;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.Width = 78;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.Width = 78;
            // 
            // doctorDataGridViewTextBoxColumn1
            // 
            this.doctorDataGridViewTextBoxColumn1.DataPropertyName = "Doctor";
            this.doctorDataGridViewTextBoxColumn1.HeaderText = "Doctor";
            this.doctorDataGridViewTextBoxColumn1.Name = "doctorDataGridViewTextBoxColumn1";
            this.doctorDataGridViewTextBoxColumn1.Width = 63;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.Width = 53;
            // 
            // timeDataGridViewTextBoxColumn1
            // 
            this.timeDataGridViewTextBoxColumn1.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn1.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn1.Name = "timeDataGridViewTextBoxColumn1";
            this.timeDataGridViewTextBoxColumn1.Width = 55;
            // 
            // appointmentTypeDataGridViewTextBoxColumn1
            // 
            this.appointmentTypeDataGridViewTextBoxColumn1.DataPropertyName = "AppointmentType";
            this.appointmentTypeDataGridViewTextBoxColumn1.HeaderText = "AppointmentType";
            this.appointmentTypeDataGridViewTextBoxColumn1.Name = "appointmentTypeDataGridViewTextBoxColumn1";
            this.appointmentTypeDataGridViewTextBoxColumn1.Width = 114;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.Width = 61;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "Schedule";
            this.scheduleBindingSource.DataSource = this.scheduleDataSet;
            // 
            // scheduleDataSet
            // 
            this.scheduleDataSet.DataSetName = "ScheduleDataSet";
            this.scheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Font = new System.Drawing.Font("Arial Nova Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1128, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Patients";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.cellDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.allergiesDataGridViewTextBoxColumn,
            this.emergencyContactDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.patientsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1250, 350);
            this.dataGridView2.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 42;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 77;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 77;
            // 
            // cellDataGridViewTextBoxColumn
            // 
            this.cellDataGridViewTextBoxColumn.DataPropertyName = "Cell";
            this.cellDataGridViewTextBoxColumn.HeaderText = "Cell";
            this.cellDataGridViewTextBoxColumn.Name = "cellDataGridViewTextBoxColumn";
            this.cellDataGridViewTextBoxColumn.Width = 47;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 56;
            // 
            // allergiesDataGridViewTextBoxColumn
            // 
            this.allergiesDataGridViewTextBoxColumn.DataPropertyName = "Allergies";
            this.allergiesDataGridViewTextBoxColumn.HeaderText = "Allergies";
            this.allergiesDataGridViewTextBoxColumn.Name = "allergiesDataGridViewTextBoxColumn";
            this.allergiesDataGridViewTextBoxColumn.Width = 68;
            // 
            // emergencyContactDataGridViewTextBoxColumn
            // 
            this.emergencyContactDataGridViewTextBoxColumn.DataPropertyName = "EmergencyContact";
            this.emergencyContactDataGridViewTextBoxColumn.HeaderText = "EmergencyContact";
            this.emergencyContactDataGridViewTextBoxColumn.Name = "emergencyContactDataGridViewTextBoxColumn";
            this.emergencyContactDataGridViewTextBoxColumn.Width = 116;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 76;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.patientDataSet3;
            // 
            // patientDataSet3
            // 
            this.patientDataSet3.DataSetName = "PatientDataSet3";
            this.patientDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1084, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // scheduleTableAdapter
            // 
            this.scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // groupBoxAppt
            // 
            this.groupBoxAppt.Controls.Add(this.linkCancel);
            this.groupBoxAppt.Controls.Add(this.linkEdit);
            this.groupBoxAppt.Controls.Add(this.linkCreate);
            this.groupBoxAppt.Font = new System.Drawing.Font("Arial Nova", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAppt.Location = new System.Drawing.Point(12, 453);
            this.groupBoxAppt.Name = "groupBoxAppt";
            this.groupBoxAppt.Size = new System.Drawing.Size(200, 125);
            this.groupBoxAppt.TabIndex = 2;
            this.groupBoxAppt.TabStop = false;
            this.groupBoxAppt.Text = "Appointments";
            // 
            // linkCancel
            // 
            this.linkCancel.AutoSize = true;
            this.linkCancel.Font = new System.Drawing.Font("Arial Nova", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCancel.Location = new System.Drawing.Point(17, 90);
            this.linkCancel.Name = "linkCancel";
            this.linkCancel.Size = new System.Drawing.Size(142, 18);
            this.linkCancel.TabIndex = 2;
            this.linkCancel.TabStop = true;
            this.linkCancel.Text = "Cancel Appointment";
            this.linkCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCancel_LinkClicked);
            // 
            // linkEdit
            // 
            this.linkEdit.AutoSize = true;
            this.linkEdit.Font = new System.Drawing.Font("Arial Nova", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkEdit.Location = new System.Drawing.Point(17, 59);
            this.linkEdit.Name = "linkEdit";
            this.linkEdit.Size = new System.Drawing.Size(174, 18);
            this.linkEdit.TabIndex = 1;
            this.linkEdit.TabStop = true;
            this.linkEdit.Text = "Edit Existing Appointment";
            this.linkEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEdit_LinkClicked);
            // 
            // linkCreate
            // 
            this.linkCreate.AutoSize = true;
            this.linkCreate.Font = new System.Drawing.Font("Arial Nova", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCreate.Location = new System.Drawing.Point(17, 27);
            this.linkCreate.Name = "linkCreate";
            this.linkCreate.Size = new System.Drawing.Size(174, 18);
            this.linkCreate.TabIndex = 0;
            this.linkCreate.TabStop = true;
            this.linkCreate.Text = "Create New Appointment";
            this.linkCreate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBoxPatient
            // 
            this.groupBoxPatient.Controls.Add(this.linkDeletePt);
            this.groupBoxPatient.Controls.Add(this.linkEditPt);
            this.groupBoxPatient.Controls.Add(this.linkNewPt);
            this.groupBoxPatient.Font = new System.Drawing.Font("Arial Nova", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPatient.Location = new System.Drawing.Point(443, 453);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Size = new System.Drawing.Size(200, 125);
            this.groupBoxPatient.TabIndex = 4;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Patients";
            // 
            // linkDeletePt
            // 
            this.linkDeletePt.AutoSize = true;
            this.linkDeletePt.Font = new System.Drawing.Font("Arial Nova", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDeletePt.Location = new System.Drawing.Point(30, 90);
            this.linkDeletePt.Name = "linkDeletePt";
            this.linkDeletePt.Size = new System.Drawing.Size(110, 18);
            this.linkDeletePt.TabIndex = 2;
            this.linkDeletePt.TabStop = true;
            this.linkDeletePt.Text = "Remove Patient";
            this.linkDeletePt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDeletePt_LinkClicked);
            // 
            // linkEditPt
            // 
            this.linkEditPt.AutoSize = true;
            this.linkEditPt.Font = new System.Drawing.Font("Arial Nova", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkEditPt.Location = new System.Drawing.Point(30, 59);
            this.linkEditPt.Name = "linkEditPt";
            this.linkEditPt.Size = new System.Drawing.Size(134, 18);
            this.linkEditPt.TabIndex = 1;
            this.linkEditPt.TabStop = true;
            this.linkEditPt.Text = "Edit Existing Patient";
            this.linkEditPt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEditPt_LinkClicked);
            // 
            // linkNewPt
            // 
            this.linkNewPt.AutoSize = true;
            this.linkNewPt.Font = new System.Drawing.Font("Arial Nova", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNewPt.Location = new System.Drawing.Point(30, 27);
            this.linkNewPt.Name = "linkNewPt";
            this.linkNewPt.Size = new System.Drawing.Size(143, 18);
            this.linkNewPt.TabIndex = 0;
            this.linkNewPt.TabStop = true;
            this.linkNewPt.Text = "Register New Patient";
            this.linkNewPt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNewPt_LinkClicked);
            // 
            // groupBoxInvoice
            // 
            this.groupBoxInvoice.Controls.Add(this.linkNewInvoice);
            this.groupBoxInvoice.Font = new System.Drawing.Font("Arial Nova", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInvoice.Location = new System.Drawing.Point(982, 453);
            this.groupBoxInvoice.Name = "groupBoxInvoice";
            this.groupBoxInvoice.Size = new System.Drawing.Size(166, 77);
            this.groupBoxInvoice.TabIndex = 5;
            this.groupBoxInvoice.TabStop = false;
            this.groupBoxInvoice.Text = "Invoices";
            // 
            // linkNewInvoice
            // 
            this.linkNewInvoice.AutoSize = true;
            this.linkNewInvoice.Font = new System.Drawing.Font("Arial Nova", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNewInvoice.Location = new System.Drawing.Point(20, 38);
            this.linkNewInvoice.Name = "linkNewInvoice";
            this.linkNewInvoice.Size = new System.Drawing.Size(136, 18);
            this.linkNewInvoice.TabIndex = 0;
            this.linkNewInvoice.TabStop = true;
            this.linkNewInvoice.Text = "Create New Invoice";
            this.linkNewInvoice.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNewInvoice_LinkClicked);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.Location = new System.Drawing.Point(1041, 28);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(97, 36);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 587);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.groupBoxInvoice);
            this.Controls.Add(this.groupBoxPatient);
            this.Controls.Add(this.groupBoxAppt);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxAppt.ResumeLayout(false);
            this.groupBoxAppt.PerformLayout();
            this.groupBoxPatient.ResumeLayout(false);
            this.groupBoxPatient.PerformLayout();
            this.groupBoxInvoice.ResumeLayout(false);
            this.groupBoxInvoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private PatientDataSet3 patientDataSet3;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private PatientDataSet3TableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private ScheduleDataSet scheduleDataSet;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private ScheduleDataSetTableAdapters.ScheduleTableAdapter scheduleTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxAppt;
        private System.Windows.Forms.LinkLabel linkCreate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.LinkLabel linkCancel;
        private System.Windows.Forms.LinkLabel linkEdit;
        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.LinkLabel linkDeletePt;
        private System.Windows.Forms.LinkLabel linkEditPt;
        private System.Windows.Forms.LinkLabel linkNewPt;
        private System.Windows.Forms.GroupBox groupBoxInvoice;
        private System.Windows.Forms.LinkLabel linkNewInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allergiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLogOut;
    }
}