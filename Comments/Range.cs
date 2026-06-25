namespace Comments;

public class Range(int lowerBound, int upperBound)
{

    public int SquareOfRange()
    {
        var sum = 0;

        for (var number = lowerBound; number <= upperBound; number++)
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