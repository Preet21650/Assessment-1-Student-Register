using System;

namespace Assessment_1_School_Register
{
    class Program
    {
        public static void Main()
        {
            // Create a Formgroup : 
            FormGroup F = new FormGroup("12 FB", "Miss Blairs");

            // add students
            string ans, name, gender  ;
            int dd,mm,yy;
            DateTime date;

            // post test loop

            do{

                Console.Write(" Name:  ");                
                name = Console.ReadLine();
                Console.Write(" Gender:  ");              
                gender = Console.ReadLine();
                Console.Write(" Enter Date of birth - day:   ");     
                dd = Convert.ToInt32( Console.ReadLine() );
                Console.Write(" Enter Date of birth - month:   ");   
                mm = Convert.ToInt32( Console.ReadLine() );
                Console.Write(" Enter Date of birth - year:   ");     
                yy = Convert.ToInt32( Console.ReadLine() );
                date = new DateTime(yy,mm,dd);

                F.AddStudent(name,date,gender);

                Console.Write(" More Students ? ");
                ans = Console.ReadLine();

            }while ( ans == "Y" );
            
            // take register
            
            Console.Write(" Want to take Attendance? ");
            ans = Console.ReadLine();       

            while ( ans == "Y" ){
                Console.Write(" Enter Date of Attendance - day:  ");     
                dd = Convert.ToInt32( Console.ReadLine() );
                Console.Write(" Enter Date of Attendance - month:  ");   
                mm = Convert.ToInt32( Console.ReadLine() );
                Console.Write(" Enter Date of Attendance - year:  ");     
                yy = Convert.ToInt32( Console.ReadLine() );
                date = new DateTime(yy,mm,dd);
           
                F.TakeRegister(date);

                 Console.Write(" any more Attendance? ");
                 ans = Console.ReadLine();    
            }


            // Printing of Register

            // Ask : Do you want weekly ? 
            // Ask : Starting date 

                Console.Write(" Print Daily Register / Weeklye Register (D/W)  ");
                ans = Console.ReadLine();   
                Console.Write(" Enter Starting Date for Register Printing - day:   ");     
                dd = Convert.ToInt32( Console.ReadLine() );
                Console.Write(" Enter Starting Date for Register Printing - month:   ");   
                mm = Convert.ToInt32( Console.ReadLine() );
                Console.Write(" Enter Starting Date for Register Printing - year:   ");     
                yy = Convert.ToInt32( Console.ReadLine() );
                date = new DateTime(yy,mm,dd);

                if ( ans == "D")
                   F.PrintRegister(date, true );
                else
                    F.PrintRegister(date,false);
                    



        }
    }
}
