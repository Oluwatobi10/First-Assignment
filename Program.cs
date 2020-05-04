using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            /* A program that calculates the value of X in a quadratic equation given a user inputs a,b,c
                
                y = aX^2 + bX + c
                X1 = -b+sqrt(b^2-4ac)
                X2 = -b-sqrt(b^2-4ac)
            */
            Console.WriteLine("Quadratic Equation Calculator"); 
            
            Console.WriteLine("Enter your first value"); //Prompts user for first value
            string  a = Console.ReadLine(); //Gets the first value

            Console.WriteLine("Enter your second value"); //Prompts user for second value
            string  b = Console.ReadLine(); // Gets the second value

            Console.WriteLine("Enter your third value"); //Prompts user for third value
            string  c = Console.ReadLine(); //Gets the third value

            int A = Convert.ToInt32(a); //Converts first value to an integer
            int B = Convert.ToInt32(b); //Converts second value to an integer
            int C = Convert.ToInt32(c); //Converts third value to an integer

            Console.WriteLine("you have entered a = " + A + " , b = " + B + " , c = " + C); //Prints out the values entered by user 

            //Test case a=1, b=5, c=6
            double X1 = (-B+ Math.Sqrt(Math.Pow(B,2)-(4*A*C)))/2; //Calculates the value of X1
            double X2 = (-B- Math.Sqrt(Math.Pow(B,2)-(4*A*C)))/2; //Calculates the value of X2
                
            Console.WriteLine("The value of X1 is " + X1); 
            Console.WriteLine("The value of X2 is " + X2 );
            

            /* A program that converts fahrenheit to celcius*/
            Console.WriteLine("              ");
            Console.WriteLine("Fahrenheit to Celcuis");

            Console.Write("Enter your value in Fahrenheit: ");//Prompts user for an input

            string num = Console.ReadLine(); //Gets the input from the user

            int num1 = Convert.ToInt32(num); //Converts the input to an integer

            double ans = ((num1-32)*5)/9;  // Converts the value to fahrenheit

            Console.WriteLine("The answer is " + ans + " degree Celcius"); //Prints the answer


            //A palindrone detector
            /* This programs get a string from a user and  checks
            whether it is Palindrome or not. 
            It returns True if it is a palindrone and False if its not
            */
            Console.WriteLine("              ");
            Console.WriteLine("A palindrome detector");

            Console.WriteLine("Input your word : "); //Prompts user to enter a value

            string text = Console.ReadLine(); //Get input from user 

            char[] arr =text.ToCharArray();//Converts it to an array

            Array.Reverse(arr);//reverses the array

            bool answer = text == new string(arr);//Compares the value with the reversed string

            Console.WriteLine("Is " + text +" a palindrone? - " + answer);//Prints out the answer
;
        }
    }
}
