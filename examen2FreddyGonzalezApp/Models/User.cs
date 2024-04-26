using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using examen2FreddyGonzalezApp.Models;

namespace examen2FreddyGonzalezApp.Models {
    public class User {

        public RestRequest? request { get; set; }
        public int UserId { get; set; }

        public string UserName { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? PhoneNumber { get; set; }

        public string UserPassword { get; set; } = null!;

        public int StrikeCount { get; set; }

        public string BackUpEmail { get; set; } = null!;

        public string? JobDescription { get; set; }

        public int UserStatusId { get; set; }

        public int CountryId { get; set; }

        public int UserRoleId { get; set; }

        public async Task<List<User>?> GetAllUserAsync() {
            try {
                string RouterSufix = string.Format("Users");
                string URL = Services.WebAPIConnection.ProductionURLPrefix + RouterSufix;

                RestClient client = new RestClient(URL);
                request = new RestRequest(URL, Method.Get);
                request.AddHeader(Services.WebAPIConnection.ApiKeyName, Services.WebAPIConnection.ApiKeyValue);

                RestResponse response = await client.ExecuteAsync(request);

                HttpStatusCode statusCode = response.StatusCode;
                if (statusCode == HttpStatusCode.OK) {
                    var list = JsonConvert.DeserializeObject<List<User>>(response.Content);
                    return list;
                } else {
                    return null;
                }
        } catch (Exception ex) {
                string ErrorMsg = ex.Message;
                throw;
            }
}
    }
}
