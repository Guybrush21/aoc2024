public class Solver2 : SolverBase
{
    private List<List<int>> reports = new List<List<int>>();
    public Solver2(int day, string[] input) : base(day, input)
    {
        foreach (var line in input)
        {
            var report = new List<int>();
            foreach (var number in line.Split(' '))
            {
                report.Add(Convert.ToInt32(number));
            }
            reports.Add(report);
        }
    }

    public override string Part1()
    {
        var validReports = 0;
        foreach (var line in reports)
        {
            if (line.First() > line.Last())
                if (this.checkDecreasing(line))
                {

                    validReports++;
                };
            if (line.First() < line.Last())
                if (this.checkIncreasing(line)) validReports++;
        }
        return validReports.ToString();
    }

    private bool checkIncreasing(List<int> line)
    {
        for (int i = 0; i < line.Count() - 2; i++)
        {
            var a = line[i];
            var b = line[i + 1];
            if (a == b || a > b || int.Abs(a - b) > 3)
                return false;
        }

        return true;
    }

    private bool checkDecreasing(List<int> line)
    {
        for (int i = 0; i < line.Count() - 2; i++)
        {
            var a = line[i];
            var b = line[i + 1];
            if (a == b || a < b || int.Abs(a - b) > 3)
                return false;
        }

        return true;
    }

    public override string Part2()
    {
        throw new NotImplementedException();
    }


}
