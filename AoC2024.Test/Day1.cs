namespace AoC2024.Test;


public class Day1
{
    [Fact]
    public void Part1()
    {
        var input = @"3   4
  4   3
  2   5
  1   3
  3   9
  3   3";

        var solver = new Solver1(1, input.Split(Environment.NewLine));

        Assert.Equal("11", solver.Part1());
    }
}
