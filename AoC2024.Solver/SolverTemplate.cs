
public abstract class SolverBase
{
    public int Day { get; set; }
    protected string[] Data;
    public SolverBase(int day, string[] data)
    {
        this.Day = day;
        this.Data = data;
    }
    public abstract string Part1();
    public abstract string Part2();
}
