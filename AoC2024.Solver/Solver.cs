public class Solver
{
    private int day;
    private List<SolverBase> solvers = new List<SolverBase>();

    public Solver()
    {
        this.solvers.Add(new Solver1(1, File.ReadAllLines($"./input/{1}")));
    }

    public void Solve(int day)
    {
        var solver = this.solvers.First(x => x.Day == day);

        Console.WriteLine($"Day {day}");
        Console.WriteLine($"Part 1: {this.solvers[day - 1].Part1()}");
        Console.WriteLine($"Part 2: {this.solvers[day - 1].Part2()}");
    }

}

