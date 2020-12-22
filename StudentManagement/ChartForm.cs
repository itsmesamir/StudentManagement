using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StudentManagement
{
    public partial class ChartForm : Form
    {
        //Binding list of Student type.
        BindingList<Student> StudentList = new BindingList<Student>();

        //Constructor holding the Bindinglist of student class type.
        public ChartForm(BindingList<Student> students)
        {
            InitializeComponent();
            this.StudentList = students;
            comboChartType.SelectedIndex = 0;
            //GenerateChart();
        }

        //Method to Generate chart.
        public void GenerateChart()
        {
            BindingList<ProgramDetails> programDetails = new BindingList<ProgramDetails>();
            programDetails.Add(new ProgramDetails("Computing", 0));
            programDetails.Add(new ProgramDetails("Networking", 0));
            programDetails.Add(new ProgramDetails("Multimedia", 0));
            programDetails.Add(new ProgramDetails("BBA", 0));
            programDetails.Add(new ProgramDetails("BBS", 0));
            int count = 0;

            foreach (Student student in StudentList)
            {
                foreach (ProgramDetails report in programDetails)
                        if (report.Program.Equals(student.ProgramEnrol))
                            report.Count++;
                    count++;
               
            }
            

            chart1.DataSource = programDetails;
            chart1.Series[0].XValueMember = "Program";
            chart1.Series[0].YValueMembers = "Count";
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0].IsVisibleInLegend = true;
            txtCount.Text = count.ToString();
            

            if (comboChartType.SelectedIndex == 0)
            {
                chart1.Series[0].ChartType = SeriesChartType.Pie;

            }
            else if (comboChartType.SelectedIndex == 1)
            {
                chart1.Series[0].ChartType = SeriesChartType.Column;

            }
            else if (comboChartType.SelectedIndex == 2)
            {
                chart1.Series[0].ChartType = SeriesChartType.Line;

            }
        }

        //Method of button calling method of generate report.
        private void btnGenerateChart_Click(object sender, EventArgs e)
        {
            GenerateChart();

        }

        private void ChartForm_Load(object sender, EventArgs e)
        {

        }
    }

    //New class to define the Program and count fields to display in chart.
    public class ProgramDetails
    {

        //Properties for which ompiler made the private field for itself..
        public string Program
        {
            get; set;
        }

        public int Count
        {
            get; set;
        }
        //Constructor holding the program and count as parameters.
        public ProgramDetails(string program, int count)
        {
            this.Program = program;
            this.Count = count;
        }
    }
}
