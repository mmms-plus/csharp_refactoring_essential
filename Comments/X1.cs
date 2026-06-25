namespace Comments;

public static class X1
{
    public static int M(int lowerBound, int upperBound)
    {
        var p = 0;

        for (var number = lowerBound; number <= upperBound; number++)
        {
            // Add square of each number in the range
            p += SquareOf(number);
        }

        // Return accumulated sum
        return p;
    }

    private static int SquareOf(int k)
    {
        // Return square of input
        return k * k;
    }
}