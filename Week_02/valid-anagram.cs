public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s == null && t == null) return true;
        else if (s == null && t != null || s != null && t == null)
        {
            return false;
        }
        else
        {
            if (s.Length != t.Length) return false;
            char[] sArray = s.ToCharArray();
            char[] tArray = t.ToCharArray();
            Array.Sort(sArray);
            Array.Sort(tArray);
            int i=0;
            while(i<sArray.Length)
            {
                if(sArray[i]!=tArray[i])
                {
                    return false;
                }
                i++;
            }
            return true;
        }
    }
}