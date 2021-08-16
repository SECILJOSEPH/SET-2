using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditon_set_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            //double a = Getdouble("Enter the number");
            //if (Greaterthan(a,0))
            //    Console.WriteLine("This number is Positive Integer");
            //else if (Lesserthan(a,0))
            //    Console.WriteLine("This number is Negative Integer");
            //else
            //    Console.WriteLine("This number is Zero");            
            
            //Question 2
            //int a = Getinteger("Enter the First number");
            //int b = Getinteger("Enter the Second number");
            //if (Equals(a,b))                
            //    Console.WriteLine("The First number and Second number is Equal");
            //else
            //    Console.WriteLine("The First number and Second number is not Equal");
            

            //Question 3
            //int @  = Getinteger("Enter the First number");
            //int b = Getinteger("Enter the Second number");

            //if (@ ==0.1)
            //    a == b)
            //    Console.WriteLine("The First number and Second number is Equal");
            //else
            //    Console.WriteLine("The First number and Second number is not Equal");


            //Question 4
            //int a = Getinteger("Enter the number");
            //if (Nozero(a))
            //    if (modulo(a , 2) == 0)
            //        Console.WriteLine("This number is Even number");
            //    else
            //        Console.WriteLine("This number is Odd number");
            //else
            //    Console.WriteLine("Please enter Positive number");

            //Question 5
            //int Year = Getinteger("Enter the Year");
            //if (Year >= 1000 && Year <= 3000)
            //    if (modulo(Year, 4) == 0 && modulo(Year, 100) != 0 && modulo(Year, 400) != 0)
            //        Console.WriteLine("This Year is Leap Year");
            //    else if (modulo(Year, 4) == 0 && modulo(Year, 100) == 0 && modulo(Year, 400) != 0)
            //        Console.WriteLine("This Year is not Leap Year");
            //    else
            //        Console.WriteLine("This Year is not Leap Year");
            //else
            //    Console.WriteLine("Please enter Valid year 1000 to 3000");

            //Question 6
            //string Name = Getstring("Enter your Name");
            //int age = Getinteger("Enter Your age");
            //if (Greaterthan(age,18) || Equals(age,18))
            //    Console.WriteLine("Your are eligible for voting");
            //else
            //    Console.WriteLine("Your are not eligible for voting");

            //Question 7            
            //int cm = Getinteger("Enter Your height in Centimetres");
            //if (cm >=60 && cm <=120)
            //    Console.WriteLine("Your height is Shortest height from the given Data");
            //else if(cm >=120 && cm <=180)
            //    Console.WriteLine("Your height is Medium height from the given Data");
            //else if(cm >=180 && cm <=240)
            //    Console.WriteLine("Your height is Tall height from the given Data");
            //else
            //    Console.WriteLine("Please enter valid height above 60 Centimetre");

            //Question 8            
            //int num1 = Getinteger("Enter the First number");
            //int num2 = Getinteger("Enter the Second number");
            //int num3 = Getinteger("Enter the Third number");
            //if (Greaterthan(num1, num2) && Greaterthan(num1,num3))
            //    Console.WriteLine("{0} is Largest Amoung Three Numbers", num1);
            //else if (Greaterthan(num2, num3) && Greaterthan(num2, num1))
            //    Console.WriteLine("{0} is Largest Amoung Three Numbers", num2);
            //else
            //    Console.WriteLine("{0} is Largest Amoung Three Numbers", num3);
        
            //Question 9
            //int num1 = Getinteger("Enter the First number");
            //int num2 = Getinteger("Enter the Second number");
            //int num3 = Getinteger("Enter the Third number");
            //if (Lesserthan(num1,num2) && Lesserthan(num1,num3))
            //    Console.WriteLine("{0} is Smallest Amoung Three Numbers", num1);
            //else if (Lesserthan(num2, num3) && Lesserthan(num2, num1))
            //    Console.WriteLine("{0} is Smallest Amoung Three Numbers", num2);
            //else
            //    Console.WriteLine("{0} is Smallest Amoung Three Numbers", num3);

            //Question 10            
            //int num1 = Getinteger("Enter the First number");
            //int num2 = Getinteger("Enter the Second number");
            //int num3 = Getinteger("Enter the Third number");
            //int num4 = Getinteger("Enter the Fourth number");
            //if (num1 > num3 && num1 > num2 && num1 > num4)
            //    Console.WriteLine("{0} is Largest Amoung Four Numbers", num1);
            //else if (num2 > num1 && num2 > num3 && num2 > num4)
            //    Console.WriteLine("{0} is Largest Amoung Four Numbers", num2);
            //else if (num3 > num1 && num3 > num2 && num3 > num4)
            //    Console.WriteLine("{0} is Largest Amoung Four Numbers", num3);
            //else
            //    Console.WriteLine("{0} is Largest Amoung Four Numbers", num4);

            //Question 11
            //int num1 = Getinteger("Enter the First number");
            //int num2 = Getinteger("Enter the Second number");
            //int num3 = Getinteger("Enter the Third number");
            //double no1 = difference(num1, num2);
            //double no2 = difference(num1, num3);
            //double no3 = difference(num2, num3);
            //if (Getpositive(num1))
            //    if (Getpositive(num2))
            //        if (Getpositive(num3))
            //            if (no1 <= no2 && no1 <= no3)
            //                Console.WriteLine("{0} and {1} is closer to each other", num1,num2);
            //            else if (no2 <= no1 && no2 <= no3)
            //                Console.WriteLine("{0} and {1} is closer to each other", num1, num3);
            //            else
            //                Console.WriteLine("{0} and {1} is closer to each other", num2, num3);
            //        else
            //            Console.WriteLine("Please enter Positive number");
            //    else
            //        Console.WriteLine("Please enter Positive number");
            //else
            //    Console.WriteLine("Please enter Positive number");
            
            //Question 12
            //int num1 = Getinteger("Enter the First number");
            //int num2 = Getinteger("Enter the Second number");
            //int num3 = Getinteger("Enter the Third number");
            //double no1 = difference(num1, num2);
            //double no2 = difference(num1, num3);
            //double no3 = difference(num2, num3);
            //if (Getpositive(num1))
            //    if (Getpositive(num2))
            //        if (Getpositive(num3))
            //            if (no1 >= no2 && no1 >= no3)
            //                Console.WriteLine("{0} and {1} is farther from each other", num1, num2);
            //            else if (no2 >= no1 && no2 >= no3)
            //                Console.WriteLine("{0} and {1} is farther from each other", num1, num3);
            //            else
            //                Console.WriteLine("{0} and {1} is farther from each other", num2, num3);
            //        else
            //            Console.WriteLine("Please enter Positive number");
            //    else
            //        Console.WriteLine("Please enter Positive number");
            //else
            //    Console.WriteLine("Please enter Positive number");

            //Question 13
            //int num1 = Getinteger("Enter the First number");
            //int num2 = Getinteger("Enter the Second number");
            //int num3 = Getinteger("Enter the Third number");
            //if (num1 < num2 && num1 < num3 && num2 < num3)
            //    Console.WriteLine("The Sorted three integers : {0}, {1}, {2}", num1, num2, num3);
            //else if (num1 < num2 && num1 < num3 && num3 < num2)
            //    Console.WriteLine("The Sorted three integers : {0}, {1}, {2}", num1, num3, num2);
            //else if (num2 < num1 && num2 < num3 && num1 < num3)
            //    Console.WriteLine("The Sorted three integers : {0}, {1}, {2}", num2, num1, num3);
            //else if (num2 < num1 && num2 < num3 && num3 < num1)
            //    Console.WriteLine("The Sorted three integers : {0}, {1}, {2}", num2, num3, num1);
            //else if (num3 < num1 && num3 < num2 && num1 < num2)
            //    Console.WriteLine("The Sorted three integers : {0}, {1}, {2}", num3, num1, num2);
            //else
            //    Console.WriteLine("The Sorted three integers : {0}, {1}, {2}", num3, num2, num1);

            //Question 14
            //int angle1 = Getinteger("Enter the First Angle");
            //int angle2 = Getinteger("Enter the Second Angle");
            //int angle3 = Getinteger("Enter the Third Angle");
            //double Angle = addition(addition(angle1, angle2), angle3);
            //if (Getpositiveone(angle1))
            //    if (Getpositiveone(angle2))
            //        if (Getpositiveone(angle3))
            //            if (Angle == 180)
            //                Console.WriteLine("The Triangle is formed by Given three Angles : {0}, {1}, {2}", angle1, angle2, angle3);
            //            else
            //                Console.WriteLine("The Triangle is not formed by Given three Angles : {0}, {1}, {2}", angle1, angle2, angle3);
            //        else
            //            Console.WriteLine("Please enter Positive number without using Zero");
            //    else
            //        Console.WriteLine("Please enter Positive number without using Zero");
            //else
            //    Console.WriteLine("Please enter Positive number without using Zero");

            //Question 15
            //int num1 = Getinteger("Enter the First Quadrant");
            //int num2 = Getinteger("Enter the Second Quadrant");
            //if (Nozero(num1))
            //    if (Nozero(num2))
            //        if (num1 > 0 && num2 > 0)
            //            Console.WriteLine("The XY coordinate points lies on I Quadrant: {0}, {1}", num1, num2);
            //        else if (num1 > 0 && num2 < 0)
            //            Console.WriteLine("The XY coordinate points lies on II Quadrant: {0}, {1}", num1, num2);
            //        else if (num1 < 0 && num2 < 0)
            //            Console.WriteLine("The XY coordinate points lies on III Quadrant: {0}, {1}", num1, num2);
            //        else
            //            Console.WriteLine("The XY coordinate points lies on IV Quadrant: {0}, {1}", num1, num2);
            //    else
            //        Console.WriteLine("Please enter Positive number without using Zero");
            //else
            //    Console.WriteLine("Please enter Positive number without using Zero");

            //Question 16
            //char ch = Getchar("Enter the Character");
            //if ((ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u') || (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U'))
            //    Console.WriteLine("{0} is Vowel", ch);
            //else
            //    Console.WriteLine("{0} is Consonant", ch);

            //Question 17
            //int side = Getinteger("Enter the number of sides of a Shape (upto 10 sides)");
            //if (side == 1)
            //    Console.WriteLine("The Name of that shape is : Monogon");
            //else if (side == 2)
            //    Console.WriteLine("The Name of that shape is : Digon");
            //else if (side == 3)
            //    Console.WriteLine("The Name of that shape is : Triangle");
            //else if (side == 4)
            //    Console.WriteLine("The Name of that shape is : Quadrilateral");
            //else if (side == 5)
            //    Console.WriteLine("The Name of that shape is : Pentagon");
            //else if (side == 6)
            //    Console.WriteLine("The Name of that shape is : Hexagon");
            //else if (side == 7)
            //    Console.WriteLine("The Name of that shape is : Heptagon");
            //else if (side == 8)
            //    Console.WriteLine("The Name of that shape is : Octagon");
            //else if (side == 9)
            //    Console.WriteLine("The Name of that shape is : Nonagon");
            //else if (side == 10)
            //    Console.WriteLine("The Name of that shape is : Decagon");
            //else
            //    Console.WriteLine("Enter vaild number 1 to 10");      

            //Question 18
            //string month = Getstring("Enter the Month");
            //if ((month == "January" || month == "March" || month == "May" || month == "July" || month == "August" || month == "October" || month == "December") || (month == "january" || month == "march" || month == "may" || month == "july" || month == "august" || month == "october" || month == "december"))
            //    Console.WriteLine("Number of days is 31");
            //else if ((month == "April" || month == "June" || month == "September" || month == "November") || (month == "april" || month == "june" || month == "september" || month == "november"))
            //    Console.WriteLine("Number of days is 30");
            //else if ((month == "February") || (month == "february"))
            //    Console.WriteLine("Number of days is 28");
            //else
            //    Console.WriteLine("Enter vaild month Must start with lower case Ex: 'april' or Initial caps Ex: 'April'");      

            //Question 19
            //int date = Getinteger("Enter the day from 1 to 31");
            //if (modulo(date,7) == 1)
            //    Console.WriteLine("The given day of Month is 'Monday'");
            //else if (modulo(date, 7) == 2)
            //    Console.WriteLine("The given day of Month is 'Tuesday'");
            //else if (modulo(date, 7) == 3)
            //    Console.WriteLine("The given day of Month is 'Wednesday'");
            //else if (modulo(date, 7) == 4)
            //    Console.WriteLine("The given day of Month is 'Thursday'");
            //else if (modulo(date, 7) == 5)
            //    Console.WriteLine("The given day of Month is 'Friday'");
            //else if (modulo(date, 7) == 6)
            //    Console.WriteLine("The given day of Month is 'Saturday'");
            //else if (modulo(date, 7) == 0)
            //    Console.WriteLine("The given day of Month is 'Sunday'");
            //else
            //    Console.WriteLine("Enter vaild day from 1 to 31 Ex: 10");      
            
            //Question 20
            //int angle1 = Getinteger("Enter the First Angle");
            //int angle2 = Getinteger("Enter the Second Angle");
            //int angle3 = Getinteger("Enter the Third Angle");
            //int Angle = angle1 + angle2 + angle3;
            //if (Getpositiveone(angle1))
            //    if (Getpositiveone(angle2))
            //        if (Getpositiveone(angle3))
            //            if (angle1 == 60 && angle2 == 60 && angle3 == 60)
            //                Console.WriteLine("The Triangle is formed and name of the triangle is : Equilateral");
            //                else if (angle1 == angle2 || angle1 == angle3 || angle2 == angle3)
            //                Console.WriteLine("The Triangle is formed and name of the triangle is : Isosceles");
            //            else if(Angle == 180)
            //                Console.WriteLine("The Triangle is formed and name of the triangle is : Scalene");
            //            else
            //                Console.WriteLine("The Triangle is not formed by given three Angles");
            //        else
            //            Console.WriteLine("Please enter Positive number without using negative number and Zero");
            //    else
            //        Console.WriteLine("Please enter Positive number without using negative number and Zero");
            //else
            //    Console.WriteLine("Please enter Positive number without using negative number and Zero");

            //Question 21
            //int mark = Getinteger("Enter Your Mark from 0 to 100");
            //if (mark >= 0 && mark <= 100)
            //    if (mark >= 90)
            //        Console.WriteLine("Your Grade is : 'A' for this mark {0}", mark);
            //    else if (mark >= 80)
            //        Console.WriteLine("Your Grade is : 'B' for this mark {0}", mark);
            //    else if (mark >= 60)
            //        Console.WriteLine("Your Grade is : 'C' for this mark {0}", mark);
            //    else if (mark >= 50)
            //        Console.WriteLine("Your Grade is : 'D' for this mark {0}", mark);
            //    else
            //        Console.WriteLine("Your Grade is : 'F' for this mark {0}", mark);
            //else
            //    Console.WriteLine("Please enter mark from 0 to 100");

            //Question 22
            //string chess = Getstring("Enter the column (a-h) and row (1-8) in a Chess Board");
            //if ((chess == "a1" || chess == "a3" || chess == "a5" || chess == "a7") || (chess == "A1" || chess == "A3" || chess == "A5" || chess == "A7"))
            //    Console.WriteLine("{0} the color is Black", chess);
            //else if ((chess == "b2" || chess == "b4" || chess == "b6" || chess == "b8") || (chess == "B2" || chess == "B4" || chess == "B6" || chess == "B8"))
            //    Console.WriteLine("{0} the color is Black", chess);
            //else if ((chess == "c1" || chess == "c3" || chess == "c5" || chess == "c7") || (chess == "C1" || chess == "C3" || chess == "C5" || chess == "C7"))
            //    Console.WriteLine("{0} the color is Black", chess);
            //else if ((chess == "d2" || chess == "d4" || chess == "d6" || chess == "d8") || (chess == "D2" || chess == "D4" || chess == "D6" || chess == "D8"))
            //    Console.WriteLine("{0} the color is Black", chess);
            //else if ((chess == "e1" || chess == "e3" || chess == "e5" || chess == "e7") || (chess == "E1" || chess == "E3" || chess == "E5" || chess == "E7"))
            //    Console.WriteLine("{0} the color is Black", chess);
            //else if ((chess == "f2" || chess == "f4" || chess == "f6" || chess == "f8") || (chess == "F2" || chess == "F4" || chess == "F6" || chess == "F8"))
            //    Console.WriteLine("{0} the color is Black", chess);
            //else if ((chess == "g1" || chess == "g3" || chess == "g5" || chess == "g7") || (chess == "G1" || chess == "G3" || chess == "G5" || chess == "G7"))
            //    Console.WriteLine("{0} the color is Black", chess);
            //else if ((chess == "h2" || chess == "h4" || chess == "h6" || chess == "h8") || (chess == "H2" || chess == "H4" || chess == "H6" || chess == "H8"))
            //    Console.WriteLine("{0} the color is Black", chess);
            //else
            //    Console.WriteLine("{0} the color is White", chess);

            //Question 22            
            //char ch = Getchar("Enter the column (a-h) in a Chess Board");
            //int num = Getinteger("Enter the row (1-8) in a Chess Board");
            //if ((Equals(ch, 'a') || Equals(ch, 'A') || Equals(ch, 'c') || Equals(ch, 'C') || Equals(ch, 'e') || Equals(ch, 'E') || Equals(ch, 'g') || Equals(ch, 'G')) && (num % 2) == 1)
            //    Console.WriteLine("{0}{1} the color is Black", ch, num);
            //else if ((Equals(ch, 'b') || Equals(ch, 'B') || Equals(ch, 'd') || Equals(ch, 'D') || Equals(ch, 'f') || Equals(ch, 'F') || Equals(ch, 'h') || Equals(ch, 'H')) && (num % 2) == 0)
            //    Console.WriteLine("{0}{1} the color is Black", ch, num);
            //else
            //    Console.WriteLine("{0}{1} the color is White", ch, num);
            
            //Question 23
            //int a = Getinteger("Enter your First number");
            //int b = Getinteger("Enter your Second number");
            //int c = Getinteger("Enter your Third number");
            //double d = difference(product(b, b), 4 * product(a, c));
            //double x1 = difference(-b, Math.Sqrt(d));
            //double x2 = addition(-b, Math.Sqrt(d));                
            //if (d == 0)
            //    Console.WriteLine("single real root");
            //else if (d > 0)
            //    Console.WriteLine("Two reel roots root one : {0} root two : {1}", x1,x2);
            //else
            //    Console.WriteLine("No real roots");


            ////Question 24
            //int price = Getinteger("Enter Your buying price");
            //int sell = Getinteger("Enter Your Selling price");
            //if (Lesserthan(price, sell))
            //    Console.WriteLine("You have Profit {0}Rs from this price : {1}Rs", sell, price);
            //else
            //    Console.WriteLine("You have Loss {0}Rs from this price : {1}Rs", sell, price);

            //Question 25            
            //int num1 = Getinteger("Enter Your First Number");
            //int num2 = Getinteger("Enter Your Second Number");
            //Console.WriteLine("For addition press : 1");
            //Console.WriteLine("For subtraction press : 2");
            //Console.WriteLine("For multiplication press : 3");
            //Console.WriteLine("For division press : 4");
            //Console.WriteLine("For modulo division press : 5");
            //int Menu = Getinteger("Choose any one of these above Calculation");
            //if (Equals(Menu,1))
            //    Console.WriteLine("The addition of two number is : {0}", addition(num1, num2));
            //else if (Equals(Menu, 2))
            //    Console.WriteLine("The subtraction of two number is : {0}", Math.Abs(difference(num1, num2)));
            //else if (Equals(Menu, 3))
            //    Console.WriteLine("The multiplication of two number is : {0}", product(num1, num2));
            //else if (Equals(Menu, 4))
            //    Console.WriteLine("The division of two number is : {0}", division(num1, num2));
            //else
            //    Console.WriteLine("The modulo division of two number is : {0}", modulo(num1, num2));
            }                   
        #region Basic Function  
            public static double addition(double i, double j)
            {
                return (i + j);
            }
            public static double difference(double i, double j)
            {
                return (i - j);
            }
            public static double product(double i, double j)
            {
                return i * j;
            }
            public static double division(double i, double j)
            {
                return i / j;
            }
            public static double modulo(double i, double j)
            {
                return i % j;
            }
            public static int Getinteger(string message)
            {
                Console.WriteLine(message +" :");
                int Getinteger = Convert.ToInt32(Console.ReadLine());
                return Getinteger;
            }
            public static long Getlong(string message)
            {
                Console.WriteLine(message + " :");
                long Getlong = Convert.ToInt64(Console.ReadLine());
                return Getlong;
            }
            public static double Getdouble(string message)
            {
                Console.WriteLine(message + " :");
                double Getdouble = Convert.ToDouble(Console.ReadLine());
                return Getdouble;
            }
            public static decimal Getdecimal(string message)
            {
                Console.WriteLine(message + " :");
                decimal Getdecimal = Convert.ToDecimal(Console.ReadLine());
                return Getdecimal;
            }
            public static string Getstring(string message)
            {
                Console.WriteLine(message + " :");
                string Getstring = Convert.ToString(Console.ReadLine());
                return Getstring;
            }
            public static char Getchar(string message)
            {
                Console.WriteLine(message + " :");
                char Getchar = Convert.ToChar(Console.ReadLine());
                return Getchar;
            }            
            public static bool Getpositive(double i)
            {
                return i >= 0;
            }
            public static bool Getpositiveone(double i)
            {
                return i >= 1;
            }
            public static bool Nozero(double i)
            {
                return i != 0;
            }
            public static bool Greaterthan(double i, double j)
            {
                return i > j;
            }
            public static bool Lesserthan(double i, double j)
            {
                return i < j;
            }
        #endregion
    }
}
        