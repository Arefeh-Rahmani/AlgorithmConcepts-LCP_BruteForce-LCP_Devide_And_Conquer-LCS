using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmConcepts
{
    public class LCP_BruteForce
    {
        public void LCP()
        {

            string[] p = new string[] { "", "" };
            string[,] myArray = new string[,]
            {
              { "bbwedhb", "bbwkhghtghjkg", "bbwoouytt", "bbwhyygfdfhhj", "bbwhtajsh", "bbwkjuy", "bbwwwet", "bbwssa", "bbwqqq", "bbwooppoui",
                "bbwggat", "bbwjjhhtt", "bbwwww", "bbwbbbbb", "bbwbwbwbwbw", "bbwoiuyt", "bbwfdsdg", "bbww", "bbwwt", "bbwwo" },
              //"bbw"

              { "abbaatt", "abbassgty", "abbapjirdgh", "abbatyyurew", "abbaaaaa", "abbaaaabbaaa", "abbaooiyt", "abba", "abbatyyrere", "abbahhtrdgj",
                "abbattyytre", "abbannmn", "abbababa", "abbatytre", "abbaaaaajjtt", "abbawqe", "abbayuutr", "abbaoiur", "abbammmnnn", "abbayuytesv" },
              //"abba"

              { "peacock", "penguin", "pet", "pen", "penny", "pencil", "per", "peach", "perk", "peak",
                  "peek", "peer", "pest", "pens", "peon", "pets", "pear", "pearl", "peppy", "petal" },
              //"pe"

              { "zoozooooo", "zooozoo", "zooo", "zoooooo", "zoozozo", "zoozo", "zoozzz", "zoozozozz", "zooozzz", "zoozzoo",
                "zoozzzzoooo", "zoozozozozoz", "zoozooooozzzzz", "zooooz", "zoozzzzz", "zoo", "zoozzzoozz", "zoooozzozozoz", "zoozz", "zooooz" },
              //"zoo"

              { "bat", "ball", "banana", "basket", "bag", "balloon", "bad", "bald", "bar", "band",
                "bend", "bash", "bake", "baby", "back", "brain", "basic", "bath", "basis", "balm" },
              //"b"
              { "nanann", "nanana", "nanaaa", "nanannn", "nanaan", "nanaann", "nanannaa", "nananan", "nanaaaannnn", "nananaannnaa",
                "nanaaannaaaa", "nananananana", "nanannnnnnn", "nana", "nanan", "nanaa", "nanaaannaan", "nanannnaaaa", "nanaan", "nanaaaannnnn"},
              //"nana"
              { "xyzzz", "xyzxx", "xyzxyz", "xyzyy", "xyzxyzxyz", "xyzxxyy", "xyzxxyyzzy", "xyzzzyyxx", "xyzyyxxzzzz", "xyzyyxxzzzz",
                "xyzyyzzxxxxz", "xyzyxzzxy", "xyzxxyyxy", "xyzzzyyzy", "xyzxxzzxz", "xyzxxyyzzxyz", "xyzxxyyzzzz", "xyzyyxxzzyxz", "xyzyzxxyz", "xyz"},
              //"xyz"
              { "aaaa", "aaaaaa", "aaaaaaa", "aaaaaaaaaa", "aaaaa", "aa", "aaa", "a", "aaaaaaaaaa", "aaaaaaaaaaaaaa",
                "aaaaaaaaaaaaaaaa", "aaaaaaaa", "aaaaaaaaa", "aaaaaaaaaaaa", "aaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaaaaaaaa", "aaaaaaaaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaaaaaaaaaaa" },
              //"a"
              { "lmno", "lhhtri", "llmmnn", "ltuiriityh", "lmntyuu", "lmhutf", "mno", "lhtrech", "lllll", "llmmnn",
                "llmmnnooo", "lll", "lmnopq", "lmopiutc", "l", "lmngtdff", "lwef", "leak", "loutfhh", "lqdf"},
              //""s
              { "apple", "app", "apply", "appear", "appoint", "approve", "apps", "apparel", "append", "appeal",
              "appose", "approach", "application", "appointed", "appraise", "approved", "appreciate", "approval", "appendix", "applaud" }
              //"app"
            };


            int length = 0;
            int stringLength = 0;
            int minLength = 0;
            string Prefix = string.Empty;
            string prefix = string.Empty;
            string prefixComplete = string.Empty;
            List<string> prefixList = new List<string>();
           
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                length = myArray.GetLength(1); 
                for (int j = 0; j < length; j++)
                {
                    stringLength = myArray[i, j].Length;
                    if (minLength != 0 && minLength > stringLength )
                        minLength = stringLength;
                    else if(minLength == 0)
                        minLength = stringLength;
                }

                
                for (int k = 0; k < minLength; k++)
                {
                    prefix = myArray[i, 0][k].ToString();
                    for (int m = 0; m < length; m++)
                    {
                        if (prefix == myArray[i, m][k].ToString())
                        {
                           // prefix = prefix + myArray[i, k][m].ToString();
                        }
                        else
                        {
                            prefix = "";
                            break;
                        }
                    }
                    if (!string.IsNullOrEmpty(prefix) )
                    {
                        prefixComplete = prefixComplete + prefix;
                    }
                }

                prefixList.Add(i.ToString() + ".LCP: " + prefixComplete + "\n");
                prefixComplete = string.Empty;
            }
            prefix = string.Empty;

            foreach (var item in prefixList)
            {

                prefix = prefix + item ;
            }

            Console.WriteLine(prefix);
        }

    }
}
