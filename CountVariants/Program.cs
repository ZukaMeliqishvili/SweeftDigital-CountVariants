static int CountVariants(int stairCount)
{
    if (stairCount < 2)
    {
        return stairCount;
    }

    int[] ans = new int[stairCount];
    ans[0] = 1;
    ans[1] = 2;

    for (int i = 2; i < stairCount; i++)
    {
        ans[i] = ans[i - 1] + ans[i - 2];
    }
    return ans[stairCount - 1];
}