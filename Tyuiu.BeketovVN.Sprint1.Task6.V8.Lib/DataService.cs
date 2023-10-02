using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BeketovVN.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V6
    {
        public string DeleteFirstLetter(string value)
        {
            string[] words = value.Split(new char[] { ' ', '\t', '\n', '\r', '.' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder res = new StringBuilder();

            foreach (string word in words)
            {
                if (word.Length > 1)
                {
                    string modifiedWord = word.Substring(1) + word[0];
                    res.Append(modifiedWord + " ");
                }
                else
                {
                    res.Append(word + " ");
                }
            }

            return res.ToString().Trim(); ;
        }
    }
}
