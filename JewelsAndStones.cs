using System.Linq;

namespace MyLeetCodeSulutions
{
    /// <summary>
    /// You're given strings jewels representing the types of stones that are jewels, 
    /// and stones representing the stones you have. Each character in stones 
    /// is a type of stone you have. You want to know how many 
    /// of the stones you have are also jewels.
    /// Letters are case sensitive, so "a" is considered a different type of stone from "A"
    /// </summary>
    
    public class JewelsAndStones
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            var data = jewels.ToHashSet();
            return stones.Count(data.Contains);
        }
    }
}
