public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        char? currentLetter;
        char? nextLetter;
        int counter = 1;
        string result = "";

        for (int i = 0; i < input.Length; i++) {
            currentLetter = input[i];
            nextLetter = (i + 1 < input.Length) ? input[i+1] : null;
            
            if (nextLetter != currentLetter) {
                result += counter <= 1 ? currentLetter : (counter.ToString() + currentLetter);
                currentLetter = nextLetter;
                counter = 0;
            }
            counter++;
        }
        return result;
    }

    public static string Decode(string input)
    {
        char currentChar;
        char nextChar;
        string result = "";

        for (int i = 0; i < input.Length; i++) {
            currentChar = input[i];
            nextChar = (i + 1 < input.Length) ? input[i+1] : '\0';
            
            if (Char.IsNumber(currentChar) && Char.IsNumber(nextChar)) {
                string numberString = string.Concat(currentChar, nextChar);
                string decodedString = new String(input[i + 2], int.Parse(numberString));
                result += decodedString;
                i += 2;
            } else if (Char.IsNumber(currentChar)) {
                string decodedString = new string(nextChar, (int)char.GetNumericValue(currentChar) - 1);
                result += decodedString;
            } else {
                result += currentChar;
            }
        }
        return result;
    }
}
