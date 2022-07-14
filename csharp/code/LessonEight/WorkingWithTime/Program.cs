using static System.Console;
using System.Globalization;

DateOnly myBirthDay = new(year: 2022, month: 4, day: 21);
WriteLine($"My BirthDay is on {myBirthDay}");

TimeOnly partyStarts = new(hour: 20, minute: 30);
WriteLine($"Party starts at {partyStarts}");

DateTime calendarEntry = myBirthDay.ToDateTime(partyStarts);
WriteLine($"Add to your calendar {calendarEntry}");

/*
WriteLine("Current culture is {0}"
, CultureInfo.CurrentCulture.Name);

string textDate = "4 July 2022";

DateTime independenceDay = DateTime.Parse(textDate);
WriteLine("Text: {0}, DateTime: {1:d MMMM}"
    , textDate
    , independenceDay);

textDate = "7/4/2022";
independenceDay = DateTime.Parse(textDate);
WriteLine("Text: {0}, DateTime: {1:d MMMM}"
    , textDate
    , independenceDay);

independenceDay = DateTime.Parse(textDate
, provider: CultureInfo.GetCultureInfo("en-US"));
WriteLine("Text: {0}, DateTime: {1:d MMMM}"
    , textDate
    , independenceDay);

for (int year = 2020; year < 2026; year++)
{
    Write($"{year} is leap: {DateTime.IsLeapYear(year)}");
    WriteLine("There are {0} days in February {1}."
        , DateTime.DaysInMonth(year:year, month:2)
        , year);
}
DateTime christmas =
    new(year: 2022, month: 12, day: 25);
WriteLine("Is Christmas daylight saving time? {0}",
    christmas.IsDaylightSavingTime());
WriteLine("Is 4th July daylight saving time? {0}",
    independenceDay.IsDaylightSavingTime());
*/



/*
WriteLine("Earliest date/time: {0}",
    DateTime.MinValue);
WriteLine("UNIX epoch date/time: {0}",
    DateTime.UnixEpoch);
WriteLine("Date/Time value Now: {0}",
    DateTime.Now);
WriteLine("Date/Time Today Now: {0}",
    DateTime.Today);
WriteLine("Date/Time Utc Now: {0}",
    DateTime.UtcNow);

DateTime christmas = 
    new (year: 2022, month:12, day: 25);
WriteLine("Christmas: {0}", christmas); //default format
WriteLine("Christmas: {0:dddd, dd MMMM yyyy}",
    christmas); //custom format
WriteLine("Christmas is in month {0}",
    christmas.Month);
WriteLine("Christmas is day {0} of the year",
    christmas.DayOfYear);
WriteLine("Christmas {0} is on {1}",
    christmas.Year, christmas.DayOfWeek);

DateTime beforeXmas =
    christmas.Subtract(TimeSpan.FromDays(12));
DateTime afterXmas =
    christmas.AddDays(12);
WriteLine("12 days before Christmas is {0}"
    , beforeXmas);
WriteLine("12 days after Christmas is {0}"
    , afterXmas);

TimeSpan untilChristmas = christmas - DateTime.Now;
WriteLine("There are {0} days and {1} hours until Christmas"
    , untilChristmas.Days
    , untilChristmas.Hours);

DateTime kidsWakeUp =
    new(year: 2022, month: 12, day: 25,
        hour: 6, minute: 30, second: 0);
WriteLine("Kids wake up at {0}", kidsWakeUp);
WriteLine("Kids wake up at {0}", kidsWakeUp.ToShortTimeString());
*/


