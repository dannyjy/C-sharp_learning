namespace OPP.Encapsulation
{
    public class Patient
    {
        // 1. Private field (Hidden from outside)
        private int _age;

        // 2. Public property (The gateway)
        public int Age
        {
            get { return _age; }
            set
            {
                // Logic to prevent "garbage" data
                if (value < 0 || value > 120)
                {
                    throw new ArgumentException("Please enter a valid age.");
                }
                _age = value;
            }
        }
    }
}