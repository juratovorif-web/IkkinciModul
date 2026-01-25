namespace lesson_9.Extensions;

public static class StringExtensions
{
    public static string RemoveDigits(this string a , string b)
    {
        for(var i = 0; i < a.Length; i++)
        {
            if(char.IsDigit(a[i]))
            {
                a = a.Remove(i,1);
                --i;
            }
        }
        return a + b;
    }
}
