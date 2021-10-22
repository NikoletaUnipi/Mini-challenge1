using System;
using System.Text.RegularExpressions;
/***
The goal of this exercise is to convert a string to a new string where each
character in the new string is "(" if that character appears only once in the original string,
or ")" if that character appears more than once in the original string. Ignore capitalization 
when determining if a character is a duplicate.

Examples
"din"      =>  "((("
"recede"   =>  "()()()"
"Success"  =>  ")())())"
"(( @"     =>  "))((" 
 ***/
namespace codewars1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "din";
            string word1 = "recede";
            string word2 = "Success";
            string word3 ="eee127456e";//)))(((((()
                                       //)))(()((()
            Console.WriteLine(DuplicateEncode(word));
            Console.WriteLine(DuplicateEncode(word1));
            Console.WriteLine(DuplicateEncode(word2));
            Console.WriteLine(DuplicateEncode(word3));


        }

       // public class Kata
       // {
            public static string DuplicateEncode(string word)
            {
                    word=word.ToUpper();
                    string newWord = "";
               for(int i =0;i<word.Length;i++) {
                   
                    char temp = word[i];
                    //Console.WriteLine(temp.ToString());
                    string word2="";
                     int counter = 0;
                    bool notfound = true;
                    while (notfound) {
                        if (word[counter] == temp) {
                        
                           notfound = false;
                            for (int j = 0; j <word.Length; j++) {
                                if (j != counter)
                                {
                                    word2 += word[j].ToString();
                                }
                            }
                        }
                        counter++;
                    }

                   Console.WriteLine(word2);
                    if (word2.Contains(temp))
                    {
                        newWord += ")";

                    }
                    else {
                        newWord += "(";
                    }

                }
                return newWord;
            }

        //}
    }
}

