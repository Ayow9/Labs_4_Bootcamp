namespace APIMovieLab.Models;

public class OMdbResponse
{
    public List<Movie> Search { get; set; }
    public string totalResults { get; set; }
    public string Response { get; set; }
}
