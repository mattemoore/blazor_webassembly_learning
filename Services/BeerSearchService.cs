using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using System;
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

        public event Action<Beer[]> SearchCompleted;
        public async Task<Beer[]> DoSearchAsync(string searchString)
        {
            beers = await _httpClient.GetFromJsonAsync<Beer[]>($"beers?beer_name={searchString}");
            SearchCompleted?.Invoke(beers);
            return beers;
        }
    }
}
