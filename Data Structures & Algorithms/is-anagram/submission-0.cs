public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> wordOne = new Dictionary<char, int>();
        Dictionary<char, int> wordTwo = new Dictionary<char, int>();

        if (s.Length > t.Length || s.Length < t.Length)
            return false;

        for (int i = 0; i < s.Length; i++) {
            
            char charOne = s[i];
            char charTwo = t[i];

            // String s
            if (wordOne.TryGetValue(charOne, out int countOne))
            {

                wordOne[charOne] = countOne + 1;
            }
            else {
                wordOne.Add(charOne, 1);
            }
            // String t
            if (wordTwo.TryGetValue(charTwo, out int countTwo))
            {

                wordTwo[charTwo] = countTwo + 1;
            }
            else {
                wordTwo.Add(charTwo, 1);
            }
        }

        if (wordOne.Count > wordTwo.Count || wordOne.Count < wordTwo.Count)
            return false;

        // Check char count
        foreach (var (key, value) in wordOne)
        {
            if (wordTwo.TryGetValue(key, out int count)) 
            {
                if (count != value)
                    return false;
            }
            else 
                return false;
        }
        return true;
    }
}
