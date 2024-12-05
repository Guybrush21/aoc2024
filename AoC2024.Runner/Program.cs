using Microsoft.Extensions.Logging;

internal class Program
{
    private static void Main(string[] args)
    {
        ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
        ILogger logger = factory.CreateLogger("Program");
        var solver = new Solver();

        solver.Solve();
    }
}
