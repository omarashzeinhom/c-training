// Will be discussed later in the course

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 */

// See https://aka.ms/new-console-template for more information


// 1. Draw a Shape
Console.WriteLine("    /----    /");
Console.WriteLine("   /|   |   /");
Console.WriteLine("  / |   |  /");
Console.WriteLine(" /  |   | /");
Console.WriteLine("/___|___|/");



//2. ADD VARIABLES and types untill 29:45
string name = "Andgoedu";
int age = 24;

Console.WriteLine("My name is " + name);
Console.WriteLine("I am " + age + "years old" );
Console.WriteLine("And i like variables that are named after me");
Console.WriteLine("Which is " + name);

//3. DATA TYPES AND STORING INTO VARS

string text = "ANDGOEDU !"; // string
char grade = 'A'; // only just a single charachter
int gradeNumber = 70; // integer is a number no need for quotation marks
int negativeGradeNumber = -70;


// double , decimal , and float are decimals untill 37:03
double money = 20.99;

// boolean values true or false 
Boolean on = true;
Boolean off = false;

//Console.Write(); does not add a new line VS Console.WriteLine(); which writes a new line

//4. Working with strings 
Console.WriteLine("Print a \n String");
Console.WriteLine(text[0]); // same index position like in js first charachter starts at 0
Console.WriteLine(text.IndexOf("ANDGO")); // .IndexOf Prints out the starting index position of the string
// if it prints out -1 the phrase is not included in the string
Console.WriteLine(text.Substring(5)); // Prints charachters from the 5th index untill the end 
Console.WriteLine(text.Substring(5, 3)); // PRINTS ALSO EDU  only the 3 charachters after the 5th index




//5. Working With Numbers
int start = 0;
int point = 1;
point++; // increment
//point--; //decrement
Console.WriteLine(point);

Console.WriteLine(-7.3);
Console.WriteLine(5 + 8); // ADDITION , SUBTRACTION , DIVISION AND MULTIPLICATION Operators , aswell as 
Console.WriteLine(5 / 10);
Console.WriteLine(1.5 / 3);
Console.WriteLine(start * 100);

// Math Operations
Console.WriteLine(Math.Abs(50)); // Absolute Value
Console.WriteLine(Math.Pow(2.4, 2)); // Power Value 2.4 ^ to 2
Console.WriteLine(Math.Max(5, 50)); // Max Value
Console.WriteLine(Math.Min(5, 20)); // Min Value


// 6. GET USER INPUT 
Console.Write("Kindly , Enter your name: ");
string userName = Console.ReadLine(); // Data stored into the name variable
Console.Write("Enter your age Please : ");
string userAge = Console.ReadLine();
Console.WriteLine("Hello " + userName + " your " + userAge + " years old !");


//7. Building a Calculator 

int num = Convert.ToInt32("45"); // Converts string to integer // dont add any other charachters than numbers in between " " or it will not work will throw an error for format
Console.WriteLine(num + 6);

Console.Write(" Enter: A Number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write(" Enter A 2nd Number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(num1 * num2);


//8 . Create A MadLib Game
// Enter Random Words and Sprinkle them randomly into a story

string color, pluralNoun, celebrity;

Console.Write("Enter A Color : ");
color = Console.ReadLine();
Console.Write("Enter A pluralNoun : ");
pluralNoun = Console.ReadLine();
Console.Write("Enter A celebrity: ");
celebrity = Console.ReadLine();
Console.WriteLine("Roses are "  + color);
Console.WriteLine("Violets are " + pluralNoun);
Console.Write("I love " + celebrity);




Console.ReadLine();            // Makes Console stay open to ReadLine


namespace Turtle
{   // class is just a  container for all the code to be executed
    class Program
    {
        static void Main(string[] args)
            // Main is a method or a function which is another container for code 
        {





        }
    }
}
