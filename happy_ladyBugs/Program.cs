using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happy_ladyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(happyLadybugs("AABCBC"));
            Console.ReadLine();


        }

        private static string happyLadybugs(string b)
        {
            bool flag = false;
            char[] arr = b.ToCharArray();

            Dictionary<char, int> hash = new Dictionary<char, int>();

            foreach (char ch in arr)
            {
                if(hash.ContainsKey(ch))
                {
                    int num = hash[ch];
                    num += 1;
                    hash[ch] = num;
                }
                else
                {
                    if(ch!='_')
                    hash.Add(ch, 1);
                }

            }

            foreach(KeyValuePair<char,int> pair in hash)
            {
                if(pair.Value==1)
                {
                    return "NO";
                }
            }


            if (b.Contains("_"))
            {
                return "YES";
            }


            flag = false;
            for (int i=1;i<arr.Length-1;i++)
            {
                if(!(arr[i-1]==arr[i]||arr[i+1]==arr[i]))
                {
                    flag = true;
                    break;
                }
            }
            if(flag==true)
            {
                return "NO";
            }
            else
            {
                return "YES";
            }

            
            


            
        }
    }
}
