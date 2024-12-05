public class Solver
{
    private List<SolverBase> solvers = new List<SolverBase>();

    public Solver()
    {
        this.solvers.Add(new Solver1(1, File.ReadAllLines($"./input/{1}")));
        this.solvers.Add(new Solver2(2, File.ReadAllLines($"./input/{2}")));
    }

    public void Solve(int day = 2)
    {
        var solver = this.solvers.First(x => x.Day == day);

        Console.WriteLine($"Day {day}");
        Console.WriteLine($"Part 1: {solver.Part1()}");
        Console.WriteLine($"Part 2: {solver.Part2()}");
    }

}

