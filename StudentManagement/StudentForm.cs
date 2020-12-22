using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class StudentForm : Form
    {
        //Binding list of student class
        public static BindingList<Student> StudentList = new BindingList<Student>();

        public bool EditMode
        {
            get;
            set;
        }
        public StudentForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        //Add student in the table
        public void AddStudent(Student student)
        {
            StudentList.Add(student);
            studentTable.DataSource = null;
            studentTable.DataSource = StudentList;
            ClearData();

        }
        //Method to clear all fields in Add panel
        public void ClearData()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text ="";
            txtContact.Text = "";
            txtEmail.Text = "";
            comboProgramEnrol.Text = "";
            registrationDatePicker.Value = DateTime.Today;
        }
        public bool Abc
        {
            get;
            set;
        }

        //functionality of adding students details.
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (EditMode == false)// boolean value to initialize between adding or modify statement.
            {
                
                
                if (txtId.Text.Length >0)
                {
                    BindingList<Student> abc = new BindingList<Student>();
                    foreach (Student students in StudentList)
                    {
                        if (students.Id.ToString().Contains(txtId.Text.ToString()))
                        {
                            MessageBox.Show("Please give a unique value for id");
                            Abc = true;
                            break;
                        }
                        else
                        {
                            Abc = false;
                        }
                            

                        
                    }




                    
                    if (Abc == false)
                    {
                        try
                        {

                            Student student = new Student(Convert.ToInt32(txtId.Text), txtName.Text, txtLastName.Text, txtAddress.Text,
                                                Convert.ToInt32(txtContact.Text), txtEmail.Text, comboProgramEnrol.Text, registrationDatePicker.Value);
                            if (comboProgramEnrol.SelectedIndex != 5)
                            {
                                AddStudent(student);

                            }

                            else
                            {
                                MessageBox.Show("Select valid program enrol");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Please fill all the fields properly.");
                        }
                    }
                            
                        
                }
                else
                {
                    MessageBox.Show("Please fill all the fields properly");
                }
                
            }
        else
        {
                if (txtId.Text.Length > 0)
                {
                    BindingList<Student> abc = new BindingList<Student>();
                     if (Convert.ToInt32(txtId.Text) != Convert.ToInt32(studentTable.SelectedRows[0].Cells[0].Value))
                        {
                            MessageBox.Show("I am sorry, But you can't change id");
                            Abc = true;
                            
                        }
                        else
                        {
                            Abc = false;
                        }



                    
                    if (Abc == false)
                    {
                        ModifyStudent(Convert.ToInt32(txtId.Text), txtName.Text, txtLastName.Text, txtAddress.Text,
                    Convert.ToInt32(txtContact.Text), txtEmail.Text, comboProgramEnrol.Text, Convert.ToDateTime(registrationDatePicker.Value));
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please enter id first and move forward");
                }
            

        }


    }

    //form load method
    private void StudentForm_Load(object sender, EventArgs e)
    {

        if (File.Exists("file1.txt"))
        {

            FileStream fileStream = new FileStream("file1.txt", FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            StudentList = (BindingList<Student>)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
        }
        studentTable.DataSource = StudentList;

        comboProgramEnrol.SelectedIndex = 5;
        comboSort.SelectedIndex = 8;

        
    }

    //delete students entries
    public void DeleteStudent(int id)
    {

        foreach (Student student in StudentList)
        {
            if (student.Id == id)
            {

                StudentList.Remove(student);
                return;

            }
        }

    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (studentTable.RowCount > 0)
        {
            DeleteRecord();
        }
        else
        {
            MessageBox.Show("Please add something before deleting.");
        }
    }
    //Method to delete record.
    public void DeleteRecord()
    {
        DeleteStudent(Convert.ToInt16(studentTable.SelectedRows[0].Cells[0].Value));

    }

    //Modify student record
    public void setData(int id, string name, string lastName, string address, int contact, string email,string program, DateTime date)
    {
        txtId.Text = Convert.ToString(id);
        //txtId.Text = Convert.ToInt32(studentTable.Rows[0].Cells[0].Value.ToString());

        txtName.Text = name;
        txtLastName.Text = lastName;
        txtAddress.Text = address;
        txtContact.Text = Convert.ToString(contact);
        txtEmail.Text= email;
        comboProgramEnrol.Text = program;
        registrationDatePicker.Value = date;


    }
   //Method to modify student details in the table.
    public void ModifyStudent(int id, string name, string lastName, string address, int contact, string email, string program, DateTime date)
    {
        foreach (Student std in StudentList)
        {
            if (std.Id == id)
            {
                std.AddStudent(id, name,lastName, address, contact,email, program, date);
                studentTable.Refresh();
                ClearData();
                return;
            }
        }

    }
    //Function of update button
    private void btnUpdate_Click(object sender, EventArgs e)
    {

        btnDelete.Enabled = false;
        if (studentTable.RowCount>0)
        {
            EditMode = true;
            setData(Convert.ToInt16(studentTable.SelectedRows[0].Cells[0].Value), studentTable.SelectedRows[0].Cells[1].Value.ToString(),studentTable.SelectedRows[0].Cells[2].Value.ToString(), studentTable.SelectedRows[0].Cells[3].Value.ToString(), Convert.ToInt32(studentTable.SelectedRows[0].Cells[4].Value), studentTable.SelectedRows[0].Cells[5].Value.ToString(), studentTable.SelectedRows[0].Cells[6].Value.ToString(), Convert.ToDateTime(studentTable.SelectedRows[0].Cells[7].Value));

        }
        else
        {
            MessageBox.Show("Please enter some data in the table.");
        }

        btnDelete.Enabled = true;
    }
    //method to hit the exit button
    private void btnExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    //Button funcitonality to clear form data.
    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearData();
    }
    //Button to sort the data in the table with different cases.
    private void btnSortData_Click(object sender, EventArgs e)
    {
        if (comboSort.SelectedIndex != 8)
        {
            sortData();
        }
        else
        {
            MessageBox.Show("Please select a valid column");
        }
    }
    //method to sort Data
    private void sortData()
    {


        for (int i = 0; i < StudentList.Count; i++)
        {
            for (int j = 0; j < StudentList.Count-i-1; j++)
            {

                switch (comboSort.SelectedIndex)
                {
                    case 0:
                        if (StudentList[j].Id.CompareTo(StudentList[j+1].Id) > 0)
                        {
                            Student temp;
                            temp = StudentList[j];
                            StudentList[j] = StudentList[j + 1];
                            StudentList[j + 1] = temp;

                        }
                        break;
                    case 1:
                        if (StudentList[j].StudentName.CompareTo(StudentList[j+1].StudentName) > 0)
                        {
                            Student temp;
                            temp = StudentList[j];
                            StudentList[j] = StudentList[j + 1];
                            StudentList[j + 1] = temp;

                        }
                        break;
                    case 2:
                        if (StudentList[j].StudentLastName.CompareTo(StudentList[j+1].StudentLastName) > 0)
                        {
                            Student temp;
                            temp = StudentList[j];
                            StudentList[j] = StudentList[j + 1];
                            StudentList[j + 1] = temp;

                        }
                        break;
                    case 3:
                        if (StudentList[j].StudentAddress.CompareTo(StudentList[j+1].StudentAddress) > 0)
                        {
                            Student temp;
                            temp = StudentList[j];
                            StudentList[j] = StudentList[j + 1];
                            StudentList[j + 1] = temp;

                        }
                        break;
                    case 4:
                        if (StudentList[j].ContactNumber.CompareTo(StudentList[j+1].ContactNumber) > 0)
                        {
                            Student temp;
                            temp = StudentList[j];
                            StudentList[j] = StudentList[j + 1];
                            StudentList[j + 1] = temp;

                        }
                        break;
                    case 5:
                        if (StudentList[j].Email.CompareTo(StudentList[j+1].Email) > 0)
                        {
                            Student temp;
                            temp = StudentList[j];
                            StudentList[j] = StudentList[j + 1];
                            StudentList[j + 1] = temp;

                        }
                        break;
                    case 6:
                        if (StudentList[j].ProgramEnrol.CompareTo(StudentList[j+1].ProgramEnrol) > 0)
                        {
                            Student temp;
                            temp = StudentList[j];
                            StudentList[j] = StudentList[j + 1];
                            StudentList[j + 1] = temp;

                        }
                        break;
                    case 7:
                        if (StudentList[j].RegistrationDate.CompareTo(StudentList[j+1].RegistrationDate) > 0)
                        {
                            Student temp;
                            temp = StudentList[j];
                            StudentList[j] = StudentList[j + 1];
                            StudentList[j + 1] = temp;

                        }
                        break;

                }

            }
        }

    }

    //Method of export csv button.
    private void btnExportCSV_Click(object sender, EventArgs e)
    {
        ExportCSV();
    }
    //Export csv
    public void ExportCSV()
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "CSV File|*.csv";
        saveFileDialog.DefaultExt = ".csv";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {

            StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Id,Name,LastName,Address,Contact No.,Email, Program Enrol, Registration Date");

            foreach (Student student in StudentList)
            {
                stringBuilder.AppendLine(student.Id.ToString() + "," + student.StudentName + "," +student.StudentLastName+ "," + student.StudentAddress + ","
                    + student.ContactNumber.ToString() + "," + student.Email + ","+ student.ProgramEnrol+","
                    + student.RegistrationDate.ToString());
            }

            streamWriter.Write(stringBuilder.ToString());
            streamWriter.Close();
            MessageBox.Show("Data exported successfully");



        }
    }

    private void btnImportCSV_Click(object sender, EventArgs e)
    {
        DialogResult abc = MessageBox.Show("Do you want to replace the existing value", "Information message", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);
        if (abc == DialogResult.Yes)
        {
            StudentList.Clear();
            ImportCSV();
        }
        else
        {

            ImportCSV();
        }
    }
    //Import csv file
    public void ImportCSV()
    {

        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "CSV File|*.csv";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {

            String[] arrline = File.ReadAllLines(openFileDialog.FileName);
            String[] record;
            bool firstOne = true;
            foreach (String abc in arrline)
            {
                record = abc.Split(',');
                if (firstOne == true)
                {
                    firstOne = false;
                }
                else
                {

                    Student student = new Student(Convert.ToInt32(record[0]), record[1].ToString(), record[2].ToString(), record[3].ToString(), Convert.ToInt32(record[4]), record[5].ToString(), record[6].ToString(), Convert.ToDateTime(record[7]));
                    AddStudent(student);
                }

            }
            MessageBox.Show("Values inserted successfully");
        }

    }

    //Method of button to hit to generate report form.
    private void btnGenerateReport_Click(object sender, EventArgs e)
    {
        if (studentTable.RowCount > 0)
        {
            ReportForm reportForm = new ReportForm(StudentList);
            reportForm.ShowDialog();
        }
        else
        {
            MessageBox.Show("Please add some value for chart in the table.");

        }

    }


    //Method of button to display the charForm.
    private void btnDisplayChart_Click(object sender, EventArgs e)
    {
        if (studentTable.RowCount > 0)
        {
            ChartForm chart = new ChartForm(StudentList);
            chart.ShowDialog();
        }
        else
        {
            MessageBox.Show("Please add some value for chart in the table.");

        }
    }

    //Using serialization just before closing of form.
    private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
    {


        FileStream fileStream = new FileStream("file1.txt", FileMode.Create);

        BinaryFormatter binaryFormatter = new BinaryFormatter();
        binaryFormatter.Serialize(fileStream, StudentList);


    }


    //Method to handle the input of Name to reject all numeric values.
    private void txtName_KeyPress(object sender, KeyPressEventArgs e)
    {
        if(e.Handled= !(Char.IsLetter(e.KeyChar) || e.KeyChar == (Char)Keys.Back || e.KeyChar == (Char)Keys.Space))
        {
            e.Handled = true;
            base.OnKeyPress(e);

        }
    }
    //Method to handle the input of last name to reject all numeric values.
    private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.Handled = !(Char.IsLetter(e.KeyChar) || e.KeyChar == (Char)Keys.Back || e.KeyChar == (Char)Keys.Space))
        {
            e.Handled = true;
            base.OnKeyPress(e);

        }
    }
    //Method to handle the input of contact to reject all string values.
    private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
            base.OnKeyPress(e);

        }
    }
    //Method to handle the input of id to reject all string values.
    private void txtId_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
            base.OnKeyPress(e);

        }
    }
    //Method to show the functionality of search button.
    private void btnSearch_Click(object sender, EventArgs e)
    {
        if(txtSearch.Text !=null)
        { 
            BindingList<Student> abc = new BindingList<Student>();
            foreach (Student student in StudentList)
            {
                if (student.StudentName.ToUpper().Contains(txtSearch.Text.ToUpper()))
                {
                    abc.Add(student);
                }
            }

            studentTable.DataSource = abc;
        }
        else
        {
            MessageBox.Show("error");
        }

    }

    private void registrationDatePicker_ValueChanged(object sender, EventArgs e)
    {
        registrationDatePicker.MinDate = DateTime.Today;
    }
}
//data class containing all the necessary parameters.
[Serializable]
public class Student
{

    //Properties which compiler made the private field for itself..
    public int Id
    {
        get; set;
    }

    public string StudentName
    {
        get; set;
    }
    public string StudentLastName
    {
        get; set;
    }
    public string StudentAddress
    {
        get;
        set;
    }
    public int ContactNumber
    {
        get;
        set;
    }
    public string Email
    {
        get;
        set;
    }
    public string ProgramEnrol
    {
        get;
        set;
    }
    public DateTime RegistrationDate
    {
        get;
        set;
    }


    //Constructor to hold the necessary parameters.
    public Student(int id, string name,string lastName, string address, int contact, string email, string programEnrol, DateTime registration)
    {
        AddStudent(id, name,lastName, address, contact, email, programEnrol, registration);

    }

    //Method of add student to take same signature of constructor.
    public void AddStudent(int id, string name,string lastName, string address, int contact, string email, string programEnrol, DateTime registration)
    {

        this.Id = id;
        this.StudentName = name;
        this.StudentLastName = lastName;
        this.StudentAddress = address;
        this.ContactNumber = contact;
        this.Email = email;
        this.ProgramEnrol = programEnrol;
        this.RegistrationDate = registration;

    }
}
}
