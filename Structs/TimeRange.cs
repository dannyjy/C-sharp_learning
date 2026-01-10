public struct TimeRange
{
    public DateTime Start { get; }
    public DateTime End { get; }

    public bool IsWithin(DateTime time) => time >= Start && time <= End;
}