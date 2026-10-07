using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StudentAcademicManagement
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private int[][] marks;
        private LinkedList<Student> registrationHistory = new LinkedList<Student>();

        public Form1()
        {
            InitializeComponent();
            marks = new int[0][];
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string studentNumber = txtStudentNumber.Text.Trim();
            string name = txtName.Text.Trim();
            string qualification = txtQualification.Text.Trim();
            string marksInput = txtMarks.Text.Trim();

            if (string.IsNullOrEmpty(studentNumber) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(qualification))
            {
                MessageBox.Show("Please fill in all student details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Student student = new Student(studentNumber, name, qualification);
            students.Add(student);

            if (marksInput.Length > 0)
            {
                string[] marksStrings = marksInput.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                int[] studentMarks = new int[marksStrings.Length];
                for (int i = 0; i < marksStrings.Length; i++)
                {
                    if (int.TryParse(marksStrings[i].Trim(), out int mark))
                    {
                        studentMarks[i] = mark;
                    }
                    else
                    {
                        MessageBox.Show("Invalid mark value. Please enter valid integers separated by commas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        students.RemoveAt(students.Count - 1);
                        return;
                    }
                }

                int[][] newMarks = new int[students.Count][];
                for (int i = 0; i < students.Count - 1; i++)
                {
                    newMarks[i] = marks[i];
                }
                newMarks[students.Count - 1] = studentMarks;
                marks = newMarks;
            }
            else
            {
                int[][] newMarks = new int[students.Count][];
                for (int i = 0; i < students.Count - 1; i++)
                {
                    newMarks[i] = marks[i];
                }
                newMarks[students.Count - 1] = new int[0];
                marks = newMarks;
            }

            registrationHistory.AddLast(student);

            MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputFields();
        }

        private void btnDisplayStudents_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();

            if (students.Count == 0)
            {
                lstOutput.Items.Add("No students to display.");
                return;
            }

            for (int i = 0; i < students.Count; i++)
            {
                Student student = students[i];
                int[] studentMarks = marks[i];
                double average = 0;
                string passFail = "N/A";

                if (studentMarks.Length > 0)
                {
                    average = studentMarks.Average();
                    passFail = average >= 50 ? "Pass" : "Fail";
                }

                string marksStr = studentMarks.Length > 0 ? string.Join(", ", studentMarks) : "No marks";
                lstOutput.Items.Add($"Student: {student.StudentNumber} - {student.Name}");
                lstOutput.Items.Add($"Qualification: {student.Qualification}");
                lstOutput.Items.Add($"Marks: {marksStr}");
                lstOutput.Items.Add($"Average: {average:F2}, Status: {passFail}");
                lstOutput.Items.Add("----------------------------------------");
            }
        }

        private void btnRegistrationHistory_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();

            if (registrationHistory.Count == 0)
            {
                lstOutput.Items.Add("No registration history to display.");
                return;
            }

            lstOutput.Items.Add("Registration History (Order of registration):");
            lstOutput.Items.Add("----------------------------------------");

            int index = 1;
            foreach (Student student in registrationHistory)
            {
                lstOutput.Items.Add($"{index}. {student.StudentNumber} - {student.Name} - {student.Qualification}");
                index++;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            lstOutput.Items.Clear();
        }

        private void ClearInputFields()
        {
            txtStudentNumber.Clear();
            txtName.Clear();
            txtQualification.Clear();
            txtMarks.Clear();
        }
    }
}
