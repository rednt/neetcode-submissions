public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
            

            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
            foreach(var s in strs){
                char[] charArray = s.ToCharArray();
                Array.Sort(charArray);
                string sortedString = new string(charArray);
                if(!map.ContainsKey(sortedString)){
                    map[sortedString] = new List<string>();
                }
                map[sortedString].Add(s);
            }
            return map.Values.ToList();

        }
}
