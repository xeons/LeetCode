using System.Text;

namespace P003_Longest_Substring
{
    class Solution
    {
        /**
         * 983 / 983 test cases passed.
         * Status: Accepted
         * Runtime: 288 ms
         */
        public int LengthOfLongestSubstring(string s)
        {
            int largestSubstring = 0;
            string lastSubstring = "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                int j = i;
                for (j = i; j < s.Length; j++)
                {
                    lastSubstring = sb.ToString();
                    if (!sb.ToString().Contains(s[j].ToString()))
                        sb.Append(s[j].ToString());
                    else
                    {
                        if (sb.Length > largestSubstring)
                            largestSubstring = sb.Length;
                        sb.Clear();
                        break;
                    }
                }
                // stop searching
                if (i + largestSubstring > s.Length)
                    break;
                // another horrible speed hack
                if (j + lastSubstring.Length < s.Length && s.Substring(j, lastSubstring.Length) == lastSubstring)
                    i = i + lastSubstring.Length - 1;
            }
            return largestSubstring > 0 ? largestSubstring : s.Length;
        }
    }
}
