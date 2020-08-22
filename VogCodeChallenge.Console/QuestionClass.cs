using System;
using System.Collections.Generic;
using System.Text;

namespace VogCodeChallenge.ConsoleApp
{
    public static class QuestionClass
    {
        static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "jeffrey"
        };

        public static void TestQuestion()
        {
            foreach (var name in NamesList)
            {
                Console.WriteLine(name);
            }
        }
    }

}
