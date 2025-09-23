using tyuiu.cources.programming.interfaces.Sprint1;
using System.Collections.Generic;
namespace Tyuiu.KuchukIA.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            string[] words = value.Split(new char[] { ' ' });
            List<string> foundWords = new List<string>();
            foreach (string word in words)
            { 

                if (word.Contains("нн"))
                {
                    foundWords.Add(word);
                }
                
            }
            
            return string.Join(" ", foundWords);


            
        }
        
    }
}
