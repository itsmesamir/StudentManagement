namespace StudentManagement
{
    partial class ReportForm
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
            this.btnWeeklyReport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboReportSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SortByPanel = new System.Windows.Forms.Panel();
            this.btnGenerateRep = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.SortPanel = new System.Windows.Forms.Panel();
            this.reportFormTable = new System.Windows.Forms.DataGridView();
            this.WeeklyReportPanel = new System.Windows.Forms.Panel();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.weeklyReportTable = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.SortByPanel.SuspendLayout();
            this.SortPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportFormTable)).BeginInit();
            this.WeeklyReportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyReportTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWeeklyReport
            // 
            this.btnWeeklyReport.BackColor = System.Drawing.Color.Crimson;
            this.btnWeeklyReport.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeeklyReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWeeklyReport.Location = new System.Drawing.Point(97, 193);
            this.btnWeeklyReport.Name = "btnWeeklyReport";
            this.btnWeeklyReport.Size = new System.Drawing.Size(169, 40);
            this.btnWeeklyReport.TabIndex = 24;
            this.btnWeeklyReport.Text = "Generate Weekly Report";
            this.btnWeeklyReport.UseVisualStyleBackColor = false;
            this.btnWeeklyReport.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.endDate);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.startDate);
            this.panel2.Controls.Add(this.btnWeeklyReport);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 250);
            this.panel2.TabIndex = 17;
            // 
            // endDate
            // 
            this.endDate.Enabled = false;
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(120, 135);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(101, 20);
            this.endDate.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(15, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(15, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "From:";
            // 
            // startDate
            // 
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(120, 69);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(101, 20);
            this.startDate.TabIndex = 25;
            this.startDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Program Enrol";
            // 
            // comboReportSort
            // 
            this.comboReportSort.FormattingEnabled = true;
            this.comboReportSort.Items.AddRange(new object[] {
            "Select",
            "Name",
            "Registration Date"});
            this.comboReportSort.Location = new System.Drawing.Point(113, 41);
            this.comboReportSort.Name = "comboReportSort";
            this.comboReportSort.Size = new System.Drawing.Size(121, 21);
            this.comboReportSort.TabIndex = 23;
            this.comboReportSort.SelectedIndexChanged += new System.EventHandler(this.comboReportSort_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Sort By:";
            // 
            // SortByPanel
            // 
            this.SortByPanel.BackColor = System.Drawing.Color.Indigo;
            this.SortByPanel.Controls.Add(this.btnGenerateRep);
            this.SortByPanel.Controls.Add(this.comboReportSort);
            this.SortByPanel.Controls.Add(this.label2);
            this.SortByPanel.Location = new System.Drawing.Point(12, 12);
            this.SortByPanel.Name = "SortByPanel";
            this.SortByPanel.Size = new System.Drawing.Size(277, 137);
            this.SortByPanel.TabIndex = 16;
            // 
            // btnGenerateRep
            // 
            this.btnGenerateRep.BackColor = System.Drawing.Color.Crimson;
            this.btnGenerateRep.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateRep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerateRep.Location = new System.Drawing.Point(113, 81);
            this.btnGenerateRep.Name = "btnGenerateRep";
            this.btnGenerateRep.Size = new System.Drawing.Size(121, 37);
            this.btnGenerateRep.TabIndex = 21;
            this.btnGenerateRep.Text = "Generate Report";
            this.btnGenerateRep.UseVisualStyleBackColor = false;
            this.btnGenerateRep.Click += new System.EventHandler(this.btnGenerateRep_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Indigo;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Honeydew;
            this.label6.Location = new System.Drawing.Point(287, -33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Student Information System";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit2
            // 
            this.btnExit2.BackColor = System.Drawing.Color.Crimson;
            this.btnExit2.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit2.Location = new System.Drawing.Point(978, 450);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(107, 40);
            this.btnExit2.TabIndex = 29;
            this.btnExit2.Text = "Close";
            this.btnExit2.UseVisualStyleBackColor = false;
            this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
            // 
            // SortPanel
            // 
            this.SortPanel.BackColor = System.Drawing.Color.Crimson;
            this.SortPanel.Controls.Add(this.reportFormTable);
            this.SortPanel.Controls.Add(this.WeeklyReportPanel);
            this.SortPanel.Location = new System.Drawing.Point(307, 12);
            this.SortPanel.Name = "SortPanel";
            this.SortPanel.Size = new System.Drawing.Size(748, 418);
            this.SortPanel.TabIndex = 30;
            // 
            // reportFormTable
            // 
            this.reportFormTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportFormTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportFormTable.Location = new System.Drawing.Point(0, 0);
            this.reportFormTable.Name = "reportFormTable";
            this.reportFormTable.Size = new System.Drawing.Size(748, 418);
            this.reportFormTable.TabIndex = 19;
            // 
            // WeeklyReportPanel
            // 
            this.WeeklyReportPanel.BackColor = System.Drawing.Color.DarkMagenta;
            this.WeeklyReportPanel.Controls.Add(this.txtCount);
            this.WeeklyReportPanel.Controls.Add(this.label10);
            this.WeeklyReportPanel.Controls.Add(this.label9);
            this.WeeklyReportPanel.Controls.Add(this.btnCancel);
            this.WeeklyReportPanel.Controls.Add(this.dateTimePicker2);
            this.WeeklyReportPanel.Controls.Add(this.dateTimePicker1);
            this.WeeklyReportPanel.Controls.Add(this.label5);
            this.WeeklyReportPanel.Controls.Add(this.label7);
            this.WeeklyReportPanel.Controls.Add(this.label8);
            this.WeeklyReportPanel.Controls.Add(this.weeklyReportTable);
            this.WeeklyReportPanel.Location = new System.Drawing.Point(0, 0);
            this.WeeklyReportPanel.Name = "WeeklyReportPanel";
            this.WeeklyReportPanel.Size = new System.Drawing.Size(748, 418);
            this.WeeklyReportPanel.TabIndex = 20;
            this.WeeklyReportPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.WeeklyReportPanel_Paint);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(502, 269);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Crimson;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Info;
            this.label10.Location = new System.Drawing.Point(401, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "Total count:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.OrangeRed;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Honeydew;
            this.label9.Location = new System.Drawing.Point(269, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 24);
            this.label9.TabIndex = 38;
            this.label9.Text = "Weekly Report";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(514, 337);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 37);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(414, 46);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker2.TabIndex = 36;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Indigo;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(367, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "To:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MediumBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(83, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "From:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.OrangeRed;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Honeydew;
            this.label8.Location = new System.Drawing.Point(262, -26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 24);
            this.label8.TabIndex = 32;
            this.label8.Text = "Weekly Report";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // weeklyReportTable
            // 
            this.weeklyReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weeklyReportTable.Location = new System.Drawing.Point(86, 87);
            this.weeklyReportTable.Name = "weeklyReportTable";
            this.weeklyReportTable.Size = new System.Drawing.Size(516, 140);
            this.weeklyReportTable.TabIndex = 31;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1097, 502);
            this.Controls.Add(this.SortPanel);
            this.Controls.Add(this.btnExit2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SortByPanel);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.SortByPanel.ResumeLayout(false);
            this.SortByPanel.PerformLayout();
            this.SortPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportFormTable)).EndInit();
            this.WeeklyReportPanel.ResumeLayout(false);
            this.WeeklyReportPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyReportTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWeeklyReport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboReportSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel SortByPanel;
        private System.Windows.Forms.Button btnGenerateRep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.Panel SortPanel;
        private System.Windows.Forms.Panel WeeklyReportPanel;
        private System.Windows.Forms.DataGridView reportFormTable;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView weeklyReportTable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label10;
    }
}