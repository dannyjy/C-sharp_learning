namespace OPP.Encapsulation
{
    public class Player
    {
        private double _health;

        public double Health { 
            get { return _health; }
            set
            {
                if(value <= 100 && value >= 0)
                {
                    _health = value;
                }
                else
                {
                    throw new ArgumentException("Health must be within 0 to 100");
                }
            } 
        }

        public bool IsDead {
            get { return (_health == 0) ? true : false; }
        }
    }
}