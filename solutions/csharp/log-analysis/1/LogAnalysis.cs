public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string character) {
        int delimeterIndex = str.IndexOf(character);
        return str.Substring(delimeterIndex + character.Length);
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string startChar, string endChar) {
        int indexStart = str.IndexOf(startChar) + startChar.Length;
        int indexEnd = str.IndexOf(endChar);
        return str.Substring(indexStart, indexEnd - indexStart);
    }
    
    // // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str) {       
        return str.SubstringAfter(": ");
    }

    // // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str) {
        return str.SubstringBetween("[", "]");
    }
}