using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_1_School_Register
{
    class Attendance
    {
        private DateTime Date;
        private string DayOfWeek;
        private string AttendenceStatus;
        private int MinutesLate;

        public Attendance(DateTime Date, string AttendenceStatus)
        {
            if (AttendenceStatus != "Late")
            {
                this.Date = Date;
                this.AttendenceStatus = AttendenceStatus;
                DayOfWeek = Date.ToString("dddd");
                MinutesLate = 0;
            }
            else if (AttendenceStatus == "Late")
            {
                this.Date = Date;
                this.AttendenceStatus = AttendenceStatus;
                DayOfWeek = Date.ToString("dddd");
                Date = Date.AddHours(-8);
                MinutesLate = (Date.Hour * 60) + Date.Minute;
                Date.AddHours(8);
            }
        }
        public int GetMinutesLate()
        {
            return MinutesLate;
        }
        public DateTime GetDate()
        {
            return Date;
        }
        public string GetAttendanceStatus()
        {
            return AttendenceStatus;

        }


    }
}