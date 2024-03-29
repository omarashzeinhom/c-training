﻿// Will be discussed later in the course

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 */

// See https://aka.ms/new-console-template for more information


//  1. Draw a Shape
using Turtle;

Console.WriteLine("    /----    /");
Console.WriteLine("   /|   |   /");
Console.WriteLine("  / |   |  /");
Console.WriteLine(" /  |   | /");
Console.WriteLine("/___|___|/");



//  2. ADD VARIABLES and types untill 29:45
string name = "Andgoedu";
int age = 24;

Console.WriteLine("My name is " + name);
Console.WriteLine("I am " + age + "years old");
Console.WriteLine("And i like variables that are named after me");
Console.WriteLine("Which is " + name);

//  3. DATA TYPES AND STORING INTO VARS

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




//  5. Working With Numbers
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


//  6. GET USER INPUT 
Console.WriteLine("Get User Inputs >>>>>>>>>");
Console.Write("Kindly , Enter your name: ");
string userName = Console.ReadLine(); // Data stored into the name variable
Console.Write("Enter your age Please : ");
string userAge = Console.ReadLine();
Console.WriteLine("Hello " + userName + " your " + userAge + " years old !");

//12. If Statements 
bool isMale = true;
bool isTall = true;

if (isMale && isTall)
{
    Console.WriteLine("Gender is Male and Tall");
}
else if (isMale && !isTall)
{
    Console.WriteLine("Gender is Male But Not Tall");
}
else if (!isMale && isTall)
{
    Console.WriteLine("You are not a male but you are Tall");
}
else
{
    Console.WriteLine("Your either not a male nor tall");
};

//  7. Building a Calculator 

//int num = Convert.ToInt32("45"); // Converts string to integer // dont add any other charachters than numbers in between " " or it will not work will throw an error for format
//Console.WriteLine(num + 6);
Console.WriteLine("Calculator >>>>>>>>>");
Console.Write(" Enter: A Number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write(" Enter A 2nd Number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(num1 * num2);



//  8. Create A MadLib Game Untill 01:21:16 
//  Enter Random Words and Sprinkle them randomly into a story

string color, pluralNoun, celebrity;

Console.Write("Enter A Color : ");
color = Console.ReadLine();
Console.Write("Enter A plural Noun : ");
pluralNoun = Console.ReadLine();
Console.Write("Enter A celebrity name : ");
celebrity = Console.ReadLine();

Console.WriteLine("Roses are " + color);
Console.WriteLine("Violets are " + pluralNoun);
Console.Write("I love " + celebrity);


//  9. Arrays for large amounts of data 01:26:18

int[] luckyNumbers = {5, 7 , 7 ,12 , 16 , 28 };
luckyNumbers[1] = 500;

string[] friends = new string[10]; // friends array is going to hold 10 values
friends[0] = " John";
friends[1] = "Jane";

Console.WriteLine(luckyNumbers[0]);




//  10. Methods -  A little block of code that performs a specific task








static void Greet(string name, int age)
{
    Console.WriteLine("Hi There " + name + "You are " + age);
}









// 11. Return statements

// GETS THE CUBED VALUE 2 ^ 3 = 2 * 2 * 2 
static int cube (int num)

{
    int result = num * num * num;
    return result;

}



//12. If Statements 

if (isMale && isTall)
{
    Console.WriteLine("Gender is Male and Tall");
}
else if (isMale && !isTall)
{
    Console.WriteLine("Gender is Male But Not Tall");
}
else if (!isMale && isTall)
{
    Console.WriteLine("You are not a male but you are Tall");
}
else
{
    Console.WriteLine("Your either not a male nor tall");
};



//13. If statements Comparision 
// Max method which one is bigger
Console.WriteLine(">>>>>>GetMax Method");
static int GetMax(int num1, int num2, int num3)
{
    int result;
    if (num1 > num2) {
        result = num1;
    }
    else if (num2 >= num1 && num2 >= num3)
    {
        result = num2;
    }else
    {
        result = num3;
    }
   
    return result;
}


Console.WriteLine(GetMax(2, 10, 4));

//14 . Better Calculator
Console.Write(" Better Calculator ");


Console.Write("Enter a Number: ");
double numb1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Operator: ");
string oper = Console.ReadLine();


Console.Write("Enter a 2nd Number: ");
double numb2 = Convert.ToDouble(Console.ReadLine());

if (oper == "+")
{
    Console.WriteLine(numb1 + numb2);
}else if (oper == "-")
{
    Console.WriteLine(numb1 - numb2);
}else if (oper == "/")
{
    Console.WriteLine(numb1 / numb2);

}
else if (oper == "*") {
    Console.WriteLine(numb1 * numb2);

}
else
{
    Console.WriteLine("Error invalid Operator");
}



//  15. Switch Statements 
// Checking a bunch of different conditions easily
// Create method that will check the day of the week 



static string GetDay(int dayNumber)
{
    string dayName;

    switch (dayNumber)
    {
        case 0:
            dayName = "Sunday";
            break;
        case 1:
            dayName = "Monday";
            break;
        case 2:
            dayName = "Tuesday";
            break;
        case 3:
            dayName = "Wednesday";
            break;
        case 4:
            dayName = "Thursday";
            break;
        case 5:
            dayName = "Friday";
            break;
        case 6:
            dayName = "Saturday";
            break;
        default:

            dayName = "Invalid Day Number";
            break;
    }

    return dayName;
}

//DEBUG SWITCH STATEMENT
Console.WriteLine(GetDay(0));



// 16. While Loops
Console.WriteLine("<<<<<<<<<<<< while Loop >>>>>>>>>");
int index = 1;
while (index <= 5)
{
    Console.WriteLine(index);
    // Watch out for infinite loop  dont remove the incrementation or the condition will always be true and print 1 all the time
    index++; //adds 1 to the index increments the value

}

//  17. Guessing Game
Console.WriteLine("<<<<< Guessing Game >>>>>>");

string secretWord = "streetdog";

string guess = "";

string hint = "st***td*g";
// limiting the user to three gueses
int guessCount = 0;
int guessLimit = 3;
bool outOfGuesses = false;

while (guess != secretWord)
{
    if (guessCount < guessLimit)
    // if guessCount is less than guessLimit
    {
        Console.WriteLine(hint);
        Console.Write("Enter Guess: ");
        guess = Console.ReadLine();
        guessCount++;
    }else
    {
        outOfGuesses = true;
    }
 

}
if (outOfGuesses)
{
    Console.Write("You Lose !");

} else
{
    Console.WriteLine("You win !");

}


// 18  . For Loops

/** They Do the same thing 
 * int i = 1;
while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}
 */

/*
 for (int i = 1;  i <= 5; i++)
{
    Console.WriteLine(i);
    
};

for ( int i = 0; i <= luckyNumbers.Length; i++)
{
    Console.WriteLine(luckyNumbers[i]);
};

 */

//  19. Building an exponent method to get the power of a number 2 ^ 3 for example 2 x 2 x 2
//  03:05:00
static int GetPower(int primaryNumber, int powerNumber)
{
    int result = 1;

    for (int i = 0; i < powerNumber; i++)
    {
        result = result * primaryNumber;
    }


    return result;

}
Console.WriteLine(GetPower(3, 2));





//  20. 2D Arrays add more commas and it will be 3d array , 4d and so on

int[,] numberGrid = {

{1,2 },
{3,4 },
{5,6 },

};
Console.WriteLine(numberGrid[1, 1]);


//  21. Comments

//

/**/



//  22. Exception Handling with try and catch blocks
try
{
    Console.Write("Enter a number:");
    int numbe1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter 2nd Number: ");
    int numbe2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(numbe1 / numbe2);
}
catch( DivideByZeroException e)
{
    // catch error and write it
    Console.WriteLine(e.Message);
}catch(FormatException e)
{
    Console.WriteLine(e.Message);
}

//  23. Classes & Objects
// Right click a program
// Add new and select class

//Program cannot divide by 0 
Console.ReadLine();

//  23.  an instance of a book object
//  23.  the class just specifies the object to be used
//  24. Constructor Method 

// Constructors are used here instead of Object in the following example
Book book1 = new Book("Harry Potter", "J.K Rowling", 400);

Book book2 = new Book("The Power of your subconsicuess mind", "Jospeh . E . Murphy", 200);

Book book3 = new Book("Example 3", "Author 3", 200);

/*

  Book book2 = new Book("Joseph");
  book2.title = "The Power of your subconsicuess mind";
  book2.author = "Jospeh . E . Murphy";
  book2.pages = 350;
*/


Console.WriteLine(book1.pages);
Console.WriteLine(book2.author);

// STUDENT EXAMPLE 
//  25. Object Methods

Student student1 = new Student("John Doe", "Arts", 2.7);

Student student2 = new Student("Jane Doe", "Business", 3.8);

Console.WriteLine(student1.hasHonors());
Console.WriteLine(student2.hasHonors());




namespace Turtle
{   // class is just a  container for all the code to be executed
    class Program
    {
   

        static void Main(string[] args)
        // Main is a method or a function which is another container for code 
        {
          

            Console.ReadLine();            // Makes Console stay open to ReadLine


        }
     

    }

}

