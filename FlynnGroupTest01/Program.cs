using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlynnGroupTest01
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution ss = new Solution();
            Console.WriteLine("00-44  48 5555 8361");
            Console.WriteLine(ss.solution("00-44  48 5555 8361"));
            Console.ReadKey();

            
            Console.WriteLine("SMS messages are really short");
            Console.WriteLine(ss.solution2("SMS messages are really short", 12).ToString());
            Console.ReadKey();
        }

        
        class Solution
        {
            public int solution2(string S, int K)
            {
                // write your code in C# 6.0 with .NET 4.5 (Mono)
                if(S==null || K==0)
                {
                    return 0;
                }
                S = S.TrimStart();
                S = S.TrimEnd();
                S = S.Trim();
                string[] str = S.Split(' ');
                int SMScounter = 1;
                string st = "";
                foreach (var v in str)
                {
                    st += v;
                    st += " ";
                    if (st.Length <= K)
                    {

                    }
                    else
                    {
                        SMScounter++;
                        st = "";
                    }

                }

                return SMScounter;
            }
            public string solution(string S)
            {
                // write your code in C# 6.0 with .NET 4.5 (Mono)
                if(S==null)
                {
                    return "";
                }
                if(S=="")
                {
                    return "";
                }
                List<string> strResult = new List<string>();
                S = S.Replace(" ", "");
                S = S.Replace("-", "");
                
                int n, counter=0, indexStr=0;
                foreach(var v in S)
                {                    
                    bool isNumeric = int.TryParse(v.ToString(), out n);
                    if(isNumeric)
                    {             
                        if(counter==3)
                        {
                            strResult.Add("-");
                            indexStr++;
                            strResult.Add(n.ToString());
                            counter = 0;
                           
                        }
                        else
                        {
                            //Test
                            strResult.Add(n.ToString());
                        }
                        counter++;
                    }
                    indexStr++;
                }
                string[] strArray = strResult.ToArray();
                if (strArray[(strArray.Length-1)]=="-")
                {
                    strArray[(strArray.Length - 1)] = "";
                }
                if(strArray[strArray.Length-2]=="-")
                {
                    strArray[strArray.Length - 2] = strArray[strArray.Length - 3];
                    strArray[strArray.Length - 3] = "-";
                }
                return string.Join("", strArray);
            }
        }
    }

}
