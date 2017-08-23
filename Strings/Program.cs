using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Colleen";
            //string lastName = "Pearson";
            ////string fullName = firstName + " " + lastName; //1st way to concatenate
            //string fullName = string.Concat(firstName, " ", lastName); //2nd way to concatenate

            //Console.WriteLine(firstName.Length); // this tells how many in firstName
            //Console.WriteLine(lastName.Length);  // this tells how many in lastName
            //Console.WriteLine(firstName[0]);  // this will show C in Colleen
            //Console.WriteLine(firstName[firstName.Length-1]); //if you didn't put -1 it would give error, 
            //Console.WriteLine(lastName[lastName.Length-1]);
            /*Console.WriteLine(fullName);*/ //prints full name
                                             //Console.WriteLine(firstName.Equals(lastName)); //output is: false
                                             //Console.WriteLine(firstName == lastName); //output is: false

            //Console.WriteLine("My favorite book is The \"The Notebook\""); //need to put \ in order to put quotes in the string
            /*Console.WriteLine("My favorite book is The \n \"The Notebook\""); *///use \n to put on the next line

            //STRING METHODS

            //ToUpper: method to convert to UpperCase
            //ToLower: method to convert to LowerCase
            //string firstName = "Colleen";
            //string lastName = "Pearson";
            //Console.WriteLine(firstName.ToUpper()); //COLLEEN
            //Console.WriteLine(lastName.ToLower());  //pearson

            //Ians:
            //string working = "EmpLOYEE";
            //string driving = "cAr";

            //Console.WriteLine(working.ToUpper());
            //Console.WriteLine(driving.ToLower());

            //SubString - dropping the one in the string
            //string example ="oneTwoThree";
            ////substring takes a start, index 0 and a length, 6 indexes long
            //string sub = example.Substring(3, 8);
            //Console.WriteLine(sub);

            //removed all characters after an idex.
            //string index = "Fothergill";

            ////start removing at index 6
            //string result = index.Remove(6);

            //Console.WriteLine(result);

            ////indexof and lastindexof examples (index of finds first occurance)
            //Console.WriteLine(fullName.IndexOf("i"));
            //Console.WriteLine(fullName.LastIndexOf("r"));

            ////trim - removes extra white space
            //string yell ="      \n\n\n    Gabrielle!!!!      ";
            //Console.WriteLine(yell);

            //string yellReduced = yell.Trim();
            //Console.WriteLine(yellReduced);

            //int numX = 3;
            //int numY = 4;
            //int numZ = 5;

            //Console.WriteLine();

            //Replace: replaces text in string

            //1st Replace example
            //string myStr = "We Can Code IT";
            //string result = myStr.Replace("We", "I");
            //Console.WriteLine(result);

            //2nd Replace example
            //string phrase = "I LOVE it";
            //string change = phrase.Replace("LOVE", "like");
            //Console.WriteLine(change);

            //Length Property
            //#1 Find the length of your first name and print it.
            string firstName = "Colleen";
            Console.WriteLine("My name, Colleen has this many letters:" + " " + firstName.Length);

            //#2Find the length of your last name and print it.
            string lastName = "Pearson";
            Console.WriteLine("My last name, Pearson has this many letters:" + " " + lastName.Length);

            //#3 If the first name is longer than the last name, print "First is longer."
            //If the first name and last name are the same length, print "Samsis!"
            //Otherwise, print "last must be longer!"

            if (firstName.Length == lastName.Length)
            {
                Console.WriteLine("Samsis!");
            }

            else if (firstName.Length >= lastName.Length)
            {
                Console.WriteLine("First is longer");
            }

            else
            {
                Console.WriteLine("last must be longer");
            }

            //#4 EXTENSION: Get user input for the first and last name instead of hardcoding, such as string fName = "Mary";
            Console.WriteLine("Please enter your first name");
            string fName = (Console.ReadLine());

            Console.WriteLine("Please enter your last name");
            string lName = (Console.ReadLine());

            if (fName.Length == lName.Length)
            {
                Console.WriteLine("Samsis!");
            }

            else if (fName.Length >= lName.Length)
            {
                Console.WriteLine("First is longer");
            }

            else
            {
                Console.WriteLine("last must be longer");
            }

            //Escaping Special Characters







        }
    }
}
