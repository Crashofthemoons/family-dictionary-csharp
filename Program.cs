using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {

        static void Main(string[] args)
        {
        Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
                {"name", "Jackie"},
                {"age", "30"}
            });

            myFamily.Add("sisterSister", new Dictionary<string, string>(){
                {"name", "Hayley"},
                {"age", "27"}
            });

            myFamily.Add("brother", new Dictionary<string, string>(){
                {"name", "Tim"},
                {"age", "22"}
            });

            myFamily.Add("father", new Dictionary<string, string>(){
                {"name", "Seth"},
                {"age", "59"}
            });

            myFamily.Add("mother", new Dictionary<string, string>(){
                {"name", "Ruth"},
                {"age", "57"}
            });

            foreach (var familyMember in myFamily)
            {
                Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old");
            }
        }
    }
}
