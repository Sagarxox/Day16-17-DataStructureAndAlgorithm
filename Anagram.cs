﻿namespace Day16_17_DSA
{
    internal class Anagram

    {



        public static void Main(string[] args)
        {
            string str1 = "heart";
            string str2 = "earth";  //hater
                                  
            
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string s1 = new string(ch1);
            string s2 = new string(ch2);

            if (s1 == s2)
            {
                Console.WriteLine("it is Anagram");

            }
            else
            {
                Console.WriteLine("Not Anagram");
            }
        }


    }
}




