namespace Comments;

public class Range(int lowerBound, int upperBound)
{
    public int LowerBound { get; } = lowerBound;
    public int UpperBound { get; } = upperBound;

    public int SquareOfRange()
    {
        var lowerBound = LowerBound;
        var upperBound = UpperBound;
        var sum = 0;

        for (var number = lowerBound; number <= upperBound; number++)
        {
            sum += X1.SquareOf(number);
        }

        return sum;
    }
}

public static class X1
{
    public static int SquareOf(int input)
    {
        return input * input;
    }
}