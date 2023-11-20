 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg1 = "Hi";
            string msg2 = "How are you?";
            Console.WriteLine(msg1);
            Console.WriteLine(msg2);
            Console.WriteLine(msg1.Length);                             //Displays the length of the string....
            Console.WriteLine(msg2.Length);
            Console.WriteLine(msg1.ToUpper());                          //Converts all the characters into UPPERCASE....
            Console.WriteLine(msg2.ToLower());                          //Converts all the characters into lowercase....
            Console.WriteLine("==============================String Concatenation==============================");
            string msg3=msg1 + msg2;                                    //Concatenation Method--1
            Console.WriteLine(msg3);
            string msg4 = string.Concat(msg1, msg2);                    //Concatenation Method--2
            Console.WriteLine(msg4);
            Console.WriteLine("============================String Interpolation ($)============================");
            string firstName = "Durga Prasad";
            string lastName = "Malthumkar";
            Console.WriteLine($"My fullName is {firstName} {lastName}");
            Console.WriteLine("==============================Accessing Strings================================");
            string myName = "Durga Prasad";
            Console.WriteLine(myName[8]);                               //Access the string using index position....
            Console.WriteLine(myName.IndexOf("P"));                     //Access the index postion using character in the string....
            Console.WriteLine("====================================Substring==================================");
            string name = "Durga Prasad";
            int charpos=name.IndexOf("P");
            //int charpos=name.IndexOf("r");
            //int charpos=name.LastIndexOf("r");
            string Name =name.Substring(charpos);
            Console.WriteLine(Name);
            Console.WriteLine(name.Contains("D"));                      //Checks whether the given character is present or not....
            Console.WriteLine(name.Contains("v"));
            Console.WriteLine(name.Replace("Durga", "Malthumkar"));     //Replaces the old string with the given new string....
            string names = "Prasad,Vinishka,Viraaj";                    //Splitting the given string based on delimeter....
            string[] namesArray=names.Split(',');
            foreach (string NAME in namesArray)
            {
                Console.WriteLine(NAME);
            }
            string greet = "Good Morning";                              //Converting the string into Character Array....
            char[] charArray=greet.ToCharArray();
            foreach(char CHAR in charArray)
            {
                Console.WriteLine(CHAR);
            }
            /*The below is the list of most used String methods:

            1.Concatenation:
                •	+ operator
                •	String.Concat()
                •	String.Join()
            2.Interpolation:
                •	String interpolation: $"Hello {name}"
            3.Length:
                •	String.Length
            4.Substring:
                •	String.Substring(startIndex, length)
                •	String.Substring(startIndex)
            5.ToUpper and ToLower:
                •	String.ToUpper()
                •	String.ToLower()

            6.Trim:
                •	String.Trim()
                •	String.TrimStart()
                •	String.TrimEnd()
            7.StartsWith and EndsWith:
                •	String.StartsWith()
                •	String.EndsWith()
            8.Contains:
                •	String.Contains()
            9.IndexOf and LastIndexOf:
                •	String.IndexOf()
                •	String.LastIndexOf()
            10.Replace:
                •	String.Replace()
            11.IsNullOrEmpty and IsNullOrWhiteSpace:
                •	String.IsNullOrEmpty()
                •	String.IsNullOrWhiteSpace()
            12.PadLeft and PadRight:
                •	String.PadLeft()
                •	String.PadRight()
            13.Remove:
                •	String.Remove()
            14.Insert:
                •	String.Insert()
            15.Compare:
                •	String.Compare()
                •	String.CompareOrdinal()

            16.ToCharArray:
                •	String.ToCharArray()
            17.ToCharArray:
                •	String.ToCharArray()
            18.Join:
                •	String.Join()
            19.Format:
                •	String.Format()
            20.Copy:
                •	String.Copy()
            21.GetEnumerator:
                •	String.GetEnumerator()
            22.ToCharArray:
                •	String.ToCharArray()*/
            Console.ReadKey(); 
        }
    }
}
