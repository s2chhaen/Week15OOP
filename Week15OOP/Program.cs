string[] data = getDataFromFile();
List<Movie> list = new List<Movie>();

foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(tempArray[0], tempArray[1], tempArray[2]); 

    list.Add(newMovie);
}

foreach (Movie movie in list)
{
    Console.WriteLine($"One of my favourite movies {movie.title} was released in {movie.year}.");
    Console.WriteLine($"The rating for this movie is {movie.rating} of 10.");
}

static string[] getDataFromFile()
{
    string filePath = @"C:\data\movies.txt";
    return File.ReadAllLines(filePath);
}

class Movie
{
    public string title;
    public string rating;
    public string year;

    public Movie (string _title, string _rating, string _year)
    {
        title = _title;
        rating = _rating;
        year = _year;
    }
}
