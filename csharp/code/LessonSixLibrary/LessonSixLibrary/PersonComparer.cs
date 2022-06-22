namespace Shared;

public class PersonComparer : IComparer<Person>
{
    public int Compare(Person? x, Person? y)
    {
        if (x is null || y is null)
            return 0;

        //Compare the Name length
        int result = x.Name.Length.CompareTo(y.Name.Length);

        return result == 0 ? CompareNamesAlphabetically() : result;

        int CompareNamesAlphabetically()
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}