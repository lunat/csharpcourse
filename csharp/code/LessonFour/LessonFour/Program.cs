using static System.Console;

//TimesTable(myString: "aa", number: 5);
decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionCode: "CH");
WriteLine($"You must pay {taxToPay:C}");


static void TimesTable(byte number, string myString)
{
    for (int i = 1; i <= 10; i++)
    {
        WriteLine($"{i} x {number} = {i * number}");
    }
}

static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
{
    decimal rate = 0.0m;
    switch (twoLetterRegionCode)
    {
        case "CH":
            rate = 0.08m;
            break;
        case "DK":
        case "NO":
            rate = 0.25m;
            break;
        case "GB":
        case "FR":
            rate = 0.2m;
            break;
        default:
            rate = 0.22m;
            break;
    }

    return amount * rate;
}