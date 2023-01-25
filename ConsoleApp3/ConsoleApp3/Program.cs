
using ConsoleApp3;

bool goagain = true;
bool listagain = true;
string userinput = null;
bool invalid = true;
Movie Movie1 = new Movie()
{
    Title = "The Godfather",
    Catagory = "Crime"
};

Movie Movie2 = new Movie()
{
    Title = "Legend",
    Catagory = "Crime"
};

Movie Movie3 = new Movie()
{
    Title = "Top Gun",
    Catagory = "Action"
};

Movie Movie4 = new Movie()
{
    Title = "Avatar",
    Catagory = "Fantasy"
};

Movie Movie5 = new Movie()
{
    Title = "The Dark Knight",
    Catagory = "Superhero"
};

Movie Movie6 = new Movie()
{
    Title = "The Lord of the Rings",
    Catagory = "Fantasy"
};

Movie Movie7 = new Movie()
{
    Title = "Goodfellas",
    Catagory = "Crime"
};

Movie Movie8 = new Movie()
{
    Title = "Scarface",
    Catagory = "Crime"
};

Movie Movie9 = new Movie()
{
    Title = "Kill Bill",
    Catagory = "Action"
};

Movie Movie10 = new Movie()
{
    Title = "John Wick",
    Catagory = "Action"
};


List<Movie> Movielist = new List<Movie>()
{
    Movie1,
    Movie2,
    Movie3,
    Movie4,
    Movie5,
    Movie6,
    Movie7,
    Movie8,
    Movie9,
    Movie10
};

while (goagain == true)
{

    int count = 1;
    foreach (Movie m in Movielist)
    {
        Console.WriteLine($"Movie {count}. Title: {m.Title}");
        Console.WriteLine($"Catagory: {m.Catagory}");
        count++;
    }

    List<Movie> CatagorizedMovies = new List<Movie>();
    CatagorizedMovies = Catagorize(Movielist);

    foreach (Movie m in CatagorizedMovies)
    {
        Console.WriteLine(m.Title);
    }
    Console.WriteLine("");

    do
    {
        Console.WriteLine("Would you like to try again? (y/n)");
        userinput = Console.ReadLine();
        if (userinput == "y")
        {
            goagain = true;
            break;
        }
        else if (userinput == "n")
        {
            goagain = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid input please try again and enter a valid input");
            invalid = true; 
        }
    }while (invalid == true);


}








List<Movie> Catagorize(List<Movie> MovieList)
{
    List<Movie> CatagorizedMovies = new List<Movie>();
    string userpinput = string.Empty;
    Console.WriteLine("");
    List<string> CatagoryList = new List<string>()
        {
            "Crime",
            "Action",
            "Fantasy",
            "Superhero"
        };
    Console.WriteLine("Please enter one of the options for a movie catagory from the list below");
    foreach (string s in CatagoryList)
    {
        Console.WriteLine(s);
    }
    do
    {
        userpinput = Console.ReadLine().ToLower().Trim();

        if (userpinput != "crime" && userpinput != "action" && userpinput != "fantasy" && userpinput != "superhero")
        {
            Console.WriteLine("Invalid input please enter one of the catagories above");
        }
        else
        {
            break;
        }
    } while (true);

    foreach (Movie m in Movielist)
    {
        if (userpinput == m.Catagory.ToLower())
        {
            CatagorizedMovies.Add(m);
        }
    }
    Console.WriteLine("");
    return CatagorizedMovies;
}
Console.WriteLine("");







