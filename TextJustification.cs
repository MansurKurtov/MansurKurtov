using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCodeSulutions
{
    /// <summary>
    /// Given an array of words and a width maxWidth, format the text such that each line 
    /// has exactly maxWidth characters and is fully (left and right) justified.
    /// You should pack your words in a greedy approach; that is, pack as many words 
    /// as you can in each line. Pad extra spaces ' ' when necessary 
    /// so that each line has exactly maxWidth characters.
    /// Extra spaces between words should be distributed as evenly as possible. 
    /// If the number of spaces on a line do not divide evenly between words, 
    /// the empty slots on the left will be assigned more spaces than the slots on the right.
    /// For the last line of text, it should be left justified and no extra space is inserted between words.
    /// </summary>
    public class TextJustification
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            var result = new List<string>();
            var index = 0;

            while (index < words.Length)
            {
                var count = words[index].Length;
                var last = index + 1;

                while (last < words.Length)
                {
                    if (words[last].Length + count + 1 > maxWidth) break;
                    count += words[last].Length + 1;
                    last++;
                }

                var row = "";
                var difference = last - index - 1;
                if (last == words.Length || difference == 0)
                {
                    for (int i = index; i < last; i++)
                    {
                        row += words[i] + " ";
                    }

                    row = row.Substring(0, row.Length - 1);
                    for (int i = row.Length; i < maxWidth; i++)
                    {
                        row += " ";
                    }
                }
                else
                {
                    var spaces = (maxWidth - count) / difference;
                    var remainder = (maxWidth - count) % difference;

                    for (int i = index; i < last; i++)
                    {
                        row += words[i];

                        if (i < last - 1)
                        {
                            var limit = spaces + ((i - index) < remainder ? 1 : 0);
                            for (int j = 0; j <= limit; j++)
                            {
                                row += " ";
                            }
                        }
                    }
                }
                result.Add(row);
                index = last;
            }
            return result;
        }
    }