using APIMovieLab.Models;

namespace APIMovieLab.Services;
//STEP 1: Make model classes and right click on global project, create servcies
//we are creating the service part for our OMdb Lab in our own lil services folder! 
public class OMdbService : IOMdbService //calling from our child class model
{
    //Vmake a method that calls the API and resturns c# obj from jsonV
    public async Task<OMdbResponse> SearchMovies(string movieName) //our async task 
    {
        //Vcreate URL as a string w/ all info necessaryV
        string url = $"http://www.omdbapi.com/?apikey=16efb775&s={movieName}"; //this is the index API to go off of we're adding our own movieName varible name! 
        //Vcall API, GET response!V
        using (HttpClient client = new HttpClient()) //instantaneous connection that cuts off after request made
        {
            try
            {
                OMdbResponse response = await client.GetFromJsonAsync<OMdbResponse>(url);
                //^this code is telling us to GET the url outlined in our string, now turn into a c# obj

                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null; // logs what went wrong, returns an error message
            }
        }
    }
}
