namespace OOP.Modifier;

class Person
{
    private string? _name;
    private int _age;
    private string? _email;
    private string? _passward;
    private string? _username;

    public string Name
    {
        get { return _name; }
        set
        {
            if(value == "")
            {
                value = "No name set";
            }
            _name = value;
        }
    }
    public int Age
    {
        get { return _age; }
        set
        {
            if (value == 0)
            {
                value = 0;
            }
            _age = value;
        }
    }
    public string Email
    {
        get { return _email; }
        set
        {
            if (value == "")
            {
                value = "Undefined email";
            }
            _email = value;
        }
    }
    public string Password
    {
        set
        {
            if (value == "")
            {
                value = "Undefined password";
            }
            _passward = value;
        }
    }
    public string UserName
    {
        get { return _username; }
        set
        {
            if (value == "")
            {
                value = "John Doe";
            }
            _username = value;
        }
    }

}