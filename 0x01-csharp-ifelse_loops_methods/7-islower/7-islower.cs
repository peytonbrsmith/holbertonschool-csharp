class Character : Program
{
    public static bool IsLower(char c)
    {
        // if c is a lowercase letter, return true
        if (c >= 'a' && c <= 'z')
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}