using System;

namespace MyLeetCodeSulutions
{
    /// <summary>
    /// Given an integer columnNumber, return its corresponding column title as it appears in an Excel sheet.
    /// 
    /// For example:
    /// A -> 1
    /// B -> 2
    /// C -> 3
    /// ...
    /// Z -> 26
    /// AA -> 27
    /// AB -> 28 
    /// </summary>

    public class ExcelSheetColumnTitle
    {
        public string ConvertToTitle(int columnNumber)
        {
            var a = columnNumber;
            var result = String.Empty;
            var b = 0;
            while (a > 0)
            {
                b = (a - 1) % 26;
                result = (char)(65 + b) + result;
                a = (int)((a - b) / 26);
            }
            return result;
        }
    }
