public class Anagram
{
    private string _baseWordArray;
    
    // there is n-1 * n-2 * n-3 .. possibilites ex 4chars in word => 4 * 3 * 2 * 1 = 24 words
    public Anagram(string baseWord)
    {
        this._baseWordArray = baseWord.ToLower();
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        List<string> matchingAnagrams = new List<string>();
        foreach (string potentialMatch in potentialMatches) {
            if (_baseWordArray == potentialMatch.ToLower()) continue;
            if (_baseWordArray.OrderBy(c => c).SequenceEqual(potentialMatch.ToLower().OrderBy(c => c))) {
                matchingAnagrams.Add(potentialMatch);
            }
        }
        return matchingAnagrams.ToArray();
    }
}