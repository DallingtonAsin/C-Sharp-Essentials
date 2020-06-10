/*
******************************************************
Variables, Data types, Strings, Numbers[int, double]
User input, Arrays, Methods, Return statements
If statements, switch statements, while loops, for loops
2d arrays, comments, exception handling, classes and objects,
Constructors, object methods, Getter and Setter methods,
Static class attributes, static MethodSemanticsAttributes and classes
Inheritance


*****Primitive data types*************
* Integral numbers: byte, short, int, long
* Real numbers: float, double, decimal
* Character: char
* Boolean: bool
*******************************************************
* 
* 
* *******Non-primitive data types in C#***************
* 1. String
* 2. Array
* 3. Enum
* 4. Class
*/

/*
 * ****Identifiers****
 * cannot start with a number
 * cannot have whitespaces
 * cannot be a reserved keyword
 * use meaningful names
 * */

 /*
  * *****Naming conventions
  * Camel Case e.g. firstName
  * Pascal Case e.g. FirstName
  * Hungarian Notation e.g. strFirstName
  * 
  * 
  * ****Scope******
  * is where a variable or constant has meaning 
  * */


using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Dynamic;
using System.Linq.Expressions;

namespace Essentials
{
    class Program: EssentialProgram //Program class inherits EssentialProgram
    {

        public string name; //public instance variable
        private int age; // private instance variable
        private string company;
        static float salary; // class variable
        const double allowance = 2000; // constant data //immutable data
       

        //getter and setter methods
        private void setCompany(string company)
        {
            this.company = company;
        }
        private string getCompany()
        {
            return this.company;
        }

        //Compute Salary
        double computeSalary()
        {
            return salary + allowance;
         
        }
        
        //Instance method
        float add(int x, float y)
        {
            return x + y;
        }

        //static or class method
        static double substract(double a, double b)
        {
            return a - b;
        }

        //use of if statement and bool data type
        bool is_old(int age){
            if(age > 18)
            {
                return true;
            }

            return false;

        }

        //use of a switch statement
         double simpleCalc(string sign, double a, double b)
        {

            double result = 1;
           
            switch(sign)
            {
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;

            }
            return result;
           
        }

       /* void overflowing()
        {
            try
            {

                checked // stops overflowing but rather throws an exception
            {
                byte num = 255; //255 is maximum for the byte
                
                    num += 1; // trying to overflow
                    Console.WriteLine("After overflowing, the value of the num is " + num);
                }
                

            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

        }*/

        // make sound using Beep()
        void makeSound()
        {
            Console.Beep();
        }


        //using for loop to sum elements in an array
        void getSum(int[] nums)
        {
             int totl = 0;
            for(int i=0; i<nums.Length; i++)
            {
                totl += nums[i]; 
            }
            Console.WriteLine("The sum of elements in an array using a for loop is "+totl+"");
        }



        //class method that uses try and catch in computind a/b
        static void division(double m, double n)
        {
            try
            {
             Console.WriteLine(""+m+" divided by "+n+" is "+m/n+"");

            }catch(DivideByZeroException ex)
            {
                Console.WriteLine("Division by zero exception message" + ex.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Am a method trying to divide two numbers");
            }

            

        }

        //using a while loop to sum elements in an array
        void getTotl(int[] nums)
        {
            int y = 0;
            int sum = 0;
            while (y < nums.Length)
            {
                sum += nums[y];
                y += 1;
            }
            Console.WriteLine("The sum of elements in an array using a while loop is " + sum + "");
        }


        //entry point to the program
        static void Main(string[] args)
        {


            byte num = 4;
            int a = 9;
            double b = 15.0;
            float c = 12.0f;
            decimal d_number = 35.9m;
            char letter = 'D';
            string the_name = "Dallington";
            Program obj = new Program();

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            //Implicit conversion
            int i = num;
            Console.WriteLine(i);

            //explicit conversion (casting)
            byte by = (byte)i;
            Console.WriteLine(by);


           // obj.overflowing();

            obj.name = "Ivan";
            obj.age = 36;
            salary = 5000;
            obj.setCompany("Microsoft Co.");
            Console.WriteLine("" + obj.name + " who is " + obj.age + " years old and works with " + obj.getCompany() + ", earns " + obj.computeSalary() + "");

            obj.details_of_the_program(); //method inherited from EssentialProgram class

            division(9, 2);


            Console.WriteLine("Letter: " + letter + " Name:" + the_name + " Byte: " + num + " and Decimal is " + d_number + "");
            Console.WriteLine("" + a + " plus " + c + " is " + obj.add(a, c) + "");
            Console.WriteLine("" + a + " minus " + b + " is " + substract(a, b) + "");

            // Arrays in C
            int[] numbers = { 12, 20, 56, 90 };
            for (int x = 0; x < numbers.Length; x++)
            {
                Console.WriteLine(numbers[x]);
            }

            //User input
            Console.WriteLine("Enter your age:");
            int agee = Convert.ToInt32(Console.ReadLine());
            bool isold = obj.is_old(agee);
            if (isold)
            {
                obj.makeSound();
            }
            Console.WriteLine("Am i old:" + isold);


            int[] mynumbers = { 12, 35, 65, 78, 125, 190, 128 };
            obj.getSum(mynumbers);
            obj.getTotl(mynumbers);



            Console.WriteLine("Enter the first value");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second value");
            double q = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operator");
            string op = Console.ReadLine();

            Console.WriteLine(+p + " " + op + " " + q + " is " + obj.simpleCalc(op, p, q));



            /*
            ************************

              Reading data from SQL database

            *************************
           */




            //string sql = null;
            //string provider = ConfigurationManager.ConnectionStrings["provider"].ToString(); 

           // string connectionString = @"Data Source=DALLINGTON\MSSQLSERVER01;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; //  ConfigurationManager.AppSettings["connectionString"]; // ConfigurationManager.ConnectionStrings["connectionString"].ToString();
                //SqlConnection cnn;
                // sql = "select * from products";

               /* cnn = new SqlConnection(connectionString);
                cnn.Open();
                Console.WriteLine("Connection Open  !");
                cnn.Close();*/




                Console.ReadLine();


            

            }
    }
}
