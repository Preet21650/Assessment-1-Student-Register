using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_1_School_Register
{
    class Student
    {
        public string Name;
        public DateTime DateOfBirth;
        public bool Gender;
        private Attendance[] Attendances;
        int MinutesLate = 0;
        int NumberOfDays = 0;
        int PresentDays = 0;
        int AbsentDays = 0;
        int LateDays = 0;

        public Student(String Name, DateTime DateOfBirth, bool Gender)
        {
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            Attendance[] Days = new Attendance[180];

        }

        public void AddAttendance(String AttendanceStatus, int MinutesLate)
        {

            if (AttendanceStatus == "Present")
            {
                Attendances[NumberOfDays] = new Attendance(Date, AttendanceStatus);
                NumberOfDays++;
                PresentDays++;
            }
            else if (AttendanceStatus == "Absent")
            {
                Attendances[NumberOfDays] = new Attendance(Date, AttendanceStatus);
                NumberOfDays++;
                AbsentDays++;
            }
            else if (AttendanceStatus == "Late")
            {
                Attendances[NumberOfDays] = new Attendance(Date, AttendanceStatus);
                MinutesLate = MinutesLate + Attendances[NumberOfDays].GetMinutesLate();
                NumberOfDays++;
                LateDays++;
            }
        }

        public int GetPresentDays()
        {
            return PresentDays;
        }
        public int GetAbsentDays()
        {
            return AbsentDays;
        }
        public int GetLateDays()
        {
            return LateDays;
        }
        public int TotalMinutesLate()
        {
            return MinutesLate;
        }
    }
}