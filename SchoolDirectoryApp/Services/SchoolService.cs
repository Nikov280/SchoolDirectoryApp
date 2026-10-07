using System.Net.Http.Json;
using SchoolDirectoryApp.Models;

namespace SchoolDirectoryApp.Services
{
    // Service to handle API consumption
    public class SchoolService
    {
        private readonly HttpClient _httpClient;

        public SchoolService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Retrieves data from the Edutots School API and deserializes it
        public async Task<List<School>?> GetSchoolsAsync()
        {
            try
            {
                // Fetching data from the provided endpoint
                return await _httpClient.GetFromJsonAsync<List<School>>("https://edutots.net/api/school");
            }
            catch (Exception)
            {
                // In case of a failure, throw to be handled gracefully by the UI
                throw;
            }
        }
    }
}
