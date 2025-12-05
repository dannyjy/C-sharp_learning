
namespace OOP;

class Employee : Person
{
    string employeeId;
    public Employee(string? Name, int Age, string? Gender,string id) : base(Name, Age, Gender)
    {
        employeeId = id;
    }

    public string GetDetails()
    {
        return @$"
            {base.GetInfo()}Id: {employeeId}
        ";
    }
}