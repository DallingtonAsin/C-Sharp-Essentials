using System;

namespace Essentials
{
    class EssentialProgram
    {

        string programcode, institution;
        int number_of_tutors;
      

      public  void details_of_the_program()
        {
            EssentialProgram obj = new EssentialProgram();
            obj.programcode = "BSSE";
            obj.institution = "Makerere University";
            obj.number_of_tutors =  120;
            Console.WriteLine(""+obj.programcode+" is an essential program in "+obj.institution+" with "+obj.number_of_tutors+" lecturers");
        }


    }
}
