namespace AoC2024.Test;

public class Day2
{
    [Fact]
    public void Part1()
    {
        var input = @"7 6 4 2 1
1 2 7 8 9
9 7 6 2 1
1 3 2 4 5
8 6 4 4 1
1 3 6 7 9";

        var solver = new Solver2(2, input.Split(Environment.NewLine));

        Assert.Equal("2", solver.Part1());
    }
}
