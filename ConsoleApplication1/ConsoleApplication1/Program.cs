using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication1
{
    class Program
    {
        class Student
        {
            string path = @"Z:\ConsoleApplication1\ConsoleApplication1\file.txt";
            string text = @"Z:\ConsoleApplication1\ConsoleApplication1\attendancefile.txt";
            string student_Id = "";
            string student_Name = "";
            string semester = "";
            string cGPA = "";
            String department = "";
            string university = "";
            string[] name = new string[10];
            public void createStudentProfile()
            {
                Console.WriteLine("Enter Student ID");
                student_Id = Console.ReadLine();
                Console.WriteLine("Enter Student Name");
                student_Name = Console.ReadLine();
                Console.WriteLine("Enter Semester");
                semester = Console.ReadLine();
                Console.WriteLine("Enter Cgpa");
                cGPA = Console.ReadLine();
                Console.WriteLine("Enter Department");
                department = Console.ReadLine();
                Console.WriteLine("Enter UniverSity");
                university = Console.ReadLine();
                string[] lines = { student_Id, student_Name, cGPA, semester, department, university };
                using (StreamWriter outputFile = new StreamWriter(path, true))
                {
                    foreach (string item in lines)
                    {
                        outputFile.WriteLine(item);
                    }
                }
            }
            public void searchStudent()
            {
                Console.WriteLine("Press 1 For Searching by ID");
                Console.WriteLine("Press 2 For Searching by Name");
                Console.WriteLine("Press 3 For Listing Students");
                string str = Console.ReadLine();
                if (str == "1")
                {
                    Console.WriteLine("Enter ID");
                    string iD = Console.ReadLine();

                    string[] reading = File.ReadAllLines(path, Encoding.UTF8);
                    List<string> readingList = reading.ToList();
                    int index = 0;
                    foreach (var item in readingList)
                    {
                        if (item == iD)
                        {
                            index = readingList.IndexOf(item);
                            Console.WriteLine(":::::::::: STUDENT INFORMATION IS AS FOLLOW:::::");
                        }
                    }
                    int till = index + 6;
                    Console.WriteLine("  Enrollment :   NAME   :  CGPA  : Semester :Department:University");
                    for (int i = index; i < till; i++)
                    {
                        Console.Write(reading[i] + "   ");
                    }
                    Console.WriteLine("");
                }
                else if (str == "2")
                {
                    string[] reading = File.ReadAllLines(path, Encoding.UTF8);
                    Console.WriteLine("Enter Name");
                    string nameStudent = Console.ReadLine();
                    var indexList = new List<int>();
                    for (int i = 0; i < reading.Length; i++)
                    {
                        if (reading[i] == nameStudent)
                        {

                            indexList.Add(i);
                        }
                    }
                    foreach (var item in indexList)
                    {
                        Console.WriteLine("{0}", item);
                    }
                    foreach (var item in indexList)
                    {
                        int index = item;
                        int till = index + 6;
                        Console.WriteLine("  Enrollment :   NAME   :  CGPA  : Semester :Department:University");
                        for (int i = index; i < till; i++)
                        {
                            Console.Write(reading[i] + "  ");
                        }
                        Console.WriteLine("");
                    }
                }
                else
                {

                    Console.WriteLine("Listing No of Students");
                    string[] reading = File.ReadAllLines(path, Encoding.UTF8);
                    for (int i = 0; i < reading.Length; i = i + 6)
                    {
                        if (i != reading.Length)
                        {
                            Console.WriteLine("Enrollment : {0}  :: Name : {1} :: CGpA : {2} :: Semester : {3} :: Department{4}:: , University: {5}", reading[i], reading[i + 1], reading[i + 2], reading[i + 3], reading[i + 4], reading[i + 5]);
                        }
                    }
                }

            }
            public void deleteStudentRecord()
            {
                string[] reading = File.ReadAllLines(path, Encoding.UTF8);
                Console.WriteLine("Enter A Student Enrollment No to delete");
                string str = Console.ReadLine();
                int indexO = 0;
                List<string> readingList = reading.ToList();
                bool execute = false;
                foreach (var item in reading)
                {
                    if (item==str)
                    {
                        indexO = readingList.IndexOf(item);
                        Console.WriteLine("{0}", indexO);
                        readingList.RemoveRange(indexO, 6);
                        reading = readingList.ToArray();
                        execute = true;
                    }
                    else
                    {
                        Console.WriteLine("ID DOesnt Exits");
                    }
                }               
                if (execute==true)
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        foreach (var item in reading)
                        {
                            writer.WriteLine(item);

                        }
                    }
                }
              
                          
            }
            public void listTopThree()
            {
                string[] reading = File.ReadAllLines(path, Encoding.UTF8);
                List<double> cgpaList = new List<double>();
                for (int i = 2; i < reading.Length; i=i+6)
                {               
                    if (i!=reading.Length)
                    {
                    double gpa = 0.0;
                    gpa=Convert.ToDouble(reading[i]);
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
                    Console.WriteLine("{0}", item);
                    index++;
                    if (index>2)
                    {
                        break;
                    }
                }
            }
            public void markStudentAttendance()
            {
                string[] enrollment = new string[100];
                int index = 0;
                Console.WriteLine("Listing No of Students");
                string[] reading = File.ReadAllLines(path, Encoding.UTF8);
                for (int i = 0; i < reading.Length; i++)
                {
                    if (i == 0 || i >= 6 && i % 6 == 0)
                    {
                        enrollment[index] = reading[i];
                        index++;
                    }
                }
                string[] attendanceList = new string[index];
                string[] enrollAlist = new string[index * 2];
                string attendance = "Null";
                Console.WriteLine("Mark Attendance");
                for (int i = 0; i < index; i++)
                {
                    Console.WriteLine("{0}", enrollment[i]);
                    attendance = Console.ReadLine();
                    attendanceList[i] = attendance;
                    using (StreamWriter outputFile = new StreamWriter(text, true))
                    {
                        outputFile.WriteLine(enrollment[i]);
                        outputFile.WriteLine(attendanceList[i]);
                    }                    
                }
            }
            public void viewAttendance()
            {
                int index = 1;
                string[] reading = File.ReadAllLines(text, Encoding.UTF8);
                Console.WriteLine("::  Enrollment  : :  Attendance  ::");
                foreach (var item in reading)
                {                    
                    Console.Write("{0}  ",item.ToString());
                    index++;
                    if (index>1)
                    {
                        if (index % 2 == 1)
                        {
                            Console.WriteLine("");
                        }
                    }
                }
            }
            static void Main(string[] args)
            {
                Student admin = new Student();
                Console.WriteLine(":::    MENU    :::");
                Console.WriteLine("Press 1 for Creating a Student Profile");
                Console.WriteLine("Press 2 for Searching a student Profile");
                Console.WriteLine("Press 3 for Deleting a student  Profile");
                Console.WriteLine("Press 4 for The List of Top 3 of Class");
                Console.WriteLine("Press 5 for Marking Student Attendance");
                Console.WriteLine("Press 6 for Viewing Attendace");
                string choice = "0";
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        int lastIndex = 0;
                        Student[] list = new Student[100];
                        list[lastIndex] = new Student();
                        list[lastIndex].createStudentProfile();
                        lastIndex++;
                        break;
                    case "2":
                        admin.searchStudent();
                        break;
                    case "3":
                        admin.deleteStudentRecord();
                        break;
                    case "4":
                        admin.listTopThree();
                        break;
                    case "5":
                        admin.markStudentAttendance();
                        break;
                    case "6":
                        admin.viewAttendance();
                        break;
                    default:
                        break;
                }
            }


        }
    }
}

