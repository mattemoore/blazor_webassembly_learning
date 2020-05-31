namespace BeerApplication.Services  
{
    public class BeerSearchService
    {
        private const string _apiRoot = "https://api.punkapi.com/v2/";

        public string DoSearch(string searchString)
        {
            // TODO: Implement async call to REST API
            //       Emit SearchCompletedEvent when done
            return searchString;
        }

        public string Name => $"{_apiRoot}";
    }
}
