using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NikolaevaAN.Sprint1.Task6.V0.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            string[] words = value.Split(new char[] { ' ' });
            List<string> res = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                char[] reverse = words[i].ToCharArray();
                Array.Reverse(reverse);
                string s = new string(reverse);
                if (words[i] == s)
                {
                    res.Add(words[i]);
                }
            }
            string strRes = string.Join(" ", res);
            return strRes;
        }
    }
}