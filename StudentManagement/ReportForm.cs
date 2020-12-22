using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class ReportForm : Form
    {
        BindingList<Student> StudentList = new BindingList<Student>(); //Binding list of student type.
        BindingList<WeeklyReportDetails> StdList = new BindingList<WeeklyReportDetails>(); // Binding list of Weekly report details type.
        //Class holding the Binding list parameter.
        public ReportForm(BindingList<Student> formlist)
        {
            
            InitializeComponent();
            this.StudentList = formlist;
            WeeklyReportPanel.SendToBack();
            SortPanel.BringToFront();

  
        }

        //open weekly report form
        private void button2_Click(object sender, EventArgs e)
        {
            weeklyReportTable.DataSource = null;
            StdList.Clear();
            WeeklyReportPanel.BringToFront();
            ReportGeneration();
            dateTimePicker1.Value = startDate.Value;
            dateTimePicker2.Value = endDate.Value;

            SortPanel.SendToBack();
            
            

        }

        //Method to generate report.
        public void ReportGeneration()
        {
            
            StdList.Add(new WeeklyReportDetails("Computing", 0));
            StdList.Add(new WeeklyReportDetails("Networking", 0));
            StdList.Add(new WeeklyReportDetails("Multimedia", 0));
            StdList.Add(new WeeklyReportDetails("BBA", 0));
            StdList.Add(new WeeklyReportDetails("BBS", 0));
            int count = 0;
            
            foreach (Student student in StudentList)
            {
                if (student.RegistrationDate.CompareTo(Convert.ToDateTime(startDate.Value.ToShortDateString())) >= 0 && student.RegistrationDate.CompareTo(Convert.ToDateTime(endDate.Value.AddDays(1).ToShortDateString())) < 0)
                {
                    foreach (WeeklyReportDetails report in StdList)
                        if (report.Program.Equals(student.ProgramEnrol))
                            report.Count++;
                    count++;
                }
            }
            txtCount.Text = count.ToString();
            weeklyReportTable.DataSource = StdList;
            weeklyReportTable.Columns[0].HeaderText = "Program Name";
            weeklyReportTable.Columns[1].HeaderText = "Student Count";
            weeklyReportTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            comboReportSort.SelectedIndex = 0;
            reportFormTable.DataSource = StudentList;

        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboReportSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboReportSort.SelectedIndex != 0)
            {
                sortReportData();
            }
            
        }
        //sort data as per name and registration
        private void sortReportData()
        {


            for (int i = 0; i < StudentList.Count; i++)
            {
                for (int j = 0; j < StudentList.Count -i- 1; j++)
                {

                    switch (comboReportSort.SelectedIndex)
                    {
                       
                        case 1:
                            if (StudentList[j].StudentName.CompareTo(StudentList[j+1].StudentName) > 0)
                            {
                                Student temp;
                                temp = StudentList[j];
                                StudentList[j] = StudentList[j+1];
                                StudentList[j+1] = temp;

                            }
                            break;
                        
                        case 2:
                            if (StudentList[j].RegistrationDate.CompareTo(StudentList[j+1].RegistrationDate) > 0)
                            {
                                Student temp;
                                temp = StudentList[j];
                                StudentList[j] = StudentList[j+1];
                                StudentList[j+1] = temp;

                            }
                            break;
                        

                    }

                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            endDate.Value = startDate.Value.AddDays(6);
        }

        private void btnGenerateRep_Click(object sender, EventArgs e)
        {
            WeeklyReportPanel.SendToBack();
            SortPanel.BringToFront();

        }

        private void WeeklyReportPanel_Paint(object sender, PaintEventArgs e)
        {
            weeklyReportTable.DataSource = StdList;
            weeklyReportTable.Columns[0].HeaderText = "Program Name";
            weeklyReportTable.Columns[1].HeaderText = "Student Count";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            WeeklyReportPanel.SendToBack();
            SortPanel.BringToFront();
        }
    }
    public class WeeklyReportDetails
    {

        //Compiler made the private field for itself..
        public string Program
        {
            get; set;
        }

        public int Count
        {
            get; set;
        }
        public WeeklyReportDetails(string program, int count)
        {
            this.Program = program;
            this.Count = count;
        }
    }
}

