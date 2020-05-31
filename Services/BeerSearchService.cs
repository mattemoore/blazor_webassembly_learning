using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using BeerApplication.Models;

namespace BeerApplication.Services  
{
    public class BeerSearchService
    {
        private const string _apiRoot = "https://api.punkapi.com/v2/";
        private Beer[] beers;
        private HttpClient _httpClient;
        // public event Action SearchCompletedEvent<string>;

        // Constructor dependency injection of default HttpClient service
        public BeerSearchService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new System.Uri(_apiRoot);
        }

        // TODO: Learn about event/Action
        //       https://docs.microsoft.com/en-us/dotnet/api/system.action?view=netcore-3.1

        // TODO: Learn about async/await/Task
        //       https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/
        //       https://docs.microsoft.com/en-us/dotnet/standard/parallel-programming/task-based-asynchronous-programming
        public async Task<Beer[]> DoSearchAsync(string searchString)
        {
            // TODO: Emit SearchCompletedEvent when done
            beers = await _httpClient.GetFromJsonAsync<Beer[]>($"beers?beer_name={searchString}");
            if (beers.Length > 0)
            {
                System.Console.WriteLine(beers[0].Name);
            }
            return beers;
        }
    }
}
