using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            string path = @"Z:\WindowsFormsApplication6\WindowsFormsApplication6\file.txt";
            string student_Id = textBoxID.Text;
            string student_Name = textBoxName.Text;
            string semester = textBoxSemester.Text;
            string department = textBoxDepartment.Text;
            string university = textBoxUniversity.Text;
            string cGPA = textBoxCgPA.Text;
            string[] profile = { student_Id, student_Name, cGPA, semester, department, university };
            using (StreamWriter outputFile = new StreamWriter(path, true))
            {
                foreach (string item in profile)
                {
                    outputFile.WriteLine(item);
                }
            }


        }

        private void buttonSearchId_Click(object sender, EventArgs e)
        {
        }

        private void buttonListAll_Click(object sender, EventArgs e)
        {
            string info = " ";
            string path = @"Z:\WindowsFormsApplication6\WindowsFormsApplication6\file.txt";
            string[] reading = File.ReadAllLines(path, Encoding.UTF8);
            for (int i = 0; i < reading.Length; i = i + 6)
            {
                if (i != reading.Length)
                {
                    info = reading[i] + "\n" + reading[i + 1] + "\n" + reading[i + 2] + "\n" + reading[i + 3] + "\n" + reading[i + 4] + "\n" + reading[i + 5] + "\n";
                }
                richTextBox1.AppendText(info);
            }
        }

        private void buttonsearchStudent_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string info = " ";
            string path = @"Z:\WindowsFormsApplication6\WindowsFormsApplication6\file.txt";
            string input = textBoxInput.Text;
            if (comboBoxSearchType.SelectedIndex == 0)
            {
                string[] reading = File.ReadAllLines(path, Encoding.UTF8);
                List<string> readingList = reading.ToList();
                int index = 0;
                int till = index + 6;
                for (int i = index; i < till; i++)
                {
                    info = reading[i] + "   " + "\n";
                    richTextBox1.AppendText(info);
                }

            }
            else if (comboBoxSearchType.SelectedIndex == 1)
            {
                string[] reading = File.ReadAllLines(path, Encoding.UTF8);
                richTextBox1.ResetText();
                var indexList = new List<int>();
                for (int i = 0; i < reading.Length; i++)
                {
                    if (reading[i] == input)
                    {

                        indexList.Add(i);
                    }
                }
                foreach (var item in indexList)
                {
                    int index = item;
                    int till = index + 6;
                    for (int i = index; i < till; i++)
                    {
                        info = reading[i] + "   " + "\n";
                        richTextBox1.AppendText(info);
                    }
                }

            }
            else if (comboBoxSearchType.SelectedIndex == 2)
            {
                string[] reading = File.ReadAllLines(path, Encoding.UTF8);
                for (int i = 0; i < reading.Length; i = i + 6)
                {
                    if (i != reading.Length)
                    {
                        info = reading[i] + "\n" + reading[i + 1] + "\n" + reading[i + 2] + "\n" + reading[i + 3] + "\n" + reading[i + 4] + "\n" + reading[i + 5] + "\n";
                    }
                    richTextBox1.AppendText(info);
                }
            }

        }

        private void comboBoxSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSearchType.SelectedIndex == 0)
            {

                labelInput.Visible = true;
                textBoxInput.Visible = true;
            }
            else if (comboBoxSearchType.SelectedIndex == 1)
            {

                labelInput.Visible = true;
                textBoxInput.Visible = true;
            }
            else if (comboBoxSearchType.SelectedIndex == 2)
            {
                labelInput.Visible = false;
                textBoxInput.Visible = false;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttontopThree_Click(object sender, EventArgs e)
        {
            richTextBoxtopThree.ResetText();
            string info = " ";
            string path = @"Z:\WindowsFormsApplication6\WindowsFormsApplication6\file.txt";
            string[] reading = File.ReadAllLines(path, Encoding.UTF8);
            List<double> cgpaList = new List<double>();
            for (int i = 2; i < reading.Length; i = i + 6)
            {
                if (i != reading.Length)
                {
                    double gpa = 0.0;
                    gpa = Convert.ToDouble(reading[i]);
                    //Console.WriteLine("{0}", gpa);                    
                    cgpaList.Add(gpa);
                }

            }
            cgpaList.Sort();
            cgpaList.Reverse();
            int index = 0;
            Console.WriteLine("Top 3 CGPA ARE");
            foreach (double item in cgpaList)
            {
                info = item.ToString() + "\n";
                richTextBoxtopThree.AppendText(info);
                index++;
                if (index > 2)
                {
                    break;
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string path = @"Z:\WindowsFormsApplication6\WindowsFormsApplication6\file.txt";
            string text = textBoxEnrollment.Text;
            string[] reading = File.ReadAllLines(path, Encoding.UTF8);
            int indexO = 0;
            List<string> readingList = reading.ToList();
            bool execute = false;
            foreach (var item in reading)
            {
                if (item == text)
                {
                    indexO = readingList.IndexOf(item);
                    Console.WriteLine("{0}", indexO);
                    readingList.RemoveRange(indexO, 6);
                    reading = readingList.ToArray();
                    execute = true;
                }
            }
            if (execute == false)
            {
                MessageBox.Show("Doesnt Exists");
            }
            if (execute == true)
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    foreach (var item in reading)
                    {
                        writer.WriteLine(item);
                    }
                }
                MessageBox.Show("SucccessFully Deleted");
            }
        }

        private void richTextBoxtopThree_TextChanged(object sender, EventArgs e)
        {

        }

        //private void button3_Click(object sender, EventArgs e)
        //{

        //    labelEnrollment.Visible = true;           
        //    string path = @"Z:\WindowsFormsApplication6\WindowsFormsApplication6\file.txt";
        //    string text = @"Z:\WindowsFormsApplication6\WindowsFormsApplication6\attendancefile.txt";
        //    string[] enrollment = new string[100];
        //    int index = 0;
        //    Console.WriteLine("Listing No of Students");
        //    string[] reading = File.ReadAllLines(path, Encoding.UTF8);
        //    for (int i = 0; i < reading.Length; i++)
        //    {
        //        if (i == 0 || i >= 6 && i % 6 == 0)
        //        {
        //            enrollment[index] = reading[i];
        //            index++;
        //        }
        //    }

        //    string[] attendanceList = new string[index];
        //    string[] enrollAlist = new string[index * 2];
        //    string attendance = "Null";
        //    for (int i = 0; i < index; i++)
        //    {
        //        labelEnrollment.Text = enrollment[i];
        //        attendance = textBoxEnrollmentAtt.Text;
        //        attendanceList[i] = attendance;
        //        using (StreamWriter outputFile = new StreamWriter(text, true))
        //        {
        //            outputFile.WriteLine(enrollment[i]);
        //            outputFile.WriteLine(attendanceList[i]);
        //        }
        //    }
        //}

        private void labelEnrollment_Click(object sender, EventArgs e)
        {            
        }
        private void panelAttendance_Paint(object sender, PaintEventArgs e)
        {
        }

        private void buttonMarkAttendance_Click(object sender, EventArgs e)
        {
            richTextBoxMarkedAttendance.Text= "";
            string enrollment = textBoxEnrollmentAtt.Text;
            string path = @"Z:\WindowsFormsApplication6\WindowsFormsApplication6\file.txt";
            string text = @"Z:\WindowsFormsApplication6\WindowsFormsApplication6\attendancefile.txt";
            string value = "";
            if (radioButtonAbsent.Checked)
            {
                value = radioButtonAbsent.Text;
            }
            else if (radioButtonPresent.Checked)
            {
                value = radioButtonPresent.Text;
            }
            string[] enrollmentlist = new string[100];
            int index = 0;
            string[] reading = File.ReadAllLines(path, Encoding.UTF8);
            for (int i = 0; i < reading.Length; i++)
            {
                if (i == 0 || i >= 6 && i % 6 == 0)
                {
                    enrollmentlist[index] = reading[i];
                    index++;
                }
            }
            foreach(string item in enrollmentlist)
            {
                if (enrollment==item)
                {
                    MessageBox.Show("Enrollment Found & Attendance Marked ");
                    using (StreamWriter outputFile = new StreamWriter(text, true))
                    {                    
                            outputFile.WriteLine(item);
                            outputFile.WriteLine(value);                    
                    }
                }
            }
              
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            string path = @"Z:\WindowsFormsApplication6\WindowsFormsApplication6\file.txt";
            string[] enrollmentlist = new string[100];
            int index = 0;
            string[] reading = File.ReadAllLines(path, Encoding.UTF8);
            for (int i = 0; i < reading.Length; i++)
            {
                if (i == 0 || i >= 6 && i % 6 == 0)
                {
                    enrollmentlist[index] = reading[i];
                    index++;
                }
            }
  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBoxEnrollmentAtt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonViewAttendance_Click(object sender, EventArgs e)
        {
            richTextBoxMarkedAttendance.Clear();
            string info = " ";
            string path = @"Z:\WindowsFormsApplication6\WindowsFormsApplication6\attendancefile.txt";
                using (StreamReader input = new StreamReader(path, true))
                {
                    while ((info = input.ReadLine()) != null)
                    {
                        richTextBoxMarkedAttendance.AppendText(info + "\n");
                    }
                }
                }

        private void panelSearching_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

    
