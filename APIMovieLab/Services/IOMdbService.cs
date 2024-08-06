using APIMovieLab.Models;

namespace APIMovieLab.Services;

//we're gonna add an interface to our API
//Interface == contract that child class has to have for parent class
public interface IOMdbService
{
    //this is our task signature in our interface
    Task<OMdbResponse> SearchMovies(string movieName);
}
