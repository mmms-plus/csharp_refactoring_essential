namespace Comments;

public class Range(int lowerBound, int upperBound)
{
    public int LowerBound => lowerBound;
    public int UpperBound { get; } = upperBound;

    public int SquareOfRange()
    {
        var sum = 0;

        for (var number = LowerBound; number <= UpperBound; number++)
        {
            sum += SquareOf(number);
        }

        return sum;
    }

    private static int SquareOf(int input)
    {
        return input * input;
    }
}