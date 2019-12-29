namespace ProgrammingAssignment_8
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblSupervisorName = new System.Windows.Forms.Label();
            this.lblReportingPeriod = new System.Windows.Forms.Label();
            this.tbEmployeeName = new System.Windows.Forms.TextBox();
            this.tbSupervisorName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dvClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvEmpBillLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvTue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvWed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvFri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvSat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvSun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvTotals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMonTotal = new System.Windows.Forms.Label();
            this.lblTueTotal = new System.Windows.Forms.Label();
            this.lblWedTotal = new System.Windows.Forms.Label();
            this.lblThuTotal = new System.Windows.Forms.Label();
            this.lblFriTotal = new System.Windows.Forms.Label();
            this.lblSatTotal = new System.Windows.Forms.Label();
            this.lblSunTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(12, 33);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(101, 13);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "Employee Name:";
            // 
            // lblSupervisorName
            // 
            this.lblSupervisorName.AutoSize = true;
            this.lblSupervisorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervisorName.Location = new System.Drawing.Point(12, 59);
            this.lblSupervisorName.Name = "lblSupervisorName";
            this.lblSupervisorName.Size = new System.Drawing.Size(107, 13);
            this.lblSupervisorName.TabIndex = 1;
            this.lblSupervisorName.Text = "Supervisor Name:";
            // 
            // lblReportingPeriod
            // 
            this.lblReportingPeriod.AutoSize = true;
            this.lblReportingPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportingPeriod.Location = new System.Drawing.Point(12, 110);
            this.lblReportingPeriod.Name = "lblReportingPeriod";
            this.lblReportingPeriod.Size = new System.Drawing.Size(147, 13);
            this.lblReportingPeriod.TabIndex = 4;
            this.lblReportingPeriod.Text = "Reporting Period: Week ";
            // 
            // tbEmployeeName
            // 
            this.tbEmployeeName.Location = new System.Drawing.Point(119, 30);
            this.tbEmployeeName.Name = "tbEmployeeName";
            this.tbEmployeeName.Size = new System.Drawing.Size(144, 20);
            this.tbEmployeeName.TabIndex = 0;
            // 
            // tbSupervisorName
            // 
            this.tbSupervisorName.Location = new System.Drawing.Point(119, 56);
            this.tbSupervisorName.Name = "tbSupervisorName";
            this.tbSupervisorName.Size = new System.Drawing.Size(144, 20);
            this.tbSupervisorName.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(777, 571);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvClient,
            this.dvContract,
            this.dvProject,
            this.dvEmpBillLevel,
            this.dvMon,
            this.dvTue,
            this.dvWed,
            this.dvThu,
            this.dvFri,
            this.dvSat,
            this.dvSun,
            this.dvTotals});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(12, 147);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 356);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // dvClient
            // 
            this.dvClient.Frozen = true;
            this.dvClient.HeaderText = "Client";
            this.dvClient.Name = "dvClient";
            // 
            // dvContract
            // 
            this.dvContract.Frozen = true;
            this.dvContract.HeaderText = "Contract";
            this.dvContract.Name = "dvContract";
            // 
            // dvProject
            // 
            this.dvProject.Frozen = true;
            this.dvProject.HeaderText = "Project(s)";
            this.dvProject.Name = "dvProject";
            // 
            // dvEmpBillLevel
            // 
            this.dvEmpBillLevel.Frozen = true;
            this.dvEmpBillLevel.HeaderText = "Employee Billing Level";
            this.dvEmpBillLevel.Name = "dvEmpBillLevel";
            this.dvEmpBillLevel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dvEmpBillLevel.Width = 135;
            // 
            // dvMon
            // 
            this.dvMon.Frozen = true;
            this.dvMon.HeaderText = "Mon";
            this.dvMon.Name = "dvMon";
            this.dvMon.Width = 40;
            // 
            // dvTue
            // 
            this.dvTue.Frozen = true;
            this.dvTue.HeaderText = "Tue";
            this.dvTue.Name = "dvTue";
            this.dvTue.Width = 40;
            // 
            // dvWed
            // 
            this.dvWed.Frozen = true;
            this.dvWed.HeaderText = "Wed";
            this.dvWed.Name = "dvWed";
            this.dvWed.Width = 40;
            // 
            // dvThu
            // 
            this.dvThu.Frozen = true;
            this.dvThu.HeaderText = "Thu";
            this.dvThu.Name = "dvThu";
            this.dvThu.Width = 40;
            // 
            // dvFri
            // 
            this.dvFri.Frozen = true;
            this.dvFri.HeaderText = "Fri";
            this.dvFri.Name = "dvFri";
            this.dvFri.Width = 40;
            // 
            // dvSat
            // 
            this.dvSat.Frozen = true;
            this.dvSat.HeaderText = "Sat";
            this.dvSat.Name = "dvSat";
            this.dvSat.Width = 40;
            // 
            // dvSun
            // 
            this.dvSun.Frozen = true;
            this.dvSun.HeaderText = "Sun";
            this.dvSun.Name = "dvSun";
            this.dvSun.Width = 40;
            // 
            // dvTotals
            // 
            this.dvTotals.Frozen = true;
            this.dvTotals.HeaderText = "Totals";
            this.dvTotals.Name = "dvTotals";
            this.dvTotals.ReadOnly = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(498, 535);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Tag = "4";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(539, 535);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Tag = "5";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(580, 535);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Tag = "6";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(621, 535);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Tag = "7";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(662, 535);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Tag = "8";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(703, 535);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(15, 14);
            this.checkBox6.TabIndex = 10;
            this.checkBox6.Tag = "9";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(744, 535);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(15, 14);
            this.checkBox7.TabIndex = 11;
            this.checkBox7.Tag = "10";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(294, 536);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Weekend/Holiday/Vacation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(417, 514);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Totals";
            // 
            // lblMonTotal
            // 
            this.lblMonTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonTotal.AutoEllipsis = true;
            this.lblMonTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonTotal.Location = new System.Drawing.Point(487, 510);
            this.lblMonTotal.Margin = new System.Windows.Forms.Padding(2);
            this.lblMonTotal.Name = "lblMonTotal";
            this.lblMonTotal.Size = new System.Drawing.Size(36, 20);
            this.lblMonTotal.TabIndex = 60;
            this.lblMonTotal.Tag = "4";
            this.lblMonTotal.Text = "0";
            this.lblMonTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTueTotal
            // 
            this.lblTueTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTueTotal.AutoEllipsis = true;
            this.lblTueTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTueTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTueTotal.Location = new System.Drawing.Point(527, 510);
            this.lblTueTotal.Margin = new System.Windows.Forms.Padding(2);
            this.lblTueTotal.Name = "lblTueTotal";
            this.lblTueTotal.Size = new System.Drawing.Size(36, 20);
            this.lblTueTotal.TabIndex = 61;
            this.lblTueTotal.Tag = "5";
            this.lblTueTotal.Text = "0";
            this.lblTueTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWedTotal
            // 
            this.lblWedTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWedTotal.AutoEllipsis = true;
            this.lblWedTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWedTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWedTotal.Location = new System.Drawing.Point(567, 510);
            this.lblWedTotal.Margin = new System.Windows.Forms.Padding(2);
            this.lblWedTotal.Name = "lblWedTotal";
            this.lblWedTotal.Size = new System.Drawing.Size(36, 20);
            this.lblWedTotal.TabIndex = 62;
            this.lblWedTotal.Tag = "6";
            this.lblWedTotal.Text = "0";
            this.lblWedTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblThuTotal
            // 
            this.lblThuTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThuTotal.AutoEllipsis = true;
            this.lblThuTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblThuTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuTotal.Location = new System.Drawing.Point(607, 510);
            this.lblThuTotal.Margin = new System.Windows.Forms.Padding(2);
            this.lblThuTotal.Name = "lblThuTotal";
            this.lblThuTotal.Size = new System.Drawing.Size(36, 20);
            this.lblThuTotal.TabIndex = 63;
            this.lblThuTotal.Tag = "7";
            this.lblThuTotal.Text = "0";
            this.lblThuTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFriTotal
            // 
            this.lblFriTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFriTotal.AutoEllipsis = true;
            this.lblFriTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFriTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriTotal.Location = new System.Drawing.Point(647, 510);
            this.lblFriTotal.Margin = new System.Windows.Forms.Padding(2);
            this.lblFriTotal.Name = "lblFriTotal";
            this.lblFriTotal.Size = new System.Drawing.Size(36, 20);
            this.lblFriTotal.TabIndex = 64;
            this.lblFriTotal.Tag = "8";
            this.lblFriTotal.Text = "0";
            this.lblFriTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSatTotal
            // 
            this.lblSatTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSatTotal.AutoEllipsis = true;
            this.lblSatTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSatTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatTotal.Location = new System.Drawing.Point(687, 510);
            this.lblSatTotal.Margin = new System.Windows.Forms.Padding(2);
            this.lblSatTotal.Name = "lblSatTotal";
            this.lblSatTotal.Size = new System.Drawing.Size(36, 20);
            this.lblSatTotal.TabIndex = 65;
            this.lblSatTotal.Tag = "9";
            this.lblSatTotal.Text = "0";
            this.lblSatTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSunTotal
            // 
            this.lblSunTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSunTotal.AutoEllipsis = true;
            this.lblSunTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSunTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunTotal.Location = new System.Drawing.Point(727, 510);
            this.lblSunTotal.Margin = new System.Windows.Forms.Padding(2);
            this.lblSunTotal.Name = "lblSunTotal";
            this.lblSunTotal.Size = new System.Drawing.Size(36, 20);
            this.lblSunTotal.TabIndex = 66;
            this.lblSunTotal.Tag = "10";
            this.lblSunTotal.Text = "0";
            this.lblSunTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(767, 510);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(85, 20);
            this.lblTotal.TabIndex = 67;
            this.lblTotal.Tag = "11";
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(165, 108);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 606);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSunTotal);
            this.Controls.Add(this.lblSatTotal);
            this.Controls.Add(this.lblFriTotal);
            this.Controls.Add(this.lblThuTotal);
            this.Controls.Add(this.lblWedTotal);
            this.Controls.Add(this.lblTueTotal);
            this.Controls.Add(this.lblMonTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbSupervisorName);
            this.Controls.Add(this.tbEmployeeName);
            this.Controls.Add(this.lblReportingPeriod);
            this.Controls.Add(this.lblSupervisorName);
            this.Controls.Add(this.lblEmployeeName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblSupervisorName;
        private System.Windows.Forms.Label lblReportingPeriod;
        private System.Windows.Forms.TextBox tbEmployeeName;
        private System.Windows.Forms.TextBox tbSupervisorName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMonTotal;
        private System.Windows.Forms.Label lblTueTotal;
        private System.Windows.Forms.Label lblWedTotal;
        private System.Windows.Forms.Label lblThuTotal;
        private System.Windows.Forms.Label lblFriTotal;
        private System.Windows.Forms.Label lblSatTotal;
        private System.Windows.Forms.Label lblSunTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvEmpBillLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvTue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvWed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvFri;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvSat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvSun;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvTotals;
    }
}

