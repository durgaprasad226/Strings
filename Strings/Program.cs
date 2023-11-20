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
            Console.WriteLine(msg2.Trim());                             //Removes excess white spaces....
            Console.WriteLine(msg1.Equals(msg2));                       //Checks whether two strings are same or not....
            Console.WriteLine("==========================String Clone==========================");
            string text1 = "Hello";
            string text2=(string)text1.Clone();                         //Cloning string of one variable into another variable....
            Console.WriteLine($"My text1 is {text1} and my text2 is {text2}");
            Console.WriteLine("==========================Copy==========================");
            string text3 = "Byeeee";
            string text4=string.Copy(text3);                            //Copying string of one variable into another variable....
            Console.WriteLine($"My text3 is {text3} and text4 is {text4}");
            Console.WriteLine("==============================String Concatenation==============================");
            string msg3=msg1 + msg2;                                    //Concatenation Method--1
            Console.WriteLine(msg3);
            string msg4 = string.Concat(msg1, msg2);                    //Concatenation Method--2
            Console.WriteLine(msg4);
            Console.WriteLine("============================String Interpolation ($)============================");
            string firstName = "Durga Prasad";
            string lastName = "Malthumkar";
            Console.WriteLine($"My fullName is {firstName} {lastName}");
            Console.WriteLine("==============================CompareOrdinal()==============================");
            string s1 = "zebra";   
            string s2 = "jello";                                        //compares two specified String objects by evaluating the 
            string s3 = "hello";                                        //numeric values of corresponding Char objects in each string
            string s4 = "apple";
            Console.WriteLine(string.CompareOrdinal(s1,s2));
            Console.WriteLine(string.CompareOrdinal(s1,s3));
            Console.WriteLine(string.CompareOrdinal(s1,s4));
            Console.WriteLine("================================EndsWith================================");
            string n1 = "Prasad";
            string n2 = "sad";
            string n3 = "hii";
            Console.WriteLine(n1.EndsWith(n2));                         //It is used to check that the end of this string instance 
            Console.WriteLine(n1.EndsWith(n3));                         //matches the specified string.
            Console.WriteLine("=================================GetHashCode================================");
            string ghc = "Hello";
            string ghc1 = "Who is this?";
            string ghc2 = "This is Durga Prasad";
            Console.WriteLine(ghc.GetHashCode());                       //GetHashCode() method is used to get hash code of this string. 
            Console.WriteLine(ghc1.GetHashCode());                      //It returns an integer value.
            Console.WriteLine(ghc2.GetHashCode());
            Console.WriteLine("==============================IsNullOrEmpty===============================");
            string ine = "Hi";
            string ine1 = "";
            string ine2 = " ";
            Console.WriteLine(string.IsNullOrEmpty(ine));               //IsNullOrEmpty() checks whether the string is null or an Empty string. 
            Console.WriteLine(string.IsNullOrEmpty(ine1));              //It returns a boolean value either true or false.
            Console.WriteLine(string.IsNullOrWhiteSpace(ine2));         //Checks for the white spaces
            Console.WriteLine("================================Insert==================================");
            string i1 = "Hello DP";                                     //The C# Insert() method is used to insert the specified string 
            string i2 = i1.Insert(5, "_");                              //at specified index number
            Console.WriteLine($"Before insert {i1} after insert {i2}");
            Console.WriteLine("==============================Accessing Strings================================");
            string myName = "Durga Prasad";
            Console.WriteLine(myName[8]);                               //Access the string using index position....
            Console.WriteLine(myName.IndexOf("P"));                     //Access the index postion using character in the string....
            Console.WriteLine("====================================Substring==================================");
            string name = "Durga Prasad";
            int charpos=name.IndexOf("P");
            //int charpos=name.IndexOf("r");                            //Shows the index of first "r"....
            //int charpos=name.LastIndexOf("r");                        //Shows the index of last occured "r"....
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
