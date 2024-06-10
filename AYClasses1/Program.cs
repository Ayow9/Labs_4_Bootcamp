//our movie database lab where we will define classes
using AYClasses1;
using System.ComponentModel;

List<Movie> movieList = new List<Movie>()
{ 
//instantiation but simpler as everything is in brackets
new Movie("A Clockwork Orange", "scifi"),
new Movie("Blade Runner", "scifi"),
new Movie("Taxi Driver", "drama"),
new Movie("Sunset Blvd", "mystery"),
new Movie("Pulp Fiction", "drama"),
new Movie("Fight Club", "satire"),
new Movie("Glass Onion", "mystery"),
new Movie("Robocop", "satire"),
new Movie("Perfect Blue", "anime"),
new Movie("Akira", "anime"),
};

foreach (Movie category in movieList)
{
    if()
}
//^^ total categories: 5 (2scifi, 2drama, 2mystery, 2satire, 2anime)

//computer, search thru movies
//search in category, 'user input', based on genre given
//computer, if category matches 'user input' show list of movies in that given category
//computer, if there is no category in your list, tell the user "Sorry, we don't have that category availble"
//computer, if user wants to continue, start over by asking for category input

Console.WriteLine("We have 10 movies. What kind of movie would you like to watch?");
string uInput = Console.ReadLine();

