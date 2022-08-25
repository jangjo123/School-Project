using Newtonsoft.Json;
using SharedData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace School_Project.Data.Services
{
    public class SchoolService
    {
        HttpClient _httpClient;

        public SchoolService(HttpClient client)
        {
            _httpClient = client;
        }

        // CRUD

        // Create
        public async Task<Result> AddResult(Result result)
        {
            string jsonStr = JsonConvert.SerializeObject(result);
            var content = new StringContent(jsonStr, Encoding.UTF8, "application/json");
            var postResult = await _httpClient.PostAsync("api/school", content);

            if (postResult.IsSuccessStatusCode == false)
                throw new Exception("AddResult Failed");

            var resultContent = await postResult.Content.ReadAsStringAsync();
            Result resResult = JsonConvert.DeserializeObject<Result>(resultContent);
            return resResult;
        }

        // Read
        public async Task<List<Result>> GetResultsAsync()
        {
            var getResult = await _httpClient.GetAsync("api/school");

            var resultContent = await getResult.Content.ReadAsStringAsync();
            List<Result> resResults = JsonConvert.DeserializeObject<List<Result>>(resultContent);
            return resResults;
        }

        // Update
        public async Task<bool> UpdateResult(Result result)
        {
            string jsonStr = JsonConvert.SerializeObject(result);
            var content = new StringContent(jsonStr, Encoding.UTF8, "application/json");
            var putResult = await _httpClient.PutAsync("api/school", content);

            if (putResult.IsSuccessStatusCode == false)
                throw new Exception("UpdateResult Failed");

            return true;
        }
        // Delect
        public async Task<bool> DeleteResult(Result result)
        {
            var deleteResult = await _httpClient.DeleteAsync($"api/school/{result.Id}");

            if (deleteResult.IsSuccessStatusCode == false)
                throw new Exception("UpdateResult Failed");

            return true;
        }
    }
}
