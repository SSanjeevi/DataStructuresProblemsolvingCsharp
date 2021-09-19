public class Solution
{
    public string LongestDiverseString(int a, int b, int c)
    {
        StringBuilder sb = new StringBuilder();
        bool isHappy = true;
        char? nextChar;

        while (isHappy && (a > 0 || b > 0 || c > 0))
        {
            int len = sb.Length;

            if (len >= 2)
            {
                nextChar = pickNextChar(sb[len - 1], sb[len - 2], a, b, c);
            }
            else if (len == 1)
            {
                nextChar = pickNextChar(sb[0], null, a, b, c);
            }
            else
            {
                nextChar = pickNextChar(null, null, a, b, c);
            }

            if (nextChar == null)
            {
                isHappy = false;
            }
            else
            {
                sb.Append(nextChar);
                switch (nextChar)
                {
                    case 'a':
                        a--;
                        break;
                    case 'b':
                        b--;
                        break;
                    case 'c':
                        c--;
                        break;
                }
            }
        }

        return sb.ToString();
    }

    private Char? pickNextChar(Char? last, Char? secondLast, int a, int b, int c)
    {
        if (last == null || secondLast == null || !last.Equals(secondLast))
        {
            // If we are looking for the first 2 chars of the string, or the last 2 chars are not equal,
            // then we don't need to worry about string getting unhappy and can pick any of 'a', 'b' and 'c'.
            if (a >= b && a >= c)
            {
                return 'a';
            }
            else if (b >= a && b >= c)
            {
                return 'b';
            }
            else
            {
                return 'c';
            }
        }
        else
        {
            // If the last 2 chars are equal, we need to pick from the other 2 chars to avoid string getting unhappy
            switch (last)
            {
                case 'a':
                    if (b >= c)
                    {
                        if (b > 0)
                        { return 'b'; }
                        else
                        {
                            return null;
                        }
                    }
                    else if (c > 0)
                    { return 'c'; }
                    else
                    {
                        return null;
                    }
                case 'b':
                    if (a >= c)
                    {
                        if (a > 0)
                        { return 'a'; }
                        else
                        {
                            return null;
                        }
                    }
                    else if (c > 0)
                    { return 'c'; }
                    else
                    {
                        return null;
                    }
                case 'c':
                    if (a >= b)
                    {
                        if (a > 0)
                        { return 'a'; }
                        else
                        {
                            return null;
                        }
                    }
                    else if (b > 0)
                    { return 'b'; }
                    else
                    {
                        return null;
                    }
                default:
                    return null;
            }
        }
    }
}