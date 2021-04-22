using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp
{
    public interface IMovieApiService
    {
        Task<List<MovieModel>> GetMovies(string title, string type);
    }
}
