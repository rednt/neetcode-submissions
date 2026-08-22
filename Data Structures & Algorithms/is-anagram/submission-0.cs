public class Solution {
    public bool IsAnagram(string s, string t) {

        char[] charArrayS = s.ToCharArray();
        char[] charArrayT = t.ToCharArray();

        Array.Sort(charArrayS);
        Array.Sort(charArrayT);
        
        if(charArrayS.SequenceEqual(charArrayT)){return true;}
        else{return false;}
    
    }
}
