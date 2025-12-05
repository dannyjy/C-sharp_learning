
namespace OOP;
class Doctor : Employee
{
    string DrSpeciality;
    public Doctor(string? Name, int Age, string? Gender, string id, string speciality) : base(Name, Age, Gender, id)
    {
        DrSpeciality = speciality;
    }
    new public string GetDetails()
    {
        return @$"
            {base.GetDetails()}    Speciality: {DrSpeciality}
        ";
    }
}