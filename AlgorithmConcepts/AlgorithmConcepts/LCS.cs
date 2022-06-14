using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmConcepts
{
    public class LCS_Class
    {

        public void findeAllSubsequencesOfString(List<string> sublist, string input,
                                     string output)
        {

            // Base Case
            // If the input is empty print the output string
            if (input.Length == 0)
            {
                sublist.Add(output);
                //Console.WriteLine(output);
                return;
            }

            // Output is passed with including
            // the Ist character of
            // Input string
            findeAllSubsequencesOfString(sublist, input.Substring(1),
                             output + input[0]);

            // Output is passed without
            // including the Ist character
            // of Input string
            findeAllSubsequencesOfString(sublist, input.Substring(1),
                             output);
        }


        public void LCS()
        {
            
            string output = string.Empty;
            string subsequence = string.Empty;
            List<string> SubsequenceList = new List<string>();
            string[,] array = new string[,] {
            { "abcde", "ace" },//"ace"
            { "lmnopq", "xyz"},//""
            { "peacock", "penguin"},//"pe"
            { "ttybace", "bclknm" },//"bc"
            { "canada", "vancouver"},//"an"
            { "book", "table" },//"b"
            { "spptap", "pxtxsap"},//"ptap"
            { "common", "communicate" },//"commn"
            { "xyzxyz", "axbyyzz"},//"xyyz"
            { "yellow", "melon" },//"elo"
            { "csstxbst", "astsbksty"},//"stbst"
            { "example", "analyze" }
            };
            int length = array.Length / 2;
            if (array.Length % 2 != 0)
            {
                length = length + 1;
            }
            for (int i = 0; i < length; i++)
            {
                List<string> subsequensesOfFirstString = new List<string>();
                findeAllSubsequencesOfString(subsequensesOfFirstString, array[i, 0], output);

                output = string.Empty;

                List<string> subsequensesOfSecondString = new List<string>();
                findeAllSubsequencesOfString(subsequensesOfSecondString, array[i, 1], output);


                foreach (string firstSubsequenceList in subsequensesOfFirstString)
                {
                    foreach (string secondSubsequenceList in subsequensesOfSecondString)
                    {
                        if (firstSubsequenceList == secondSubsequenceList)
                        {
                            if (subsequence.Length < firstSubsequenceList.Length)
                                subsequence = firstSubsequenceList;
                        }
                    }

                }

                SubsequenceList.Add(subsequence);

                subsequence = string.Empty;

            }

            var counter = 1;

            foreach (var subs in SubsequenceList)
            {
                subsequence = subsequence + counter.ToString() + ".LCS: " + subs + "         Length : " + subs.Length + "\n";


                counter++;
            }
            Console.WriteLine(subsequence);
            Console.WriteLine();

        }


    }
}
