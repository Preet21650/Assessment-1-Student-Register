using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_1_Student_Register
{
    class FormGroup
    {
        private string Name;
        private string TeacherName;
        private Student[] Students;
        int totalStudent = 0;

        public FormGroup(string Name, string TeacherName)
        {
            this.Name = Name;
            this.TeacherName = TeacherName;
            Students = new Student[50];
            
        }
    }
}
