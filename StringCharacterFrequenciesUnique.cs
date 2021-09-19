public class Solution
{
    public int MinDeletions(string s)
    {

        char[] str = s.ToArray();

        int[] count = new int[128];
        foreach (char c in str)
        {    // O(N)
            count[c]++;
        }

        Array.Sort(count);

        HashSet<int> set = new HashSet<int>();
        int r = 0;

        for (int i = 0; i < count.Length; i++)
        {   // O(128)

            if (count[i] != 0)
            {
                if (!set.Contains(count[i]))
                {
                    set.Add(count[i]);

                }
                else
                {
                    int cur = count[i];
                    while (cur != 0 && set.Contains(cur))
                    {   // O(M)
                        // 5 4 3 (2)
                        cur--;
                    }
                    set.Add(cur);
                    r += count[i] - cur;
                }

            }
        }

        return r;
    }
}