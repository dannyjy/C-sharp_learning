namespace OOP;

class Movie
{
    public string name;
    public string director;
    private string rating;

    public Movie(string movieName,string directorName, string aRating){
        name = movieName;
        director = directorName;
        Rating = aRating;
    }

    public string Rating
    {
        get {return rating;}
        set
        {
            string[] rates = new string[] {"NR","R","PG","PG-13"};
            foreach (var rate in rates)
            {
                if(value != rate)
                {
                    rating = "NR";
                }
                else
                {
                    rating = value;
                }
            }
        }
    }
}