using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmConcepts
{
    class Model
    {
        public Model()
        {

        }

        public List<string> innerList { get; set; }
    }

class LCP_Devide_And_Conquer
	{
		// A Utility Function to find
		// the common prefix between
		// strings- str1 and str2
		static string commonPrefixUtil(string str1,
									string str2)
		{
			string result = "";
			int n1 = str1.Length,
				n2 = str2.Length;

			for (int i = 0, j = 0;
					i <= n1 - 1 && j <= n2 - 1;
					i++, j++)
			{
				if (str1[i] != str2[j])
					break;
				result += str1[i];
			}
			return (result);
		}

		// A Divide and Conquer based
		// function to find the longest
		// common prefix. This is similar
		// to the merge sort technique
		static string commonPrefix(string[] arr,
								int low, int high)
		{
			if (low == high)
				return (arr[low]);

			if (high > low)
			{
				// Same as (low + high)/2,
				// but avoids overflow for
				// large low and high
				int mid = low + (high - low) / 2;

				string str1 = commonPrefix(arr, low, mid);
				string str2 = commonPrefix(arr, mid + 1, high);

				return (commonPrefixUtil(str1, str2));
			}
			return null;
		}

		// Driver Code
		public void LCP()
		{
			List<Model> myArray = new List<Model>()
		   { 
				new Model(){ innerList =
				new List<string>(){
				 "bbwedhb", "bbwkhghtghjkg", "bbwoouytt", "bbwhyygfdfhhj", "bbwhtajsh", "bbwkjuy", "bbwwwet", "bbwssa", "bbwqqq", "bbwooppoui",
				"bbwggat", "bbwjjhhtt", "bbwwww", "bbwbbbbb", "bbwbwbwbwbw", "bbwoiuyt", "bbwfdsdg", "bbww", "bbwwt", "bbwwo" },
				} ,//"bbw"

				new Model()
				{
					innerList =  new List<string>()
			  { "abbaatt", "abbassgty", "abbapjirdgh", "abbatyyurew", "abbaaaaa", "abbaaaabbaaa", "abbaooiyt", "abba", "abbatyyrere", "abbahhtrdgj",
				"abbattyytre", "abbannmn", "abbababa", "abbatytre", "abbaaaaajjtt", "abbawqe", "abbayuutr", "abbaoiur", "abbammmnnn", "abbayuytesv" },
              //"abba"
			  },

			  new Model()
				{
					innerList =  new List<string>()
			  { "peacock", "penguin", "pet", "pen", "penny", "pencil", "per", "peach", "perk", "peak",
				  "peek", "peer", "pest", "pens", "peon", "pets", "pear", "pearl", "peppy", "petal" }
			 }, //"pe"

              new Model()
				{
					innerList =  new List<string>()
			  { "zoozooooo", "zooozoo", "zooo", "zoooooo", "zoozozo", "zoozo", "zoozzz", "zoozozozz", "zooozzz", "zoozzoo",
				"zoozzzzoooo", "zoozozozozoz", "zoozooooozzzzz", "zooooz", "zoozzzzz", "zoo", "zoozzzoozz", "zoooozzozozoz", "zoozz", "zooooz" }
			 }, //"zoo"

              new Model()
				{
					innerList =  new List<string>()
			  { "bat", "ball", "banana", "basket", "bag", "balloon", "bad", "bald", "bar", "band",
				"bend", "bash", "bake", "baby", "back", "brain", "basic", "bath", "basis", "balm" },
			  },//"b"
             new Model()
				{
					innerList =  new List<string>()
			  {"nanann", "nanana", "nanaaa", "nanannn", "nanaan", "nanaann", "nanannaa", "nananan", "nanaaaannnn", "nananaannnaa",
				"nanaaannaaaa", "nananananana", "nanannnnnnn", "nana", "nanan", "nanaa", "nanaaannaan", "nanannnaaaa", "nanaan", "nanaaaannnnn"},
			  },//"nana"
              new Model()
				{
					innerList =  new List<string>()
			  { "xyzzz", "xyzxx", "xyzxyz", "xyzyy", "xyzxyzxyz", "xyzxxyy", "xyzxxyyzzy", "xyzzzyyxx", "xyzyyxxzzzz", "xyzyyxxzzzz",
				"xyzyyzzxxxxz", "xyzyxzzxy", "xyzxxyyxy", "xyzzzyyzy", "xyzxxzzxz", "xyzxxyyzzxyz", "xyzxxyyzzzz", "xyzyyxxzzyxz", "xyzyzxxyz", "xyz"},
			  },//"xyz"
              new Model()
				{
					innerList =  new List<string>()
			  { "aaaa", "aaaaaa", "aaaaaaa", "aaaaaaaaaa", "aaaaa", "aa", "aaa", "a", "aaaaaaaaaa", "aaaaaaaaaaaaaa",
				"aaaaaaaaaaaaaaaa", "aaaaaaaa", "aaaaaaaaa", "aaaaaaaaaaaa", "aaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaaaaaaaa", "aaaaaaaaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaaaaaaaaaaa" },
			 }, //"a"
              new Model()
				{
					innerList =  new List<string>()
			  { "lmno", "lhhtri", "llmmnn", "ltuiriityh", "lmntyuu", "lmhutf", "mno", "lhtrech", "lllll", "llmmnn",
				"llmmnnooo", "lll", "lmnopq", "lmopiutc", "l", "lmngtdff", "lwef", "leak", "loutfhh", "lqdf"},
			  },//""
              new Model()
				{
					innerList =  new List<string>()
			  { "apple", "app", "apply", "appear", "appoint", "approve", "apps", "apparel", "append", "appeal",
			  "appose", "approach", "application", "appointed", "appraise", "approved", "appreciate", "approval", "appendix", "applaud" }
			   //"app"
                }


		   };

			int n = 0;
			string prefix = string.Empty;
			List<string> prefixList = new List<string>();
			int counter = 0;
            foreach (var item in myArray)
            {
				n = item.innerList.Count();
				string ans = commonPrefix(item.innerList.ToArray(), 0, n - 1);
				//if (ans.Length != 0)
				//{
					prefixList.Add(counter.ToString() + ".LCP: " + ans + "\n");
					counter++;
				//}
			}

			foreach (var item in prefixList)
			{

				prefix = prefix + item;
			}

			Console.WriteLine(prefix);


		}
	}

	// This code is contributed by 29AjayKumar

}
