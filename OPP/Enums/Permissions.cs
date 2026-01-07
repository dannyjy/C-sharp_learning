namespace OPP.Enums;

[Flags]
public enum Permissions
{
    None = 0,
    Read = 1,    // 0001
    Write = 2,   // 0010
    Delete = 4,  // 0100
    Execute = 8  // 1000
}