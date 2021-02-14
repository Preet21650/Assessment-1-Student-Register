using System;
using System.Collections.Generic;
using System.Text;

 namespace Assessment_1_School_Register
{
    class FormGroup
    {
        private string FormName;
        private string TeacherName;
        private Student[] Students;
        int totalStudent = 0;

        public FormGroup(string Name, string TeacherName)
        {
            this.FormName = Name;
            this.TeacherName = TeacherName;
            Students = new Student[30];

        }
        public void AddStudent(String Name, DateTime DateOfBirth, String Gender)
        {
            Students[totalStudent] = new Student(Name, DateOfBirth, Gender);
            totalStudent++;
        }

        public void TakeRegister(DateTime Date)
        {
            for (int i = 0; Students[i] != null; i++)
            {
              
                    Console.WriteLine("Please Enter " + Students[i].GetName() + " s Attendance Status");
                    String AttendanceStatus = Console.ReadLine();
                    Students[i].AddAttendance(Date, AttendanceStatus);
            }

        }

        public void PrintRegister(DateTime startDate, bool  day)
        // if day = false, it is weekly register
        {
           

            if ( day == true)
            {
                Console.WriteLine(DateTime.Today.ToShortDateString());
                for( int i=0; Students[i] != null; i++)
                {
                    Console.WriteLine( Students[i].GetName() + "\t" + Students[i].getAttendancestatus(startDate));              
                }
            }
            else
            {
                 DateTime D = startDate;

                // Printing the heading
                for ( int i=0; i< 7;i++)
                {
                    Console.Write(D.ToShortDateString() + "\t");
                    D = D.AddDays(1);
                }
                Console.WriteLine("");

               

                // Print Attendance status for a week for each student
                for( int i=0; Students[i] != null; i++)
                {
                    D = startDate;
                    Console.Write( Students[i].GetName() + "\t" );

                   for ( int j = 0; j < 7 && j < Students[i].GetNumberOfDays() ;j++)
                    { 
                        Console.Write("\t" + Students[i].getAttendancestatus(D) + "\t");
                        D = D.AddDays(1);
                    }
                    Console.WriteLine(""); // next student
                }
                    
            } // else ends

       

            

        } // function ends





    }// class
}//namespace