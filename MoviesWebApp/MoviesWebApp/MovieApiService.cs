using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace MoviesWebApp
{
    public class MovieApiService : IMovieApiService
    {
        private static readonly HttpClient client;

        static MovieApiService()
        {
            client = new HttpClient()
            {
                BaseAddress = new Uri("https://www.omdbapi.com")
            };
        }

        
        async public Task<List<MovieModel>> GetMovies(string title, string type)
        {
            var url = string.Format("/?t={0}&type={1}&apikey=4a249f8d", title, type);
            var result = new List<MovieModel>();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<List<MovieModel>>(stringResponse,
                    new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }

            return result;
        }
    }
}
