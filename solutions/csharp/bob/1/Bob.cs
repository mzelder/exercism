public static class Bob
{
    public static string Response(string statement)
    {
        if (IsQuestion(statement) && IsYield(statement)) return "Calm down, I know what I'm doing!";
        else if (IsQuestion(statement)) return "Sure.";
        else if (IsYield(statement)) return "Whoa, chill out!";
        else if (IsNothing(statement)) return "Fine. Be that way!";
        else return "Whatever.";
    }
    public static bool IsQuestion(string statement) {
        if (IsNothing(statement)) return false;
        else if (IsNothing(statement.Trim())) return true;
        else if (statement.Trim()[^1] == '?') return true;
        return false;
    }
    public static bool IsYield(string statement) {
        var onlyLetters = statement.Where(char.IsLetter).ToArray();
        return onlyLetters.Length > 0 && onlyLetters.All(char.IsUpper);
    }
    public static bool IsNothing(string statement) => statement.Trim().Length == 0;
}