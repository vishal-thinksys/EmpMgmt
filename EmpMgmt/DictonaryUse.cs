using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt
{
    public class DictonaryUse
    {
        public void CountRepeatedChar(string text)
        {
            //string text = "banana";
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (!dict.ContainsKey(text[i]))
                {
                    int n = 1;
                    for (int j = i + 1; j < text.Length; j++)
                    {
                        if (text[i] == text[j])
                        {
                            if (!dict.ContainsKey(text[i]))
                            {
                                dict.Add(text[i], ++n);
                            }
                            else
                            {

                                dict[text[i]]=++dict[text[i]];
                            }   
                        }
                    }
                }
            }
            foreach (KeyValuePair<char, int> item in dict)
            {
                Console.WriteLine($"Count of {item.Key} is {item.Value}.");
            }
        }
    }
}
