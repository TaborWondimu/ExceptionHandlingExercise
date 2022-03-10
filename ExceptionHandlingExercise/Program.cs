using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // DONE First create an char[], it must contain 6 numbers and 3 letters - name it arr
              var arr = new char[] { '1', '2', '3', '4', '5', '6', 'c', 'a', 'd' };
            // DONE Create a list called numbers that will hold integers
              var numbers = new List<int>();
            // DONE Create an string variable with an empty string initializer - name it str
              string str =  null;
            // DONE using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            /*  foreach(var ch in arr)
              {
                  var result = int.Parse(arr);
                  Console.WriteLine(ch);
              }
              // and Exceptions will be thrown 
              // Below we will set this up 
              // ------------------------------------------------------------------------------
            */


            //TODO START HERE:

            // DONE Make a foreach loop to iterate through your character array
            foreach (var ch in arr)
            {
                // Now create a try catch
                try
                {
                    str = ch.ToString();
                    int eachInt = int.Parse(str);
                    numbers.Add(eachInt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unable to Parse '{ch}'"); //character will be the name of each item in your collection

                }
                
            }

            //DONE Inside your try block
            // DONE set your string variable to each array element in your char[] to .ToString()
            //DONE  Now, using int.Parse, parse your string variable and store in an int variable
            // Then add each int to your list

            // DONE  catch your Exception:
            // in the scope of your catch you can use the following, 

            //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection



            foreach (var num in numbers)
            {
                Console.WriteLine(num);
           }
        }
    }
}
