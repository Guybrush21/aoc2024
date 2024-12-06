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
73 74 77 77 80 82 83 87
73 74 78 81 84
40 42 46 48 51 53 53
3 5 8 7 6 3 3
85 88 91 88 85 81
1 3 6 7 9";

        var solver = new Solver2(2, input.Split(Environment.NewLine));

        Assert.Equal("2", solver.Part1());
    }
}
