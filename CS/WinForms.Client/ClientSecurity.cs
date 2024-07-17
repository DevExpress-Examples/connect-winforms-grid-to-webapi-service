using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Client {
    static class ClientSecurity {
        static readonly HttpClient HttpClient = new HttpClient();
        //
        static string BaseUrl {
            get { return System.Configuration.ConfigurationManager.AppSettings["baseURL"]; }
        }
        static string AuthUrl {
            get { return System.Configuration.ConfigurationManager.AppSettings["authURL"]; }
        }
        static string PermissionUrl {
            get { return System.Configuration.ConfigurationManager.AppSettings["checkPermissionURL"]; }
        }
        public static string ODataUrl {
            get { return System.Configuration.ConfigurationManager.AppSettings["baseODataUrl"]; }
        }
        //
        public static void Initialize() {
            HttpClient.BaseAddress = new Uri(BaseUrl);
        }
        static string AuthToken;
        public static void SetAuthToken(string authToken) {
            AuthToken = authToken;
        }
        public static async Task<string> Authenticate(string userName, string password) {
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var responseMessage = await HttpClient.PostAsJsonAsync(AuthUrl, new {
                UserName = userName,
                Password = password
            }).ConfigureAwait(false);
            if(responseMessage.IsSuccessStatusCode) {
                string token = await responseMessage.Content.ReadAsStringAsync()
                    .ConfigureAwait(false);
                return token.Replace("\"", "").Trim();
            }
            return null;
        }
        public static async Task<bool> EnsureEditPermissions(string objectTypeFullName, string objectKey) {
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AuthToken);
            var responseMessage = await HttpClient.GetAsync(PermissionUrl + $"?typeName={objectTypeFullName}&objectKey={objectKey}")
                .ConfigureAwait(false);
            if(responseMessage.IsSuccessStatusCode) {
                string result = await responseMessage.Content.ReadAsStringAsync()
                    .ConfigureAwait(false);
                return bool.Parse(result);
            }
            return false;
        }
        public static void EnsureAuthorization(Microsoft.OData.Client.BuildingRequestEventArgs args) {
            args.Headers.Add("Authorization", "Bearer " + AuthToken); // Add authentification token
        }
    }
}
