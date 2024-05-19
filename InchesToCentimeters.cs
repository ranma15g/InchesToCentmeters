using System;

/*

2-1.  Write a C# program named InchesToCentmeters that declares a named constant that holds the number of centimeters in an inch: 2.54.

 Also declare a variable to represent a measurement in inches, and assign a value.

 Display the measurement in both inches and centimeters—for example, 3 inches is 7.62 centimeters.

*/

class Program
{
    static void Main(string[] args)
    {
    /* Here is where we declare a named constant 
        that holds the number of centimeters in 
        an inch: 2.54. */
        const double CENTIMETERS_PER_INCH = 2.54;

    /* Here is where we declare a variable to represent
        a measurement in inches, and assign a value. */
        int inches = 15994; /* This value changes based 
                            on the Unit Test */

    /* Here is where we convert inches to centimeters */
        double centimeters = inches * CENTIMETERS_PER_INCH;
                /* Please note that this is implicit type
                    casing where we combine an int and a 
                    double. When we perform mathematical 
                    operations. The int gets converted to 
                    a double and the result of this
                    equation becomes a double. */


        /* Here we will display the measurement in both 
            inches and centimeters
            —Unit Test 4, Required Inputs:  15994 inches 
                        Expected Outcome: 406.24.76 centimeters. */
            Console.WriteLine("Unit Test 4 -  15994 inches:");
            Console.WriteLine("{0} inches is {1} centimeters.", inches, centimeters); 

    }
}
