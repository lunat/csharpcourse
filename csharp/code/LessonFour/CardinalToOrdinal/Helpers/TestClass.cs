namespace CardinalToOrdinal.Helpers;

public static class TestClass
{
    /// <summary>
    /// Pass a 32-bit integer and it will be converted into its ordinal equivalent.
    /// </summary>
    /// <param name="number">Any cardinal number to convert to ordinal</param>
    /// <returns>Ordinal Number</returns>
    public static string CardinalToOrdinal(int number)
    {
        switch (number)
        {
            case 11:
            case 12:
            case 13:
                return $"{number}th";
            default:
                int lastDigit = number % 10;
                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };
                return $"{number}{suffix}";
        }
    }
}
